
namespace CreationalPatterns.Advanced.Builder
{
    public class Wrapper : Packing
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }

    public class Bottle : Packing
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}
