using System;
using System.ComponentModel;
using System.Linq;

namespace CardEditor
{
    public static class EnumHelper
    {
        public class ValueWrapper<T>
        {
            public T Value { get; set; }
            public string Display { get; set; }
        }

        public static ValueWrapper<T> WrapEnum<T>(this T enumValue) where T : Enum
        {
            return new ValueWrapper<T> {Value = enumValue, Display = enumValue.GetEnumDescription()};
        }

        public static string GetEnumDescription(this Enum enumValue)
        {
            var name = enumValue.ToString();
            var type = enumValue.GetType();
            return type.GetMember(name).FirstOrDefault() != null
                ? $"{(Attribute.GetCustomAttribute(type.GetField(name), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description}"
                : "string.Empty";
        }
    }
}