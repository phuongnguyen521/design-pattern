
namespace CreationalPatterns.Advanced.Builder
{
    //This is item
    public interface Item
    {
        public string name();
        public Packing packing();
        public float price();
    }

    public interface Packing
    {
        public string Pack();
    }
}
