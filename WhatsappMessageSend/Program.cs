using System;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using System.Linq;

namespace WhatsappMessageSend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const string accountSid = "ACf1287f54879cf44faac833c8fc492f02";
            const string authToken = "5a195ea1598fc282778cf2d27c375560";
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"), 
                body: "Günaydınlaarr", //Gönderilmesini istediğiniz mesaj
                to: new Twilio.Types.PhoneNumber("whatsapp:/+90*** Formatında Mesaj gönderilecek Numara/"));  //mesaj gönderilmesini istediğiniz numara ile "+14155238886" numarasına whatsapp üzerinden "join specific-someone" mesajını göndermeniz gerekmektedir.
            Console.WriteLine(message.Sid);
        }
    }
}
