using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchMakings.Data.Migrations
{
    /// <inheritdoc />
    public partial class TPT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_MaleId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_MatchMakerId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_WomenId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyDetails_Users_MaleId",
                table: "FamilyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyDetails_Users_WomenId",
                table: "FamilyDetails");

            migrationBuilder.DropColumn(
                name: "AdditionalEducationalInstitution",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AgeFrom",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AgeTo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AnOutsider",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Appearance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BackGround",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Beard",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BigYeshiva",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BurnDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Club",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Community",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CurrentOccupation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DriversLicense",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DrivingLicense",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExpectationsFromPartner",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExperienceInShidduchim",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FacePaint",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FatherPhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GeneralAppearance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HasChildrenInShidduchim",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Hat",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HeadCovering",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HealthCondition",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HighSchool",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Hot",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImportantTraitsIAmLookingFor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImportantTraitsIMLookingFor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImportantTraitsInMe",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InterestedInBoy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsInternalMatchmaker",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsSeminarGraduate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Kibbutz",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LandlinePhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LifeSkills",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchMaker_Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchMaker_City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchMaker_Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchMaker_Occupation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MatchmakerName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MobilePhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MoreInformation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MotherPhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Openness",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PairingType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersonalClub",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreferredProfessionalPath",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreferredSeminarStyle",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreferredSittingStyle",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PreviousWorkplaces",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PrintingNotes",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Seminar",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SmallYeshiva",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Smoker",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StatusVacant",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StudyPath",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Suit",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Tz",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_AgeFrom",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_AgeTo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_AnOutsider",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Appearance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_BackGround",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Beard",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_BurnDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Class",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Club",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_FacePaint",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_FatherPhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_GeneralAppearance",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_HeadCovering",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_HealthCondition",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Height",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_ImportantTraitsInMe",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_MoreInformation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_MotherPhone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Occupation",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Openness",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_PairingType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Smoker",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_StatusVacant",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Suit",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Women_Tz",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "YearsInShidduchim",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "male",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnOutsider = table.Column<bool>(type: "bit", nullable: false),
                    BackGround = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Openness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BurnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    HealthCondition = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusVacant = table.Column<bool>(type: "bit", nullable: false),
                    PairingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    GeneralAppearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacePaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Appearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoreInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriversLicense = table.Column<bool>(type: "bit", nullable: false),
                    Smoker = table.Column<bool>(type: "bit", nullable: false),
                    Beard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmallYeshiva = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BigYeshiva = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kibbutz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectationsFromPartner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Club = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeFrom = table.Column<int>(type: "int", nullable: false),
                    AgeTo = table.Column<int>(type: "int", nullable: false),
                    ImportantTraitsInMe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportantTraitsIAmLookingFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredSeminarStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredProfessionalPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadCovering = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_male", x => x.Id);
                    table.ForeignKey(
                        name: "FK_male_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "matchMaker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MatchmakerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandlinePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalClub = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Community = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousWorkplaces = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSeminarGraduate = table.Column<bool>(type: "bit", nullable: true),
                    HasChildrenInShidduchim = table.Column<bool>(type: "bit", nullable: true),
                    ExperienceInShidduchim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LifeSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearsInShidduchim = table.Column<int>(type: "int", nullable: true),
                    IsInternalMatchmaker = table.Column<bool>(type: "bit", nullable: true),
                    PrintingNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matchMaker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_matchMaker_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "women",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnOutsider = table.Column<bool>(type: "bit", nullable: true),
                    BackGround = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Openness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BurnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    HealthCondition = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusVacant = table.Column<bool>(type: "bit", nullable: true),
                    PairingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    GeneralAppearance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacePaint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Appearance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoreInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadCovering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seminar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalEducationalInstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Club = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeFrom = table.Column<int>(type: "int", nullable: true),
                    AgeTo = table.Column<int>(type: "int", nullable: true),
                    ImportantTraitsInMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportantTraitsIMLookingFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredSittingStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterestedInBoy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrivingLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Smoker = table.Column<bool>(type: "bit", nullable: true),
                    Beard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_women", x => x.Id);
                    table.ForeignKey(
                        name: "FK_women_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_male_MaleId",
                table: "Contacts",
                column: "MaleId",
                principalTable: "male",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_matchMaker_MatchMakerId",
                table: "Contacts",
                column: "MatchMakerId",
                principalTable: "matchMaker",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_women_WomenId",
                table: "Contacts",
                column: "WomenId",
                principalTable: "women",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyDetails_male_MaleId",
                table: "FamilyDetails",
                column: "MaleId",
                principalTable: "male",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyDetails_women_WomenId",
                table: "FamilyDetails",
                column: "WomenId",
                principalTable: "women",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_male_MaleId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_matchMaker_MatchMakerId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_women_WomenId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyDetails_male_MaleId",
                table: "FamilyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_FamilyDetails_women_WomenId",
                table: "FamilyDetails");

            migrationBuilder.DropTable(
                name: "male");

            migrationBuilder.DropTable(
                name: "matchMaker");

            migrationBuilder.DropTable(
                name: "women");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalEducationalInstitution",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgeFrom",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgeTo",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AnOutsider",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Appearance",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BackGround",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Beard",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BigYeshiva",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BurnDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Club",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Community",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentOccupation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DriversLicense",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrivingLicense",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpectationsFromPartner",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceInShidduchim",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacePaint",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherPhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneralAppearance",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasChildrenInShidduchim",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hat",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadCovering",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HealthCondition",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Users",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HighSchool",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hot",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportantTraitsIAmLookingFor",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportantTraitsIMLookingFor",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportantTraitsInMe",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InterestedInBoy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsInternalMatchmaker",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSeminarGraduate",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kibbutz",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandlinePhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LifeSkills",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchMaker_Occupation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchmakerName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobilePhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MoreInformation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherPhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Openness",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PairingType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalClub",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredProfessionalPath",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredSeminarStyle",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredSittingStyle",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousWorkplaces",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrintingNotes",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Seminar",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmallYeshiva",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Smoker",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StatusVacant",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudyPath",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Suit",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tz",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "Users",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Women_Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Women_Age",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Women_AgeFrom",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Women_AgeTo",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Women_AnOutsider",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Appearance",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_BackGround",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Beard",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Women_BurnDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Class",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Club",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Country",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_FacePaint",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_FatherPhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_GeneralAppearance",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_HeadCovering",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Women_HealthCondition",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Women_Height",
                table: "Users",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_ImportantTraitsInMe",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_MoreInformation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_MotherPhone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Occupation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Openness",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_PairingType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Women_Smoker",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Status",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Women_StatusVacant",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Suit",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Women_Tz",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearsInShidduchim",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_MaleId",
                table: "Contacts",
                column: "MaleId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_MatchMakerId",
                table: "Contacts",
                column: "MatchMakerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_WomenId",
                table: "Contacts",
                column: "WomenId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyDetails_Users_MaleId",
                table: "FamilyDetails",
                column: "MaleId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FamilyDetails_Users_WomenId",
                table: "FamilyDetails",
                column: "WomenId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
