
namespace CustomInterface
{
    public abstract class Shape
    {
        protected Shape(string name = "NoName") => PetName = name;
        public string PetName { get; set; }

        public abstract void Draw();
    }
}
