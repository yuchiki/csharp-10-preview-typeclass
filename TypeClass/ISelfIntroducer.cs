namespace TypeClass;

public interface ISelfIntroducer
{
    public abstract static string IntroduceTypeItself();
}


public class HappyClass : ISelfIntroducer
{
    public static string IntroduceTypeItself() => "I'm a happy lucky class!";
}
