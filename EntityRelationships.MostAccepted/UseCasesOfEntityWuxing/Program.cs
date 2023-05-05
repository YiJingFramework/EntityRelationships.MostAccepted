using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.EntityRelationships.MostAccepted.EntityWuxingExtensions;

var qian = GuaTrigram.Parse("111");
Console.WriteLine(qian.Wuxing());
// Ouput: Metal

var zi = Dizhi.Zi;
Console.WriteLine(zi.Wuxing());
// Ouput: Water

var jia = Tiangan.Jia;
Console.WriteLine(jia.Wuxing());
// Ouput: Wood
