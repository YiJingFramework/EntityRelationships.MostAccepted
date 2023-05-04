using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelationships.MostAccepted.GuaDerivingExtensions;

/// <summary>
/// 关于卦变换的扩展。
/// Extensions about Guas' derivation.
/// </summary>
public static class GuaDerivingExtensions
{
    #region ApplyDerivation
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
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 或 <paramref name="derivation"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> or <paramref name="derivation"/> is <c>null</c>.
    /// </exception>
    public static TGuaOut ApplyDerivation<TGuaIn, TGuaOut>(
        this TGuaIn gua, Func<TGuaIn, TGuaOut> derivation)
    {
        ArgumentNullException.ThrowIfNull(gua);
        ArgumentNullException.ThrowIfNull(derivation);

        return derivation(gua);
    }
    #endregion

    #region ReverseLines
    /// <summary>
    /// 改变卦中几爻，返回修改后的卦。
    /// Reverse some lines in a Gua and returns the modified Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="lineIndexes">
    /// 要修改的爻。
    /// 如果出现两次，将会翻转回来。
    /// The lines to reverse.
    /// If a number appears twice, this line will be reversed back.
    /// </param>
    /// <param name="throwIfOutOfRange">
    /// 指示是否要在超出范围时抛出异常。
    /// 若否，则会忽略超出范围的索引，并继续下一个。
    /// Indicate whether exceptions should be thrown when it is out of range.
    /// If false, the out-of-range indexes will be ignored and will continue to the next ones.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 或 <paramref name="lineIndexes"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> or <paramref name="lineIndexes"/> is <c>null</c>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// 若 <paramref name="throwIfOutOfRange"/> 为 <c>true</c> ，
    /// 则在索引超出范围时会抛出此异常。
    /// If <paramref name="throwIfOutOfRange"/> is set to <c>true</c>, 
    /// this exception will occurs when one of the indexes is out of range.
    /// </exception>
    public static Gua ReverseLines(
        this Gua gua, IEnumerable<int> lineIndexes,
        bool throwIfOutOfRange = true)
    {
        ArgumentNullException.ThrowIfNull(gua);
        ArgumentNullException.ThrowIfNull(lineIndexes);

        var lines = new List<Yinyang>(gua);
        foreach (var i in lineIndexes)
        {
            if (i < 0 || i >= lines.Count)
            {
                if (throwIfOutOfRange)
                    throw new ArgumentOutOfRangeException(nameof(lineIndexes));

                continue;
            }

            lines[i] = !lines[i];
        }
        return new(lines);
    }

    /// <summary>
    /// 改变卦中几爻，返回修改后的卦。
    /// Reverse some lines in a Gua and returns the modified Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="lineIndexes">
    /// 要修改的爻。
    /// 如果出现两次，将会翻转回来。
    /// The lines to reverse.
    /// If a number appears twice, this line will be reversed back.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 或 <paramref name="lineIndexes"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> or <paramref name="lineIndexes"/> is <c>null</c>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// 索引超出范围。
    /// One of the indexes is out of range.
    /// </exception>
    public static Gua ReverseLines(this Gua gua, params int[] lineIndexes)
    {
        return ReverseLines(gua, lineIndexes, true);
    }
    #endregion

    #region Cuogua
    /// <summary>
    /// 获取错卦。
    /// Get a Gua's Cuogua (reverse all the lines).
    /// </summary>
    /// <param name="gua">
    /// 本卦。
    /// The original Gua.
    /// </param>
    /// <returns>
    /// 错卦。
    /// Cuogua.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Gua Cuogua(this Gua gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return new Gua(gua.Select(line => !line));
    }
    #endregion

    #region Zonggua
    /// <summary>
    /// 获取综卦。
    /// Get a Gua's Zonggua (reverse the order of the lines).
    /// </summary>
    /// <param name="gua">
    /// 本卦。
    /// The original Gua.
    /// </param>
    /// <returns>
    /// 综卦。
    /// Zonggua.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static Gua Zonggua(this Gua gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        static IEnumerable<Yinyang> ReverseOrder(Gua gua)
        {
            for (int i = gua.Count - 1; i >= 0; i--)
                yield return gua[i];
        }
        return new Gua(ReverseOrder(gua));
    }
    #endregion

    #region Hugua
    /// <summary>
    /// 获取互卦。
    /// Get a Gua's Hugua.
    /// (The Huguas will made up with -- 
    /// the 2nd (<c>[1]</c>) line, the 3rd (<c>[2]</c>) line, the 4th line,
    /// then the 3rd line again, the 4th line and the 5th line
    /// -- of the original hexagram.)
    /// </summary>
    /// <param name="gua">
    /// 本卦。
    /// The original Gua.
    /// </param>
    /// <returns>
    /// 互卦。
    /// Hugua.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static GuaHexagram Hugua(this GuaHexagram gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return new(gua[1], gua[2], gua[3], gua[2], gua[3], gua[4]);
    }
    #endregion

    #region Jiaogua
    /// <summary>
    /// 获取交卦。
    /// Get a Gua's Jiaogua (swap the upper GuaTrigram and the lower GuaTrigram).
    /// </summary>
    /// <param name="gua">
    /// 本卦。
    /// The original Gua.
    /// </param>
    /// <returns>
    /// 交卦。
    /// Jiaogua.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    public static GuaHexagram Jiaogua(this GuaHexagram gua)
    {
        ArgumentNullException.ThrowIfNull(gua);

        return new(gua[3], gua[4], gua[5], gua[0], gua[1], gua[2]);
    }
    #endregion

    #region Split
    /// <summary>
    /// 拆分一个卦为更小的多个卦。
    /// Split a Gua to smaller Guas.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="pieceLength">
    /// 拆开后每一卦的爻数。
    /// 如果除不尽，则最后一卦可能爻数不一致。
    /// The line count of each smaller Guas.
    /// If it cannot be completely divided, the last one may not be this value.
    /// </param>
    /// <returns>
    /// 结果。
    /// The result.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="gua"/> 为 <c>null</c> 。
    /// <paramref name="gua"/> is <c>null</c>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="pieceLength"/> 不大于 <c>0</c> 。
    /// <paramref name="pieceLength"/> is not greater than <c>0</c>.
    /// </exception>
    public static IEnumerable<Gua> Split(this Gua gua, int pieceLength)
    {
        ArgumentNullException.ThrowIfNull(gua);

        if (pieceLength <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(pieceLength), 
                $"{nameof(pieceLength)} should be greater than zero.");

        Yinyang[] currentGua = new Yinyang[pieceLength];
        int iCurrentGua = 0;

        for (int iOriginalGua = 0; iOriginalGua < gua.Count; iOriginalGua++)
        {
            currentGua[iCurrentGua] = gua[iOriginalGua];

            iCurrentGua++;
            if (iCurrentGua == pieceLength)
            {
                yield return new(currentGua);
                iCurrentGua = 0;
            }
        }

        if(iCurrentGua is not 0)
        {
            yield return new(currentGua.Take(iCurrentGua));
        }
    }
    #endregion
}
