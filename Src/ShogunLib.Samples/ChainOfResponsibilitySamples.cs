// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Linq;
using NUnit.Framework;
using ShogunLib.Patterns.ChainOfResponsibility;

namespace ShogunLib.Samples
{
    // Current samples presents several ways on how to solve same task 
    // using framework 'Chain of Responsibility design pattern'. 
    //
    // The task is to send notification (by email or post or sms) depending
    // on a country.
    [TestFixture]
    public sealed class ChainOfResponsibilitySamples
    {
        private readonly string[] _mailCoutries = { "Ukraine", "UK" };
        private readonly string[] _postCountries = { "Mexico", "USA" };

        [Test]
        // Link approach without response
        public void Sample_1()
        {
            var notificator = new Notificator();

            // Create links
            var mailNotificator = new MailLink(_mailCoutries, notificator);
            var postNotificator = new PostLink(_postCountries, notificator);
            var smsNotificator =
                new VoidLink<string, string>
                    (
                    (country, name) => true, // Last link will handle all unhandled requests
                    (country, name) => notificator.SendSms(country, name)
                    );

            // Configure chain
            var chain =
                Chain
                    .CreateVoid<string, string>()
                    .Add(mailNotificator)
                    .Add(postNotificator)
                    .Add(smsNotificator)
                    .Build();

            // Execute requests
            chain.Execute("USA", "John Doe");
            chain.Execute("Ukraine", "Ivan Mazepa");
            chain.Execute("Russia", "Vasya Pupkin");
        }
        // Sample_1 output
        // [POST] to 'John Doe'. Country USA
        // [MAIL] to 'Ivan Mazepa'. Country Ukraine
        // [SMS] to 'Vasya Pupkin'. Country Russia

        [Test]
        // Can&Do approach without response
        public void Sample_2()
        {
            var notificator = new Notificator();

            // Create all CANs
            var canSendMail = new CanSend(_mailCoutries);
            var canSendPost = new CanSend(_postCountries);
            var canSendSms = new Can<string, string>((coutry, name) => true);  // Last link will handle all unhandled requests

            // Create all DOs
            var mailDo = new MailDo(notificator);
            var postDo = new PostDo(notificator);
            var smsDo = new VoidDo<string, string>((country, name) => notificator.SendSms(country, name));

            var chain =
                Chain
                    .CreateVoid<string, string>()
                    .Add(canSendMail, mailDo)
                    .Add(canSendPost, postDo)
                    .Add(canSendSms, smsDo)
                    .Build();

            chain.Execute("USA", "John Doe");
            chain.Execute("Ukraine", "Ivan Mazepa");
            chain.Execute("Russia", "Vasya Pupkin");
        }
        // Sample_2 output
        // [POST] to 'John Doe'. Country USA
        // [MAIL] to 'Ivan Mazepa'. Country Ukraine
        // [SMS] to 'Vasya Pupkin'. Country Russia

        [Test]
        // Delegates approach without response
        public void Sample_3()
        {
            var notificator = new Notificator();

            // Configure chain
            var chain =
                Chain
                    .CreateVoid<string, string>()
                    .Add
                    (
                        (country, name) => _mailCoutries.Contains(country),
                        (country, name) => notificator.SendMail(country, name)
                    )
                    .Add
                    (
                        (country, name) => _postCountries.Contains(country),
                        (country, name) => notificator.SendPost(country, name)
                    )
                    .Add
                    (
                        (country, name) => true, // Last link will handle all unhandled requests
                        (country, name) => notificator.SendSms(country, name)
                    )
                    .Build();

            chain.Execute("USA", "John Doe");
            chain.Execute("Ukraine", "Ivan Mazepa");
            chain.Execute("Russia", "Vasya Pupkin");
        }
        // Sample_3 output
        // [POST] to 'John Doe'. Country USA
        // [MAIL] to 'Ivan Mazepa'. Country Ukraine
        // [SMS] to 'Vasya Pupkin'. Country Russia

        [Test]
        // Mixed (Link, Can&Do, Delegate) approach without response
        public void Sample_4()
        {
            var notificator = new Notificator();

            // Link
            var mailNotificator = new MailLink(_mailCoutries, notificator);

            // Can&Do
            var canSendPost = new CanSend(_postCountries);
            var postDo = new PostDo(notificator);

            var chain =
                Chain
                    .CreateVoid<string, string>()
                    .Add(mailNotificator)
                    .Add(canSendPost, postDo)
                    .Add
                    (
                        (country, name) => true, // Last link will handle all unhandled requests
                        (country, name) => notificator.SendSms(country, name)
                    )
                    .Build();

            chain.Execute("USA", "John Doe");
            chain.Execute("Ukraine", "Ivan Mazepa");
            chain.Execute("Russia", "Vasya Pupkin");
        }
        // Sample_4 output
        // [POST] to 'John Doe'. Country USA
        // [MAIL] to 'Ivan Mazepa'. Country Ukraine
        // [SMS] to 'Vasya Pupkin'. Country Russia

