using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbuild
{
    public class SavedSystem
    {
        [BsonId] // MongoDB'nin _id alanını eşleştirir
        [BsonRepresentation(BsonType.ObjectId)] // _id alanını string olarak temsil eder
        public required string Id { get; set; } // MongoDB ObjectId

        public required string UserName { get; set; } // Kullanıcı adı
        public DateTime SavedDate { get; set; } // Kaydetme tarihi
        public required List<string> Components { get; set; } // Sistem bileşenleri
        public decimal TotalPrice { get; set; }
        public string? Description { get; set; }
    }
}
