using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelationships.MostAccepted.GuaDerivingExtensions;

/// <summary>
/// 关于卦变换的扩展。
/// Extensions about Guas' derivation.
/// </summary>
public static class GuaApplyingDerivationExtensions
{
    /// <summary>
    /// 在卦上应用变换。
    /// Apply a derivation on a Gua.
    /// </summary>
    /// <typeparam name="TGuaIn">
    /// 输入卦的类型。
    /// Type of the input Gua.
    /// </typeparam>
    /// <typeparam name="TGuaOut">
    /// 输出卦的类型。
    /// Type of the output Gua.
    /// </typeparam>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="derivation">
    /// 变换。
    /// The derivation.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    public static TGuaOut ApplyDerivation<TGuaIn, TGuaOut>(
        this TGuaIn gua, Func<TGuaIn, TGuaOut> derivation)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return derivation(gua);
    }
}
