using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount.Extensions;

namespace YiJingFramework.EntityRelationships.MostAccepted.EntityWuxingExtensions;

/// <summary>
/// 关于八卦五行的扩展。
/// Extensions about Wuxing of Guas (trigrams).
/// </summary>
public static class GuaWuxingExtensions
{
    private static Wuxing Wuxing(int guaHashChecked)
    {
        Debug.Assert(guaHashChecked is >= 0b1000 and <= 0b1111);
        return guaHashChecked switch {
            0b1_000 => PrimitiveTypes.Wuxing.Earth,
            0b1_100 => PrimitiveTypes.Wuxing.Wood,
            0b1_010 => PrimitiveTypes.Wuxing.Water,
            0b1_110 => PrimitiveTypes.Wuxing.Metal,
            0b1_001 => PrimitiveTypes.Wuxing.Earth,
            0b1_101 => PrimitiveTypes.Wuxing.Fire,
            0b1_011 => PrimitiveTypes.Wuxing.Wood,
            _ => PrimitiveTypes.Wuxing.Metal, // 0b111
        };
    }

    /// <summary>
    /// 获取八卦的五行。
    /// Get the Wuxing attribute of a Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
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

        if(gua.Count is not 3)
        {
            throw new ArgumentException(
                $"Gua '{gua}' is not a trigram (Gua with 3 lines).", nameof(gua));
        }
        return Wuxing(gua.GetHashCode());
    }

    /// <summary>
    /// 获取八卦的五行。
    /// Get the Wuxing attribute of a Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <returns>
    /// 五行。
    /// The Wuxing.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 是 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Wuxing Wuxing(this GuaTrigram gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return Wuxing(gua.GetHashCode());
    }
}
