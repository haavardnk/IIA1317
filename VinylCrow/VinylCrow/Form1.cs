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
            UpdateList(_facade.GetRecordList(), 0);
            listRecord.SetSelected(0, true);
        }

        public void UpdateList(List<Record> list, int selectIndex)
        {
            listRecord.Items.Clear();
            listRecord.BeginUpdate();

            foreach (var record in list)
            {
                listRecord.DisplayMember = "displayTitle";
                listRecord.ValueMember = "recordId";
                listRecord.Items.Add(record);
            }

            listRecord.EndUpdate();
            if (listRecord.Items.Count > 0)
            {
                listRecord.SetSelected(selectIndex, true);
            }
            

        }

        public void UpdateActive(Record record)
        {
            textTitle.Text = record.title.Trim();
            textArtist.Text = record.artist.Trim();
            dateTimeYear.Value = record.year;
            checkLimited.Checked = record.limited;
            checkSigned.Checked = record.signed;
            checkLive.Checked = record.seenLive;
            comboGenre.Text = record.genre.Trim();
            textPressing.Text = record.pressingNumber.Trim();
            comboCondition.Text = record.condition.Trim();
            textColor.Text = record.color.Trim();
            textDescription.Text = record.description.Trim();

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

        public void UpdateRecord(Record record)
        {
            record.title = textTitle.Text;
            record.artist = textArtist.Text;
            record.year = dateTimeYear.Value;
            record.limited = checkLimited.Checked;
            record.signed = checkSigned.Checked;
            record.seenLive = checkLive.Checked;
            record.genre = comboGenre.Text;
            record.pressingNumber = textPressing.Text;
            record.condition = comboCondition.Text;
            record.color = textColor.Text;
            record.description = textDescription.Text;

            _facade.SaveRecord(record);
            var index = listRecord.Items.IndexOf(listRecord.SelectedItem);
            UpdateList(_facade.GetRecordList(), index);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            var record = listRecord.SelectedItem as Record;
            UpdateRecord(record);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _facade.NewRecord();
            UpdateList(_facade.GetRecordList(), 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var record = listRecord.SelectedItem as Record;
            _facade.DeleteRecord(record);
            UpdateList(_facade.GetRecordList(), 0);
        }
    }
}
