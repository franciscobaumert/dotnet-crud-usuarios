# dotnet-crud-usuarios
CRUD Usuarios con .NET y EF Core

Este proyecto implementa un CRUD básico de usuarios utilizando .NET 8, Entity Framework Core y SQL Server. Incluye endpoints REST y documentación automática con Swagger.

🚀 Requisitos previos

.NET 8 SDK instalado

SQL Server (Express, Developer o LocalDB)

Visual Studio Code o Visual Studio

⚙️ Configuración inicial

Clonar el repositorio:

git clone https://github.com/tuusuario/dotnet-crud-usuarios.git
cd dotnet-crud-usuarios/CrudUsuarios

Configurar la cadena de conexión en appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\SQLEXPRESS;Database=UsuariosDB;Trusted_Connection=True;TrustServerCertificate=True;"
}

👉 Ajusta según tu instancia de SQL Server. Para LocalDB:

"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\MSSQLLocalDB;Database=UsuariosDB;Trusted_Connection=True;"
}

Aplicar migraciones:

dotnet ef database update

📖 Endpoints disponibles

Usuarios

GET /api/usuarios → Lista todos los usuarios

GET /api/usuarios/{id} → Obtiene un usuario por ID

POST /api/usuarios → Crea un nuevo usuario

PUT /api/usuarios/{id} → Actualiza un usuario existente

DELETE /api/usuarios/{id} → Elimina un usuario

🔧 Ejemplos de uso

Crear usuario (POST)

{
  "nombre": "Francisco",
  "email": "francisco@example.com",
  "edad": 30
}

Actualizar usuario (PUT)

{
  "id": 1,
  "nombre": "Francisco Baumert",
  "email": "francisco@example.com",
  "edad": 31
}

Eliminar usuario (DELETE)

DELETE /api/usuarios/1

🌐 Swagger

La documentación interactiva está disponible en:

http://localhost:5100/swagger/index.html

📂 Estructura del proyecto

CrudUsuarios/
├── Controllers/
│   └── UsuariosController.cs
├── Models/
│   └── Usuario.cs
├── Data/
│   └── AppDbContext.cs
├── Migrations/
├── appsettings.json
└── Program.cs

✅ Resultado esperado

API funcional con operaciones CRUD.

Base de datos UsuariosDB creada y sincronizada.

Documentación automática con Swagger.

📌 Autor

Proyecto desarrollado por Francisco Andrés Baumert Gómez como parte de su portafolio técnico.