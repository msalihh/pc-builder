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
        public string Id { get; set; } // MongoDB ObjectId

        public string Username { get; set; } // Kullanıcı adı
        public string Password { get; set; } // Şifre
    }


}
