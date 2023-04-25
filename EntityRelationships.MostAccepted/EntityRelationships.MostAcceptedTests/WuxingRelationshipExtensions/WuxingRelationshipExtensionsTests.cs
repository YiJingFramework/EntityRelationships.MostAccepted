using Microsoft.VisualStudio.TestTools.UnitTesting;
using YiJingFramework.PrimitiveTypes;

namespace YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions.Tests;

[TestClass()]
public class WuxingRelationshipExtensionsTests
{
    [TestMethod()]
    public void GetWuxingRelationshipTest()
    {
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Wood.GetWuxingRelationship(Wuxing.Fire));
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Fire.GetWuxingRelationship(Wuxing.Earth));
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Earth.GetWuxingRelationship(Wuxing.Metal));
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Metal.GetWuxingRelationship(Wuxing.Water));
        Assert.AreEqual(WuxingRelationship.GeneratedByMe,
            Wuxing.Water.GetWuxingRelationship(Wuxing.Wood));

        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Wood.GetWuxingRelationship(Wuxing.Water));
        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Water.GetWuxingRelationship(Wuxing.Metal));
        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Metal.GetWuxingRelationship(Wuxing.Earth));
        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Earth.GetWuxingRelationship(Wuxing.Fire));
        Assert.AreEqual(WuxingRelationship.GeneratingMe,
            Wuxing.Fire.GetWuxingRelationship(Wuxing.Wood));
    }

    [TestMethod()]
    public void GetWuxingThatTest()
    {
        for (int i = 0; i < 5; i++)
        {
            var woodP = (Wuxing)i;
            var fireP = woodP.GetWuxingThat(WuxingRelationship.GeneratedByMe);
            var earthP = fireP.GetWuxingThat(WuxingRelationship.GeneratedByMe);
            var metalP = earthP.GetWuxingThat(WuxingRelationship.GeneratedByMe);
            var waterP = metalP.GetWuxingThat(WuxingRelationship.GeneratedByMe);

            Assert.AreEqual(WuxingRelationship.GeneratedByMe,
                woodP.GetWuxingRelationship(fireP));
            Assert.AreEqual(WuxingRelationship.OvercameByMe,
                woodP.GetWuxingRelationship(earthP));
            Assert.AreEqual(WuxingRelationship.OvercomingMe,
                woodP.GetWuxingRelationship(metalP));
            Assert.AreEqual(WuxingRelationship.GeneratingMe,
                woodP.GetWuxingRelationship(waterP));

            Assert.AreEqual(fireP,
                woodP.GetWuxingThat(WuxingRelationship.GeneratedByMe));
            Assert.AreEqual(earthP,
                woodP.GetWuxingThat(WuxingRelationship.OvercameByMe));
            Assert.AreEqual(metalP,
                woodP.GetWuxingThat(WuxingRelationship.OvercomingMe));
            Assert.AreEqual(waterP,
                woodP.GetWuxingThat(WuxingRelationship.GeneratingMe));
        }
    }
}