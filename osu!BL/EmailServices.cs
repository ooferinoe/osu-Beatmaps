using MailKit.Net.Smtp;
using MimeKit;
using ozuDL;
using ozuModel;

namespace osu_BL
{
    public class EmailServices
    {
        public bool emailNewSong(string title, string artist)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("osu!", "osu@ppy.sh"));
            message.To.Add(new MailboxAddress("Atomoz", "sample.email@gmail.com"));
            message.Subject = "Newly added beatmap";

            message.Body = new TextPart("html")
            {
                Text = 
                "<h1>Hi, Atomoz!</h1> <br>" +
                "<br>" +
                $"<p> A new beatmap named <strong>{title}</strong> with the artist(s) <strong>{artist}</strong> has been added to the collection! <br>" +
                "<br>" +
                "<p>We hope to receive more amazing beatmaps from you in the future!</p> <br>" +
                "<p>--</p>" +
                """
                <p>osu! | <a href="https://osu.ppy.sh">https://osu.ppy.sh</a></p>
                """
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                    client.Authenticate("93919a8286e246", "36d61ec08d9dcd");

                    client.Send(message);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
}
