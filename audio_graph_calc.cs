using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bar measure project

    /*
     * caclulates possible combinations to fit
     * visualizer on a 1920x1080 display
     */
namespace ConsoleApplication3
{
    class Program
    {
        //main
        static void Main(string[] args)
        {

            //number of bars
            for (int bars = 2; bars <= 128; bars++)
            {

                //thickness of bars
                for (int thickness = 1; thickness <= 64; thickness++)
                {

                    //space between bars
                    for (int gapSpace = 0; gapSpace <= thickness; gapSpace++)
                    {

                        //formula to find solution that spans 1920x1080
                        if (2*(((bars - 1) * (thickness + gapSpace) - (gapSpace / 2)))== 1920)
                           {
                            Console.WriteLine("bars:" + bars + " thick: " + thickness + " gap: " + gapSpace);

                       
                         }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
