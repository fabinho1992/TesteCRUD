using System.ComponentModel.DataAnnotations;
using System.Drawing;
using webAPI02.Models;

namespace webAPI02.Infraestrutura.Dto.VendaItensDto
{
    public class CreateVendaItensDto
    {
       

        [Required]
        public double Quantidade { get; set; }
       
        [Required]
        public int ProdutoId { get; set; }
       
        [Required]
        public int VendaId { get; set; }
        
    }
}
