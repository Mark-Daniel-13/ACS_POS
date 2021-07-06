using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Helpers
{
    public class RandomGenerator
    {
        public static string GenerateRandomString(Random random, int size) {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, size).Select(c => c[random.Next(c.Length)]).ToArray());
        }

        public static int GenerateRandomNumber(Random random,int min, int max) {
            return random.Next(min, max);
        }
    }
}
