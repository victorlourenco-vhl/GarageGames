using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_Games.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao) " +
                "VALUES('Portátil', 'O portátil é ideal para viagens e eventos')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao) " +
                "VALUES('Console', 'Se divirta com sua família e amigos utilizando o console')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao) " +
                "VALUES('Simulador', 'O simulador é ideal para quem gosta de automobilismo')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
