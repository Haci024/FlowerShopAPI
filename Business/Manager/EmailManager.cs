using Business.Service;
using Data.Connection;
using DTO.DTOS.SubscriberDTO;
using MimeKit;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
namespace Business.Manager
{
    public class EmailManager : IEmailService
    {
        private readonly DbConnection _db;
        public EmailManager(DbConnection db)
        {
            _db = db;
        }

        public void SendEmailToNewSubscriber(NewSubscriberDTO dto)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress ConfirmAddressFrom = new MailboxAddress("Abunəlik", "odisseybanks024@gmail.com");
            MailboxAddress ConfirmAdressTo = new MailboxAddress("Fiorello", dto.Email);

            mimeMessage.From.Add(ConfirmAddressFrom);
            mimeMessage.To.Add(ConfirmAdressTo);
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"Abunəliyiniz uğurla tamamlandı.Ən son yeniliklərdən anında xəbəriniz olacaq ,hörmətlə Fiorello komandası:)";

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "Yeni Abunə";

            SmtpClient client = new SmtpClient();

            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("odisseybanks024@gmail.com", "voxryimidhytyjot");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }

        public void UnSubscribeMessageToCustomer(UnSubscribeDTO dto)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress ConfirmAddressFrom = new MailboxAddress("Abunəlik", "odisseybanks024@gmail.com");
            MailboxAddress ConfirmAdressTo = new MailboxAddress("Fiorello", dto.Email);

            mimeMessage.From.Add(ConfirmAddressFrom);
            mimeMessage.To.Add(ConfirmAdressTo);
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"Abunəliyiniz uğurla tamamlandı.Ən son yeniliklərdən anında xəbəriniz olacaq ,hörmətlə Fiorello komandası:)";

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "Yeni Abunə";

            SmtpClient client = new SmtpClient();

            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("odisseybanks024@gmail.com", "voxryimidhytyjot");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }
    }
}
