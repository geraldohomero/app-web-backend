using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Veículo")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a Placa!")]
        public string Placa { get; set; }


       // public ICollection<Consumo> Consumos { get; set; }

        };
    }
