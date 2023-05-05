using System.Net;
using System.Xml.Linq;
using YiJingFramework.EntityRelationships.MostAccepted;
using YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions;
using YiJingFramework.PrimitiveTypes;

static void WriteTableLine(IEnumerable<string> items)
{
    foreach (var item in items)
    {
        Console.Write("|");
        Console.Write(item);
    }
    Console.WriteLine("|");
}

var wuxings = from i in Enumerable.Range(0, 5)
              select (Wuxing)i;

var relationships = new[]
{
    WuxingRelationship.SameAsMe,
    WuxingRelationship.GeneratingMe,
    WuxingRelationship.GeneratedByMe,
    WuxingRelationship.OvercomingMe,
    WuxingRelationship.OvercameByMe
};

var relationshipNames = new[]
{
    "同我",
    "生我",
    "我生",
    "克我",
    "我克"
};

WriteTableLine(wuxings.Select(x => x.ToString("C")).Prepend("关系"));
WriteTableLine(wuxings.Select(x => ":-:").Prepend(":-:"));
foreach (var (r, rName) in relationships.Zip(relationshipNames))
    WriteTableLine(wuxings.Select(x => x.GetWuxingThat(r).ToString("C")).Prepend(rName));

Console.WriteLine();

WriteTableLine(wuxings.Select(x => x.ToString()).Prepend("Relationship"));
WriteTableLine(wuxings.Select(x => ":-:").Prepend(":-:"));
foreach(var r in relationships)
    WriteTableLine(wuxings.Select(x => x.GetWuxingThat(r).ToString()).Prepend(r.ToString()));

