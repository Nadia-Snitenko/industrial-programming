namespace MusicMarketTests;
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
    
}
