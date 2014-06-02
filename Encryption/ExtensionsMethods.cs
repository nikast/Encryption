using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LZ_arhive
{
    /// <summary>
    /// Класс расшинения методов компрессии/декомпрессии.
    /// </summary>
    internal static class ExtensionsMethods
    {
        /// <summary>
        /// Дописываем ноль перед стройокй бит.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Zero(this string value, int length)
        {
            while (value.Length < length)
                value = "0" + value;
            return value;
        }

        /// <summary>
        /// Переводим строку битов в байты
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<byte> ToByteArray(this string value)
        {
            var list = new List<byte>();
            
            for (var i = 0; i < value.Length; i += 8)
                list.Add(Convert.ToByte(i + 8 <= value.Length ? value.Substring(i, 8) : value.Substring(i, value.Length - i), 2));

            return list;
        }

        /// <summary>
        /// Поиск ключа.
        /// </summary>
        /// <param name="lookup"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FindKey(this IDictionary<string, int> lookup, int value)
        {
            return (from pair in lookup where pair.Value == value select pair.Key).FirstOrDefault();
        }
    }
}
