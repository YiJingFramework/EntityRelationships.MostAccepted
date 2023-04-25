﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelationships.MostAccepted.EntityYinyangExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelationships.MostAccepted.EntityYinyangExtensions.Tests;

[TestClass()]
public class GuaTrigramYinyangExtensionsTests
{
    private static IEnumerable<GuaTrigram> QianDuiLiZhenXunKanGenKun()
    {
        yield return new GuaTrigram(Yinyang.Yang, Yinyang.Yang, Yinyang.Yang);
        yield return new GuaTrigram(Yinyang.Yang, Yinyang.Yang, Yinyang.Yin);
        yield return new GuaTrigram(Yinyang.Yang, Yinyang.Yin, Yinyang.Yang);
        yield return new GuaTrigram(Yinyang.Yang, Yinyang.Yin, Yinyang.Yin);
        yield return new GuaTrigram(Yinyang.Yin, Yinyang.Yang, Yinyang.Yang);
        yield return new GuaTrigram(Yinyang.Yin, Yinyang.Yang, Yinyang.Yin);
        yield return new GuaTrigram(Yinyang.Yin, Yinyang.Yin, Yinyang.Yang);
        yield return new GuaTrigram(Yinyang.Yin, Yinyang.Yin, Yinyang.Yin);
    }

    [TestMethod()]
    public void YinyangTest()
    {
        var yinyangs = QianDuiLiZhenXunKanGenKun().Select(g => g.Yinyang());
        Assert.IsTrue(yinyangs.SequenceEqual(new[] {
            Yinyang.Yang,
            Yinyang.Yin,
            Yinyang.Yin,
            Yinyang.Yang,
            Yinyang.Yin,
            Yinyang.Yang,
            Yinyang.Yang,
            Yinyang.Yin
        }));
    }
}