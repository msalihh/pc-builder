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
        public string Id { get; set; } // MongoDB ObjectId

        public string UserName { get; set; } // Kullanıcı adı
        public DateTime SavedAt { get; set; } // Kaydetme tarihi
        public List<string> Components { get; set; } // Sistem bileşenleri
    }
}
