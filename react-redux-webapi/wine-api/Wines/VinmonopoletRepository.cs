using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WineApi.Wines
{
    public class VinmonopoletRepository
    {
        private Dictionary<string, WineInfo> _wineInfos;

        public VinmonopoletRepository()
        {
            var lines = File.ReadAllLines("produkter.csv").Select(line => line.Split(';'));
            var header = lines.Take(1).ToList();

            _wineInfos = lines.ToDictionary(l => l[1], l => new WineInfo
            {
                Name = l[2],
                Vintage = l[23],
                Country = l[20]
            });
        }

        public WineInfo GetWineInfo(int id)
        {
            _wineInfos.TryGetValue(id.ToString(), out var wineInfo);
            return wineInfo;
        }
    }
}