using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount.Extensions;

namespace YiJingFramework.EntityRelationships.MostAccepted.EntityYinyangExtensions;

/// <summary>
/// 关于卦阴阳的扩展。
/// Extensions about Yinyang attribute of Guas.
/// </summary>
public static class GuaYinyangExtensions
{
    /// <summary>
    /// 获取卦的阴阳。
    /// Get the Yinyang attribute of a Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// 须为一爻卦或三爻卦。
    /// The Gua.
    /// Should exactly have 1 line or 3 lines.
    /// </param>
    /// <returns>
    /// 阴阳。
    /// The Yinyang.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="gua"/> 不是一个一爻或三爻卦。
    /// <paramref name="gua"/> does not have exact 1 or 3 lines.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 是 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Yinyang Yinyang(this Gua gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        if(gua.Count is 1)
        {
            return gua[0];
        }

        if (gua.Count is 3)
        {
            return GuaTrigramYinyangExtensions.YinyangOfCheckedTrigram(gua.GetHashCode());
        }

        throw new ArgumentException(
            $"Gua '{gua}' does not have exact 1 or 3 lines.", nameof(gua));
    }

}
