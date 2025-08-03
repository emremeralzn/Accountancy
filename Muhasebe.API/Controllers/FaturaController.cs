using Microsoft.AspNetCore.Mvc;
using Muhasebe.Business;
using Muhasebe.Entities;

namespace Muhasebe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaturaController : ControllerBase
    {
        private readonly FaturaService _service;

        public FaturaController(FaturaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var faturalar = _service.FaturaListele();
            return Ok(faturalar);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var fatura = _service.FaturaGetir(id);
            if (fatura == null) return NotFound();
            return Ok(fatura);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Fatura fatura)
        {
            _service.FaturaEkle(fatura);
            return CreatedAtAction(nameof(Get), new { id = fatura.Id }, fatura);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Fatura fatura)
        {
            _service.FaturaGuncelle(fatura);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var fatura = _service.FaturaGetir(id);
            if (fatura == null) return NotFound();
            _service.FaturaSil(fatura);
            return NoContent();
        }
    }
}