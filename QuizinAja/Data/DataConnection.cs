using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QuizinAja.Models;

namespace QuizinAja.Data;

public partial class DataConnection : DbContext
{
    public DataConnection()
    {
    }

    public DataConnection(DbContextOptions<DataConnection> options)
        : base(options)
    {
    }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<ParticipantAnswer> ParticipantAnswers { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Quiz> Quizzes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=QuizinAja;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Participant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Particip__3214EC275B0A26F9");

            entity.HasOne(d => d.Quiz).WithMany(p => p.Participants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuizParticipant_Quiz_QuizID");
        });

        modelBuilder.Entity<ParticipantAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Particip__3214EC279725FF5F");

            entity.HasOne(d => d.Participant).WithMany(p => p.ParticipantAnswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuizParticipantAnswer_Participant_ParticipantID");

            entity.HasOne(d => d.Question).WithMany(p => p.ParticipantAnswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuizParticipantAnswer_Question_QuestionID");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Question__3214EC27916D3541");

            entity.HasOne(d => d.Quiz).WithMany(p => p.Questions).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Quiz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quiz__3214EC277D850300");

            entity.HasOne(d => d.User).WithMany(p => p.Quizzes).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC2766D3C588");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
