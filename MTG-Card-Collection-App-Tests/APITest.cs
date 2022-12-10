using MtgApiManager.Lib.Service;
using System.Numerics;

namespace MTG_Card_Collection_App_Tests
{
    public class APITest
    {
        

        [Fact]
        public async void FindCardById_Test()
        {
            //Arrange
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();
            ICardService service = serviceProvider.GetCardService();

            //Act
            var result = await service.FindAsync("409741");

            //Assert
            Assert.NotNull(result);
            Assert.Equal("Archangel Avacyn // Avacyn, the Purifier", result.Value.Name);
            Assert.Equal("SOI", result.Value.Set);
        }

        [Fact]
        public async void GetCardsByName_Test()
        {
            //Arrange
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();
            ICardService service = serviceProvider.GetCardService();

            //Act
            var result = await service
                .Where(c => c.Name, "Avacyn")
                .AllAsync();

            
            var ordered = result.Value.OrderBy(c => c.Name).DistinctBy(c => c.Name).ToList();

            //Assert
            Assert.NotNull(ordered);
            Assert.Equal(11, ordered.Count);
            Assert.Equal("Archangel Avacyn // Avacyn, the Purifier", ordered[0].Name);
            Assert.Equal("Avacyn, Angel of Hope", ordered[1].Name);
            Assert.Equal("Avacyn, Guardian Angel", ordered[2].Name);
            Assert.Equal("Avacyn's Collar", ordered[3].Name);
            Assert.Equal("Avacyn's Judgment", ordered[4].Name);
            Assert.Equal("Avacyn's Memorial", ordered[5].Name);
            Assert.Equal("Avacyn's Pilgrim", ordered[6].Name);
            Assert.Equal("Avacynian Missionaries // Lunarch Inquisitors", ordered[7].Name);
            Assert.Equal("Avacynian Priest", ordered[8].Name);
            Assert.Equal("Mask of Avacyn", ordered[9].Name);
            Assert.Equal("Scroll of Avacyn", ordered[10].Name);
        }

        [Fact]
        public async void GetCardsByExactName_Test()
        {
            //Arrange
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();
            ICardService service = serviceProvider.GetCardService();

            //Act
            var result = await service
                .Where(c => c.Name, value: "Avacyn, Angel of Hope")
                .AllAsync();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(10, result.Value.Count);
        }

        [Fact]
        public async void GetIdByNumAndSet_Test()
        {
            //Arrange
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();
            ICardService service = serviceProvider.GetCardService();

            //Act
            var result = await service
                .Where(c => c.Number, "335")
                .Where(c => c.Set, "2XM")
                .AllAsync();

            //Assert
            Assert.NotNull(result);
            Assert.Single(result.Value);
            Assert.Equal("491344", result.Value[0].MultiverseId);
        }
    }
}