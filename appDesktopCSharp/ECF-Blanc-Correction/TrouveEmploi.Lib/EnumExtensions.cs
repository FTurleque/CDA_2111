using System.ComponentModel;
using System.Reflection;

namespace TrouveEmploi.Lib
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] Level = genericEnumType.GetMember(GenericEnum.ToString());
            if ((Level.Length <= 0))
            {
                return GenericEnum.ToString();
            }
            object[] attribs = Level[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attribs.Any() ? ((DescriptionAttribute)attribs.ElementAt(0)).Description : GenericEnum.ToString();
        }
    }
}
