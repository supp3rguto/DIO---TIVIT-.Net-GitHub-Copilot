using CoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CardController : ControllerBase {
    private readonly CardService _service;

    public CardController() {
        _service = new CardService();
    }

    [HttpGet("{numero}")]
    public IActionResult Verificar(string numero) {
        var resultado = _service.VerificarCartao(numero);
        
        return Ok(resultado);
    }
}