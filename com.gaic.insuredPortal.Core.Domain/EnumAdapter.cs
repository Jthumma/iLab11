using System;
using System.ComponentModel;
using System.Reflection;

namespace com.gaic.insuredPortal.Core.Domain
{
    public static class EnumAdapter
    {
        public static string GetDescription(this Enum value)
        {
            var desc =
                (DescriptionAttribute[])
                    (value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof (DescriptionAttribute),
                        false);
            return desc.Length > 0 ? desc[0].Description : value.ToString();
        }

        public static T GetEnum<T>(this string description)
        {
            Type type = typeof (T);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (FieldInfo field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof (DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T) field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T) field.GetValue(null);
                }
            }
            //throw new ArgumentException("Not found.", "description");
            return default(T);
        }
    }
}