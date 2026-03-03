using BookACar.Dto.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BookACar.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto) 
        {
            var client = _httpClientFactory.CreateClient();
            createContactDto.SendDate = DateTime.Now;
            var jsondata = JsonConvert.SerializeObject(createContactDto);
            //metin türünde gönderilecek veriyi json formatına dönüştürmek için JsonConvert.SerializeObject() kullanılır.
            StringContent content = new StringContent(jsondata,Encoding.UTF8, "application/json");
            //UTF8 türkçe karakterlerin doğru şekilde gönderilmesini sağlar. "application/json" ise gönderilen verinin türünü belirtir.
            var responseMessage = await client.PostAsync("https://localhost:7273/api/Contacts", content);
            //listelerken getasync kullanılırken, veri eklerken postasync kullanılır.
            //content parametresi ise gönderilecek veriyi içerir.
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
