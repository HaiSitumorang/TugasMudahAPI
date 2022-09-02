using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INetCoreAPI.Service.Interface.Services;
using NetCoreAPI.Data.Interface.Repositories;
using NetCoreAPI.Model.Entities;

namespace NetCoreAPI.Service.Services
{
    class MahasiswaServices : IMahasiswaService
    {
        private readonly IMahasiswaRepository mahasiswaRepository;

        public MahasiswaServices(IMahasiswaRepository mahasiswaRepository)
        {
            this.mahasiswaRepository = mahasiswaRepository;
        }

        public async Task<bool> Create(Mahasiswa mahasiswa)
        {
            var result = await mahasiswaRepository.Create(mahasiswa);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await mahasiswaRepository.Delete(id);
            return true; 
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaRepository.GetAll();
            return result;
        }
    }
}
