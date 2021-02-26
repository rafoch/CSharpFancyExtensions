using System;
using FluentAssertions;
using Xbehave;
using Xunit;

namespace CSharpFancyExtensions.UnitTests
{
    public class StringExtensionTests
    {
        [Scenario]
        [Example(null)]
        [Example("")]
        public void StringShouldBeEmpty(string value)
        {
            value.IsNullOrEmpty().Should().BeTrue();
        }

        [Scenario]
        [Example("Some String")]
        public void StringShouldNotBeEmpty(string value)
        {
            value.IsNullOrEmpty().Should().BeFalse();
        }
    }
}
