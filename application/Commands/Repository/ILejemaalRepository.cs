using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Commands.Repository
{
    //Interface der implementeres i Infrastructure
    public interface ILejemaalRepository
    {
        Task Save(domain.Model.Lejemaal lejemaal);
        Task<domain.Model.Lejemaal> Load(int id);
        Task Update(domain.Model.Lejemaal lejemaal);
        Task Delete(domain.Model.Lejemaal lejemaal);
    }
}
