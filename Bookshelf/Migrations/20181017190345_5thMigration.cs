using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf.Migrations
{
    public partial class _5thMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Authors_AuthorId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Books_BookId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_Publishers_Books_BookId",
                table: "Publishers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBooks_AspNetUsers_ApplicationUsersId",
                table: "UserBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBooks_Books_BookId",
                table: "UserBooks");

            migrationBuilder.DropIndex(
                name: "IX_Publishers_BookId",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBooks",
                table: "UserBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Publishers");

            migrationBuilder.RenameTable(
                name: "UserBooks",
                newName: "BookUsers");

            migrationBuilder.RenameTable(
                name: "BookAuthor",
                newName: "BookAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_UserBooks_BookId",
                table: "BookUsers",
                newName: "IX_BookUsers_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_UserBooks_ApplicationUsersId",
                table: "BookUsers",
                newName: "IX_BookUsers_ApplicationUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthors",
                newName: "IX_BookAuthors_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthors",
                newName: "IX_BookAuthors_AuthorId");

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookUsers",
                table: "BookUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_AspNetUsers_ApplicationUsersId",
                table: "BookUsers",
                column: "ApplicationUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookUsers_Books_BookId",
                table: "BookUsers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_AspNetUsers_ApplicationUsersId",
                table: "BookUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookUsers_Books_BookId",
                table: "BookUsers");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookUsers",
                table: "BookUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "BookUsers",
                newName: "UserBooks");

            migrationBuilder.RenameTable(
                name: "BookAuthors",
                newName: "BookAuthor");

            migrationBuilder.RenameIndex(
                name: "IX_BookUsers_BookId",
                table: "UserBooks",
                newName: "IX_UserBooks_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookUsers_ApplicationUsersId",
                table: "UserBooks",
                newName: "IX_UserBooks_ApplicationUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthor",
                newName: "IX_BookAuthor_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthor",
                newName: "IX_BookAuthor_AuthorId");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Publishers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBooks",
                table: "UserBooks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_BookId",
                table: "Publishers",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Authors_AuthorId",
                table: "BookAuthor",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Books_BookId",
                table: "BookAuthor",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publishers_Books_BookId",
                table: "Publishers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBooks_AspNetUsers_ApplicationUsersId",
                table: "UserBooks",
                column: "ApplicationUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBooks_Books_BookId",
                table: "UserBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
