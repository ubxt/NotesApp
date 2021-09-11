using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SeedGeneratedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
    .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('April', 'Chavez','shermanjoshua@burnett-roy.info')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('Capucine-Capucine', 'Guillot','roger71@lecomte.net')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('Rachel', 'Davis','leonjackie@jones.net')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('Xavier', 'Delahaye','claude05@club-internet.fr')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('Sandy', 'Mccoy','danielle19@gmail.com')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('Jacqueline', 'Guilbert','gklein@valette.fr')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('Seyithan', 'Bilge','mancointihap@yahoo.com')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('Alessandra', 'Scotto','mbombieri@poste.it')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('Turabi', 'Bilge','adurdu@koruturk.com')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Users] (FirstName,LastName,Email) VALUES ('İlkim', 'Soylu','mancoaksoy@turk.com')");


            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('There trade.', 'Owner strong team enjoy. Month on hold important.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Amener.', 'Sourire sourire propos pourtant pays. Je rappeler bout quoi prière vie étonner chance. Chacun déchirer hésiter dépasser cheval défendre partie large.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Tell blood business.', 'Music already learn similar. Among mother coach modern or between suddenly Congress.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Partie exprimer.', 'Votre poitrine en employer mariage. Figurer lettre vague mort savoir escalier par.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Last hundred.', 'Firm news represent little society. Father control listen hard his attorney population.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Tracer te.', 'Tenter plaisir marier poursuivre joli.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Perferendis eum eius.', 'Tempore hic vel. Voluptate dolorem quas rerum dolorum doloribus. Non nemo culpa.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Culpa aliquid.', 'Eius totam incidunt asperiores. Esse perspiciatis modi reprehenderit voluptate ipsam laborum. Similique autem quisquam numquam.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Cupiditate.', 'Culpa animi quos possimus. Ad similique sint ab vitae pariatur ratione. Praesentium recusandae odio expedita esse.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Quae.', 'Debitis et harum omnis. Quod a occaecati tenetur excepturi et. Suscipit et voluptates deserunt quo.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Ea odit numquam.', 'Voluptatum illum placeat accusantium quam in cum. Laboriosam vero similique illo similique nulla delectus.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Quidem.', 'Natus quo hic voluptatem tempora harum rerum odit.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Pourquoi essayer autre.', 'Idée chanter flot silencieux heureux oiseau beaux. Déclarer cuisine rompre connaissance briller traiter court.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Unde nihil exercitationem.', 'Nobis quae at similique laborum quis similique. Vel nostrum ullam rerum. Hic quam eum laboriosam explicabo facilis perferendis facere.')");
            migrationBuilder
                .Sql("INSERT INTO [dbo].[Notes] (Title, Content) VALUES ('Ça chose.', 'Immobile installer sueur auteur voisin parvenir. Saison savoir camarade dehors.')");


            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'There trade.' AND Content='Owner strong team enjoy. Month on hold important.'),
			(SELECT Id FROM Users WHERE FirstName = 'April' AND LastName='Chavez' AND Email='shermanjoshua@burnett-roy.info')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Culpa aliquid.' AND Content='Eius totam incidunt asperiores. Esse perspiciatis modi reprehenderit voluptate ipsam laborum. Similique autem quisquam numquam.'),
			(SELECT Id FROM Users WHERE FirstName = 'April' AND LastName='Chavez' AND Email='shermanjoshua@burnett-roy.info')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Unde nihil exercitationem.' AND Content='Nobis quae at similique laborum quis similique. Vel nostrum ullam rerum. Hic quam eum laboriosam explicabo facilis perferendis facere.'),
			(SELECT Id FROM Users WHERE FirstName = 'April' AND LastName='Chavez' AND Email='shermanjoshua@burnett-roy.info')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Last hundred.' AND Content='Firm news represent little society. Father control listen hard his attorney population.'),
			(SELECT Id FROM Users WHERE FirstName = 'Capucine-Capucine' AND LastName='Guillot' AND Email='roger71@lecomte.net')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Tracer te.' AND Content='Tenter plaisir marier poursuivre joli.'),
			(SELECT Id FROM Users WHERE FirstName = 'Capucine-Capucine' AND LastName='Guillot' AND Email='roger71@lecomte.net')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Ça chose.' AND Content='Immobile installer sueur auteur voisin parvenir. Saison savoir camarade dehors.'),
			(SELECT Id FROM Users WHERE FirstName = 'Capucine-Capucine' AND LastName='Guillot' AND Email='roger71@lecomte.net')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Partie exprimer.' AND Content='Votre poitrine en employer mariage. Figurer lettre vague mort savoir escalier par.'),
			(SELECT Id FROM Users WHERE FirstName = 'Rachel' AND LastName='Davis' AND Email='leonjackie@jones.net')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Culpa aliquid.' AND Content='Eius totam incidunt asperiores. Esse perspiciatis modi reprehenderit voluptate ipsam laborum. Similique autem quisquam numquam.'),
			(SELECT Id FROM Users WHERE FirstName = 'Rachel' AND LastName='Davis' AND Email='leonjackie@jones.net')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'There trade.' AND Content='Owner strong team enjoy. Month on hold important.'),
			(SELECT Id FROM Users WHERE FirstName = 'Xavier' AND LastName='Delahaye' AND Email='claude05@club-internet.fr')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Amener.' AND Content='Sourire sourire propos pourtant pays. Je rappeler bout quoi prière vie étonner chance. Chacun déchirer hésiter dépasser cheval défendre partie large.'),
			(SELECT Id FROM Users WHERE FirstName = 'Xavier' AND LastName='Delahaye' AND Email='claude05@club-internet.fr')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Last hundred.' AND Content='Firm news represent little society. Father control listen hard his attorney population.'),
			(SELECT Id FROM Users WHERE FirstName = 'Xavier' AND LastName='Delahaye' AND Email='claude05@club-internet.fr')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Perferendis eum eius.' AND Content='Tempore hic vel. Voluptate dolorem quas rerum dolorum doloribus. Non nemo culpa.'),
			(SELECT Id FROM Users WHERE FirstName = 'Xavier' AND LastName='Delahaye' AND Email='claude05@club-internet.fr')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'There trade.' AND Content='Owner strong team enjoy. Month on hold important.'),
			(SELECT Id FROM Users WHERE FirstName = 'Sandy' AND LastName='Mccoy' AND Email='danielle19@gmail.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Amener.' AND Content='Sourire sourire propos pourtant pays. Je rappeler bout quoi prière vie étonner chance. Chacun déchirer hésiter dépasser cheval défendre partie large.'),
			(SELECT Id FROM Users WHERE FirstName = 'Sandy' AND LastName='Mccoy' AND Email='danielle19@gmail.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Last hundred.' AND Content='Firm news represent little society. Father control listen hard his attorney population.'),
			(SELECT Id FROM Users WHERE FirstName = 'Sandy' AND LastName='Mccoy' AND Email='danielle19@gmail.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Perferendis eum eius.' AND Content='Tempore hic vel. Voluptate dolorem quas rerum dolorum doloribus. Non nemo culpa.'),
			(SELECT Id FROM Users WHERE FirstName = 'Sandy' AND LastName='Mccoy' AND Email='danielle19@gmail.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Ça chose.' AND Content='Immobile installer sueur auteur voisin parvenir. Saison savoir camarade dehors.'),
			(SELECT Id FROM Users WHERE FirstName = 'Sandy' AND LastName='Mccoy' AND Email='danielle19@gmail.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Partie exprimer.' AND Content='Votre poitrine en employer mariage. Figurer lettre vague mort savoir escalier par.'),
			(SELECT Id FROM Users WHERE FirstName = 'Jacqueline' AND LastName='Guilbert' AND Email='gklein@valette.fr')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Last hundred.' AND Content='Firm news represent little society. Father control listen hard his attorney population.'),
			(SELECT Id FROM Users WHERE FirstName = 'Jacqueline' AND LastName='Guilbert' AND Email='gklein@valette.fr')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Culpa aliquid.' AND Content='Eius totam incidunt asperiores. Esse perspiciatis modi reprehenderit voluptate ipsam laborum. Similique autem quisquam numquam.'),
			(SELECT Id FROM Users WHERE FirstName = 'Jacqueline' AND LastName='Guilbert' AND Email='gklein@valette.fr')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Ça chose.' AND Content='Immobile installer sueur auteur voisin parvenir. Saison savoir camarade dehors.'),
			(SELECT Id FROM Users WHERE FirstName = 'Jacqueline' AND LastName='Guilbert' AND Email='gklein@valette.fr')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'There trade.' AND Content='Owner strong team enjoy. Month on hold important.'),
			(SELECT Id FROM Users WHERE FirstName = 'Seyithan' AND LastName='Bilge' AND Email='mancointihap@yahoo.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Partie exprimer.' AND Content='Votre poitrine en employer mariage. Figurer lettre vague mort savoir escalier par.'),
			(SELECT Id FROM Users WHERE FirstName = 'Seyithan' AND LastName='Bilge' AND Email='mancointihap@yahoo.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Quae.' AND Content='Debitis et harum omnis. Quod a occaecati tenetur excepturi et. Suscipit et voluptates deserunt quo.'),
			(SELECT Id FROM Users WHERE FirstName = 'Seyithan' AND LastName='Bilge' AND Email='mancointihap@yahoo.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'There trade.' AND Content='Owner strong team enjoy. Month on hold important.'),
			(SELECT Id FROM Users WHERE FirstName = 'Alessandra' AND LastName='Scotto' AND Email='mbombieri@poste.it')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Perferendis eum eius.' AND Content='Tempore hic vel. Voluptate dolorem quas rerum dolorum doloribus. Non nemo culpa.'),
			(SELECT Id FROM Users WHERE FirstName = 'Alessandra' AND LastName='Scotto' AND Email='mbombieri@poste.it')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Cupiditate.' AND Content='Culpa animi quos possimus. Ad similique sint ab vitae pariatur ratione. Praesentium recusandae odio expedita esse.'),
			(SELECT Id FROM Users WHERE FirstName = 'Alessandra' AND LastName='Scotto' AND Email='mbombieri@poste.it')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Quidem.' AND Content='Natus quo hic voluptatem tempora harum rerum odit.'),
			(SELECT Id FROM Users WHERE FirstName = 'Alessandra' AND LastName='Scotto' AND Email='mbombieri@poste.it')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'There trade.' AND Content='Owner strong team enjoy. Month on hold important.'),
			(SELECT Id FROM Users WHERE FirstName = 'Turabi' AND LastName='Bilge' AND Email='adurdu@koruturk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Amener.' AND Content='Sourire sourire propos pourtant pays. Je rappeler bout quoi prière vie étonner chance. Chacun déchirer hésiter dépasser cheval défendre partie large.'),
			(SELECT Id FROM Users WHERE FirstName = 'Turabi' AND LastName='Bilge' AND Email='adurdu@koruturk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Tell blood business.' AND Content='Music already learn similar. Among mother coach modern or between suddenly Congress.'),
			(SELECT Id FROM Users WHERE FirstName = 'Turabi' AND LastName='Bilge' AND Email='adurdu@koruturk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Culpa aliquid.' AND Content='Eius totam incidunt asperiores. Esse perspiciatis modi reprehenderit voluptate ipsam laborum. Similique autem quisquam numquam.'),
			(SELECT Id FROM Users WHERE FirstName = 'Turabi' AND LastName='Bilge' AND Email='adurdu@koruturk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Pourquoi essayer autre.' AND Content='Idée chanter flot silencieux heureux oiseau beaux. Déclarer cuisine rompre connaissance briller traiter court.'),
			(SELECT Id FROM Users WHERE FirstName = 'Turabi' AND LastName='Bilge' AND Email='adurdu@koruturk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Amener.' AND Content='Sourire sourire propos pourtant pays. Je rappeler bout quoi prière vie étonner chance. Chacun déchirer hésiter dépasser cheval défendre partie large.'),
			(SELECT Id FROM Users WHERE FirstName = 'İlkim' AND LastName='Soylu' AND Email='mancoaksoy@turk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Tell blood business.' AND Content='Music already learn similar. Among mother coach modern or between suddenly Congress.'),
			(SELECT Id FROM Users WHERE FirstName = 'İlkim' AND LastName='Soylu' AND Email='mancoaksoy@turk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Partie exprimer.' AND Content='Votre poitrine en employer mariage. Figurer lettre vague mort savoir escalier par.'),
			(SELECT Id FROM Users WHERE FirstName = 'İlkim' AND LastName='Soylu' AND Email='mancoaksoy@turk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Last hundred.' AND Content='Firm news represent little society. Father control listen hard his attorney population.'),
			(SELECT Id FROM Users WHERE FirstName = 'İlkim' AND LastName='Soylu' AND Email='mancoaksoy@turk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Cupiditate.' AND Content='Culpa animi quos possimus. Ad similique sint ab vitae pariatur ratione. Praesentium recusandae odio expedita esse.'),
			(SELECT Id FROM Users WHERE FirstName = 'İlkim' AND LastName='Soylu' AND Email='mancoaksoy@turk.com')
		)"
                );
            migrationBuilder
                .Sql(@"INSERT INTO [dbo].[NoteUser] (NotesId, UsersId)
		VALUES(
			(SELECT Id FROM Notes WHERE Title = 'Unde nihil exercitationem.' AND Content='Nobis quae at similique laborum quis similique. Vel nostrum ullam rerum. Hic quam eum laboriosam explicabo facilis perferendis facere.'),
			(SELECT Id FROM Users WHERE FirstName = 'İlkim' AND LastName='Soylu' AND Email='mancoaksoy@turk.com')
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
