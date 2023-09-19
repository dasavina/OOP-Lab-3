class Rectangle
{
    public string id
    { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int x { get; set; }
    public int y { get; set; }

    public Rectangle(string id, int width, int height, int x, int y)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.x = x;
        this.y = y;
    }

    public bool Intersects(Rectangle rectangle)
    {
        if ((rectangle.x >= x && rectangle.x <= x + width && rectangle.y >= y - height && rectangle.y <= y) || (x >= rectangle.x && x <= rectangle.x + rectangle.width && y >= rectangle.y - rectangle.height && y <= rectangle.y))
            return true;
        else return false;
    }

}
