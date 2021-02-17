// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility.Extensions
{
    public static class AttributeExtensions
    {
        public static TAttribute? GetAttributeFromField<TAttribute>(this Type type, string fieldName) where TAttribute : Attribute
        {
            var field = type.GetField(fieldName);

            return field is not null
                ? (TAttribute?)Attribute.GetCustomAttribute(field, typeof(TAttribute))
                : null;
        }

        public static TAttribute? GetAttributeFromMethod<TAttribute>(this Type type, string methodName) where TAttribute : Attribute
        {
            var method = type.GetMethod(methodName);

            return method is not null
                ? (TAttribute?)Attribute.GetCustomAttribute(method, typeof(TAttribute))
                : null;
        }

        public static TAttribute? GetAttributeFromMethod<TAttribute>(this Type type, string methodName, params Type[] types) where TAttribute : Attribute
        {
            var method = type.GetMethod(methodName, types);

            return method is not null
                ? (TAttribute?)Attribute.GetCustomAttribute(method, typeof(TAttribute))
                : null;
        }

        public static TAttribute? GetAttributeFromProperty<TAttribute>(this Type type, string propertyName) where TAttribute : Attribute
        {
            var property = type.GetProperty(propertyName);

            return property is not null
                ? (TAttribute?)Attribute.GetCustomAttribute(property, typeof(TAttribute))
                : null;
        }
    }
}
