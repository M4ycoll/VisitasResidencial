using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Visitas_residencial.Models;
using Visitas_residencial.Data;

namespace Visitas_residencial.Services
{
    public class CasaService : ICasaService
    {
        private readonly YourDbContext _context;

        public CasaService(YourDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Casa casa)
        {
            await _context.Casas.AddAsync(casa);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Casa> GetCasas()
        {
            return _context.Casas;
        }

        public async Task UpdateAsync(Guid id, Casa casa)
        {
            var existingCasa = await _context.Casas.FindAsync(id);

            if (existingCasa != null)
            {
                existingCasa.Numero = casa.Numero;
                existingCasa.Bloque = casa.Bloque;
                existingCasa.Calle = casa.Calle;
                existingCasa.Referencia = casa.Referencia;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var existingCasa = await _context.Casas.FindAsync(id);

            if (existingCasa != null)
            {
                _context.Casas.Remove(existingCasa);
                await _context.SaveChangesAsync();
            }
        }
    }

    public interface ICasaService
    {
        Task CreateAsync(Casa casa);
        IEnumerable<Casa> GetCasas();
        Task UpdateAsync(Guid id, Casa casa);
        Task DeleteAsync(Guid id);
    }
}