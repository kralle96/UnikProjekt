using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using application.Commands.Repository;
using infrastructure.Lejemaal;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Repository
{
    public class LejemaalRepository : ILejemaalRepository
    {
        private readonly LejemaalContext _lejemaalContext;

        public LejemaalRepository(LejemaalContext lejemaalContext)
        {
            _lejemaalContext = lejemaalContext;
        }

        async Task ILejemaalRepository.Save(domain.Model.Lejemaal lejemaal)
        {
            if (!_lejemaalContext.Lejemaal.Any(a => a.Id == lejemaal.Id))
                _lejemaalContext.Lejemaal.Add(lejemaal);
            await _lejemaalContext.SaveChangesAsync();
        }

        async Task ILejemaalRepository.Update(domain.Model.Lejemaal updatedLejemaal)
        {
            if (!_lejemaalContext.Lejemaal.Any(a => a.Id == updatedLejemaal.Id))
                _lejemaalContext.Lejemaal.Add(updatedLejemaal);

            _lejemaalContext.Update(updatedLejemaal);
            _lejemaalContext.SaveChanges();
        }

        async Task<domain.Model.Lejemaal> ILejemaalRepository.Load(int id)
        {
            var found = await _lejemaalContext.Lejemaal.FirstOrDefaultAsync(a => a.Id == id);
            if (found == null) 
                throw new Exception($"blog not found (id: {id}");
            return found;
        }

        async Task ILejemaalRepository.Delete(domain.Model.Lejemaal lejemaal)
        {
            var found = await _lejemaalContext.Lejemaal.FirstOrDefaultAsync(a => a.Id == lejemaal.Id);
            if (found == null)
                throw new Exception($"blog not found (id: {lejemaal.Id}");
            _lejemaalContext.Lejemaal.Remove(found);
            await _lejemaalContext.SaveChangesAsync();
        }
    }
}
