using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions;

/// <summary>
/// 提供一些 <seealso cref="IWuxingRelationshipToStringConverter"/> 的实现样例。
/// 一般情况下不会使用这些样例，还是需要自己实现。
/// Provides some sample of <seealso cref="IWuxingRelationshipToStringConverter"/>'s implementation.
/// These samples may not be used in most cases. And you can write your own implementation.
/// </summary>
public static class SampleWuxingRelationshipToStringConverters
{
    /// <summary>
    /// 此转换器会返回 S 、 G 或 O 以表示相同、相生和相克。
    /// This converter will return S, G or O to represent that their are same (S), 
    /// one is generating (G) the other, or one is overcoming (O) the other.
    /// </summary>
    public static IWuxingRelationshipToStringConverter ToSingleCharacter { get; }
        = new DefaultWuxingRelationshipToStringConverter(
            "S", "G", "G", "O", "O");

    /// <summary>
    /// 此转换器会返回 Peer 、 Elder 、 Offspring 、 Wife&amp;Wealth 或 Superior&amp;Spirit 以表示六亲关系。
    /// This converter will return Peer, Elder, Offspring, Wife&amp;Wealth or Superior&amp;Spirit
    /// to represent the Liuqin relationship.
    /// </summary>
    public static IWuxingRelationshipToStringConverter ToLiuqinInEnglish { get; }
        = new DefaultWuxingRelationshipToStringConverter(
            "Peer", "Parent", "Offspring", "Wife&Wealth", "Superior&Spirit");

    /// <summary>
    /// 此转换器会返回兄弟、父母、子孙、妻财或官鬼以表示六亲关系。
    /// This converter will return 兄弟, 父母, 子孙, 妻财 or 官鬼
    /// to represent the Liuqin relationship.
    /// </summary>
    public static IWuxingRelationshipToStringConverter ToLiuqinInChinese { get; }
        = new DefaultWuxingRelationshipToStringConverter(
            "兄弟", "父母", "子孙", "妻财", "官鬼");
}
