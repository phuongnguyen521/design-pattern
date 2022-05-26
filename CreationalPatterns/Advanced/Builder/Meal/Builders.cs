
namespace CreationalPatterns.Advanced.Builder
{
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
