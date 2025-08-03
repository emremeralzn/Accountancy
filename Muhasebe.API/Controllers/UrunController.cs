using Microsoft.AspNetCore.Mvc;
using Muhasebe.Business;
using Muhasebe.Entities;

namespace Muhasebe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrunController : ControllerBase
    {
        private readonly UrunService _service;

        public UrunController(UrunService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var urunler = _service.UrunListele();
            return Ok(urunler);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var urun = _service.UrunGetir(id);
            if (urun == null) return NotFound();
            return Ok(urun);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Urun urun)
        {
            _service.UrunEkle(urun);
            return CreatedAtAction(nameof(Get), new { id = urun.Id }, urun);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Urun urun)
        {
            _service.UrunGuncelle(urun);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var urun = _service.UrunGetir(id);
            if (urun == null) return NotFound();
            _service.UrunSil(urun);
            return NoContent();
        }
    }
}