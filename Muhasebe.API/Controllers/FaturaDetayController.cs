using Microsoft.AspNetCore.Mvc;
using Muhasebe.Business;
using Muhasebe.Entities;

namespace Muhasebe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaturaDetayController : ControllerBase
    {
        private readonly FaturaDetayService _service;

        public FaturaDetayController(FaturaDetayService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var faturaDetaylar = _service.FaturaDetayListele();
            return Ok(faturaDetaylar);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var faturaDetay = _service.FaturaDetayGetir(id);
            if (faturaDetay == null) return NotFound();
            return Ok(faturaDetay);
        }

        [HttpPost]
        public IActionResult Create([FromBody] FaturaDetay faturaDetay)
        {
            _service.FaturaDetayEkle(faturaDetay);
            return CreatedAtAction(nameof(Get), new { id = faturaDetay.Id }, faturaDetay);
        }

        [HttpPut]
        public IActionResult Update([FromBody] FaturaDetay faturaDetay)
        {
            _service.FaturaDetayGuncelle(faturaDetay);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var faturaDetay = _service.FaturaDetayGetir(id);
            if (faturaDetay == null) return NotFound();
            _service.FaturaDetaySil(faturaDetay);
            return NoContent();
        }
    }
}