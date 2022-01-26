using System;
using System.ComponentModel.DataAnnotations;

namespace ISAT.Developer.Exam.Web.Models
{
    public class UsuarioViewModel
    {
        [Display(Name = "Código")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(255, ErrorMessage = "nome não pode ser maior que 255 caracteres.")]
        [Display(Name = "nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(255, ErrorMessage = "sobreNome não pode ser maior que 255 caracteres.")]
        [Display(Name = "sobreNome")]
        public string sobreNome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(255, ErrorMessage = "E-mail não pode ser maior que 255 caracteres.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Range(10, 100, ErrorMessage = "A idade deve ser entre 10 e 100.")]
        [Display(Name = "idade")]
        public int idade { get; set; }

        [Display(Name = "nome Completo")]
        public string nomeCompleto
        {
            get
            {
                return nome + " " + sobreNome;
            }
        }
    }
}
