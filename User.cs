using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbuild
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class User
    {
        [BsonId] // MongoDB'nin _id alanını eşleştirir
        [BsonRepresentation(BsonType.ObjectId)] // _id alanını string olarak temsil eder
        public required string Id { get; set; } // MongoDB ObjectId

        public required string Username { get; set; } // Kullanıcı adı
        public required string Password { get; set; } // Şifre
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }


}
