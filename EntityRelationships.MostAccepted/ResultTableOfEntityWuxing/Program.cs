﻿using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.EntityRelationships.MostAccepted.EntityWuxingExtensions;
using YiJingFramework.EntityRelationships.MostAccepted.GuaToTextExtensions;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

static void WriteTableLine(IEnumerable<string> items)
{
    foreach (var item in items)
    {
        Console.Write("|");
        Console.Write(item);
    }
    Console.WriteLine("|");
}

{
    Console.WriteLine("### For GuaTrigrams");
    Console.WriteLine();

    var guas = from i in Enumerable.Range(0, 0b111)
               let s = Convert.ToString(i, 2).PadLeft(3, '0')
               select GuaTrigram.Parse(s);

    WriteTableLine(guas.Select(gua => gua.ToUnicodeChar().ToString()));
    WriteTableLine(guas.Select(gua => ":-:"));
    WriteTableLine(guas.Select(gua => gua.Wuxing().ToString("C")));
    Console.WriteLine();

    WriteTableLine(guas.Select(gua => gua.ToString()));
    WriteTableLine(guas.Select(gua => ":-:"));
    WriteTableLine(guas.Select(gua => gua.Wuxing().ToString()));
    Console.WriteLine();
    Console.WriteLine();
}

{
    Console.WriteLine("### For Tiangans");
    Console.WriteLine();

    var tiangans = from i in Enumerable.Range(1, 10)
                   select new Tiangan(i);

    WriteTableLine(tiangans.Select(x => x.ToString("C")));
    WriteTableLine(tiangans.Select(x => ":-:"));
    WriteTableLine(tiangans.Select(x => x.Wuxing().ToString("C")));
    Console.WriteLine();

    WriteTableLine(tiangans.Select(x => x.ToString()));
    WriteTableLine(tiangans.Select(x => ":-:"));
    WriteTableLine(tiangans.Select(x => x.Wuxing().ToString()));
    Console.WriteLine();
    Console.WriteLine();
}

{
    Console.WriteLine("### For Dizhis");
    Console.WriteLine();

    var dizhis = from i in Enumerable.Range(1, 12)
                 select new Dizhi(i);

    WriteTableLine(dizhis.Select(x => x.ToString("C")));
    WriteTableLine(dizhis.Select(x => ":-:"));
    WriteTableLine(dizhis.Select(x => x.Wuxing().ToString("C")));
    Console.WriteLine();

    WriteTableLine(dizhis.Select(x => x.ToString()));
    WriteTableLine(dizhis.Select(x => ":-:"));
    WriteTableLine(dizhis.Select(x => x.Wuxing().ToString()));
    Console.WriteLine();
    Console.WriteLine();
}