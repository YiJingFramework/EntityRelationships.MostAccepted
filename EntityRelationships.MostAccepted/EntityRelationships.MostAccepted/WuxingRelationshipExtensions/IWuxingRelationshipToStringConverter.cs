using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions;

/// <summary>
/// 表示一个将 <seealso cref="WuxingRelationship"/> 转换为字符串的转换器。
/// Represents a converter that can convert <seealso cref="WuxingRelationship"/>s to strings.
/// </summary>
public interface IWuxingRelationshipToStringConverter
{
    /// <summary>
    /// 进行转换。
    /// Do conversion.
    /// </summary>
    /// <param name="wuxingRelationship">
    /// 五行关系。
    /// The relationship.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public string Convert(WuxingRelationship wuxingRelationship);
}
