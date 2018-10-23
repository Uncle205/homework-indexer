using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   

    class Move
    {
        int[] mas = { 1, 2, 3, 4, 5 };
    public int this[int index]
    {
        get { return mas[index] * 2; }
        set { mas[index] = value; }
    }}
    
}
