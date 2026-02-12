using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuizinAja.Models;

[Table("ParticipantAnswer")]
public partial class ParticipantAnswer
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ParticipantID")]
    public int ParticipantId { get; set; }

    [Column("QuestionID")]
    public int QuestionId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Answer { get; set; } = null!;

    [ForeignKey("ParticipantId")]
    [InverseProperty("ParticipantAnswers")]
    public virtual Participant Participant { get; set; } = null!;

    [ForeignKey("QuestionId")]
    [InverseProperty("ParticipantAnswers")]
    public virtual Question Question { get; set; } = null!;
}
