namespace LudoAPI.Models;

public class Move
{
    private int xChange;
    private int yChange;

    public Move(int xChange, int yChange)
    {
        this.xChange = xChange;
        this.yChange = yChange;
    }
}