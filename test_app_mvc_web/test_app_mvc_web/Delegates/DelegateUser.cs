using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using test_app_mvc_web.Models;
using test_app_mvc_web.Models.UI;
namespace test_app_mvc_web.Delegates
{
    public class DelegateUser
    {
        private readonly IConfiguration _Configuration;
        public DelegateUser(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }

        public async Task<List<User>> GetUsers()
        {
            List<User> Response = new List<User>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(String.Format("{0}:{1}/User/GetUsers", _Configuration["ApiPersistencia:Url"], _Configuration["ApiPersistencia:Port"]));
            client.DefaultRequestHeaders.Accept.Clear();            
            string HttpResponse = await client.GetStringAsync(client.BaseAddress);
            if (!String.IsNullOrWhiteSpace(HttpResponse))
            {
                Response = JsonConvert.DeserializeObject<List<User>>(HttpResponse);
            }            
            return Response;        
        }
    }
}
