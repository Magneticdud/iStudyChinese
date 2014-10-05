using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
using WaveLib;
using Yeti.MMedia;
using Yeti.MMedia.Mp3;
using System.IO;

namespace iStudyChinese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class globali
        {
            public static string datiimi = "", datipinyin = "", datihanzi = "";
            public static string percorso = ("d:\\Supermemo\\systems\\Cinese\\flash\\");
            public static string extfile = (".wav");
            public static int numerofile = 1;
            public static int numerofile2 = 1;
            public static int maxgen = 128;
            public static string flash1 = ("<embed src=\"/Supermemo/systems/Cinese/flash/");
            public static string flash2 = (".mp3\" width=\"50\" height=\"20\" autostart=\"true\" loop=\"false\"  controller=\"true\" ></embed>");
            public static string flash3 = ("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //globali.percorso = Environment.GetEnvironmentVariable("supermemo");
            //globali.percorso += ("\\");
        }

        private void buttoncsharp_Click(object sender, EventArgs e)
        {
            globali.datiimi += ("\"" + textBoximi.Text + "\" , ");
            globali.datipinyin += ("\"" + textBoxpinyin.Text + "\" , ");
            globali.datihanzi += ("\"" + textBoxhanzi.Text + "\" , ");
            textBoxcsharp.Text = ("Significati:\n\n" + globali.datiimi + "\n\n\nPinyin:\n\n" + globali.datipinyin + "\n\n\nHanzi:\n\n" + globali.datihanzi);
            textBoxcsharp.SelectAll();
            textBoxcsharp.Copy();
            textBoxcsharp.DeselectAll();
        }

        private void buttonhtml_Click(object sender, EventArgs e)
        {
            textBoxhtml.Text = ("");
            string hex = unicodifica();
            sintetizza();
            textBoxhtml.Text = (globali.flash1 + hex + globali.flash2);
            textBoxhtml.SelectAll();
            textBoxhtml.Copy();
            textBoxhtml.DeselectAll();
        }

        // istanza di SpVoice
        protected SpVoice voce = new SpVoice();
        private void sintetizza()
        {
            string hex = unicodifica();
            string nomefile = globali.percorso + hex + globali.extfile;
            string nomefilemp3 = (globali.percorso + hex + ".mp3");
            SpFileStream miofile = null;
        //    try
        //    {
                if (radioButtonmaschio.Checked)
                    voce.Voice = voce.GetVoices("", "").Item(3);
                else
                    voce.Voice = voce.GetVoices("", "").Item(2);
                if (radioButtonfemmina2.Checked)
                    voce.Voice = voce.GetVoices("", "").Item(1);
                voce.Rate = -5;
                miofile = new SpFileStream();
                miofile.Open(@nomefile, SpeechStreamFileMode.SSFMCreateForWrite, false);
                voce.AudioOutputStream = miofile;
                voce.Speak(textBoxhanzi.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        //    }
        //    finally
        //    {
                if (miofile != null)
                {
                    miofile.Close();
                    mp3izza(nomefile, nomefilemp3);
                }
        //    }
        }

        private string unicodifica()
        {
            Encoding unicode = Encoding.Unicode;
            string unicodeString = textBoxhanzi.Text;
            // Convert the string into a byte[].
            byte[] unicodeBytes = unicode.GetBytes(unicodeString);
            string hex = BitConverter.ToString(unicodeBytes);
            hex = hex.Replace("-", "");
            hex = hex.ToLower();
            return hex;
        }
        private static void mp3izza(string nomefile, string nomefilemp3)
        {
            WaveStream filewav = new WaveStream(nomefile);
      //      try
      //      {
                Mp3Writer salvamp3 = new Mp3Writer(new FileStream(nomefilemp3,
                                                    FileMode.Create), filewav.Format);
      //          try
      //          {
                    byte[] buff = new byte[salvamp3.OptimalBufferSize];
                    int read = 0;
                    while ((read = filewav.Read(buff, 0, buff.Length)) > 0)
                    {
                        salvamp3.Write(buff, 0, read);
                    }
       //         }
       //         finally
       //         {
                    salvamp3.Close();
       //         }
       //     }
       //     finally
       //     {
                filewav.Close();
       //     }
            File.Delete(nomefile);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            globali.datiimi = "";
            globali.datipinyin = "";
            globali.datihanzi = "";
            textBoxcsharp.Text = "";
        }

        private void textBoximi_Enter(object sender, EventArgs e)
        {
            string CName = "";
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                CName = lang.Culture.EnglishName.ToString();
                CName = lang.LayoutName.ToString();

                if (CName.StartsWith("中文"))
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }

        private void textBoxpinyin_Enter(object sender, EventArgs e)
        {
            string CName = "";
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                CName = lang.Culture.EnglishName.ToString();
                CName = lang.LayoutName.ToString();

                if (CName.StartsWith("Pinyinput"))
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }

        private void textBoxhanzi_Enter(object sender, EventArgs e)
        {
            string CName = "";
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                CName = lang.Culture.EnglishName.ToString();
                CName = lang.LayoutName.ToString();

                if (CName.StartsWith("中文"))
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }
    }
}
