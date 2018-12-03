using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BL
{
    public class Compare
    {
       public static bool CompareObject<T>(T Object1, T object2)
        {
            Type type = typeof(T);
            if (Object1 == null || object2 == null)
                return false;

            foreach (System.Reflection.PropertyInfo property in type.GetProperties())
            {
                if (property.Name != "ExtensionData")
                {
                    string Object1Value = string.Empty;
                    string Object2Value = string.Empty;
                    if (type.GetProperty(property.Name).GetValue(Object1, null) != null)
                        Object1Value = type.GetProperty(property.Name).GetValue(Object1, null).ToString();
                    if (type.GetProperty(property.Name).GetValue(object2, null) != null)
                        Object2Value = type.GetProperty(property.Name).GetValue(object2, null).ToString();
                    if (Object1Value.Trim() != Object2Value.Trim())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
