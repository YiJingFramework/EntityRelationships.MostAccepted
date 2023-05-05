using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.EntityRelationships.MostAccepted.EntityYinyangExtensions;

var qian = GuaTrigram.Parse("111");
Console.WriteLine(qian.Yinyang());
Console.WriteLine();
// Ouput: Yang

var zi = Dizhi.Zi;
Console.WriteLine(zi.Yinyang());
Console.WriteLine();
// Ouput: Yang

var jia = Tiangan.Jia;
Console.WriteLine(jia.Yinyang());
Console.WriteLine();
// Ouput: Yang
