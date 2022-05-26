
namespace StructuralPatterns.Advanced.Adapter
{
    //https://gpcoder.com/4483-huong-dan-java-design-pattern-adapter/
    class VietnameseClient
    {
        static void Main(string[] args)
        {
            IVietnameseTarget target = new TranslatorAdapter(
            new JapaneseAdaptee());
            target.send("Xin Chao");
        }
    }
}
