using System;
using System.Net;
using System.Net.Mail;


namespace lyas_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес вашей почты: ");
            string email_from = Console.ReadLine();

            Console.WriteLine("Введите пароль: ");
            string email_password = Console.ReadLine();

            Console.WriteLine("Введите ваше имя: ");
            string email_name = Console.ReadLine();

            Console.WriteLine("Введите адрес почты получателя: ");
            string email_to = Console.ReadLine();

            Console.WriteLine("Введите тему письма: ");
            string object_subject = Console.ReadLine();

            Console.WriteLine("Введите содержимое письма: ");
            string object_body = Console.ReadLine();

            MailAddress from = new MailAddress(email_from, email_name);
            MailAddress to = new MailAddress(email_to);
            MailMessage object_mail = new MailMessage(email_from, email_to);
            object_mail.Subject = object_subject;
            object_mail.Body = object_body;
            object_mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(email_from, email_password);
            smtp.EnableSsl = true;
            smtp.Send(object_mail);
            Console.Read();


        }
    }
}
