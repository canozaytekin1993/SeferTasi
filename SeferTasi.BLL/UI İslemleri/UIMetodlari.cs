using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeferTasi.BLL.UI_İslemleri
{
    public class UIMetodlari
    {
        public void FormuTemizle(Control gbbir, Control gbiki)
        {
            foreach (Control item in gbbir.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
            foreach (Control item in gbiki.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is NumericUpDown)
                    (item as NumericUpDown).Value = 0;
            }
        }
        public void FormuTemizle(Control form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty; //item.Text = "";
                else if (item is ComboBox)
                    (item as ComboBox).SelectedItem = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is RichTextBox)
                    item.Text = string.Empty;
                else if (item is NumericUpDown)
                    (item as NumericUpDown).Value = 0;
            }
        }
        public void YildizlariSil(PictureBox[] yildizlar)
        {
            for (int i = 0; i < yildizlar.Length; i++)
            {
                yildizlar[i].Visible = false;
            }
        }
        public void YildizlariEnFalse(PictureBox[] yildizlar)
        {
            for (int i = 0; i < yildizlar.Length; i++)
            {
                yildizlar[i].Enabled = false;
            }
        }
        public void YildizlariEnTrue(PictureBox[] yildizlar)
        {
            for (int i = 0; i < yildizlar.Length; i++)
            {
                yildizlar[i].Enabled = true;
            }
        }
    }
}
