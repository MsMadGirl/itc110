using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Rebecca Scott
 * Peer for loop exercise
 * ITC110 FL16*/
namespace PeerForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<100; i+=2)
            {
                Console.WriteLine(i);
            }//end for loop

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }//end main
    }//end class
}//end namespace
