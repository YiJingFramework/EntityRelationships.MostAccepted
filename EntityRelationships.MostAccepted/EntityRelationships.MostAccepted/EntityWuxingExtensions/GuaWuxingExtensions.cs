using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelationships.MostAccepted.EntityWuxingExtensions;

/// <summary>
/// 关于卦五行的扩展。
/// Extensions about Wuxing attribute of Guas.
/// </summary>
public static class GuaWuxingExtensions
{
    /// <summary>
    /// 获取卦的五行。
    /// Get the Wuxing attribute of a Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// 须为三爻卦。
    /// The Gua.
    /// Should be a trigram.
    /// </param>
    /// <returns>
    /// 五行。
    /// The Wuxing.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="gua"/> 不是一个三爻卦。
    /// <paramref name="gua"/> is not a trigram (Gua with 3 lines).
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 是 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Wuxing Wuxing(this Gua gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        if (gua.Count is 3)
        {
            return GuaTrigramWuxingExtensions.WuxingOfCheckedTrigram(gua.GetHashCode());
        }
        throw new ArgumentException(
            $"Gua '{gua}' is not a trigram (Gua with 3 lines).", nameof(gua));
    }

}
