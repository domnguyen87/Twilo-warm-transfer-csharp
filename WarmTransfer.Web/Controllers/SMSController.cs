using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using Twilio.TwiML;
using Twilio.AspNet.Mvc;

namespace WarmTransfer.Web.Controllers
{
    public class SMSController : TwilioController
    {
        public ActionResult SendSms()
        {
            const string accountSid = "AC69fd168a9f5492be7fda53c8b5749f35";
            const string authToken = "2647d1c3f063791684a6255825261788";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
            body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
            from: new Twilio.Types.PhoneNumber("+17149425069"),
            to: new Twilio.Types.PhoneNumber("+17143832573")
            );

            return Content(message.Sid);
        }

        
    }
}