using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NotaFiscalApi.Data;
using NotaFiscalApi.Models;

namespace NotaFiscalApi.Controllers;

[ApiController]
[Route("notas")]
[Authorize]
public class NotasController : ControllerBase
{
    private readonly NotaFiscalContext _context;

    public NotasController(NotaFiscalContext context) => _context = context;

    [HttpGet]
    public IActionResult GetNotas() => Ok(_context.NotasFiscais.ToList());

    [HttpPost]
    public IActionResult PostNota(NotaFiscal nota)
    {
        var existente = _context.NotasFiscais.Find(nota.Index);

        nota.Cadastro = DateTime.UtcNow;

        if (existente != null)
        {
            // Atualiza os campos necessários
            existente.Numero = nota.Numero;
            existente.Cliente = nota.Cliente;
            existente.Valor = nota.Valor;
            existente.Emissao = nota.Emissao;
            existente.Cadastro = nota.Cadastro;
            _context.NotasFiscais.Update(existente);
        }
        else
        {
            _context.NotasFiscais.Add(nota);
        }

        _context.SaveChanges();
        return CreatedAtAction(nameof(GetNotas), new { id = nota.Index }, nota);
    }
}