using MailKit.Net.Smtp;
using MimeKit;

namespace ozuMail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("osu!", "osu@ppy.sh"));
            message.To.Add(new MailboxAddress("Atomoz", "sample.email@gmail.com"));
            message.Subject = "osu! account verification";

            message.Body = new TextPart("html")
            {
                Text =
                """
                <p>Hi Atomoz, <br>
                <br>
                An action performed on your account from Philippines requires verification. <br>
                <br>
                Your verification code is: ce62bc73 <br>
                You can enter the code with or without spaces. <br>
                <br>
                Alternatively, you can also visit this link below to finish verification: <br>
                <br>
                https://osu.ppy.sh/home/account/verify?key=b627fc44ef91874472c821fc7eab577fdd9d9d7d7dd539938febd50cd0d59900 <br>
                <br>
                If you did not request this, please REPLY IMMEDIATELY as your account may be in danger. <br>
                <br>
                -- <br>
                osu! | https://osu.ppy.sh
                </p>
                """
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                    client.Authenticate("93919a8286e246", "36d61ec08d9dcd");

                    client.Send(message);
                    Console.WriteLine("An email about account verification has been sent successfully through Mailtrap.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
}
