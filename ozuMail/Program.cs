using MailKit.Net.Smtp;
using MimeKit;

namespace ozuMail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Peppy", "osu.ppy@gmail.com"));
            message.To.Add(new MailboxAddress("Atomoz", "sample.email@gmail.com"));
            message.Subject = "Your Beatmap has been Ranked";

            message.Body = new TextPart("html")
            {
                Text = "<h1>Congratulations, Atomoz!</h1>" +
                "<p>The beatmap that you have submitted on March 12, 2024 has been recently ranked!</p>" +
                "<p></p>" +
                "<p>We hope to receive more amazing beatmaps from you in the future!</p>" +
                "<p></p>" +
                "<p>Sincerely, <strong>Peppy</strong></p>"
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                    client.Authenticate("93919a8286e246", "36d61ec08d9dcd");

                    client.Send(message);
                    Console.WriteLine("Email sent successfully through Mailtrap.");
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
