using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace почта
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу почту");
            string address = Console.ReadLine();
            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();
            MailAddress from = new MailAddress(address, name);

            Console.WriteLine("Введите почту получателя");
            string address_poluchatelia = Console.ReadLine();
            MailMessage objectMail = new MailMessage(address, address_poluchatelia);

            Console.WriteLine("Введите тему сообения");
            string tema = Console.ReadLine();
            objectMail.Subject = tema;

            Console.WriteLine("Введите текст сообщения");
            string text = Console.ReadLine();
            objectMail.Body = text;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            Console.WriteLine("Ведите почту");
            string pochta = Console.ReadLine();

            Console.WriteLine("Введите пороль");
            string password = Console.ReadLine();

            smtp.Credentials = new NetworkCredential(pochta, password);
            smtp.EnableSsl = true;
            smtp.Send(objectMail);

            Console.Read();
        }
    }
}
