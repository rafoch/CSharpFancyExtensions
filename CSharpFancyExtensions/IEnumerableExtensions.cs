using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFancyExtensions
{
    public static class IEnumerableExtensions
    {
        public static T SingleOrThrow<T>(this IEnumerable<T> enumerable)
        {
            try
            {
                return enumerable.Single();
            }
            catch (InvalidOperationException exception)
            {
                throw;
            }
            catch (Exception exception)
            {
                throw;
            }
        }
    }
}