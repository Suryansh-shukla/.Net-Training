using System.Data;
using Microsoft.Data.SqlClient;
namespace FlightSearchEngine.Data
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;
        public DatabaseHelper(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }
        public async Task<List<string>> GetSourcesAsync()
        {
            var sources = new List<string>();
            using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("sp_GetSources", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        sources.Add(reader["[Source]"].ToString() ?? string.Empty);
                    }
                }
            }
            return sources;
        }
    }
}
