
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class VinmonopoletWineInfoRepository : IWineInfoRepository
{
    private Dictionary<string, WineInfo> _wineInfos;

    public VinmonopoletWineInfoRepository()
    {
        var lines = File.ReadAllLines("./produkter.csv").Select(line => line.Split(';'));
        var header = lines.Take(1).ToList();

        _wineInfos = lines.ToDictionary(l => l[1], l => new WineInfo
        {
            Name = l[2],
            Vintage = "2015",
            Country = "France"
        });
    }
    
    public WineInfo GetWineInfo(int id)
    {
        return _wineInfos[id.ToString()];
    }
}