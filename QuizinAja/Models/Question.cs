using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuizinAja.Models;

[Table("Question")]
public partial class Question
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("QuizID")]
    public int QuizId { get; set; }

    [Column("Question", TypeName = "text")]
    public string Question1 { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string OptionA { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string OptionB { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string OptionC { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string OptionD { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string CorrectAnswer { get; set; } = null!;

    [InverseProperty("Question")]
    public virtual ICollection<ParticipantAnswer> ParticipantAnswers { get; set; } = new List<ParticipantAnswer>();

    [ForeignKey("QuizId")]
    [InverseProperty("Questions")]
    public virtual Quiz Quiz { get; set; } = null!;
}
