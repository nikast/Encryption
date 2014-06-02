using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LZ_arhive
{
    /// <summary>
    /// Класс отвечает за кодирование информации.
    /// </summary>
    internal class EnCryption
    {
        /// <summary>
        /// Входящая строка
        /// </summary>
        private readonly string _inString;

        /// <summary>
        /// Длина двочного кода
        /// </summary>
        private int _codeLength;

        private readonly StringBuilder _stringBuilder;

        private readonly ProgressBar _progressBar;

        private readonly int _key;

        /// <summary>
        /// Словарь
        /// </summary>
        private readonly Dictionary<string, int> _dictionary;

        public EnCryption(string input, ProgressBar DBar, int key)
        {
            _key = key;
            _progressBar = DBar;
            _codeLength = 8;
            _inString = input;
            _stringBuilder = new StringBuilder();
            _dictionary = new Dictionary<string, int>();
             for (var i = 0; i < 256; i++)
                 _dictionary.Add(System.Text.Encoding.Default.GetString(new byte[1] { Convert.ToByte(i) }), i);
        }

        /// <summary>
        /// Процесс шифрования
        /// </summary>
        /// <returns></returns>
        public List<byte> Process()
        {
            _stringBuilder.Clear();
            _progressBar.Minimum = 0;
            _progressBar.Maximum = _inString.Length;
            _progressBar.Step = 1;
            var counter = 0;
            var len = _inString.Length;
            while (counter < len)
            {
                _progressBar.PerformStep();
                var w = _inString[counter].ToString();
                counter++;
                if (_dictionary.ContainsKey(w) == false) return null;
                int oldNumber;
                _dictionary.TryGetValue(w, out oldNumber);
                oldNumber+=_key;
                if (oldNumber >= 256) oldNumber = oldNumber - 256;
                _stringBuilder.Append(Convert.ToString(oldNumber, 2).Zero(_codeLength));
            }

            return _stringBuilder.ToString().ToByteArray();
        }
    }
}
