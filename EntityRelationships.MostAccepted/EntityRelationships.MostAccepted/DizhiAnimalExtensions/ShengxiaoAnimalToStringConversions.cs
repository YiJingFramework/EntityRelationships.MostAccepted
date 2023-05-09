using YiJingFramework.EntityRelationships.MostAccepted.Shared;

namespace YiJingFramework.EntityRelationships.MostAccepted.DizhiAnimalExtensions;

/// <summary>
/// 提供一些针对 <seealso cref="ShengxiaoAnimal"/> 的 <seealso cref="ConversionToString{T}"/> 样例。
/// Provides some samples of <seealso cref="ConversionToString{T}"/> of <seealso cref="ShengxiaoAnimal"/>s.
/// </summary>
public static class ShengxiaoAnimalToStringConversions
{
    /// <summary>
    /// 此转换会返回中文的鼠、牛、虎、兔、龙、蛇、马、羊、猴、鸡、狗和猪。
    /// This conversion will return 鼠, 牛, 虎, 兔, 龙, 蛇, 马, 羊, 猴, 鸡, 狗 and 猪 in Chinese.
    /// </summary>
    public static ConversionToString<ShengxiaoAnimal> InChinese { get; }
        = (animal) => {
            return animal switch {
                ShengxiaoAnimal.Rat => "鼠",
                ShengxiaoAnimal.Cow => "牛",
                ShengxiaoAnimal.Tiger => "虎",
                ShengxiaoAnimal.Rabbit => "兔",
                ShengxiaoAnimal.Long => "龙",
                ShengxiaoAnimal.Snake => "蛇",
                ShengxiaoAnimal.Horse => "马",
                ShengxiaoAnimal.Sheep => "羊",
                ShengxiaoAnimal.Monkey => "猴",
                ShengxiaoAnimal.Chicken => "鸡",
                ShengxiaoAnimal.Dog => "狗",
                ShengxiaoAnimal.Pig => "猪",
                _ => animal.ToString()
            };
        };
}
