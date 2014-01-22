using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval
{
    public class Sequence
    {
        public static IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers)
        {
            //modulus two equals one.
            return numbers.Where(i => i % 2 == 1);
          
        }

        public static IEnumerable<int> GetPositiveIntegers()
        {

            return Generate(0, n => n + 1);

        }

        /// <summary>
        /// Implementation of lazy evaluation using  using the IEnumerable<T>
        /// First element and a function that takes a value as an argument and calculates the next value in a sequence. 
        /// This function is implemented using the Func<A0,T> delegate type:
        ///  </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="initial"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        ///
        private static IEnumerable<T> Generate<T>(T initial, Func<T, T?> next) where T : struct
        {

            T? val = initial;

            while (val.HasValue)
            {

                yield return val.Value;

                val = next(val.Value);

            }

        }

    }







}
