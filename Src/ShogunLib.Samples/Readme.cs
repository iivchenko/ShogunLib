// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections.Generic;
using NUnit.Framework;
using ShogunLib.Events;
using ShogunLib.LINQ;
using ShogunLib.Monads;
using ShogunLib.Patterns.ChainOfResponsibility;

namespace ShogunLib.Samples
{
    [TestFixture(Category = Constants.Category)]
    public sealed class Readme
    {
        public event EventHandler<SimpleEventArgs<string>> NameChanged;

        public sealed class Record
        {
            public string Header { get; set; }
        }

        public sealed  class ReportItem
        {
            public string Name { get; set; }

            public long Length { get; set; }

            public string Value { get; set; }
        }

        public sealed class Report
        {
            public string Header { get; set; }

            public ReportItem Item { get; set; } 

            public IEnumerable<Record> Records { get; set; }
        }

        public sealed class Logger
        {
            public void LogInfo(string msg)
            {
                Log("[INFO]", msg);
            }

            public void LogWarn(string msg)
            {
                Log("[WARN]", msg);
            }

            public void LogError(string msg)
            {
                Log("[ERROR]", msg);
            }

            public void LogDebug(string msg)
            {
                Log("[DEBUG]", msg);
            }

            private void Log(string level, string msg)
            {
                Console.WriteLine($"{level} {msg}");
            }
        }

        public void Process(Report report, string author)
        {
            // Validate extensions
            report.ValidateNull(nameof(report));
            author.ValidateStringEmpty(nameof(author));
            
            // Maybe monad and Events extensions
            report
                .ToMaybe()
                .Bind(x => x.Item)
                .Bind(x => x.Value)
                .Do(x => NameChanged.Raise(this, x));

            // Maybe monad
            var unit =
                report
                    .ToMaybe()
                    .Bind(x => x.Item)
                    .Bind(x => x.Length.ToUnit())
                    .Return();

                Console.WriteLine($"Report size is {unit.Value} ({unit.Name})");

            report
                .ToMaybe()
                .Do(x => x.Records.ForEach(y => Console.WriteLine(y.Header)));

            // Chain of Responsibility
            var log = new Logger();

            var chain =
                Chain
                    .CreateVoid<string, string>()
                    .Add
                    (
                        (level, message) => level == "ERROR",
                        (level, message) => log.LogError(message)
                    )
                    .Add
                    (
                        (level, message) => level == "WARN",
                        (level, message) => log.LogWarn(message)
                    )
                    .Add
                    (
                        (level, message) => true, // Last link will handle all unhandled requests
                        (level, message) => log.LogDebug(message)
                    )
                    .Build();

            chain.Execute("DEBUG", "Some DEBUG message");
            chain.Execute("INFO", "Some DEBUG message");
            chain.Execute("ERROR", "Some ERROR message");
            chain.Execute("TRACE", "Some DEBUG message");
            chain.Execute("WARN", "Some WARN message");
        }

        [Test]
        public void JustRunTest()
        {
            var report = new Report
            {
                Header = "A report",
                Item = new ReportItem
                {
                    Name = "Item",
                    Value = "Value",
                    Length = 2*1024*1024
                },
                Records = new[] {new Record {Header = "r1"}, new Record {Header = "r2"}}
            };

            Process(report, "Ivan");
        }
    }
}
