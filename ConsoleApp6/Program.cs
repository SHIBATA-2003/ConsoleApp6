using System;
public class box
{
    static void Main()
    {
        Box box = new Box(InputFloat("幅を入力"), InputFloat("高さを入力"), InputFloat("奥行きを入力"));
        Console.WriteLine("表面積 = " + box.GetSurface());
        Console.WriteLine("体積 = " + box.GetVolume());
    }

    static float InputFloat(string su)
    {
        float input;
        while (true)
        {
            Console.WriteLine(su);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
    }
}
class Box
{
    private float width;
    private float height;
    private float depth;
    public Box(float w, float h, float d)
    {
        this.width = w;
        this.height = h;
        this.depth = d;
    }
    public Box(float w = 1)
    {
        this.width = w;
        this.height = w;
        this.depth = w;
    }
    public float GetVolume()
    {
        return width * height * depth;
    }
    public float GetSurface()
    {
        return (width * height + height * depth + depth * width) * 2;
    }
}