using backendnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendnet.Data.Seed;

public class SeedCategoria: IEntityTypeConfiguration<Categoria>{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.HasData(
            new Models.Categoria{CategoriaId = 1,Nombre = "Acción", Protegida = true},
            new Models.Categoria{CategoriaId = 2,Nombre = "Aventura", Protegida = true},
            new Models.Categoria{CategoriaId = 3,Nombre = "Animación", Protegida = true},
            new Models.Categoria{CategoriaId = 4,Nombre = "Ciencia Ficción", Protegida = true},
            new Models.Categoria{CategoriaId = 5,Nombre = "Comedia", Protegida = true},
            new Models.Categoria{CategoriaId = 6,Nombre = "Crimen", Protegida = true},
            new Models.Categoria{CategoriaId = 7,Nombre = "Documental", Protegida = true},
            new Models.Categoria{CategoriaId = 8,Nombre = "Drama", Protegida = true},
            new Models.Categoria{CategoriaId = 9,Nombre = "Familiar", Protegida = true},
            new Models.Categoria{CategoriaId = 10,Nombre = "Fantasía", Protegida = true},
            new Models.Categoria{CategoriaId = 11,Nombre = "Histórica", Protegida = true},
            new Models.Categoria{CategoriaId = 12,Nombre = "Horror", Protegida = true},
            new Models.Categoria{CategoriaId = 13,Nombre = "Música", Protegida = true},
            new Models.Categoria{CategoriaId = 14,Nombre = "Misterio", Protegida = true},
            new Models.Categoria{CategoriaId = 15,Nombre = "Romance", Protegida = true}

        );
    }
}
