
public abstract class BaseClass
{
    protected int _x = 10;
    protected int _y = 20;

    public abstract void AbstractMethod();

    public abstract int X { get; }
    public abstract int Y { get; }
}
public class BaseClass2 : BaseClass
{
    public override void AbstractMethod()
    {
        _x++;
        _y++;
    }

    public override int X
    {
        get { return _x; }
    }

    public override int Y
    {
        get { return _y; }
    }
}


