using Microsoft.AspNetCore.Mvc;
using Muhasebe.Business;
using Muhasebe.Entities;

namespace Muhasebe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusteriController : ControllerBase
    {
        private readonly MusteriService _service;

        public MusteriController(MusteriService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var musteriler = _service.MusteriListele();
            return Ok(musteriler);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var musteri = _service.MusteriGetir(id);
            if (musteri == null) return NotFound();
            return Ok(musteri);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Musteri musteri)
        {
            _service.MusteriEkle(musteri);
            return CreatedAtAction(nameof(Get), new { id = musteri.Id }, musteri);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Musteri musteri)
        {
            _service.MusteriGuncelle(musteri);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var musteri = _service.MusteriGetir(id);
            if (musteri == null) return NotFound();
            _service.MusteriSil(musteri);
            return NoContent();
        }
    }
}