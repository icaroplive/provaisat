using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISAT.Developer.Exam.Core.Entities.Models
{
    public class Usuario : BaseEntity<Usuario>
    {
        public Usuario()
        {

            RuleFor(usuario => usuario.nome).NotEmpty().Length(1, 255);
            RuleFor(usuario => usuario.sobreNome).NotEmpty().Length(1, 255);
            RuleFor(usuario => usuario.email).EmailAddress().Length(1, 255);
            RuleFor(usuario => usuario.idade).InclusiveBetween(10, 100);
        }
        public String nome { get; set; }
        public String sobreNome { get; set; }
        public String email { get; set; }
        public int idade { get; set; }
        public override bool IsValid()
        {
            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
