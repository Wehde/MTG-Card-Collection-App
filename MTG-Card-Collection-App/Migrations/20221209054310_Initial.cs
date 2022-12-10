using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTG_Card_Collection_App.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManaCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CMC = table.Column<double>(type: "float", nullable: false),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supertypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toughness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Layout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Printings = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Artist", "CMC", "ColorIdentity", "Colors", "ImageUrl", "Layout", "ManaCost", "Name", "Number", "Power", "Printings", "Rarity", "Set", "SetName", "Subtypes", "Supertypes", "Text", "Toughness", "Type", "Types" },
                values: new object[,]
                {
                    { "507585", "Piotr Dura", 0.0, "[\"W\"]", null, "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507585&type=card", "normal", null, "Plains", "394", null, "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"ATH\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CMR\",\"CST\",\"DDC\",\"DDE\",\"DDF\",\"DDG\",\"DDH\",\"DDI\",\"DDK\",\"DDL\",\"DDN\",\"DDO\",\"DDP\",\"DDQ\",\"DMU\",\"DOM\",\"DTK\",\"DVD\",\"E01\",\"ELD\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GS1\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"MD1\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PDGM\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PLIST\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"PZ2\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"TD2\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC00\",\"WC02\",\"WC03\",\"WC04\",\"WC97\",\"WC98\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]", "Common", "KHM", "Kaldheim", "[\"Plains\"]", "[\"Basic\"]", "({T}: Add {W}.)", null, "Basic Land — Plains", "[\"Land\"]" },
                    { "507586", "Johannes Voss", 0.0, "[\"U\"]", null, "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507586&type=card", "normal", null, "Island", "395", null, "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"BTD\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CMR\",\"CST\",\"DD2\",\"DDE\",\"DDF\",\"DDH\",\"DDI\",\"DDJ\",\"DDM\",\"DDN\",\"DDO\",\"DDQ\",\"DDS\",\"DDT\",\"DDU\",\"DMU\",\"DOM\",\"DPA\",\"DTK\",\"E01\",\"ELD\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GS1\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"JVC\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL02\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PHED\",\"PLIST\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"PZ2\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"TD2\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC00\",\"WC01\",\"WC02\",\"WC03\",\"WC04\",\"WC97\",\"WC98\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]", "Common", "KHM", "Kaldheim", "[\"Island\"]", "[\"Basic\"]", "({T}: Add {U}.)", null, "Basic Land — Island", "[\"Land\"]" },
                    { "507587", "Piotr Dura", 0.0, "[\"B\"]", null, "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507587&type=card", "normal", null, "Swamp", "396", null, "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"ATH\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"BTD\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CST\",\"DDC\",\"DDD\",\"DDE\",\"DDH\",\"DDJ\",\"DDK\",\"DDM\",\"DDN\",\"DDP\",\"DDQ\",\"DDR\",\"DKM\",\"DMU\",\"DOM\",\"DPA\",\"DTK\",\"DVD\",\"E01\",\"ELD\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GVL\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"MD1\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PD3\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PHUK\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"TD2\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC01\",\"WC02\",\"WC03\",\"WC97\",\"WC98\",\"WC99\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]", "Common", "KHM", "Kaldheim", "[\"Swamp\"]", "[\"Basic\"]", "({T}: Add {B}.)", null, "Basic Land — Swamp", "[\"Land\"]" },
                    { "507588", "Sam Burley", 0.0, "[\"R\"]", null, "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507588&type=card", "normal", null, "Mountain", "397", null, "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"ARN\",\"ATH\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"BTD\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CMR\",\"CST\",\"DD1\",\"DD2\",\"DDE\",\"DDG\",\"DDH\",\"DDI\",\"DDJ\",\"DDK\",\"DDL\",\"DDN\",\"DDP\",\"DDS\",\"DDT\",\"DDU\",\"DKM\",\"DMU\",\"DOM\",\"DPA\",\"DTK\",\"E01\",\"ELD\",\"EVG\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GS1\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"JVC\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PD2\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PHED\",\"PLIST\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"PZ2\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC00\",\"WC01\",\"WC02\",\"WC03\",\"WC97\",\"WC98\",\"WC99\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]", "Common", "KHM", "Kaldheim", "[\"Mountain\"]", "[\"Basic\"]", "({T}: Add {R}.)", null, "Basic Land — Mountain", "[\"Land\"]" },
                    { "507589", "Sam Burley", 0.0, "[\"G\"]", null, "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507589&type=card", "normal", null, "Forest", "398", null, "[\"10E\",\"2ED\",\"2XM\",\"3ED\",\"40K\",\"4BB\",\"4ED\",\"5ED\",\"6ED\",\"7ED\",\"8ED\",\"9ED\",\"AFR\",\"AKH\",\"AKR\",\"ALA\",\"ANA\",\"ANB\",\"ARC\",\"ATH\",\"AVR\",\"BBD\",\"BFZ\",\"BRB\",\"BTD\",\"C13\",\"C14\",\"C15\",\"C16\",\"C17\",\"C18\",\"C19\",\"CED\",\"CEI\",\"CHK\",\"CLB\",\"CM2\",\"CMA\",\"CMD\",\"CMR\",\"CST\",\"DD1\",\"DDD\",\"DDE\",\"DDG\",\"DDH\",\"DDJ\",\"DDL\",\"DDM\",\"DDO\",\"DDP\",\"DDR\",\"DDS\",\"DDU\",\"DKM\",\"DMU\",\"DOM\",\"DPA\",\"DTK\",\"E01\",\"ELD\",\"EVG\",\"FBB\",\"FRF\",\"G17\",\"GK1\",\"GK2\",\"GN2\",\"GNT\",\"GRN\",\"GS1\",\"GVL\",\"H09\",\"HBG\",\"HOP\",\"HOU\",\"ICE\",\"IKO\",\"INV\",\"ISD\",\"ITP\",\"J14\",\"JMP\",\"KHM\",\"KLD\",\"KLR\",\"KTK\",\"LEA\",\"LEB\",\"LRW\",\"M10\",\"M11\",\"M12\",\"M13\",\"M14\",\"M15\",\"M19\",\"M20\",\"M21\",\"MBS\",\"ME1\",\"ME3\",\"MH2\",\"MID\",\"MIR\",\"MMQ\",\"MRD\",\"NEO\",\"NPH\",\"ODY\",\"OLEP\",\"ONS\",\"ORI\",\"P02\",\"PAL00\",\"PAL01\",\"PAL03\",\"PAL04\",\"PAL05\",\"PAL06\",\"PAL99\",\"PALP\",\"PANA\",\"PARL\",\"PC2\",\"PCA\",\"PELP\",\"PF19\",\"PF20\",\"PGPX\",\"PGRU\",\"PMPS\",\"PMPS06\",\"PMPS07\",\"PMPS08\",\"PMPS09\",\"PMPS10\",\"PMPS11\",\"POR\",\"PPP1\",\"PRM\",\"PRW2\",\"PRWK\",\"PS11\",\"PSAL\",\"PSS2\",\"PSS3\",\"PTC\",\"PTK\",\"PZ2\",\"RAV\",\"RIX\",\"RNA\",\"ROE\",\"RQS\",\"RTR\",\"S99\",\"SHM\",\"SLD\",\"SNC\",\"SOI\",\"SOM\",\"STX\",\"SUM\",\"TD0\",\"TD2\",\"THB\",\"THS\",\"TMP\",\"TPR\",\"TSP\",\"UGL\",\"UND\",\"UNF\",\"UNH\",\"USG\",\"UST\",\"VOW\",\"WAR\",\"WC00\",\"WC01\",\"WC02\",\"WC03\",\"WC04\",\"WC97\",\"WC98\",\"WC99\",\"XANA\",\"XLN\",\"ZEN\",\"ZNR\"]", "Common", "KHM", "Kaldheim", "[\"Forest\"]", "[\"Basic\"]", "({T}: Add {G}.)", null, "Basic Land — Forest", "[\"Land\"]" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
