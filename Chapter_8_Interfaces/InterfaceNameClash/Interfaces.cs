namespace InterfaceNameClash
{

    /*
     * Так делать нельзя, но для примера сойдет
     */

    public interface IDrawToForm
    {
        void Draw();
    }

    public interface IDrawToMemory
    {
        void Draw();
    }

    public interface IDrawToPrinter
    {
        void Draw();
    }
}
