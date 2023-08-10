using Newtonsoft.Json.Linq;
using Repository.Contracts;
using System.Net.Http.Headers;

namespace Repository.Concrete
{
    public class FontAwesomeRepository : IFontAwesomeRepository
    {
        private const string FontAwesomeGitHubUrl = "https://github.com/FortAwesome/Font-Awesome/tree/master/svgs/solid";
        public async Task<List<string>> GetAllFreeIcons()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");  // User-Agent eklemek GitHub API için gereklidir.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // Accept header eklemek GitHub API için gereklidir.
                HttpResponseMessage response = await client.GetAsync(FontAwesomeGitHubUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    var jsonObject = JObject.Parse(jsonResult);
                    var items = jsonObject["payload"]["tree"]["items"];
                    var icons = new List<string>();
                    foreach (var item in items)
                    {
                        string itemName = item["name"].ToString();
                        string className = GetIconClassFromSvgLink(itemName);
                        icons.Add(className);
                    }
                    return icons;
                }
                else
                {
                    throw new Exception("İstek başarısız oldu. Hata kodu: " + response.StatusCode);
                }
            }
        }
        public string GetIconClassFromSvgLink(string svgLink)
        {
            var fileName = Path.GetFileNameWithoutExtension(svgLink);
            return "fa-solid fa-" + fileName;
        }
    }
}
