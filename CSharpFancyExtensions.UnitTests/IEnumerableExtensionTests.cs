using System;
using System.Collections.Generic;
using Xbehave;

namespace CSharpFancyExtensions.UnitTests
{
    public class IEnumerableExtensionTests
    {
        [Scenario]
        public void ShouldNotThrow()
        {
            var list = new List<string>();
            list.SingleOrThrow();
        }
    }
}