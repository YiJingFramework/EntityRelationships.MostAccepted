using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount.Extensions;

namespace YiJingFramework.EntityRelationships.MostAccepted.GuaDerivingExtensions;

/// <summary>
/// 关于卦变换的扩展（动爻部分）。
/// Extensions about Guas' derivation (Lines Changing Part).
/// </summary>
public static class GuaChangingLinesExtensions
{
    /// <summary>
    /// 改变卦中几爻，返回修改后的卦。
    /// Change some lines in a Gua and returns the modified Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="lineIndexes">
    /// 要修改的爻。
    /// 如果出现两次，将会翻转回来。
    /// The lines to change.
    /// If a number appears twice, this line will be changed back.
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
    public static Gua ChangeLines(
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
                if(throwIfOutOfRange)
                    throw new ArgumentOutOfRangeException(nameof(lineIndexes));

                continue;
            }

            lines[i] = !lines[i];
        }
        return new(lines);
    }

    /// <summary>
    /// 改变卦中几爻，返回修改后的卦。
    /// Change some lines in a Gua and returns the modified Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="lineIndexes">
    /// 要修改的爻。
    /// 如果出现两次，将会翻转回来。
    /// The lines to change.
    /// If a number appears twice, this line will be changed back.
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
    public static Gua ChangeLines(this Gua gua, params int[] lineIndexes)
    {
        return ChangeLines(gua, (IEnumerable<int>)lineIndexes);
    }

    /// <summary>
    /// 改变卦中几爻，返回修改后的卦。
    /// Change some lines in a Gua and returns the modified Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="lineIndexes">
    /// 要修改的爻。
    /// 如果出现两次，将会翻转回来。
    /// The lines to change.
    /// If a number appears twice, this line will be changed back.
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
    public static TGua ChangeLines<TGua>(
        this TGua gua, IEnumerable<int> lineIndexes,
        bool throwIfOutOfRange = true)
        where TGua : IGuaWithFixedCount<TGua>
    {
        return ChangeLines(gua?.AsGua()!, lineIndexes, throwIfOutOfRange).As<TGua>();
    }

    /// <summary>
    /// 改变卦中几爻，返回修改后的卦。
    /// Change some lines in a Gua and returns the modified Gua.
    /// </summary>
    /// <param name="gua">
    /// 卦。
    /// The Gua.
    /// </param>
    /// <param name="lineIndexes">
    /// 要修改的爻。
    /// 如果出现两次，将会翻转回来。
    /// The lines to change.
    /// If a number appears twice, this line will be changed back.
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
    public static TGua ChangeLines<TGua>(
        this TGua gua, params int[] lineIndexes)
        where TGua : IGuaWithFixedCount<TGua>
    {
        return ChangeLines(gua, (IEnumerable<int>)lineIndexes);
    }
}
