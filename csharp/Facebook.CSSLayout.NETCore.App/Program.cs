using System;

namespace Facebook.CSSLayout.NETCore.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var node = new CSSNode();

            node.SetMeasureFunction((_, width, widthMode, height, heightMode) => MeasureOutput.Make(100f, 150f));
            node.CalculateLayout();

            if (Math.Abs(100f - node.LayoutWidth) > 0.01)
            {
                throw new Exception("Unexpected Width");
            }
            if (Math.Abs(150f - node.LayoutHeight) > 0.01)
            {
                throw new Exception("Unexpected Height");
            }

            Console.WriteLine("Success");
            Console.ReadLine();
        }
    }
}
