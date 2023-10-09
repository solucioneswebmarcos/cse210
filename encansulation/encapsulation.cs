using system;

public class Fraction
{
    private int _top;
    private int _botton;

    public Fraction (int top, int botton)
    {
        _top = top;
        _botton = botton;
    }

    public int GetTop ()
    {
        return _top;
    }

    public int GetBotton ()
    {
        return _botton;
    }

    public void SetTop (int top)
    {
        _top = top;
    }

    public void SetBotton (int botton)
    {
        _botton = botton;
    }

}