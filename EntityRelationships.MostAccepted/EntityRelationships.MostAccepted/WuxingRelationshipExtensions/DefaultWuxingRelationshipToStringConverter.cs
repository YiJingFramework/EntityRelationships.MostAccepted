using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YiJingFramework.EntityRelationships.MostAccepted.WuxingRelationshipExtensions;

internal sealed class DefaultWuxingRelationshipToStringConverter : IWuxingRelationshipToStringConverter
{
    private readonly string[] names;
    public DefaultWuxingRelationshipToStringConverter(
        string sameAsMe, string generatingMe, 
        string generatedByMe, string overcameByMe, 
        string overcomingMe)
    {
        this.names = new string[5];
        this.names[(int)WuxingRelationship.SameAsMe] = sameAsMe;
        this.names[(int)WuxingRelationship.GeneratingMe] = generatingMe;
        this.names[(int)WuxingRelationship.GeneratedByMe] = generatedByMe;
        this.names[(int)WuxingRelationship.OvercameByMe] = overcameByMe;
        this.names[(int)WuxingRelationship.OvercomingMe] = overcomingMe;
    }

    public string Convert(WuxingRelationship wuxingRelationship)
    {
        var index = (int)wuxingRelationship % 5;
        return names[index];
    }
}
