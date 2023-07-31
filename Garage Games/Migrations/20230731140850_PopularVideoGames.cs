using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_Games.Migrations
{
    /// <inheritdoc />
    public partial class PopularVideoGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO VideoGames(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, favorito, disponivel, CategoriaId)" +
                "VALUES('PS5', 'Console Sony Playstation 5', 'Desfrute do carregamento do seu PS5, extremamente rápido com o SSD de altíssima velocidade', " +
                "'3500.00', 'ps5.jpg', 'ps5.jpg', 0, 1, 2)");

            migrationBuilder.Sql("INSERT INTO VideoGames(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, favorito, disponivel, CategoriaId)" +
                "VALUES('G29', 'Volante Simulador G29', 'O G29 eleva os jogos de corridas mais recentes ao nível mais alto', " +
                "'1900.00', 'g29.jpg', 'g29.jpg', 1, 1, 3)");

            migrationBuilder.Sql("INSERT INTO VideoGames(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, favorito, disponivel, CategoriaId)" +
                "VALUES('Nintendo Switch', 'Console portátil Nintendo Switch', 'O console que lhe permite jogar os jogos que quiser, onde e como quiser', " +
                "'2199.99', 'nintendo-switch.jpg', 'nintendo-switch.jpg', 0, 1, 1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELET FROM VideoGames");
        }
    }
}
