﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using webAPI02.Infraestrutura;
using webAPI02.Infraestrutura.Dto.VendaItensDto;
using webAPI02.Models;
using webAPI02.Repository.Interfaces;

namespace webAPI02.Repository
{
    public class VendaItensrepository : IVendaItensRepository
    {
        private readonly DbContextControle _context;
        private readonly IMapper _mapper;

        public VendaItensrepository(DbContextControle context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddVendaItens(CreateVendaItensDto vendaItensDto)
        {
            
            var venda = _mapper.Map<VendaItens>(vendaItensDto);
            
            _context.VendaItens.Add(venda);
            _context.SaveChanges();
        }

        public ReadVendaItensDto GetVendaId(int id)
        {
            var venda = _context.VendaItens.Include(x => x.Venda).FirstOrDefault(venda => venda.Id == id);
            var vendaALterada = _mapper.Map<ReadVendaItensDto>(venda);
            return vendaALterada;
        }

        public IEnumerable<ReadVendaItensDto> GetVendaItens()
        {
            var vendas = _mapper.Map<List<ReadVendaItensDto>>(_context.VendaItens.ToList());
            return vendas;
        }

        public void UpdateVendaItens(int id, CreateVendaItensDto vendaItensDto)
        {
            throw new NotImplementedException();
        }
    }
}
