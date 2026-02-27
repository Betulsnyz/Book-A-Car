using BookACar.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookACar.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial:ViewComponent
    {
        private readonly  IHttpClientFactory _httpClientFactory;

        public _AboutUsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7273/api/Abouts");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);//jsondata deserialize edilerek resultaboutdto türüne dönüştürülüyor.
                //api türünde gelen veriyi normal text türünde view'e göndermek için json verisini string olarak okuyup, sonra da deserialize ederek view model türüne dönüştürüyoruz.
                //ekleme güncelleme yapmak istediğimizde serialize ederek json formatına dönüştürüp api'ye göndereceğiz.
                return View(result);
            }
            return View();
        }
    }
}
