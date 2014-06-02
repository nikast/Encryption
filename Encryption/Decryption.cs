using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LZ_arhive
{
    /// <summary>
    /// Класс для декомпрессии.
    /// </summary>
    public class Decryption
    {
        /// <summary>
        /// Входяшая строка
        /// </summary>
        private readonly string _inString;

        /// <summary>
        /// Длина двоичного кода
        /// </summary>
        private int _codeLength;

        /// <summary>
        /// Билдер строк
        /// </summary>
        private readonly StringBuilder _stringBuilder;

        /// <summary>
        /// Словарь
        /// </summary>
        private readonly Dictionary<string, int> _dictionary;

        private readonly ProgressBar _progressBar;

        private readonly int _key;

        public Decryption(IEnumerable<byte> input, ProgressBar Dbar, int key)
        {
            _key = key;
            _progressBar = Dbar;
            _codeLength = 8;
            var sb = new StringBuilder();
            _stringBuilder = new StringBuilder();
            _dictionary = new Dictionary<string, int>();
            
            foreach (var item in input)
                sb.Append(Convert.ToString(item, 2).Zero(_codeLength) );
            
            _inString = sb.ToString();

            for (var i = 0; i < 256; i++)
                _dictionary.Add(System.Text.Encoding.Default.GetString(new byte[1] {Convert.ToByte(i)}), i);

        }

        /// <summary>
        /// Метод расшифровки.
        /// </summary>
        /// <returns></returns>
        public string Decoder()
        {
            _progressBar.Minimum = 0;
            _progressBar.Maximum = _inString.Length;
            _progressBar.Step = 8;

            var counter = 0;
            while (counter < _inString.Length)
            {
                _progressBar.PerformStep();
                var w = "";
                if (counter + 8 + _codeLength <= _inString.Length)
                {
                    w = _inString.Substring(counter, _codeLength);
                }
                else if (counter + _codeLength <= _inString.Length)
                {
                    var encodedLen = counter + _codeLength;
                    var a = _inString.Length - encodedLen;
                    w = _inString.Substring(counter, _codeLength - (8 - a)) + _inString.Substring(_inString.Length - (8 - a), (8 - a));
                }
                else
                {
                    break;
                }
                var value = Convert.ToInt32(w, 2);
                value-=_key;
                if (value < 0) value += 256;
                var key = _dictionary.FindKey(value);
                _stringBuilder.Append(key);
                counter += _codeLength;
            }
            return _stringBuilder.ToString();
        }

    }
}