        [Test]
        // Mixed (Link, Can&Do, Delegate) approach with response
        public void Sample_5()
        {
            var notificator = new Notificator();

            // Link
            var mailNotificator = new MailLinkWithResponse(_mailCoutries, notificator);

            // Can&Do
            var canSendPost = new CanSend(_postCountries);
            var postDo = new PostDoWithResponse(notificator);

            var chain =
                Chain
                    .CreateResult<string, string, string>()
                    .Add(mailNotificator)
                    .Add(canSendPost, postDo)
                    .Add
                    (
                        (country, name) => true, // Last link will handle all unhandled requests
                        (country, name) => notificator.SendSmsWithResponce(country, name)
                    )
                    .Build();

            Console.WriteLine(chain.Execute("USA", "John Doe"));
            Console.WriteLine(chain.Execute("Ukraine", "Ivan Mazepa"));
            Console.WriteLine(chain.Execute("Russia", "Vasya Pupkin"));
        }

        // Sample_5 output
        // [POST] to 'John Doe'. Country USA
        // [MAIL] to 'Ivan Mazepa'. Country Ukraine
        // [SMS] to 'Vasya Pupkin'. Country Russia
    }

    // General purpose class that is used in Link and in Can&Do approaches.
    public class Notificator
    {
        public void SendMail(string country, string name)
        {
            Console.WriteLine($"[MAIL] to '{name}'. Country {country}");
        }

        public void SendPost(string country, string name)
        {
            Console.WriteLine($"[POST] to '{name}'. Country {country}");
        }

        public void SendSms(string country, string name)
        {
            Console.WriteLine($"[SMS] to '{name}'. Country {country}");
        }

        public string SendMailWithResponce(string country, string name)
        {
            return $"[MAIL] to '{name}'. Country {country}";
        }

        public string SendPostWithResponce(string country, string name)
        {
            return $"[POST] to '{name}'. Country {country}";
        }

        public string SendSmsWithResponce(string country, string name)
        {
            return $"[SMS] to '{name}'. Country {country}";
        }
    }

    #region Link approach

    public sealed class MailLink : IVoidLink<string, string>
    {
        private readonly string[] _coutries;
        private readonly Notificator _notificator;

        public MailLink(string[] coutries, Notificator notificator)
        {
            _coutries = coutries;
            _notificator = notificator;
        }

        // t1 - country
        // t2 - name
        public bool Cando(string t1, string t2)
        {
            return _coutries.Contains(t1);
        }

        // t1 - country
        // t2 - name
        public void Do(string t1, string t2)
        {
            _notificator.SendMail(t1, t2);
        }
    }

    public sealed class MailLinkWithResponse : IResultLink<string, string, string>
    {
        private readonly string[] _coutries;
        private readonly Notificator _notificator;

        public MailLinkWithResponse(string[] coutries, Notificator notificator)
        {
            _coutries = coutries;
            _notificator = notificator;
        }

        // t1 - country
        // t2 - name
        public bool Cando(string t1, string t2)
        {
            return _coutries.Contains(t1);
        }

        // t1 - country
        // t2 - name
        public string Do(string t1, string t2)
        {
            return _notificator.SendMailWithResponce(t1, t2);
        }
    }

    public sealed class PostLink : IVoidLink<string, string>
    {
        private readonly string[] _coutries;
        private readonly Notificator _notificator;

        public PostLink(string[] coutries, Notificator notificator)
        {
            _coutries = coutries;
            _notificator = notificator;
        }

        // t1 - country
        // t2 - name
        public bool Cando(string t1, string t2)
        {
            return _coutries.Contains(t1);
        }

        // t1 - country
        // t2 - name
        public void Do(string t1, string t2)
        {
            _notificator.SendPost(t1, t2);
        }
    }

    #endregion

    #region Can&Do approach 

    public sealed class CanSend : ICan<string, string>
    {
        private readonly string[] _coutries;

        public CanSend(string[] coutries)
        {
            _coutries = coutries;
        }

        // t1 - country
        // t2 - name
        public bool Cando(string t1, string t2)
        {
            return _coutries.Contains(t1);
        }
    }

    public sealed class MailDo : IVoidDo<string, string>
    {
        private readonly Notificator _notificator;

        public MailDo(Notificator notificator)
        {
            _notificator = notificator;
        }

        // t1 - country
        // t2 - name
        public void Do(string t1, string t2)
        {
            _notificator.SendMail(t1, t2);
        }
    }

    public sealed class PostDo : IVoidDo<string, string>
    {
        private readonly Notificator _notificator;

        public PostDo(Notificator notificator)
        {
            _notificator = notificator;
        }

        // t1 - country
        // t2 - name
        public void Do(string t1, string t2)
        {
            _notificator.SendPost(t1, t2);
        }
    }

    public sealed class PostDoWithResponse : IResultDo<string, string, string>
    {
        private readonly Notificator _notificator;

        public PostDoWithResponse(Notificator notificator)
        {
            _notificator = notificator;
        }

        // t1 - country
        // t2 - name
        public string Do(string t1, string t2)
        {
            return _notificator.SendPostWithResponce(t1, t2);
        }
    }

    public sealed class SmsDo : IVoidDo<string, string>
    {
        private readonly Notificator _notificator;

        public SmsDo(Notificator notificator)
        {
            _notificator = notificator;
        }

        // t1 - country
        // t2 - name
        public void Do(string t1, string t2)
        {
            _notificator.SendSms(t1, t2);
        }
    }

    #endregion 
}
