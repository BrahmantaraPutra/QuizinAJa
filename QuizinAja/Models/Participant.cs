using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuizinAja.Models;

[Table("Participant")]
public partial class Participant
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("QuizID")]
    public int QuizId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string ParticipantNickname { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ParticipationDate { get; set; }

    public int TimeTaken { get; set; }

    [InverseProperty("Participant")]
    public virtual ICollection<ParticipantAnswer> ParticipantAnswers { get; set; } = new List<ParticipantAnswer>();

    [ForeignKey("QuizId")]
    [InverseProperty("Participants")]
    public virtual Quiz Quiz { get; set; } = null!;
}
