using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INetCoreAPI.Service.Interface.Services;
using NetCoreAPI.Data.Interface.Repositories;
using NetCoreAPI.Model.Entities;

namespace NetCoreAPI.Data.Repositories
{
    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly IDBService _dbService;

        public MahasiswaRepository(IDBService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> Create(Mahasiswa mahasiswa)
        {
            await _dbService.ModifyData("INSERT INTO mahasiswa " +
                "(id, nama, alamat, usia, idjurusan) " +
                "values (@Id, @Nama, @Alamat, @Usia, @JurusanId)", mahasiswa);
            return true;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await _dbService.GetData<Mahasiswa>("SELECT * FROM mahasiswa", new { });
            return result;
        }
        public async Task<bool> Delete(int id)
        {
            await _dbService.DeleteData("DELETE FROM mahasiswa WHERE id = @Id", new { Id = @id});
            return true;
        }
    }
}