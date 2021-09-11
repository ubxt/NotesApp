using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName) VALUES ('Ünal Berke', 'Topçu')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Initial Note', 'Trying new things!')");
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId) 
                    VALUES(
                        (SELECT Id FROM Notes WHERE Title = 'Initial Note'),
                        (SELECT Id FROM Users WHERE FirstName = 'Ünal Berke')
                    )"
                );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM NoteUser");
            migrationBuilder
                .Sql("DELETE FROM Users");
            migrationBuilder
                .Sql("DELETE FROM Notes");
        }
    }
}
