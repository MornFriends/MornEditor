﻿namespace MornEditor
{
    public sealed class EnableIfAttribute : GivenBoolNameAttributeBase
    {
        public EnableIfAttribute(string propertyName) : base(propertyName)
        {
        }
    }
}
