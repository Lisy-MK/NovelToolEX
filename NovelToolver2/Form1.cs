using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NovelToolver2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mainFList.Items.Add("◆選択or新規作成してください");

            //カレントディレクトリ内のフォルダ列挙
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory());
            IEnumerable<System.IO.DirectoryInfo> files =
                    di.EnumerateDirectories("*", System.IO.SearchOption.TopDirectoryOnly);
            //ファイルを列挙する
            foreach (System.IO.DirectoryInfo f in files)
            {
                if(f.Name != "SystemFolder")
                {
                    mainFList.Items.Add(f.Name);
                }
            }

            mainFList.SelectedIndex = 0;

            subFLList.Items.Clear();
            subFLName.Text = "";
            subFLClear.Enabled = false;
            subFLOK.Enabled = false;
            subFLNew.Enabled = false;
            fileLList.Items.Clear();
            fileLName.Text = "";
            fileLClear.Enabled = false;
            fileLEdit.Enabled = false;
            fileLView.Enabled = false;
            fileLSave.Enabled = false;
            boxL.ReadOnly = false;
            boxL.Enabled = false;
            boxL.Text = "";

            subFRList.Items.Clear();
            subFRName.Text = "";
            subFRClear.Enabled = false;
            subFROK.Enabled = false;
            subFRNew.Enabled = false;
            fileRList.Items.Clear();
            fileRName.Text = "";
            fileRClear.Enabled = false;
            fileREdit.Enabled = false;
            fileRView.Enabled = false;
            fileRSave.Enabled = false;
            boxR.ReadOnly = false;
            boxR.Enabled = false;
            boxR.Text = "";

            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory()
                + "/" + "SystemFolder"
                + "/" + "system.txt",
                Encoding.GetEncoding("Shift_JIS"));

            string str = sr.ReadToEnd();

            sr.Close();

            for (int no = 0; no < colorList.Items.Count; no++)
            {
                if (str == colorList.Items[no].ToString())
                {
                    colorList.SelectedIndex = no;
                    break;
                }
            }

        }

        private void MainFClear_Click(object sender, EventArgs e)
        {
            mainFName.Text = "";

            subFLList.Items.Clear();
            subFLName.Text = "";
            subFLClear.Enabled = false;
            subFLOK.Enabled = false;
            subFLNew.Enabled = false;
            fileLList.Items.Clear();
            fileLName.Text = "";
            fileLClear.Enabled = false;
            fileLEdit.Enabled = false;
            fileLView.Enabled = false;
            fileLSave.Enabled = false;
            boxL.ReadOnly = false;
            boxL.Enabled = false;
            boxL.Text = "";

            subFRList.Items.Clear();
            subFRName.Text = "";
            subFRClear.Enabled = false;
            subFROK.Enabled = false;
            subFRNew.Enabled = false;
            fileRList.Items.Clear();
            fileRName.Text = "";
            fileRClear.Enabled = false;
            fileREdit.Enabled = false;
            fileRView.Enabled = false;
            fileRSave.Enabled = false;
            boxR.ReadOnly = false;
            boxR.Enabled = false;
            boxR.Text = "";
        }

        private void MainFOK_Click(object sender, EventArgs e)
        {
            if (mainFList.SelectedIndex != 0)
            {
                subFLList.Items.Clear();
                subFRList.Items.Clear();
                subFLList.Items.Add("◆選択or新規作成してください");
                subFRList.Items.Add("◆選択or新規作成してください");
                subFLList.SelectedIndex = 0;
                subFRList.SelectedIndex = 0;

                mainFName.Text = mainFList.SelectedItem.ToString();

                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory()
                    + "/" + mainFName.Text);
                IEnumerable<System.IO.DirectoryInfo> files =
                    di.EnumerateDirectories("*", System.IO.SearchOption.TopDirectoryOnly);
                //ファイルを列挙する
                foreach (System.IO.DirectoryInfo f in files)
                {
                    subFLList.Items.Add(f.Name);
                    subFRList.Items.Add(f.Name);
                }

                subFLName.Text = "";
                subFLClear.Enabled = true;
                subFLOK.Enabled = true;
                subFLNew.Enabled = true;
                fileLList.Items.Clear();
                fileLName.Text = "";
                fileLClear.Enabled = false;
                fileLEdit.Enabled = false;
                fileLView.Enabled = false;
                fileLSave.Enabled = false;
                boxL.ReadOnly = false;
                boxL.Enabled = false;
                boxL.Text = "";

                subFRName.Text = "";
                subFRClear.Enabled = true;
                subFROK.Enabled = true;
                subFRNew.Enabled = true;
                fileRList.Items.Clear();
                fileRName.Text = "";
                fileRClear.Enabled = false;
                fileREdit.Enabled = false;
                fileRView.Enabled = false;
                fileRSave.Enabled = false;
                boxR.ReadOnly = false;
                boxR.Enabled = false;
                boxR.Text = "";
            }
        }

        private void MainFNew_Click(object sender, EventArgs e)
        {
            if (mainFName.Text != "")
            {
                if (!mainFList.Items.Contains(mainFName.Text))
                {
                    Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory()
                        + "/" + mainFName.Text);
                }

                subFLClear.Enabled = true;
                subFLOK.Enabled = true;
                subFLNew.Enabled = true;
                fileLList.Items.Clear();
                fileLName.Text = "";
                fileLClear.Enabled = false;
                fileLEdit.Enabled = false;
                fileLView.Enabled = false;
                fileLSave.Enabled = false;
                boxL.ReadOnly = false;
                boxL.Enabled = false;
                boxL.Text = "";

                subFRClear.Enabled = true;
                subFROK.Enabled = true;
                subFRNew.Enabled = true;
                fileRList.Items.Clear();
                fileRName.Text = "";
                fileRClear.Enabled = false;
                fileREdit.Enabled = false;
                fileRView.Enabled = false;
                fileRSave.Enabled = false;
                boxR.ReadOnly = false;
                boxR.Enabled = false;
                boxR.Text = "";
            }
        }

        private void SubFLClear_Click(object sender, EventArgs e)
        {
            subFLName.Text = "";

            fileLList.Items.Clear();
            fileLName.Text = "";
            fileLClear.Enabled = false;
            fileLEdit.Enabled = false;
            fileLView.Enabled = false;
            fileLSave.Enabled = false;
            boxL.ReadOnly = false;
            boxL.Enabled = false;
            boxL.Text = "";
        }

        private void SubFLOK_Click(object sender, EventArgs e)
        {
            if(subFLList.SelectedIndex != 0)
            {
                fileLList.Items.Clear();
                fileLList.Items.Add("◆選択or新規作成してください");
                fileLList.SelectedIndex = 0;

                subFLName.Text = subFLList.SelectedItem.ToString();

                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory()
                    + "/" + mainFName.Text
                    + "/" + subFLName.Text);
                IEnumerable<System.IO.FileInfo> files =
                    di.EnumerateFiles("*.txt", System.IO.SearchOption.TopDirectoryOnly);
                //ファイルを列挙する
                foreach (System.IO.FileInfo f in files)
                {
                    int length = f.Name.Length;
                    string str = f.Name.Substring(0, length - 4);

                    fileLList.Items.Add(str);
                }

                fileLName.Text = "";
                fileLClear.Enabled = true;
                fileLEdit.Enabled = true;
                fileLView.Enabled = true;
                fileLSave.Enabled = true;
                boxL.ReadOnly = false;
                boxL.Enabled = true;
                boxL.Text = "";
            }
        }

        private void SubFLNew_Click(object sender, EventArgs e)
        {
            if (subFLName.Text != "")
            {
                if (!subFLList.Items.Contains(subFLName.Text))
                {
                    Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory()
                        + "/" + mainFName.Text
                        + "/" + subFLName.Text);

                    subFLList.Items.Add(subFLName.Text);
                    subFRList.Items.Add(subFLName.Text);
                }

                fileLName.Text = "";
                fileLClear.Enabled = true;
                fileLEdit.Enabled = true;
                fileLView.Enabled = true;
                fileLSave.Enabled = true;
                boxL.ReadOnly = false;
                boxL.Enabled = true;
                boxL.Text = "";
            }
        }

        private void FileLClear_Click(object sender, EventArgs e)
        {
            fileLName.Text = "";

            fileLClear.Enabled = true;
            fileLEdit.Enabled = true;
            fileLView.Enabled = true;
            fileLSave.Enabled = true;
            boxL.ReadOnly = false;
            boxL.Enabled = true;
            boxL.Text = "";
        }

        private void FileLEdit_Click(object sender, EventArgs e)
        {
            if (fileLList.SelectedIndex != 0)
            {
                fileLName.Text = fileLList.SelectedItem.ToString();

                StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory()
                    + "/" + mainFName.Text
                    + "/" + subFLName.Text
                    + "/" + fileLName.Text + ".txt",
                    Encoding.GetEncoding("Shift_JIS"));

                boxL.Text = sr.ReadToEnd();

                sr.Close();

                boxL.ReadOnly = false;
                boxL.Enabled = true;

                if(fileLName.Text == fileRName.Text)
                {
                    boxL.ReadOnly = true;
                }
            }
        }

        private void FileLView_Click(object sender, EventArgs e)
        {
            if (fileLList.SelectedIndex != 0)
            {
                fileLName.Text = fileLList.SelectedItem.ToString();

                StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory()
                    + "/" + mainFName.Text
                    + "/" + subFLName.Text
                    + "/" + fileLName.Text + ".txt",
                    Encoding.GetEncoding("Shift_JIS"));

                boxL.Text = sr.ReadToEnd();

                sr.Close();

                boxL.ReadOnly = true;
                boxL.Enabled = true;
            }
        }

        private void FileLSave()
        {
            // 文字コードを指定
            Encoding enc = Encoding.GetEncoding("Shift_JIS");

            // ファイルを開く
            StreamWriter writer = new StreamWriter(System.IO.Directory.GetCurrentDirectory()
                + "/" + mainFName.Text
                + "/" + subFLName.Text
                + "/" + fileLName.Text + ".txt",
                false,
                enc);

            writer.Write(boxL.Text);

            // ファイルを閉じる
            writer.Close();

            MessageBox.Show("「" + fileLName.Text + "」を「" + mainFName.Text + "」の「" + subFLName.Text + "」に保存しました。",
                "保存完了", MessageBoxButtons.OK);

            if (!fileLList.Items.Contains(fileLName.Text))
            {
                fileLList.Items.Add(fileLName.Text);
                fileRList.Items.Add(fileLName.Text);
            }
        }

        private void FileLSave_Click(object sender, EventArgs e)
        {
            FileLSave();
        }

        private void BoxL_CS(object sender, KeyEventArgs e)
        {
            if(boxL == ActiveControl)
            {
                if (e.KeyData == (Keys.S | Keys.Control))
                {
                    FileLSave();
                }
            }
        }

        private void SubFRClear_Click(object sender, EventArgs e)
        {
            subFRName.Text = "";

            fileRList.Items.Clear();
            fileRName.Text = "";
            fileRClear.Enabled = false;
            fileREdit.Enabled = false;
            fileRView.Enabled = false;
            fileRSave.Enabled = false;
            boxR.ReadOnly = false;
            boxR.Enabled = false;
            boxR.Text = "";
        }

        private void SubFROK_Click(object sender, EventArgs e)
        {
            if (subFRList.SelectedIndex != 0)
            {
                fileRList.Items.Clear();
                fileRList.Items.Add("◆選択or新規作成してください");
                fileRList.SelectedIndex = 0;

                subFRName.Text = subFRList.SelectedItem.ToString();

                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory()
                    + "/" + mainFName.Text
                    + "/" + subFRName.Text);
                IEnumerable<System.IO.FileInfo> files =
                    di.EnumerateFiles("*.txt", System.IO.SearchOption.TopDirectoryOnly);
                //ファイルを列挙する
                foreach (System.IO.FileInfo f in files)
                {
                    int length = f.Name.Length;
                    string str = f.Name.Substring(0, length - 4);

                    fileRList.Items.Add(str);
                }

                fileRName.Text = "";
                fileRClear.Enabled = true;
                fileREdit.Enabled = true;
                fileRView.Enabled = true;
                fileRSave.Enabled = true;
                boxR.ReadOnly = false;
                boxR.Enabled = true;
                boxR.Text = "";
            }
        }

        private void SubFRNew_Click(object sender, EventArgs e)
        {
            if (subFRName.Text != "")
            {
                if (!subFRList.Items.Contains(subFRName.Text))
                {
                    Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory()
                        + "/" + mainFName.Text
                        + "/" + subFRName.Text);

                    subFLList.Items.Add(subFRName.Text);
                    subFRList.Items.Add(subFRName.Text);
                }

                fileRName.Text = "";
                fileRClear.Enabled = true;
                fileREdit.Enabled = true;
                fileRView.Enabled = true;
                fileRSave.Enabled = true;
                boxR.ReadOnly = false;
                boxR.Enabled = true;
                boxR.Text = "";
            }
        }

        private void FileRClear_Click(object sender, EventArgs e)
        {
            fileRName.Text = "";

            fileRClear.Enabled = true;
            fileREdit.Enabled = true;
            fileRView.Enabled = true;
            fileRSave.Enabled = true;
            boxR.ReadOnly = false;
            boxR.Enabled = true;
            boxR.Text = "";
        }

        private void FileREdit_Click(object sender, EventArgs e)
        {
            if (fileRList.SelectedIndex != 0)
            {
                fileRName.Text = fileRList.SelectedItem.ToString();

                StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory()
                    + "/" + mainFName.Text
                    + "/" + subFRName.Text
                    + "/" + fileRName.Text + ".txt",
                    Encoding.GetEncoding("Shift_JIS"));

                boxR.Text = sr.ReadToEnd();

                sr.Close();

                boxR.ReadOnly = false;
                boxR.Enabled = true;

                if (fileLName.Text == fileRName.Text)
                {
                    boxL.ReadOnly = true;
                }
            }
        }

        private void FileRView_Click(object sender, EventArgs e)
        {
            if (fileRList.SelectedIndex != 0)
            {
                fileRName.Text = fileRList.SelectedItem.ToString();

                StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory()
                    + "/" + mainFName.Text
                    + "/" + subFRName.Text
                    + "/" + fileRName.Text + ".txt",
                    Encoding.GetEncoding("Shift_JIS"));

                boxR.Text = sr.ReadToEnd();

                sr.Close();

                boxR.ReadOnly = true;
                boxR.Enabled = true;
            }
        }

        private void FileRSave()
        {
            // 文字コードを指定
            Encoding enc = Encoding.GetEncoding("Shift_JIS");

            // ファイルを開く
            StreamWriter writer = new StreamWriter(System.IO.Directory.GetCurrentDirectory()
                + "/" + mainFName.Text
                + "/" + subFRName.Text
                + "/" + fileRName.Text + ".txt",
                false,
                enc);

            writer.Write(boxR.Text);

            // ファイルを閉じる
            writer.Close();

            MessageBox.Show("「" + fileRName.Text + "」を「" + mainFName.Text + "」の「" + subFRName.Text + "」に保存しました。",
                "保存完了", MessageBoxButtons.OK);

            if (!fileLList.Items.Contains(fileRName.Text))
            {
                fileLList.Items.Add(fileRName.Text);
                fileRList.Items.Add(fileRName.Text);
            }
        }

        private void FileRSave_Click(object sender, EventArgs e)
        {
            FileRSave();
        }

        private void BoxR_CS(object sender, KeyEventArgs e)
        {
            if (boxR == ActiveControl)
            {
                if (e.KeyData == (Keys.S | Keys.Control))
                {
                    FileRSave();
                }
            }
        }

        private void ColorSetUp(string str)
        {
            if (str == "ライト")
            {
                SetColor(Color.White, Color.WhiteSmoke, Color.Black, Color.MediumTurquoise);
            }
            if (str == "ダーク")
            {
                SetColor(Color.Black, Color.DimGray, Color.White, Color.MediumTurquoise);
            }
            if (str == "サクラ")
            {
                SetColor(Color.SeaShell, Color.Snow, Color.Black, Color.LightCoral);
            }
        }

        private void SetColor(Color baseColor, Color areaColor, Color fontColor, Color titleColor)
        {
            this.BackColor = baseColor;

            foreach (Control item in this.Controls)
            {
                item.BackColor = baseColor;
                item.ForeColor = fontColor;
            }

            foreach (Control item in groupBox1.Controls)
            {
                item.BackColor = baseColor;
                item.ForeColor = fontColor;
            }

            foreach (Control item in groupBox2.Controls)
            {
                item.BackColor = baseColor;
                item.ForeColor = fontColor;
            }

            foreach (Control item in groupBox3.Controls)
            {
                item.BackColor = baseColor;
                item.ForeColor = fontColor;
            }

            foreach (Control item in groupBox4.Controls)
            {
                item.BackColor = baseColor;
                item.ForeColor = fontColor;
            }

            foreach (Control item in groupBox5.Controls)
            {
                item.BackColor = baseColor;
                item.ForeColor = fontColor;
            }

            boxL.BackColor = areaColor;
            boxR.BackColor = areaColor;
            title.ForeColor = titleColor;
            version.ForeColor = titleColor;
        }

        private void ColorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = colorList.SelectedItem.ToString();

            ColorSetUp(str);

            // 文字コードを指定
            Encoding enc = Encoding.GetEncoding("Shift_JIS");

            StreamWriter writer = new StreamWriter(System.IO.Directory.GetCurrentDirectory()
                    + "/" + "SystemFolder"
                    + "/" + "system.txt",
                    false,
                    enc);

            writer.Write(str);

            writer.Close();
        }
    }
}
