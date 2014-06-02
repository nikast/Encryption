using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LZ_arhive
{
    /// <summary>
    /// Основная форма программы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Диалог открытия файла
        /// </summary>
        private OpenFileDialog _openFile;

        /// <summary>
        /// Диалог открытия архива
        /// </summary>
        private OpenFileDialog _openFileZip;

        /// <summary>
        /// Путь
        /// </summary>
        private readonly string _path;

        public MainForm()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = "";
            _path = Directory.GetCurrentDirectory();
            PathLabel.Text = @"Path : " + _path;
            PathLabelUnzip.Text = @"Path : " + _path;
        }

        /// <summary>
        /// Открваем файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileButton(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "";

            _openFile = new OpenFileDialog
            {
                InitialDirectory = _path,

            };

            if (_openFile.ShowDialog() != DialogResult.OK) return;
            EBar.Value = 0;
            var filename = _openFile.SafeFileName;
            NameBox1.Text = filename;
            PathLabel.Text = @"Path : " + _openFile.FileName;
            StartButton.Enabled = true;

        }

        /// <summary>
        /// Начинаем обработку по кнопке старт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = new StreamReader(_openFile.FileName);
                var list = new List<byte>();
                using (reader)
                {
                    var currentByte = reader.BaseStream.ReadByte();
                    while (currentByte > -1)
                    {
                        list.Add((byte)currentByte);
                        currentByte = reader.BaseStream.ReadByte();
                    }
                }

                EBar.Visible = true;
                var encoder = new EnCryption(File.ReadAllText(_openFile.FileName, System.Text.ASCIIEncoding.Default), EBar, Convert.ToInt16(KeyE.Text));

                File.WriteAllBytes(_openFile.FileName + ".nikast", encoder.Process().ToArray());

                this.toolStripStatusLabel1.Text = @"Encryption complate...";
                
                StartButton.Enabled = false;
                NameBox1.Text = "";
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = @"В процессе выполнения обнаружены ошибки.";
                MessageBox.Show(@"Processing error. Reason is : " + ex.Message);
            }

        }

        /// <summary>
        /// Выходим
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Действия при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если понадобится что-то сделать при закрытии.
        }


        /// <summary>
        /// Диалог выбора файла для распаковки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenUnzipButton_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "";
            _openFileZip = new OpenFileDialog
            {
                Filter = @"Archive files (*.nikast)|*.nikast",
                InitialDirectory = _path,
            };

            if (_openFileZip.ShowDialog() != DialogResult.OK) return;
            DBar.Value = 0;
            var filename = _openFileZip.SafeFileName;
            NameBoxUnzip.Text = filename;
            PathLabelUnzip.Text = @"Path : " + _openFileZip.FileName;
            UnZip.Enabled = true;
        }

        /// <summary>
        /// Кнопка распаковать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnZip_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = new StreamReader(_openFileZip.FileName);
                var list = new List<byte>();
                using (reader)
                {
                    var currentByte = reader.BaseStream.ReadByte();
                    while (currentByte > -1)
                    {
                        list.Add((byte)currentByte);
                        currentByte = reader.BaseStream.ReadByte();
                    }
                }
                DBar.Visible = true;
               
                var decoder = new Decryption(list, DBar, Convert.ToInt16(KeyD.Text));

                File.WriteAllText(_openFileZip.FileName.Replace(".nikast", ""), decoder.Decoder(), System.Text.Encoding.Default);

                this.toolStripStatusLabel1.Text = @"Decryption complate...";

                UnZip.Enabled = false;

                NameBoxUnzip.Text = "";
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = @"В процессе выполнения обнаружены ошибки.";
                MessageBox.Show(@"Processing error. Reason is : " + ex.Message);
            }
        }
    }
}
