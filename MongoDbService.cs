using MongoDB.Driver;
using newbuild;

using MongoDB.Driver;
using System.Threading.Tasks;

public class MongoDbService
{
    private readonly IMongoCollection<User> _usersCollection;
    private readonly IMongoCollection<SavedSystem> _systemsCollection;

    public MongoDbService(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);

        _usersCollection = database.GetCollection<User>("Users"); // Kullanıcı koleksiyonu
        _systemsCollection = database.GetCollection<SavedSystem>("SavedSystems"); // Sistem koleksiyonu
    }

    // Kullanıcı adı kontrolü
    public async Task<bool> IsUsernameTakenAsync(string username)
    {
        var existingUser = await _usersCollection.Find(u => u.Username == username).FirstOrDefaultAsync();
        return existingUser != null;
    }

    // Yeni kullanıcı kaydetme
    public async Task RegisterUserAsync(User user)
    {
        await _usersCollection.InsertOneAsync(user);
    }

    // Kullanıcı doğrulama
    public async Task<User> ValidateUserAsync(string username, string password)
    {
        return await _usersCollection
            .Find(u => u.Username == username && u.Password == password)
            .FirstOrDefaultAsync();
    }

    // Sistem kaydetme
    public async Task SaveSystemAsync(SavedSystem system)
    {
        await _systemsCollection.InsertOneAsync(system);
    }

    public async Task<List<SavedSystem>> GetSavedSystemsAsync(string username)
    {
        return await _systemsCollection
            .Find(system => system.UserName == username)
            .ToListAsync();
    }


}
