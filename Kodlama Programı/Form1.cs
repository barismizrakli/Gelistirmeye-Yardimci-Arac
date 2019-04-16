using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodlama_Programı
{
    public partial class Form1 : Form
    {
        private string uzanti = ".zip";
        private int dil; //C# = 0; Python = 1; Visual Basic = 2;
        private string NetAraclar;
        private string dosyaAdi;
        public Form1()
        {

        InitializeComponent();
        }
        private void nyX_Theme1_Click(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (diller.SelectedItem.ToString() == "C# Programlama Dili")
            {
                dil = 0;//C# Seçildi.
                netAraclar_Getir();
            }
        }
        private void netAraclar_Getir()
        {
            araclar.Items.Clear();
            araclar.Items.Add("Button"); 
            araclar.Items.Add("CheckBox");
            araclar.Items.Add("ComboBox");
            araclar.Items.Add("DataGridView");
            araclar.Items.Add("Label");
            araclar.Items.Add("LinkLabel");
            araclar.Items.Add("ListBox");
            araclar.Items.Add("ListView");
            araclar.Items.Add("NumericUpDown");
            araclar.Items.Add("PictureBox");
            araclar.Items.Add("ProgressBar");
            araclar.Items.Add("RadioButton");
            araclar.Items.Add("RichTextBox");
            araclar.Items.Add("TextBox");
            araclar.Items.Add("Timer");
            araclar.Items.Add("TrackBar");
        }

        private void button()
        {
            arac_Ozellikler.Items.Clear();
            arac_Ozellikler.Items.Add("Flat Style");
            arac_Ozellikler.Items.Add("Aktiflik Durumu");
            arac_Ozellikler.Items.Add("Arka Plan Rengi");
            arac_Ozellikler.Items.Add("Yazı Rengi");
        }
        private void araclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (araclar.SelectedItem.ToString() == "Button")
            {
                NetAraclar = araclar.SelectedItem.ToString();
                if (NetAraclar == "Button")
                {
                    button();
                }
            }
            if (araclar.SelectedItem.ToString() =="CheckBox" )
            {
                NetAraclar = araclar.SelectedItem.ToString();

            }
            if (araclar.SelectedItem.ToString() == "ComboBox" )
            {
                NetAraclar = araclar.SelectedItem.ToString();

            }
            if (araclar.SelectedItem.ToString() == "DataGridView")
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() =="Label" )
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() =="LinkLabel" )
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() =="ListBox" )
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() == "ListView")
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() == "NumericUpDown")
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() == "PictureBox")
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() == "ProgressBar")
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() == "RadioButton")
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() =="RichTextBox" )
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() == "TextBox")
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() == "Timer")
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }
            if (araclar.SelectedItem.ToString() =="TrackBar" )
            {
                NetAraclar = araclar.SelectedItem.ToString();
            }

        }
        private void flatgetir()
        {
            ozellikler_ici.Items.Clear();
            ozellikler_ici.Items.Add("Flat");
            ozellikler_ici.Items.Add("Popup");
            ozellikler_ici.Items.Add("Standart");
            ozellikler_ici.Items.Add("System");
        }
        private void aktiflik_getir()
        {
            ozellikler_ici.Items.Clear();
            ozellikler_ici.Items.Add("Aktif");
            ozellikler_ici.Items.Add("DeAktif");
        }
        private void arac_Ozellikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOzellikler();

        }
        
        private void ozellikler_ici_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            flatozellikler();
            button_aktiflik(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void button_aktiflik()
        {
            if (ozellikler_ici.SelectedItem.ToString() == "Aktif")
            {
                console.Text = "button1.Enabled = true;";
            }
            if (ozellikler_ici.SelectedItem.ToString() == "DeAktif")
            {
                console.Text = "button1.Enabled = false;";
            }
        }
        private void flatozellikler()
        {
            if (ozellikler_ici.SelectedItem.ToString() == "Flat")
            {
                console.Text = "button1.FlatStyle = FlatStyle." + ozellikler_ici.SelectedItem.ToString() + ";";
            }
            if (ozellikler_ici.SelectedItem.ToString() == "Popup")
            {
                console.Text = "button1.FlatStyle = FlatStyle." + ozellikler_ici.SelectedItem.ToString() + ";";
            }
            if (ozellikler_ici.SelectedItem.ToString() == "Standart")
            {
                console.Text = "button1.FlatStyle = FlatStyle." + ozellikler_ici.SelectedItem.ToString() + ";";
            }
            if (ozellikler_ici.SelectedItem.ToString() == "System")
            {
                console.Text = "button1.FlatStyle = FlatStyle." + ozellikler_ici.SelectedItem.ToString() + ";";
            }
        }
        private void buttonOzellikler()
        {
            if (arac_Ozellikler.SelectedItem.ToString() == "Flat Style")
            {
                flatgetir();
                
            }//TAMAMLANDI
            if (arac_Ozellikler.SelectedItem.ToString() == "Aktiflik Durumu")
            {
                aktiflik_getir();
                
               
            }
            if (arac_Ozellikler.SelectedItem.ToString() == "Arka Plan Rengi")
            {
            }
            if (arac_Ozellikler.SelectedItem.ToString() == "Yazı Rengi")
            {
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (download_panel.SelectedIndex == 0)
            {
                DownLoadDefault();
                link.Text = "https://github.com/hasfdfasfafs/Developer_Tools/raw/master/C_Sharp_Theme.zip";
                dosyaAdi = "C_Sharp_Theme";
                uzanti = ".zip";
                process_mb.Text = ".CS Uzantılı Temalar";
                islemci_isim.Text = "384KB";
                download_button.Enabled = true;

            }
            if (download_panel.SelectedIndex ==1)
            {
                DownLoadDefault();

                link.Text = "https://github.com/hasfdfasfafs/Developer_Tools/raw/master/Android_Image_Kitchen.zip";
                process_mb.Text = "Android Image Kitchen";
                dosyaAdi = "Android?_Image_Kitchen";
                uzanti = ".zip";
                islemci_isim.Text = "7MB";
                download_button.Enabled = true;

            }
            if (download_panel.SelectedIndex == 2)//TWRP BASE
            {
                DownLoadDefault();

                islemci_isim.FlatStyle = FlatStyle.System;
                islemci_isim.DropDownStyle = ComboBoxStyle.DropDownList;
                process_mb.FlatStyle = FlatStyle.System;
                process_mb.DropDownStyle = ComboBoxStyle.DropDownList;
                islemci_isim.Items.Add("Qualcomm");
                islemci_isim.Items.Add("MediaTek");
                islemci_isim.Items.Add("Exynos");
                islemci_isim.Enabled = true;
                process_mb.Enabled = true;
            }
            if (download_panel.SelectedIndex == 3)

            {
                DownLoadDefault();

                link.Text = "https://github.com/hasfdfasfafs/Developer_Tools/raw/master/C_Sharp_Theme.zip";
            }
            if (download_panel.SelectedIndex == 4)
            {
                DownLoadDefault();
                link.Text = "https://github.com/hasfdfasfafs/Developer_Tools/raw/master/C_Sharp_Theme.zip";
            }
        }
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islemci_isim.SelectedIndex == 0) //QC-MTK-EXY
            {
                process_mb.Items.Clear();
                process_mb.Items.Add("SnapDragon 435");
            }
            if (islemci_isim.SelectedIndex ==1)
            {
                process_mb.Items.Clear();
                process_mb.Items.Add("MT6572");
                process_mb.Items.Add("MT6580");
                process_mb.Items.Add("MT6582");
                process_mb.Items.Add("MT6592");
                process_mb.Items.Add("MT6735");
                process_mb.Items.Add("MT6737");
                process_mb.Items.Add("MT6750");
                process_mb.Items.Add("MT6753");
                process_mb.Items.Add("MT6795");
            }
        }
        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (process_mb.SelectedItem.ToString() == "MT6572")
            {
                link.Text = "https://github.com/hasfdfasfafs/TWRP_Base/raw/master/MediaTek/MT6572/recovery.img";
                dosyaAdi = "MT6572_Recovery";
                uzanti = ".img";
                download_button.Enabled = true;
            }
            if (process_mb.SelectedItem.ToString() == "MT6580")
            {
                link.Text = "https://github.com/hasfdfasfafs/TWRP_Base/raw/master/MediaTek/MT6580/recovery.img";
                dosyaAdi = "MT6580_Recovery";
                uzanti = ".img";
                download_button.Enabled = true;
            }
            if (process_mb.SelectedItem.ToString() == "MT6582")
            {
                link.Text = "https://github.com/hasfdfasfafs/TWRP_Base/raw/master/MediaTek/MT6582/recovery.img";
                dosyaAdi = "MT6582_Recovery";
                uzanti = ".img";
                download_button.Enabled = true;
            }
            if (process_mb.SelectedItem.ToString() == "MT6592")
            {
                link.Text = "https://github.com/hasfdfasfafs/TWRP_Base/raw/master/MediaTek/MT6592/recovery.img";
                dosyaAdi = "MT6592_Recovery";
                uzanti = ".img";
                download_button.Enabled = true;
            }
            if (process_mb.SelectedItem.ToString() == "MT6735")
            {
                link.Text = "https://github.com/hasfdfasfafs/TWRP_Base/raw/master/MediaTek/MT6735/recovery.img";
                dosyaAdi = "MT6735_Recovery";
                uzanti = ".img";
                download_button.Enabled = true;
            }
            if (process_mb.SelectedItem.ToString() == "MT6737")
            {
                link.Text = "https://github.com/hasfdfasfafs/TWRP_Base/raw/master/MediaTek/MT6737/recovery.img";
                dosyaAdi = "MT6737_Recovery";
                uzanti = ".img";
                download_button.Enabled = true;
            }
            if (process_mb.SelectedItem.ToString() == "MT6750")
            {
                link.Text = "https://github.com/hasfdfasfafs/TWRP_Base/raw/master/MediaTek/MT6750/recovery.img";
                dosyaAdi = "MT6750_Recovery";
                uzanti = ".img";
                download_button.Enabled = true;
            }
            if (process_mb.SelectedItem.ToString() == "MT6753")
            {
                link.Text = "https://github.com/hasfdfasfafs/TWRP_Base/raw/master/MediaTek/MT6753/recovery.img";
                dosyaAdi = "MT6753_Recovery";
                uzanti = ".img";
                download_button.Enabled = true;
            }
            if (process_mb.SelectedItem.ToString() == "MT6795")
            {
                link.Text = "https://github.com/hasfdfasfafs/TWRP_Base/raw/master/MediaTek/MT6795/recovery.img";
                dosyaAdi = "MT6795_Recovery";
                uzanti = ".img";
                download_button.Enabled = true;
            }
        }

        private void DownLoadDefault()
        {
            islemci_isim.Enabled = false;
            process_mb.Enabled = false;
            islemci_isim.Items.Clear();
            process_mb.Items.Clear();
            islemci_isim.FlatStyle = FlatStyle.Flat;
            islemci_isim.DropDownStyle = ComboBoxStyle.DropDown;
            process_mb.FlatStyle = FlatStyle.Flat;
            process_mb.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 400);
            nyX_Theme1.Location = new Point(300, 400);

            download_panel.Items.Add("C# Temaları");

            download_panel.Items.Add("Android Image Kitchen'lar");
            download_panel.Items.Add("TWRP Base");
            download_panel.Items.Add("Root - SuperSU");
            download_panel.Items.Add("DLL Fix");
        }





        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        private void Download_button_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileAsync(new Uri(link.Text),Application.StartupPath + @"\\" + dosyaAdi + uzanti);
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            nyX_ProgressBar1.Value = e.ProgressPercentage;
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            console.Text = "İndirme Başarıyla Tamamlandı.";
        }
    }
}
