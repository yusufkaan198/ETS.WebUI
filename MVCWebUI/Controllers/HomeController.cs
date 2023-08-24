using Microsoft.AspNetCore.Mvc;
using MVCWebUI.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5061/api");
            var response = await client.GetAsync($"{client.BaseAddress}/Structures");
            var responseRead = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseComing<StructureItem>>(responseRead);

            return View(result.data);
        }
    }
}
