﻿using System.ComponentModel.DataAnnotations;

namespace webAPI02.Infraestrutura.Dto.ProdutoDto
{
    public class UpdateProdutoDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public string Categoria { get; set; }
    }
}
