namespace CrudUsuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }       // Clave primaria
        public required string Nombre { get; set; } // Nombre del usuario
        public required string Email { get; set; }  // Correo electrónico
        public int Edad { get; set; }      // Edad
    }
}