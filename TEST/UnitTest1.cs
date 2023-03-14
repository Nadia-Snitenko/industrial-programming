namespace TEST;

using System.Linq;



public class MusicMarketTest : IClassFixture<MusicMarketFixture>
{
    private readonly MusicMarketFixture _fixture;
    public MusicMarketTest(MusicMarketFixture fixture)
    {
        _fixture = fixture;
    }

    /// <summary>
    /// ������ ������: ������� ���������� � ���� ��������� ��������� ����������.
    /// </summary>
    [Fact]
    public void VinylRecordsInfoTest()
    {
        //var fixtureProduct = _fixture.FixtureProducts.ToList();
        var request = (from product in _fixture.FixtureProducts
                       where (product.TypeOfCarrier == "vinyl record") && (product.Status == "sold")
                       select product).Count();
        Assert.Equal(2, request);
    }

    /// <summary>
    /// ������ ������: ������� ���������� � ���� ������� ���������� ��������, ����������� �� ����.
    /// </summary>
    [Fact]
    public void ProductBySeller()
    {
        var request = (from product in _fixture.FixtureProducts
                       where (product.Seller.ShopName == "StopRobot")
                       orderby product.Price
                       select product).Count();
        Assert.Equal(3, request);
    }

    /// <summary>
    /// ������ ������: ������� ���������� � ����������� �������� ��������       //// ????????????????????????????
    /// �������� ���������� �����������, ��������� ������������� � �������� 
    /// ������� �� ���� "�������".
    /// </summary>
    //[Fact]
    //public void F()
    //{
    //    var firstCompDate = new DateOnly(2023, 3, 2);
    //    var secondCompDate = new DateOnly(2023, 4, 2);
    //    var request = (from flight in _fixture.FixtureFlights
    //                   where (flight.AirplaneType == "Cargo") && (flight.DepartureDate.CompareTo(firstCompDate) > 0) &&
    //                   (flight.DepartureDate.CompareTo(secondCompDate) < 0)
    //                   select flight).Count();
    //    Assert.Equal(2, request);
    //}

    /// <summary>
    /// �������� ������: ������� ���������� � ���������� ��������� �� �������� ��������
    /// ������� ������� ���� �������������.
    /// </summary>
    //[Fact]
    //public void Aidio()
    //{
    //    // �����,
    //    var request0 = (from flight in _fixture.FixtureFlights
    //                    where flight != null
    //                    select flight.Tickets.Count).Take(5).Count();
    //    // �������,
    //    var request1 = (from flight in _fixture.FixtureFlights
    //                    where flight != null
    //                    select flight.Tickets.Count).Take(5).Count();
    //    // ��������� ���������.
    //    var request2 = (from product in _fixture.FixtureProducts
    //                    where (product.TypeOfCarrier == "vinyl record") && (product.Status == "sold")
    //                    select product).Count();

    //    Assert.Equal(5, request0);
    //    Assert.Equal(19, request1);
    //    Assert.Equal(9.5, request2);
    //}

    /// <summary>
    /// ����� ������: ������� ���������� � ��� 5 ����������� 
    /// �� ������� ��������� ����������� ������� � ������ ��������� ��������.
    /// </summary>
    //[Fact]
    //public void TopFiveTest()
    //{
    //    var fixtureCard = _fixture.FixtureCard.ToList();
    //    var date = new DateOnly(2023, 3, 1);
    //    var numOfReaders = (from card in fixtureCard
    //                        from reader in card.IdReader
    //                        where card.DateOfReturn < date
    //                        group card by reader.Id into g
    //                        select new
    //                        {
    //                            readers = g.Key,
    //                            count = g.Count()
    //                        }).ToList();
    //    var request = (from reader in numOfReaders
    //                   orderby reader.count descending
    //                   select reader).Take(5).ToList();
    //    var first = request.First();

    //    Assert.Equal(1, first.readers);
    //    Assert.Equal(5, request.Count);
    //}

    /// <summary>
    /// ������ ������: ������� ���������� � ���������� ��������� ������� ������ ��������� 
    /// �� ��������� ��� ������.
    /// </summary>
    //[Fact]
    //public void MaxAndAvgBaggageAmountFromSpecifiedSource()
    //{
    //    var tickets = (from flight in _fixture.FixtureFlights
    //                   from ticket in flight.Tickets
    //                   where flight.Source == "Moscow"
    //                   select ticket.BaggageWeight).ToList();
    //    var max = tickets.Max();
    //    var avg = tickets.Average();

    //    Assert.Equal(19, max);
    //    Assert.Equal(9.5, avg);
    //}
}