using System.ComponentModel.DataAnnotations;
using webAPI02.Infraestrutura.Dto.ProdutoDto;
using webAPI02.Infraestrutura.Dto.VendaDto;

namespace webAPI02.Infraestrutura.Dto.VendaItensDto
{
    public class ReadVendaItensDto
    {
        
        public int Id { get; set; }
        public double Valor { get; set ; } 
        public double Quantidade { get; set; } 
        public int ProdutoId { get; set; }
        public virtual ReadProdutoDto ReadProdutoDto { get; set; }
        public int VendaId { get; set; }
        public virtual ReadVendaDto ReadVendaDto { get; set; }
    }
}
