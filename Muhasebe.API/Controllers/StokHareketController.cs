using Microsoft.AspNetCore.Mvc;
using Muhasebe.Business;
using Muhasebe.Entities;

namespace Muhasebe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StokHareketController : ControllerBase
    {
        private readonly StokHareketService _service;

        public StokHareketController(StokHareketService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var stokHareketler = _service.StokHareketListele();
            return Ok(stokHareketler);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var stokHareket = _service.StokHareketGetir(id);
            if (stokHareket == null) return NotFound();
            return Ok(stokHareket);
        }

        [HttpPost]
        public IActionResult Create([FromBody] StokHareket stokHareket)
        {
            _service.StokHareketEkle(stokHareket);
            return CreatedAtAction(nameof(Get), new { id = stokHareket.Id }, stokHareket);
        }

        [HttpPut]
        public IActionResult Update([FromBody] StokHareket stokHareket)
        {
            _service.StokHareketGuncelle(stokHareket);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var stokHareket = _service.StokHareketGetir(id);
            if (stokHareket == null) return NotFound();
            _service.StokHareketSil(stokHareket);
            return NoContent();
        }
    }
}