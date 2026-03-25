using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceData.Core.cache
{
    public class CacheEntry // запись в кэше с временем истечения
    {
        public object Value { get; set; } // сохраненное значнеие
        public DateTime ExpiresAt { get; set; } // время истечения записи
        public DateTime CreatedAt { get; set; }
        public int AccessCount { get; set; } // количество обращений к этой записи
        public DateTime LastAccessedAt { get; set; } // время последнего доступа к этой записи
        public long SizeInBytes { get; set; }

        public CacheEntry(object value, DateTime expiresAt)
        {
            Value = value;
            ExpiresAt = expiresAt;
            CreatedAt = DateTime.Now;
            LastAccessedAt = DateTime.Now;
            AccessCount = 0;
            SizeInBytes = EstimateSize(value);
        }

        public bool IsExpired => DateTime.Now > ExpiresAt; // истек ли срок записи

        public void RecordAccess() // обновление информации о доступе
        {
            AccessCount++;
            LastAccessedAt = DateTime.Now;
        }
        private long EstimateSize(object obj)
        {
            if (obj == null) return 0;

            var json = System.Text.Json.JsonSerializer.Serialize(obj);
            return System.Text.Encoding.UTF8.GetByteCount(json);
        }

    }
}
