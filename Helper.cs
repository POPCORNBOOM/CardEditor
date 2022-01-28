using System;
using System.Collections.Generic;
using System.Reflection;

namespace CardEditor
{
    public static class Helper
    {
        public static IList<T> Swap<T>(IList<T> list, int index1, int index2)
        {
            var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
            return list;
        }

        public static T DeepCopy<T>(T obj)
        {
            //如果是字符串或值类型则直接返回
            if (obj is string || obj.GetType().IsValueType) return obj;

            var result = Activator.CreateInstance(obj.GetType());
            var fields = obj.GetType().GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var field in fields)
                field.SetValue(result, DeepCopy(field.GetValue(obj)));

            return (T) result;
        }
    }
}