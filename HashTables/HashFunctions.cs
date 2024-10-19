using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    static class HashFunctions
    {
        public static int HashByDivision(string key, int tableSize)
        {
            int hashCode = key.GetHashCode();
            return Math.Abs(hashCode % tableSize);
        }

        public static int HashByMultiplication(string key, int tableSize)
        {
            int hashCode = key.GetHashCode();
            double A = (Math.Sqrt(5) - 1) / 2; // As suggested by Knuth
            return (int)(tableSize * ((hashCode * A) % 1));
        }

        public static int UniversalHashing(string key, int tableSize, int a, int b, int p)
        {
            int hashCode = key.GetHashCode();
            return ((a * hashCode + b) % p) % tableSize;
            // 1 <= a < p
            // 0 <= b < p
        }

    }
}
