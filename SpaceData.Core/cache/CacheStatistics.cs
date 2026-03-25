using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceData.Core.cache
{
    public class CacheStatistics
    {
        public int Hits { get; set; } // количество попаданий в кэш
        public int Misses { get; set; } // количество промахов (когда данных нет в кэше)
        public int TotalRequests => Hits + Misses;
        public double HitRate => TotalRequests > 0 ? (double)Hits / TotalRequests * 100 : 0;
        public int EntriesCount { get; set; }
        public long TotalSizeInBytes { get; set; }
        public double TotalSizeInKB => TotalSizeInBytes / 1024.0;
        public int ExpiredEntriesRemoved { get; set; } // количество удаленных истекших записей
        public double AverageCacheAccessTime { get; set; } // среднее время доступа к кэшу в миллисекундах
        public double AverageSourceAccessTime { get; set; } // среднее время доступа к источнику данных в миллисекундах
        public double TimeSaved => Hits * (AverageSourceAccessTime - AverageCacheAccessTime); // общее время, сэкономленное благодаря кэшу
        public override string ToString()
        {
            return $"Hits: {Hits}, Misses: {Misses}, Hit Rate: {HitRate:F1}%, Entries: {EntriesCount}";
        }
    }
}
