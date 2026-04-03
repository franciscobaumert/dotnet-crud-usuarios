using Microsoft.AspNetCore.Mvc;
using CrudUsuarios.Data;
using CrudUsuarios.Models;

namespace CrudUsuarios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/usuarios
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            return Ok(_context.Usuarios.ToList());
        }

        // GET: api/usuarios/{id}
        [HttpGet("{id}")]
        public IActionResult GetUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        // POST: api/usuarios
        [HttpPost]
        public IActionResult CreateUsuario([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUsuario), new { id = usuario.Id }, usuario);
        }

        // PUT: api/usuarios/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUsuario(int id, [FromBody] Usuario usuario)
        {
            var existing = _context.Usuarios.Find(id);
            if (existing == null) return NotFound();

            existing.Nombre = usuario.Nombre;
            existing.Email = usuario.Email;
            existing.Edad = usuario.Edad;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/usuarios/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null) return NotFound();

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return NoContent();
        }
    }
}