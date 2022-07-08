using System.IO;
using System.Text.Json;

namespace eStore.Services

{
    public record Account
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class ReadJson
    {
        public static Account GetAccount()
        {
            string fileName = "appsettings.json";
            string json = File.ReadAllText(fileName);

            var Account = JsonSerializer.Deserialize<Account>(json);
            return Account;
        }
    }
}
