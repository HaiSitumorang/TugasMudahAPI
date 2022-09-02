using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INetCoreAPI.Service.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Model.Entities;

namespace NetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private readonly IMahasiswaService mahasiswaService;

        public MahasiswaController(IMahasiswaService mahasiswaService)
        {
            this.mahasiswaService = mahasiswaService;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Mahasiswa mahasiswa)
        {
            var result = await mahasiswaService.Create(mahasiswa);
            return Ok(result);
        }

        [HttpGet]
        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaService.GetAll();
            return result;
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await mahasiswaService.Delete(id);
            return Ok(result);
        }
    }
}
