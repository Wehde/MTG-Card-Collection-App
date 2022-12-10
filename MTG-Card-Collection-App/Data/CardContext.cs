using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MTG_Card_Collection_App.Models;
using Newtonsoft.Json;

namespace MTG_Card_Collection_App.Data
{
    public class CardContext : IdentityDbContext<User>
    {
        public CardContext(DbContextOptions<CardContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardCollection> CardCollections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var converter = new ValueConverter<List<string>, string>(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<string>>(v));

            var comparer = new ValueComparer<List<string>>(
                (c1, c2) => c1.SequenceEqual(c2), 
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList());

            modelBuilder.Entity<Card>()
                .Property(e => e.Colors)
                .HasConversion(converter, comparer);

            modelBuilder.Entity<Card>()
                .Property(e => e.ColorIdentity)
                .HasConversion(converter, comparer);

            modelBuilder.Entity<Card>()
                .Property(e => e.Supertypes)
                .HasConversion(converter, comparer);

            modelBuilder.Entity<Card>()
                .Property(e => e.Types)
                .HasConversion(converter, comparer);

            modelBuilder.Entity<Card>()
                .Property(e => e.Subtypes)
                .HasConversion(converter, comparer);

            modelBuilder.Entity<Card>()
                .Property(e => e.Printings)
                .HasConversion(converter, comparer);

            modelBuilder.Entity<Card>().HasData(
                new Card()
                {
                    Id = "507585",
                    Name = "Plains",
                    ManaCost = null,
                    CMC = 0.0,
                    Colors = null,
                    ColorIdentity = new List<string> { "W" },
                    Type = "Basic Land — Plains",
                    Supertypes = new List<string> { "Basic" },
                    Types = new List<string> { "Land" },
                    Subtypes = new List<string> { "Plains" },
                    Rarity = "Common",
                    Set = "KHM",
                    SetName = "Kaldheim",
                    Text = "({T}: Add {W}.)",
                    Artist = "Piotr Dura",
                    Number = "394",
                    Power = null,
                    Toughness = null,
                    Layout = "normal",
                    ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507585&type=card",
                    Printings = new List<string>{ "10E", "2ED", "2XM", "3ED", "40K", "4BB", "4ED", "5ED", "6ED", "7ED", "8ED", "9ED", "AFR", "AKH", "AKR", "ALA", "ANA", "ANB", "ARC", "ATH", "AVR", "BBD", "BFZ", "BRB", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "CED", "CEI", "CHK", "CLB", "CM2", "CMA", "CMD", "CMR", "CST", "DDC", "DDE", "DDF", "DDG", "DDH", "DDI", "DDK", "DDL", "DDN", "DDO", "DDP", "DDQ", "DMU", "DOM", "DTK", "DVD", "E01", "ELD", "FBB", "FRF", "G17", "GK1", "GK2", "GN2", "GNT", "GRN", "GS1", "H09", "HBG", "HOP", "HOU", "ICE", "IKO", "INV", "ISD", "ITP", "J14", "JMP", "KHM", "KLD", "KLR", "KTK", "LEA", "LEB", "LRW", "M10", "M11", "M12", "M13", "M14", "M15", "M19", "M20", "M21", "MBS", "MD1", "ME1", "ME3", "MH2", "MID", "MIR", "MMQ", "MRD", "NEO", "NPH", "ODY", "OLEP", "ONS", "ORI", "P02", "PAL00", "PAL01", "PAL03", "PAL04", "PAL05", "PAL06", "PAL99", "PALP", "PANA", "PARL", "PC2", "PCA", "PDGM", "PELP", "PF19", "PF20", "PGPX", "PGRU", "PLIST", "PMPS", "PMPS06", "PMPS07", "PMPS08", "PMPS09", "PMPS10", "PMPS11", "POR", "PPP1", "PRM", "PRW2", "PRWK", "PS11", "PSAL", "PSS2", "PSS3", "PTC", "PTK", "PZ2", "RAV", "RIX", "RNA", "ROE", "RQS", "RTR", "S99", "SHM", "SLD", "SNC", "SOI", "SOM", "STX", "SUM", "TD0", "TD2", "THB", "THS", "TMP", "TPR", "TSP", "UGL", "UND", "UNF", "UNH", "USG", "UST", "VOW", "WAR", "WC00", "WC02", "WC03", "WC04", "WC97", "WC98", "XANA", "XLN", "ZEN", "ZNR" }
                },
                new Card()
                {
                    Id = "507586",
                    Name = "Island",
                    ManaCost = null,
                    CMC = 0.0,
                    Colors = null,
                    ColorIdentity = new List<string> { "U" },
                    Type = "Basic Land — Island",
                    Supertypes = new List<string> { "Basic" },
                    Types = new List<string> { "Land" },
                    Subtypes = new List<string> { "Island" },
                    Rarity = "Common",
                    Set = "KHM",
                    SetName = "Kaldheim",
                    Text = "({T}: Add {U}.)",
                    Artist = "Johannes Voss",
                    Number = "395",
                    Power = null,
                    Toughness = null,
                    Layout = "normal",
                    ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507586&type=card",
                    Printings = new List<string> { "10E", "2ED", "2XM", "3ED", "40K", "4BB", "4ED", "5ED", "6ED", "7ED", "8ED", "9ED", "AFR", "AKH", "AKR", "ALA", "ANA", "ANB", "ARC", "AVR", "BBD", "BFZ", "BRB", "BTD", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "CED", "CEI", "CHK", "CLB", "CM2", "CMA", "CMD", "CMR", "CST", "DD2", "DDE", "DDF", "DDH", "DDI", "DDJ", "DDM", "DDN", "DDO", "DDQ", "DDS", "DDT", "DDU", "DMU", "DOM", "DPA", "DTK", "E01", "ELD", "FBB", "FRF", "G17", "GK1", "GK2", "GN2", "GNT", "GRN", "GS1", "H09", "HBG", "HOP", "HOU", "ICE", "IKO", "INV", "ISD", "ITP", "J14", "JMP", "JVC", "KHM", "KLD", "KLR", "KTK", "LEA", "LEB", "LRW", "M10", "M11", "M12", "M13", "M14", "M15", "M19", "M20", "M21", "MBS", "ME1", "ME3", "MH2", "MID", "MIR", "MMQ", "MRD", "NEO", "NPH", "ODY", "OLEP", "ONS", "ORI", "P02", "PAL00", "PAL01", "PAL02", "PAL03", "PAL04", "PAL05", "PAL06", "PAL99", "PALP", "PANA", "PARL", "PC2", "PCA", "PELP", "PF19", "PF20", "PGPX", "PGRU", "PHED", "PLIST", "PMPS", "PMPS06", "PMPS07", "PMPS08", "PMPS09", "PMPS10", "PMPS11", "POR", "PPP1", "PRM", "PRW2", "PRWK", "PS11", "PSAL", "PSS2", "PSS3", "PTC", "PTK", "PZ2", "RAV", "RIX", "RNA", "ROE", "RQS", "RTR", "S99", "SHM", "SLD", "SNC", "SOI", "SOM", "STX", "SUM", "TD0", "TD2", "THB", "THS", "TMP", "TPR", "TSP", "UGL", "UND", "UNF", "UNH", "USG", "UST", "VOW", "WAR", "WC00", "WC01", "WC02", "WC03", "WC04", "WC97", "WC98", "XANA", "XLN", "ZEN", "ZNR" }
                },
                new Card()
                {
                    Id = "507587",
                    Name = "Swamp",
                    ManaCost = null,
                    CMC = 0.0,
                    Colors = null,
                    ColorIdentity = new List<string> { "B" },
                    Type = "Basic Land — Swamp",
                    Supertypes = new List<string> { "Basic" },
                    Types = new List<string> { "Land" },
                    Subtypes = new List<string> { "Swamp" },
                    Rarity = "Common",
                    Set = "KHM",
                    SetName = "Kaldheim",
                    Text = "({T}: Add {B}.)",
                    Artist = "Piotr Dura",
                    Number = "396",
                    Power = null,
                    Toughness = null,
                    Layout = "normal",
                    ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507587&type=card",
                    Printings = new List<string> { "10E", "2ED", "2XM", "3ED", "40K", "4BB", "4ED", "5ED", "6ED", "7ED", "8ED", "9ED", "AFR", "AKH", "AKR", "ALA", "ANA", "ANB", "ARC", "ATH", "AVR", "BBD", "BFZ", "BRB", "BTD", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "CED", "CEI", "CHK", "CLB", "CM2", "CMA", "CMD", "CST", "DDC", "DDD", "DDE", "DDH", "DDJ", "DDK", "DDM", "DDN", "DDP", "DDQ", "DDR", "DKM", "DMU", "DOM", "DPA", "DTK", "DVD", "E01", "ELD", "FBB", "FRF", "G17", "GK1", "GK2", "GN2", "GNT", "GRN", "GVL", "H09", "HBG", "HOP", "HOU", "ICE", "IKO", "INV", "ISD", "ITP", "J14", "JMP", "KHM", "KLD", "KLR", "KTK", "LEA", "LEB", "LRW", "M10", "M11", "M12", "M13", "M14", "M15", "M19", "M20", "M21", "MBS", "MD1", "ME1", "ME3", "MH2", "MID", "MIR", "MMQ", "MRD", "NEO", "NPH", "ODY", "OLEP", "ONS", "ORI", "P02", "PAL00", "PAL01", "PAL03", "PAL04", "PAL05", "PAL06", "PAL99", "PALP", "PANA", "PARL", "PC2", "PCA", "PD3", "PELP", "PF19", "PF20", "PGPX", "PGRU", "PHUK", "PMPS", "PMPS06", "PMPS07", "PMPS08", "PMPS09", "PMPS10", "PMPS11", "POR", "PPP1", "PRM", "PRW2", "PRWK", "PS11", "PSAL", "PSS2", "PSS3", "PTC", "PTK", "RAV", "RIX", "RNA", "ROE", "RQS", "RTR", "S99", "SHM", "SLD", "SNC", "SOI", "SOM", "STX", "SUM", "TD0", "TD2", "THB", "THS", "TMP", "TPR", "TSP", "UGL", "UND", "UNF", "UNH", "USG", "UST", "VOW", "WAR", "WC01", "WC02", "WC03", "WC97", "WC98", "WC99", "XANA", "XLN", "ZEN", "ZNR" }
                },
                new Card()
                {
                    Id = "507588",
                    Name = "Mountain",
                    ManaCost = null,
                    CMC = 0.0,
                    Colors = null,
                    ColorIdentity = new List<string> { "R" },
                    Type = "Basic Land — Mountain",
                    Supertypes = new List<string> { "Basic" },
                    Types = new List<string> { "Land" },
                    Subtypes = new List<string> { "Mountain" },
                    Rarity = "Common",
                    Set = "KHM",
                    SetName = "Kaldheim",
                    Text = "({T}: Add {R}.)",
                    Artist = "Sam Burley",
                    Number = "397",
                    Power = null,
                    Toughness = null,
                    Layout = "normal",
                    ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507588&type=card",
                    Printings = new List<string> { "10E","2ED","2XM","3ED","40K","4BB","4ED","5ED","6ED","7ED","8ED","9ED","AFR","AKH","AKR","ALA","ANA","ANB","ARC","ARN","ATH","AVR","BBD","BFZ","BRB","BTD","C13","C14","C15","C16","C17","C18","C19","CED","CEI","CHK","CLB","CM2","CMA","CMD","CMR","CST","DD1","DD2","DDE","DDG","DDH","DDI","DDJ","DDK","DDL","DDN","DDP","DDS","DDT","DDU","DKM","DMU","DOM","DPA","DTK","E01","ELD","EVG","FBB","FRF","G17","GK1","GK2","GN2","GNT","GRN","GS1","H09","HBG","HOP","HOU","ICE","IKO","INV","ISD","ITP","J14","JMP","JVC","KHM","KLD","KLR","KTK","LEA","LEB","LRW","M10","M11","M12","M13","M14","M15","M19","M20","M21","MBS","ME1","ME3","MH2","MID","MIR","MMQ","MRD","NEO","NPH","ODY","OLEP","ONS","ORI","P02","PAL00","PAL01","PAL03","PAL04","PAL05","PAL06","PAL99","PALP","PANA","PARL","PC2","PCA","PD2","PELP","PF19","PF20","PGPX","PGRU","PHED","PLIST","PMPS","PMPS06","PMPS07","PMPS08","PMPS09","PMPS10","PMPS11","POR","PPP1","PRM","PRW2","PRWK","PS11","PSAL","PSS2","PSS3","PTC","PTK","PZ2","RAV","RIX","RNA","ROE","RQS","RTR","S99","SHM","SLD","SNC","SOI","SOM","STX","SUM","TD0","THB","THS","TMP","TPR","TSP","UGL","UND","UNF","UNH","USG","UST","VOW","WAR","WC00","WC01","WC02","WC03","WC97","WC98","WC99","XANA","XLN","ZEN","ZNR" }
                },
                new Card()
                {
                    Id = "507589",
                    Name = "Forest",
                    ManaCost = null,
                    CMC = 0.0,
                    Colors = null,
                    ColorIdentity = new List<string> { "G" },
                    Type = "Basic Land — Forest",
                    Supertypes = new List<string> { "Basic" },
                    Types = new List<string> { "Land" },
                    Subtypes = new List<string> { "Forest" },
                    Rarity = "Common",
                    Set = "KHM",
                    SetName = "Kaldheim",
                    Text = "({T}: Add {G}.)",
                    Artist = "Sam Burley",
                    Number = "398",
                    Power = null,
                    Toughness = null,
                    Layout = "normal",
                    ImageUrl = "http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=507589&type=card",
                    Printings = new List<string> { "10E", "2ED", "2XM", "3ED", "40K", "4BB", "4ED", "5ED", "6ED", "7ED", "8ED", "9ED", "AFR", "AKH", "AKR", "ALA", "ANA", "ANB", "ARC", "ATH", "AVR", "BBD", "BFZ", "BRB", "BTD", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "CED", "CEI", "CHK", "CLB", "CM2", "CMA", "CMD", "CMR", "CST", "DD1", "DDD", "DDE", "DDG", "DDH", "DDJ", "DDL", "DDM", "DDO", "DDP", "DDR", "DDS", "DDU", "DKM", "DMU", "DOM", "DPA", "DTK", "E01", "ELD", "EVG", "FBB", "FRF", "G17", "GK1", "GK2", "GN2", "GNT", "GRN", "GS1", "GVL", "H09", "HBG", "HOP", "HOU", "ICE", "IKO", "INV", "ISD", "ITP", "J14", "JMP", "KHM", "KLD", "KLR", "KTK", "LEA", "LEB", "LRW", "M10", "M11", "M12", "M13", "M14", "M15", "M19", "M20", "M21", "MBS", "ME1", "ME3", "MH2", "MID", "MIR", "MMQ", "MRD", "NEO", "NPH", "ODY", "OLEP", "ONS", "ORI", "P02", "PAL00", "PAL01", "PAL03", "PAL04", "PAL05", "PAL06", "PAL99", "PALP", "PANA", "PARL", "PC2", "PCA", "PELP", "PF19", "PF20", "PGPX", "PGRU", "PMPS", "PMPS06", "PMPS07", "PMPS08", "PMPS09", "PMPS10", "PMPS11", "POR", "PPP1", "PRM", "PRW2", "PRWK", "PS11", "PSAL", "PSS2", "PSS3", "PTC", "PTK", "PZ2", "RAV", "RIX", "RNA", "ROE", "RQS", "RTR", "S99", "SHM", "SLD", "SNC", "SOI", "SOM", "STX", "SUM", "TD0", "TD2", "THB", "THS", "TMP", "TPR", "TSP", "UGL", "UND", "UNF", "UNH", "USG", "UST", "VOW", "WAR", "WC00", "WC01", "WC02", "WC03", "WC04", "WC97", "WC98", "WC99", "XANA", "XLN", "ZEN", "ZNR" }
                });

            modelBuilder.Entity<CardCollection>()
                .HasKey(cc => new { cc.CardId, cc.UserId });

            modelBuilder.Entity<CardCollection>()
                .HasOne(cc => cc.Card)
                .WithMany(c => c.Users)
                .HasForeignKey(cc => cc.CardId);

            modelBuilder.Entity<CardCollection>()
                .HasOne(cc => cc.User)
                .WithMany(c => c.Cards)
                .HasForeignKey(cc => cc.UserId);
        }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            using (var scoped = serviceProvider.CreateScope())
            {
                UserManager<User> userManager = scoped.ServiceProvider.GetRequiredService<UserManager<User>>();
                RoleManager<IdentityRole> roleManager = scoped.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                string email = "admin@mtg.app";
                string pwd = "admin";
                string roleName = "Admin";

                // if role doesn't exist, create it
                if (await roleManager.FindByNameAsync(roleName) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }

                if (await userManager.FindByNameAsync(email) == null)
                {
                    User user = new User() { Email = email };
                    var result = await userManager.CreateAsync(user, pwd);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, roleName);
                    }
                }
            }
        }
    }
}
