namespace InterfaceHierarchy
{
    public interface IAdvancedDraw : IDrawable
    {
        void DrawInBox(int top, int bottom, int left, int right);
        void DrawUpsideBox();
    }
}
