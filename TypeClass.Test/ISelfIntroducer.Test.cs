using TypeClass;
using Xunit;

namespace TypeClass.Test;

public class ISelfIntroducerTest
{

    static string AskTheirIdentity<T>()
        where T : ISelfIntroducer
    {
        return T.IntroduceTypeItself();
    }

    [Fact]
    public void HappyClassAsISelfIntroducerCanIntroduceThemself()
    {
        var expected = "I'm a happy lucky class!";
        Assert.Equal(AskTheirIdentity<HappyClass>(), expected);
    }
}
