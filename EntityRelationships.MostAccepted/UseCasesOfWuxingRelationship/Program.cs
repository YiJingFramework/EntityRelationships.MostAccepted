using YiJingFramework.PrimitiveTypes;
using YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions;

var wood = Wuxing.Wood;
var metal = Wuxing.Metal;
var relationship = WuxingRelationship.OvercomingMe;

Console.WriteLine(
    $"For {wood}, " +
    $"{metal} is the Wuxing that {wood.GetWuxingRelationship(metal)}.");

Console.WriteLine(
    $"For {wood}, " +
    $"the Wuxing that {relationship} is {wood.GetWuxingThat(relationship)}.");

var converter = SampleWuxingRelationshipToStringConverters.ToLiuqinInEnglish;
Console.WriteLine($"{relationship.ToString(converter)} of {wood} is {metal}.");

Console.WriteLine();
// Outputs:
// For Wood, Metal is the Wuxing that OvercomingMe.
// For Wood, the Wuxing that OvercomingMe is Metal.
// Superior&Spirit of Wood is Metal.