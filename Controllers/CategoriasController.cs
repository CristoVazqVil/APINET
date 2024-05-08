using System.Data.Common;
using backend.Models;
using backendnet.Data;
using backendnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendnet.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriasController(DataContext context): Controller{
    //GET
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Categoria>>> GetCategoria(){
        return await context.Categoria.AsNoTracking().ToListAsync();
    }

    //GET categorias con id 5
    [HttpGet("{id}")]
    public async Task<ActionResult<Categoria>> GetCategoria(int id){
        var categoria = await context.Categoria.FindAsync(id);
        if(categoria == null) return NotFound();
        return categoria;
    }

    //POST categorias
    [HttpPost]
    public async Task<ActionResult<Categoria>> PostCategoria(CategoriaDTO categoriaDTO){
        Categoria categoria = new(){
            Nombre = categoriaDTO.Nombre,
        };
        context.Categoria.Add(categoria);
        await context.SaveChangesAsync(); 
        
        return CreatedAtAction(nameof(GetCategoria), new {id = categoria.CategoriaId}, categoria);
    }

    // PUT categoria
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCategoria(int idCategoria, CategoriaDTO categoriaDTO){
        if(idCategoria != categoriaDTO.CategoriaId) return BadRequest();
        var cat = await context.Categoria.FindAsync(idCategoria);
        if(cat == null) return NotFound();

        cat.Nombre = categoriaDTO.Nombre;
        await context.SaveChangesAsync();
        return NoContent();
    }

    // delete 
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategoria(int idCategoria){
        var categoria = await context.Categoria.FindAsync(idCategoria);
        if(categoria == null) return NotFound();

        if(categoria.Protegida) return BadRequest(); 

        context.Categoria.Remove(categoria);
        await context.SaveChangesAsync();
        return NoContent();
    }
} 