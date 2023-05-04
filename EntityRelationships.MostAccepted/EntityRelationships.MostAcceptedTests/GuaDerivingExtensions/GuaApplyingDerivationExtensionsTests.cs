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
public class GuaApplyingDerivationExtensionsTests
{
    [TestMethod()]
    public void ApplyDerivationTest()
    {
        Assert.AreEqual(Yinyang.Yin, new Gua(Yinyang.Yang).ApplyDerivation((gua) => {
            return new Gua(Yinyang.Yin);
        })[0]);
        Assert.AreEqual(Yinyang.Yin, new GuaWith1Line(Yinyang.Yang).ApplyDerivation((gua) => {
            return new Gua(Yinyang.Yin);
        })[0]);
        Assert.AreEqual(0, new GuaWith1Line(Yinyang.Yang).ApplyDerivation((gua) => {
            return new GuaEmpty();
        }).Count);
    }
}