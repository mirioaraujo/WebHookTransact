using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebHook_Transact.Controllers
{
    public class GenericJsonWebHookHandler : WebHookHandler
    {
        public GenericJsonWebHookHandler()
        {
            this.Receiver = GenericJsonWebHookReceiver.ReceiverName;
        }

        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            try
            {
                JObject data = context.GetDataOrDefault<JObject>();

                string action = context.Actions.FirstOrDefault();

            }
            catch (Exception)
            {

                throw;
            }

            return Task.FromResult(true);

        }
    }
}