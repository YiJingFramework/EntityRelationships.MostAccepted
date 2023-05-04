using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelationships.MostAccepted.GuaDerivingExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

namespace YiJingFramework.EntityRelationships.MostAccepted.GuaDerivingExtensions.Tests;

[TestClass()]
public class GuaChangingLinesExtensionsTests
{
    [TestMethod()]
    public void ChangeLinesTest()
    {
        Assert.AreEqual(Gua.Parse("000"), Gua.Parse("000").ChangeLines());
        Assert.AreEqual(Gua.Parse("000"), Gua.Parse("111").ChangeLines(0, 1, 2));
        Assert.AreEqual(Gua.Parse("000"), Gua.Parse("101").ChangeLines(0, 2, 1, 1, 1, 1));
        Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => Gua.Parse("101").ChangeLines(0, 2, 3, -234, 1239109));

        Assert.AreEqual(Gua.Parse("000"), Gua.Parse("101").ChangeLines(
            new[] { 0, 2, 3, -234, 1239109 }, false));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Gua.Parse("101").ChangeLines(
            new[] { 0, 2, 3, -234, 1239109 }));

        Assert.AreEqual(GuaTrigram.Parse("000"), GuaTrigram.Parse("000").ChangeLines());
        Assert.AreEqual(GuaTrigram.Parse("000"), GuaTrigram.Parse("111").ChangeLines(0, 1, 2));
        Assert.AreEqual(GuaTrigram.Parse("000"), GuaTrigram.Parse("101").ChangeLines(0, 2, 1, 1, 1, 1));
        Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => GuaTrigram.Parse("101").ChangeLines(0, 2, 3, -234, 1239109));

        Assert.AreEqual(GuaTrigram.Parse("000"), GuaTrigram.Parse("101").ChangeLines(
            new[] { 0, 2, 3, -234, 1239109 }, false));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => GuaTrigram.Parse("101").ChangeLines(
            new[] { 0, 2, 3, -234, 1239109 }));
    }
}