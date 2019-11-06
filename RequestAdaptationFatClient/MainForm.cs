using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestAdaptationFatClient
{

    public partial class MainForm : Form
    {

        public static string Role = String.Empty, Login = String.Empty;


        public MainForm()
        {
            InitializeComponent();
        }


        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

       

        private void MainForm_Shown(object sender, EventArgs e)
        {
            AuthorizFormShow();
        }

        private void AuthorizFormShow()
        {
            Form Auth = new Authorization();
            Auth.Show();
        }

        private void AuthorizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizFormShow();
        }

        private void FeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            CreateForm("Отзывы", DBConnect.dtFeedback);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

    

        private void CreateForm(string formName, DataTable table)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Width = 400;
            childForm.Height = 300;
            childForm.Text = formName;

            DataGridView dataGrid = new DataGridView();
            dataGrid.Parent = childForm;
            dataGrid.Top = 0;
            dataGrid.Left = 0;
            dataGrid.Width = 388;
            dataGrid.Height = 200;
            dataGrid.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));

            DataTable tempDataTable = new DataTable();
            tempDataTable.Load(table.CreateDataReader());

            dataGrid.DataSource = tempDataTable;
            dataGrid.ColumnHeadersHeight = 50;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Button btnSave = new Button();
            btnSave.Parent = childForm;
            btnSave.Height = 30;
            btnSave.Width = 120;
            btnSave.Top = 220;
            btnSave.Left = 20;

            btnSave.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            btnSave.Text = "Сохранить";
            btnSave.Click += new EventHandler(SaveDataTable);

            childForm.Show();
        }
        private void SaveDataTable(object sender, EventArgs e)
        {
            var button = sender as Button;
            var dataGrid = button.Parent.GetChildAtPoint(new Point(1, 1)) as DataGridView;
            DataTable dt = (DataTable)dataGrid.DataSource;
            switch (button.Parent.Text)
            {
                case "Отзывы":
                    DataTable trueTable = DBConnect.dtFeedback;
                    DBConnect.ClearTable("Feedback");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DBActions.Feedback_Insert(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());
                    }
                    DBConnect.FillAllTable();



                    break;
                case "Сотрудники":

                    break;
                case "Аккаунты":

                    break;
                case "Клиенты":

                    break;
                case "Договоры":

                    break;
                case "Заявки":

                    break;
                case "Программные продукты":

                    break;
                case "Прогруммные продукты клиентов":

                    break;
            }
        }

       

        private void chBetweenTable(DataTable D1, DataTable D2, EventArgs e)
        {
            if (D1 != D2)
            {
                for (int i = 0; i < D1.Rows.Count; i++)
                {
                    if (D1.Rows[i] != D2.Rows[i])
                    {

                    }
                } 
            }
        }
    }

}
