using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawlowski_Michal_Projekt1
{
    class Masks //klasa ktora przechowuje maski
    {

        //deklaracja masek
        public static int[,] OneOverNine { get; private set; }
        public static int[,] OneOverTen { get; private set; }
        public static int[,] OneOverSixteen { get; private set; }
        public static int[,] LaplacianBasic { get; private set; }
        public static int[,] LaplacianA { get; private set; }
        public static int[,] LaplacianB { get; private set; }
        public static int[,] LaplacianC { get; private set; }
        public static int[,] LaplacianD { get; private set; }
        public static int[,] LaplacianE { get; private set; }
        public static int[,] EdgeDetectionA { get; private set; }
        public static int[,] EdgeDetectionB { get; private set; }
        public static int[,] EdgeDetectionC { get; private set; }
        

        //recznie tworze te maski jako stale
        static Masks()
        {
            OneOverNine = new int[,]
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };
            OneOverTen = new int[,]
            {
                { 1, 1, 1 },
                { 1, 2, 1 },
                { 1, 1, 1 }
            };
            OneOverSixteen = new int[,]
            {
                { 1, 2, 1 },
                { 2, 4, 2 },
                { 1, 2, 1 }
            };
            LaplacianBasic = new int[,]
            {
                { 0, 1, 0 },
                { 1, -4, 1 },
                { 0, 1, 0 }
            };
            LaplacianA = new int[,]
            {
                { 0, -1, 0 },
                { -1, 4, -1 },
                { 0, -1, 0 }
            };
            LaplacianB = new int[,]
            {
                { -1, -1, -1 },
                { -1, 8, -1 },
                { -1, -1, -1 }
            };
            LaplacianC = new int[,]
            {
                { 1, -2, 1 },
                { -2, 4, -2 },
                { 1, -2, 1 }
            };
            LaplacianD = new int[,]
            {
                { -1, -1, -1 },
                { -1, 9, -1 },
                { -1, -1, -1 }
            };
            LaplacianE = new int[,]
            {
                { 0, -1, 0 },
                { -1, 5, -1 },
                { 0, -1, 0 }
            };
            EdgeDetectionA = new int[,]
            {
                { 1, -2, 1 },
                { -2, 5, -2 },
                { 1, -2, 1 }
            };
            EdgeDetectionB = new int[,]
            {
                { -1, -1, -1 },
                { -1, 9, -1 },
                { -1, -1, -1 }
            };
            EdgeDetectionC = new int[,]
            {
                { 0, -1, 0 },
                { -1, 5, -1 },
                { 0, -1, 0 }
            };
           
        }
    }
}
