using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace newbuild
{
    public class ComponentManager
    {
        private readonly IDriver _driver;

        public ComponentManager(IDriver driver)
        {
            _driver = driver;
        }

        private async Task<List<T>> FetchDataAsync<T>(string query, Func<IRecord, T> mapFunction, object parameters = null)
        {
            var resultList = new List<T>();

            try
            {
                using var session = _driver.AsyncSession();
                var result = await session.RunAsync(query, parameters);

                await foreach (var record in result)
                {
                    resultList.Add(mapFunction(record));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while fetching data: {ex.Message}", ex);
            }

            return resultList;
        }

        // Load all CPUs
        public Task<List<CpuInfo>> GetCpuDataAsync()
        {
            const string query = @"
                MATCH (cpu:CPU)
                RETURN DISTINCT 
                    cpu.generatedID AS ID,
                    cpu.brand AS Brand,
                    cpu.name AS Name,
                    cpu.cores AS Cores,
                    cpu.tdp AS TDP,
                    cpu.socket AS Socket,
                    cpu.ram_support AS RamSupport,
                    cpu.max_ram AS MaxRam,
                    cpu.rank AS Rank,
                    cpu.price AS Price";

            return FetchDataAsync(query, record => new CpuInfo
            {
                ID = record["ID"]?.As<int>() ?? 0,
                Brand = record["Brand"]?.As<string>(),
                Name = record["Name"]?.As<string>(),
                Cores = record["Cores"]?.As<int>() ?? 0,
                TDP = record["TDP"]?.As<int>() ?? 0,
                Socket = record["Socket"]?.As<string>(),
                RamSupport = record["RamSupport"]?.As<string>(),
                MaxRam = record["MaxRam"]?.As<int>() ?? 0,
                Rank = record["Rank"]?.As<int>() ?? 0,
                Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2)
            });
        }

        // Load all Motherboards
        public Task<List<MotherboardInfo>> GetAllMotherboardDataAsync()
        {
            const string query = @"
                MATCH (mb:Motherboard)
                RETURN DISTINCT
                    mb.brand AS Brand,
                    mb.name AS Name,
                    mb.max_memory AS MaxMemory,
                    mb.form_factor AS FormFactor,
                    mb.color AS Color,
                    mb.socket AS Socket,
                    mb.ram_type AS RamType,
                    mb.price AS Price";

            return FetchDataAsync(query, record => new MotherboardInfo
            {
                Brand = record["Brand"]?.As<string>(),
                Name = record["Name"]?.As<string>(),
                Memory = record["MaxMemory"]?.As<int>() ?? 0,
                FormFactor = record["FormFactor"]?.As<string>(),
                Color = record["Color"]?.As<string>(),
                Socket = record["Socket"]?.As<string>(),
                RamType = record["RamType"]?.As<string>(),
                Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2)
            });
        }

        // Load all RAMs
        public Task<List<RamInfo>> GetAllRamDataAsync()
        {
            const string query = @"
                MATCH (ram:RAM)
                RETURN DISTINCT
                    ram.brand AS Brand,
                    ram.name AS Name,
                    ram.max_capacity AS MaxCapacity,
                    ram.ram_type AS RamType,
                    ram.speed AS Speed,
                    ram.price AS Price";

            return FetchDataAsync(query, record => new RamInfo
            {
                Brand = record["Brand"]?.As<string>(),
                Name = record["Name"]?.As<string>(),
                MaxCapacity = record["MaxCapacity"]?.As<int>() ?? 0,
                RamType = record["RamType"]?.As<string>(),
                Speed = record["Speed"]?.As<int>() ?? 0,
                Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2)
            });
        }

        // Load all GPUs
        public Task<List<GpuInfo>> GetAllGpuDataAsync()
        {
            const string query = @"
                MATCH (gpu:GPU)
                RETURN DISTINCT
                    gpu.brand AS Brand,
                    gpu.name AS Name,
                    gpu.memory AS Memory,
                    gpu.base_clock AS BaseClock,
                    gpu.boost_clock AS BoostClock,
                    gpu.tdp AS Tdp,
                    gpu.price AS Price";

            return FetchDataAsync(query, record => new GpuInfo
            {
                Brand = record["Brand"]?.As<string>(),
                Name = record["Name"]?.As<string>(),
                Memory = record["Memory"]?.As<string>(),
                BaseClock = record["BaseClock"]?.As<string>(),
                BoostClock = record["BoostClock"]?.As<string>(),
                Tdp = record["Tdp"]?.As<string>(),
                Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2)
            });
        }

        // Load all SSDs
        public Task<List<SsdInfo>> GetAllSsdDataAsync()
        {
            const string query = @"
                MATCH (ssd:SSD)
                RETURN DISTINCT
                    ssd.brand AS Brand,
                    ssd.name AS Name,
                    ssd.interface AS Interface,
                    ssd.capacity AS Capacity,
                    ssd.read_speed AS ReadSpeed,
                    ssd.write_speed AS WriteSpeed,
                    ssd.price AS Price";

            return FetchDataAsync(query, record => new SsdInfo
            {
                Brand = record["Brand"]?.As<string>(),
                Name = record["Name"]?.As<string>(),
                Interface = record["Interface"]?.As<string>(),
                Capacity = record["Capacity"]?.As<string>(),
                ReadSpeed = record["ReadSpeed"]?.As<string>(),
                WriteSpeed = record["WriteSpeed"]?.As<string>(),
                Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2)
            });
        }

        // Filter Motherboards by CPU
        public Task<List<MotherboardInfo>> FilterMotherboardsByCpuAsync(string cpuSocket)
        {
            const string query = @"
                MATCH (cpu:CPU {socket: $cpuSocket})-[:SUPPORTS_CPU_MOTHERBOARD]->(mb:Motherboard)
                RETURN DISTINCT
                    mb.brand AS Brand,
                    mb.name AS Name,
                    mb.max_memory AS MaxMemory,
                    mb.form_factor AS FormFactor,
                    mb.color AS Color,
                    mb.socket AS Socket,
                    mb.ram_type AS RamType,
                    mb.pcie_version AS PcieVersion,
                    mb.price AS Price";

            return FetchDataAsync(query, record => new MotherboardInfo
            {
                Brand = record["Brand"]?.As<string>(),
                Name = record["Name"]?.As<string>(),
                Memory = record["MaxMemory"]?.As<int>() ?? 0,
                FormFactor = record["FormFactor"]?.As<string>(),
                Color = record["Color"]?.As<string>(),
                Socket = record["Socket"]?.As<string>(),
                RamType = record["RamType"]?.As<string>(), 
                Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2)
            }, new { cpuSocket });
        }

        // Filter RAMs by CPU and Motherboard compatibility
        public Task<List<RamInfo>> FilterRamsByCpuAndMotherboardAsync(string cpuSocket, string motherboardRamType)
        {
            const string query = @"
                MATCH (cpu:CPU {socket: $cpuSocket})-[:SUPPORTS_CPU_RAM]->(ram:RAM),
                      (mb:Motherboard {ram_type: $motherboardRamType})-[:SUPPORTS_MOTHERBOARD_RAM]->(ram)
                RETURN DISTINCT
                    ram.brand AS Brand,
                    ram.name AS Name,
                    ram.max_capacity AS MaxCapacity,
                    ram.ram_type AS RamType,
                    ram.speed AS Speed,
                    ram.price AS Price";

            return FetchDataAsync(query, record => new RamInfo
            {
                Brand = record["Brand"]?.As<string>(),
                Name = record["Name"]?.As<string>(),
                MaxCapacity = record["MaxCapacity"]?.As<int>() ?? 0,
                RamType = record["RamType"]?.As<string>(),
                Speed = record["Speed"]?.As<int>() ?? 0,
                Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2)
            }, new { cpuSocket, motherboardRamType });
        }
        public async Task<List<GpuInfo>> FilterGpusByCpuMotherboardAndRamAsync(string cpuSocket, string motherboardRamType, string ramType)
        {
            // Neo4j sorgusu: CPU, Anakart ve RAM'e uygun GPU'ları filtreler
            const string query = @"
MATCH 
    (cpu:CPU {socket: $cpuSocket})-[:SUPPORTS_CPU_GPU]->(gpu:GPU)
RETURN DISTINCT
    gpu.brand AS Brand,
    gpu.name AS Name,
    gpu.memory AS Memory,
    gpu.base_clock AS BaseClock,
    gpu.boost_clock AS BoostClock,
    gpu.tdp AS Tdp,
    gpu.price AS Price";

            try
            {
                // FetchDataAsync çağrısı, verileri getirir ve GpuInfo nesnesine dönüştürür
                return await FetchDataAsync(query, record => new GpuInfo
                {
                    Brand = record["Brand"]?.As<string>(),
                    Name = record["Name"]?.As<string>(),
                    Memory = record["Memory"]?.As<string>(),
                    BaseClock = record["BaseClock"]?.As<string>(),
                    BoostClock = record["BoostClock"]?.As<string>(),
                    Tdp = record["Tdp"]?.As<string>(),
                    Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2)
                }, new
                {
                    cpuSocket,
                    motherboardRamType,
                    ramType
                });
            }
            catch (Exception ex)
            {
                // Detaylı hata mesajı
                throw new Exception($"Error while fetching GPUs for the selected CPU, Motherboard, and RAM: {ex.Message}", ex);
            }
        }

        // Filter SSDs by all selected components
        public Task<List<SsdInfo>> FilterSsdsByAllComponentsAsync(string cpuSocket, string motherboardRamType, string ramType)
        {
            const string query = @"
                MATCH (cpu:CPU {socket: $cpuSocket})-[:SUPPORTS_CPU_MOTHERBOARD]->(mb:Motherboard {ram_type: $motherboardRamType}),
                      (mb)-[:SUPPORTS_MOTHERBOARD_RAM]->(ram:RAM {ram_type: $ramType}),
                      (mb)-[:SUPPORTS_SSD_MOTHERBOARD]->(ssd:SSD)
                RETURN DISTINCT
                    ssd.brand AS Brand,
                    ssd.name AS Name,
                    ssd.interface AS Interface,
                    ssd.capacity AS Capacity,
                    ssd.read_speed AS ReadSpeed,
                    ssd.write_speed AS WriteSpeed,
                    ssd.price AS Price";

            return FetchDataAsync(query, record => new SsdInfo
            {
                Brand = record["Brand"]?.As<string>(),
                Name = record["Name"]?.As<string>(),
                Interface = record["Interface"]?.As<string>(),
                Capacity = record["Capacity"]?.As<string>(),
                ReadSpeed = record["ReadSpeed"]?.As<string>(),
                WriteSpeed = record["WriteSpeed"]?.As<string>(),
                Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2)
            }, new { cpuSocket, motherboardRamType, ramType });
        }



        public Task<List<MonitorInfo>> GetMonitorDataAsync()
        {
            const string query = @"
        MATCH (monitor:Monitor)
        RETURN DISTINCT 
            monitor.brand AS Brand,
            monitor.name AS Name,
            monitor.price AS Price,
            monitor.screen_size AS ScreenSize,
            monitor.response_time AS ResponseTime,
            monitor.panel_type AS PanelType";

            return FetchDataAsync(query, record => new MonitorInfo
            {
                Brand = record["Brand"]?.As<string>(),
                Name = record["Name"]?.As<string>(),
                Price = Math.Round(record["Price"]?.As<double>() ?? 0.0, 2),
                ScreenSize = record["ScreenSize"]?.As<int>() ?? 0,
                ResponseTime = Math.Round(record["ResponseTime"]?.As<double>() ?? 0.0, 2),
                PanelType = record["PanelType"]?.As<string>()
            });
        }

    }
}

