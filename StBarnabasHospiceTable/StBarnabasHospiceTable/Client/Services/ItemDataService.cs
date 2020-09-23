using StBarnabasHospiceTable.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StBarnabasHospiceTable.Client.Services
{
    public class ItemDataService : IItemDataService
    {
        private readonly HttpClient _httpClient;

        public ItemDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Item> AddItem(Item item)
        {
            var ItemJson =
                new StringContent(JsonSerializer.Serialize(item), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsJsonAsync($"api/item", ItemJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Item>(await response.Content.ReadAsStreamAsync());
            }
            return null;
        }
        public async Task<IEnumerable<Item>> GetAllItems()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Item>>
                (await _httpClient.GetStreamAsync($"api/Item"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task<Item> GetItemById(int itemId)
        {
            return await JsonSerializer.DeserializeAsync<Item>
                (await _httpClient.GetStreamAsync($"api/Item/{itemId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
