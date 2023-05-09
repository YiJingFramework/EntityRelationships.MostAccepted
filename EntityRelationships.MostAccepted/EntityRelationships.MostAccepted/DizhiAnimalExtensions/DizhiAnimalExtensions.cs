using YiJingFramework.EntityRelationships.MostAccepted.Shared;
using YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelationships.MostAccepted.DizhiAnimalExtensions;

/// <summary>
/// 关于地支生肖的扩展。
/// Extensions about Shengxiao animals of Dizhis.
/// </summary>
public static class DizhiAnimalExtensions
{
    /// <summary>
    /// 获取地支对应的生肖。
    /// Get the corresponding Shengxiao animal of a Dizhi.
    /// </summary>
    /// <param name="dizhi">
    /// 地支。
    /// The Dizhi.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static ShengxiaoAnimal Animal(this Dizhi dizhi)
    {
        return (ShengxiaoAnimal)(dizhi.Index % 12);
    }

    /// <summary>
    /// 获取生肖对应的地支。
    /// Get the corresponding Dizhi of a Shengxiao animal.
    /// </summary>
    /// <param name="animal">
    /// 生肖。
    /// The animal.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static Dizhi Dizhi(this ShengxiaoAnimal animal)
    {
        return new((int)animal);
    }

    /// <summary>
    /// 将 <seealso cref="ShengxiaoAnimal"/> 通过指定的转换方法转换为字符串。
    /// Convert <seealso cref="ShengxiaoAnimal"/>s to strings with the given conversion method.
    /// </summary>
    /// <param name="animal">
    /// 要转换的生肖。
    /// The animal to convert.
    /// </param>
    /// <param name="conversion">
    /// 要用的转换器。
    /// The converter to be used.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static string ToString(
        this ShengxiaoAnimal animal,
        ConversionToString<ShengxiaoAnimal>? conversion)
    {
        if (conversion is null)
            return animal.ToString();
        return conversion(animal);
    }
}
