using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuizinAja.Models;

[Table("Quiz")]
public partial class Quiz
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [Column(TypeName = "text")]
    public string Description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [InverseProperty("Quiz")]
    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();

    [InverseProperty("Quiz")]
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    [ForeignKey("UserId")]
    [InverseProperty("Quizzes")]
    public virtual User User { get; set; } = null!;
}
