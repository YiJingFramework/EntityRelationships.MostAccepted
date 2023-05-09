using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions.Tests;

[TestClass()]
public class SampleWuxingRelationshipToStringConvertersTests
{
    [TestMethod()]
    public void Test()
    {
        var c = SampleWuxingRelationshipToStringConverters.ToSingleCharacter;
        Assert.AreEqual(WuxingRelationship.GeneratingMe.ToString(c), "G");
        Assert.AreEqual(WuxingRelationship.GeneratedByMe.ToString(c), "G");
        Assert.AreEqual(WuxingRelationship.OvercameByMe.ToString(c), "O");
        Assert.AreEqual(WuxingRelationship.OvercomingMe.ToString(c), "O");
        Assert.AreEqual(WuxingRelationship.SameAsMe.ToString(c), "S");

        c = SampleWuxingRelationshipToStringConverters.ToLiuqinInChinese;
        Assert.AreEqual(WuxingRelationship.GeneratingMe.ToString(c), "父母");
        Assert.AreEqual(WuxingRelationship.GeneratedByMe.ToString(c), "子孙");
        Assert.AreEqual(WuxingRelationship.OvercameByMe.ToString(c), "妻财");
        Assert.AreEqual(WuxingRelationship.OvercomingMe.ToString(c), "官鬼");
        Assert.AreEqual(WuxingRelationship.SameAsMe.ToString(c), "兄弟");

        c = SampleWuxingRelationshipToStringConverters.ToLiuqinInEnglish;
        Assert.AreEqual(WuxingRelationship.GeneratingMe.ToString(c), "Parent");
        Assert.AreEqual(WuxingRelationship.GeneratedByMe.ToString(c), "Offspring");
        Assert.AreEqual(WuxingRelationship.OvercameByMe.ToString(c), "Wife&Wealth");
        Assert.AreEqual(WuxingRelationship.OvercomingMe.ToString(c), "Superior&Spirit");
        Assert.AreEqual(WuxingRelationship.SameAsMe.ToString(c), "Peer");
    }
}