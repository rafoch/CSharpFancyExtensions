﻿using System;

namespace CSharpFancyExtensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrWhiteSpace(value);
    }
}
