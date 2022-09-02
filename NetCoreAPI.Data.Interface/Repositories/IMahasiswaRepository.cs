using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoreAPI.Model.Entities;

namespace NetCoreAPI.Data.Interface.Repositories
{
    public interface IMahasiswaRepository
    {
        public Task<bool> Create(Mahasiswa mahasiswa);
        public Task<List<Mahasiswa>> GetAll();
        public Task<bool> Delete(int id);
    }
}
