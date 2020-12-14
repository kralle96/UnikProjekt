using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Repository
{
    public interface ILejemaalRepository
    {
        Task Save(Domain.Model.Lejemaal lejemaal);
        Task<Domain.Model.Lejemaal> Load(int id);
        Task Update(Domain.Model.Lejemaal lejemaal);
        Task Delete(Domain.Model.Lejemaal lejemaal);
    }
}
