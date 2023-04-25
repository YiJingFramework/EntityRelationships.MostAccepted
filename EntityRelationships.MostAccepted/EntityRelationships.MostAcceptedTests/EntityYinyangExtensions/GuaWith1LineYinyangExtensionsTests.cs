using Microsoft.VisualStudio.TestTools.UnitTesting;
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
public class GuaWith1LineYinyangExtensionsTests
{
    [TestMethod()]
    public void YinyangTest()
    {
        Assert.AreEqual(Yinyang.Yang, new GuaWith1Line(Yinyang.Yang).Yinyang());
        Assert.AreEqual(Yinyang.Yin, new GuaWith1Line(Yinyang.Yin).Yinyang());
    }
}