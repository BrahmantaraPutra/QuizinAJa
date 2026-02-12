using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuizinAja.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string FullName { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
}
