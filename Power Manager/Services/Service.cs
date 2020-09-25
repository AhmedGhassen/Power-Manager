using System.Threading.Tasks;
using Newtonsoft.Json;
using PowerManager.Constants;
using PowerManager.Controllers;
using PowerManager.Models;

namespace PowerManager.Services
{
    class Service
    {
        public async static Task<Product> getLastVersionService()
        {
            try
            {
                var content = (await HttpClientController.HttpClientGetAsync(ServiceStringPath.getLastVersion)).Content;
                return JsonConvert.DeserializeObject<Product>(await content.ReadAsStringAsync());
            } catch
            {
                return null;
            }
        }

        public async static Task<bool> sendFeedback(FeedBack feedBack)
        {
            try
            {
                var response = await HttpClientController.HttpClientPostAsync(ServiceStringPath.sendFeedback, feedBack);
                if (response !=null)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
