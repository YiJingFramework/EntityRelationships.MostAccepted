using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions;

/// <summary>
/// 关于五行生克关系的扩展。
/// Extensions about Wuxing relationship.
/// </summary>
public static class WuxingRelationshipExtensions
{
    /// <summary>
    /// 获取与另一五行之间的关系。
    /// Get the relationship between a Wuxing and another Wuxing.
    /// </summary>
    /// <param name="me">
    /// 此五行（我）。
    /// The current Wuxing (me).
    /// </param>
    /// <param name="other">
    /// 另一五行。
    /// The other Wuxing.
    /// </param>
    /// <returns>
    /// 关系。
    /// The relationship.
    /// </returns>
    public static WuxingRelationship GetWuxingRelationship(this Wuxing me, Wuxing other)
    {
        return (WuxingRelationship)(((int)other - (int)me + 5) % 5);
    }

    /// <summary>
    /// 通过五行关系获取另一五行。
    /// Get another Wuxing with the relationship of a Wuxing.
    /// </summary>
    /// <param name="me">
    /// 此五行（我）。
    /// The current Wuxing (me).
    /// </param>
    /// <param name="relationship">
    /// 关系。
    /// The relationship.
    /// </param>
    /// <returns>
    /// 另一五行。
    /// The another Wuxing.
    /// </returns>
    public static Wuxing GetWuxingThat(this Wuxing me, WuxingRelationship relationship)
    {
        return me + (int)relationship;
    }
}
