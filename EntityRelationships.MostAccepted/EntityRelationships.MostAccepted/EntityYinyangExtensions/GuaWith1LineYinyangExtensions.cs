using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelationships.MostAccepted.EntityYinyangExtensions;

/// <summary>
/// 关于一爻卦阴阳的扩展。
/// Extensions about Yinyang attribute of Guas with 1 line.
/// </summary>
public static class GuaWith1LineYinyangExtensions
{
    /// <summary>
    /// 获取卦的阴阳。
    /// Get the Yinyang attribute of a Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <returns>
    /// 阴阳。
    /// The Yinyang.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 是 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Yinyang Yinyang(this GuaWith1Line gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return gua[0];
    }
}
