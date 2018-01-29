public class DummyWineInfoRepository : IWineInfoRepository
{
    public WineInfo GetWineInfo(int id)
    {
        return new WineInfo
        {
            Name = "DummyWine",
            Vintage = "2015",
            Country = "France"
        };
    }
}