using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_4
{
    public partial class Form1 : Form
    {
        //специальные строки для проверки вводимого текста
        string eng_string = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ\n\r ";
        string rus_string = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n\r ";
        string eng_string2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rus_string2 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public Form1()
        {
            InitializeComponent();
        }

        private void rus_CheckedChanged(object sender, EventArgs e)
        {
            if (rus.Checked == true) //проверка свойства (выбрана или нет)
            {
                eng.Checked = false; //меняем свойство другой кнопки 
                input_error.Visible = false; //прячем текст об ошибке
                key_error.Visible = false;
                input_text.Text = ""; //очистка поля
                input_binary.Text = "";
                key_text.Text = "";
                key_binary.Text = "";
                crypt_text.Text = "";
                decrypt_text.Text = "";
                decrypt_nonbin.Text = "";
            }
            else
            {
                eng.Checked = true;
            }
        }

        private void eng_CheckedChanged(object sender, EventArgs e)
        {
            if (eng.Checked == true)
            {
                rus.Checked = false; //меняем свойство другой кнопки 
                input_error.Visible = false; //прячем текст об ошибке
                key_error.Visible = false;
                input_text.Text = ""; //очистка поля
                input_binary.Text = "";
                key_text.Text = "";
                key_binary.Text = "";
                crypt_text.Text = "";
                decrypt_text.Text = "";
                decrypt_nonbin.Text = "";
            }
            else
            {
                rus.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "cryptoProgram";
        }

        

        private void input_text_TextChanged(object sender, EventArgs e)
        {
            //проверка вводимого текста
            string text = input_text.Text; //вытаскиваем текст для проверки

            for (int i = 0; i < input_text.Text.Length; i++)
            {
                if (rus.Checked == true && !rus_string.Contains(text[i]))
                //не даем ввести все что не входит в контрольные строки
                {
                    input_error.Visible = true;
                    input_text.Text = text.Remove(text.Length - 1);
                }
                if (eng.Checked == true && !eng_string.Contains(text[i]))
                {
                    input_error.Visible = true;
                    input_text.Text = text.Remove(text.Length - 1);
                }
            }
            //переводим каретку в конец (точку старта ввода)
            input_text.SelectionStart = input_text.Text.Length;
        }
        
        private void input_bin_but_Click(object sender, EventArgs e)
        {
            string text = input_text.Text;
            string binary = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    binary += Convert.ToString(text[i], 2) + ' ';
                }
                else
                {
                    if (rus.Checked == true)
                    {
                        binary += "00000" + Convert.ToString(text[i], 2) + ' ';
                    }
                    else
                    {
                        binary += "0" + Convert.ToString(text[i], 2) + ' ';
                    }
                }
            }
            input_binary.Text = binary;
        }

        private void key_text_TextChanged(object sender, EventArgs e)
        {
            //проверка вводимого текста
            string text = key_text.Text; //вытаскиваем текст для проверки
            for (int i = 0; i < key_text.Text.Length; i++)
            {
                if (rus.Checked == true && !rus_string2.Contains(text[i]))
                //не даем ввести все что не входит в контрольные строки
                {
                    key_error.Visible = true;
                    key_text.Text = text.Remove(text.Length - 1);
                }
                if (eng.Checked == true && !eng_string2.Contains(text[i]))
                {
                    key_error.Visible = true;
                    key_text.Text = text.Remove(text.Length - 1);
                }
                
            }
            //переводим каретку в конец (точку старта ввода)
            key_text.SelectionStart = key_text.Text.Length;
        }

        private void key_bin_but_Click(object sender, EventArgs e)
        {
            string text = key_text.Text;
            string binary = "";
            for (int i = 0; i < text.Length; i++)
            {
                binary += Convert.ToString(text[i], 2) + ' ';
            }
            key_binary.Text = binary;
        }

        private void shifr_Click(object sender, EventArgs e)
        {
            if (input_binary.Text != "" && key_binary.Text != "")
            {
                string text = input_binary.Text;
                string key = key_binary.Text;
                string encrypted = "";
                while (key.Length < text.Length)
                {
                    key += key;
                }
                if (key.Length > text.Length)
                {
                    key = key.Substring(0, text.Length);
                }

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != ' ')
                    {
                        encrypted += text[i] ^ key[i];
                    }
                    else
                    {
                        encrypted += ' ';
                    }
                }
                crypt_text.Text = encrypted;
            }
            else
            {
                xor_error.Visible = true;
            }
        }

        private void deshifr2_Click(object sender, EventArgs e)
        {
            if (crypt_text.Text != "" && key_binary.Text != "")
            {
                string text = crypt_text.Text;
                string key = key_binary.Text;
                string decrypted = "";
                string non_binary = "";
                while (key.Length < text.Length)
                {
                    key += key;
                }
                if (key.Length > text.Length)
                {
                    key = key.Substring(0, text.Length);
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != ' ')
                    {
                        decrypted += text[i] ^ key[i];
                    }
                    else
                    {
                        decrypted += ' ';
                    }
                }
                decrypt_text.Text = decrypted;
                if (rus.Checked == true)
                {
                    string[] chars = decrypted.Split(' ');
                    for (int i = 0; i < chars.Length - 1; i ++)
                    {
                        non_binary += Convert.ToChar(Convert.ToInt32(chars[i], 2));
                    }
                }
                else
                {
                    string[] chars = decrypted.Split(' ');
                    for (int i = 0; i < chars.Length - 1; i++)
                    {
                        non_binary += Convert.ToChar(Convert.ToInt32(chars[i], 2));
                    }
                }
                decrypt_nonbin.Text = non_binary;
            }
            else
            {
                decrypt_error.Visible = true;
            }
        }
    }
}
