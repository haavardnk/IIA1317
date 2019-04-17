using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinylCrow
{
    public partial class Form1 : Form
    {
        private Facade _facade = new Facade();
        public Form1()
        {
            InitializeComponent();
            UpdateList(_facade.GetRecordList());
        }

        public void UpdateList(List<Record> list)
        {
            listRecord.BeginUpdate();

            foreach (Record record in list)
            {
                listRecord.DisplayMember = "displayTitle";
                listRecord.ValueMember = "recordId";
                listRecord.Items.Add(record);
            }

            listRecord.EndUpdate();
            listRecord.SetSelected(0, true);
        }

        public void UpdateActive(Record record)
        {
            textTitle.Text = record.title;
            textArtist.Text = record.artist;
            dateTimeYear.Value = record.year;
            checkLimited.Checked = record.limited;
            checkSigned.Checked = record.signed;
            checkLive.Checked = record.seenLive;
            comboGenre.Text = record.genre;
            textPressing.Text = record.pressingNumber;
            comboCondition.Text = record.condition;
            textColor.Text = record.color;
            textDescription.Text = record.description;

            if (record.image != null)
            {
                var ms = new MemoryStream(record.image);
                recordImage.Image = Image.FromStream(ms);
            }
        }

        public void UpdateImage(Record record, string imgLoc)
        {
            byte[] img = null;
            var fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            var br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            record.image = img;

            UpdateActive(record);
        }
        private void listRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            var record = listRecord.SelectedItem as Record;
            UpdateActive(record);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fileDialogImage.ShowDialog();

            var imgLoc = fileDialogImage.FileName.ToString();
            var record = listRecord.SelectedItem as Record;
            UpdateImage(record, imgLoc);
        }
    }
}
