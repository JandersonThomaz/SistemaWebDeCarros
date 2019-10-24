using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebDeCarros.Models
{
    public class Carro
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio"), Display(Name = "Ano De Fabricação")]
        public int AnoDeFabricacao { get; set; }

        [Required, Display(Name ="Modelo")]
        public string Modelo { get; set; }

        [Required, Display(Name ="Marca")]
        public string Marca { get; set; }

        [Required, Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required, Display(Name ="Chassi")]
        public string Chassi { get; set; }

        [Required, Display (Name ="Cor")]
        public string Cor { get; set; }
    }
}
