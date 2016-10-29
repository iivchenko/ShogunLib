// <copyright company="XATA">
//      Copyright (c) 2016 by Shogun, All Right Reserved
// </copyright>
// <author>Ivan Ivchenko</author>
// <email>iivchenko@live.com</email>

using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using ShogunLib.Events;
using ShogunLib.LINQ;
using ShogunLib.Monads;

namespace ShogunLib.Samples
{
    [TestFixture]
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

        
        public void Process(Report report, string author)
        {
            report.ValidateNull(nameof(report));
            author.ValidateStringEmpty(nameof(author));

            report
                .ToMaybe()
                .Bind(x => x.Item)
                .Bind(x => x.Value)
                .Do(x => NameChanged.Raise(this, x));

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
