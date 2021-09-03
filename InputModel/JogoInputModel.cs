using System.ComponentModel.DataAnnotations;

namespace APICatalogoDeJogos.Controllers.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength =3, ErrorMessage ="O jogo precisa ter entre 3 e 100 caracteres em seu nome")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength =1, ErrorMessage ="O nome da produtora deve ter entre 1 e 100 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(1,100,)]
    }
}