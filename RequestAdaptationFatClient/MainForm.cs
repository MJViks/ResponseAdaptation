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
      
            CreateForm("Отзывы", DBConnect.bsFeedback);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        
      
            private void CreateForm(string formName, BindingSource bindSource)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Width = 450;
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
            dataGrid.DataSource = bindSource;
            dataGrid.ColumnHeadersHeight = 50;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGrid.SelectionChanged += new EventHandler(SelectCells);
            Button btnSave = new Button();
            btnSave.Parent = childForm;
            btnSave.Height = 30;
            btnSave.Width = 120;
            btnSave.Top = 220;
            btnSave.Left = 20;
            btnSave.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            btnSave.Text = "Сохранить";
            btnSave.Click += new EventHandler(SaveDataTable);

            if (formName == "Клиенты" ||
                formName == "Договоры" ||
                formName == "Сотрудники" || 
                formName == "Заявки" || 
                formName == "Прогруммные продукты клиентов") { 
            Button btnOpenChild = new Button();
            btnOpenChild.Parent = childForm;
            btnOpenChild.Height = 30;
            btnOpenChild.Width = 160;
            btnOpenChild.Top = 220;
            btnOpenChild.Left = 160;
            btnOpenChild.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            btnOpenChild.Text = "Открыть дочерние таблицы";
            btnOpenChild.Click += new EventHandler(OpenChildTable);
            }
            if(formName == "Клиенты")
            {
                Button btnSendMail = new Button();
                btnSendMail.Parent = childForm;
                btnSendMail.Height = 30;
                btnSendMail.Width = 120;
                btnSendMail.Top = 220;
                btnSendMail.Left = 340;
                btnSendMail.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
                btnSendMail.Text = "Рассылка";
                btnSendMail.Click += new EventHandler(btnEmailSendClick);
            }
            childForm.Show();

            DBConnect.FillTableBinding();
        }
        private void btnEmailSendClick(object sender, EventArgs e)
        {
            try
            {
                List<string> ToList = new List<string>();
                if (selCells.Count > 0)
                {
                    for (int i = 0; i < selCells.Count; i++)
                        ToList.Add(selCells[i].Cells[2].Value.ToString());
                    Form EmailForm = new SendEmailForm(ToList);
                    EmailForm.MdiParent = this;
                    EmailForm.Show();
                }
                else
                    MessageBox.Show("Выберете минимум одного клиента!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static DataGridViewSelectedRowCollection selCells;

        private void SelectCells(object sender, EventArgs e)
        {
            selCells = (sender as DataGridView).SelectedRows;
        }

        private void SaveDataTable(object sender, EventArgs e)
        {
            string tableName = (sender as Button).Parent.Text;
            switch (tableName)
            {
                case "Отзывы":
                    DBConnect.UpdateFeedbackAdapter();
                    break;
                case "Сотрудники":
                    DBConnect.UpdateEmployeeAdapter();
                    break;
                case "Аккаунты":
                    DBConnect.UpdateUserAdapter();
                    break;
                case "Клиенты":
                    DBConnect.UpdateClientAdapter();
                    break;
                case "Договоры":
                    DBConnect.UpdateContractAdapter();
                    break;
                case "Заявки":
                    DBConnect.UpdateRequestAdapter();
                    break;
                case "Программные продукты":
                    DBConnect.UpdateSoftwareAdapter();
                    break;
                case "Программные продукты клиентов":
                    DBConnect.UpdateSoftwareClientAdapter();
                    break;
            }
            DBConnect.FillTableBinding();
        }

        private void OpenChildTable(object sender, EventArgs e)
        {
            string tableName = (sender as Button).Parent.Text;
            switch (tableName)
            {
                case "Сотрудники":
                    CreateForm("Аккаунты", DBConnect.bsUser);
                    break;
                case "Клиенты":
                    CreateForm("Аккаунты", DBConnect.bsUser);
                    break;
                case "Договоры":
                    CreateForm("Сотрудники", DBConnect.bsEmployee);
                    CreateForm("Клиенты", DBConnect.bsClient);
                    break;
                case "Заявки":
                    CreateForm("Клиенты", DBConnect.bsClient);
                    break;
                case "Программные продукты клиентов":
                    CreateForm("Клиенты", DBConnect.bsClient);
                    CreateForm("Программные продукты", DBConnect.bsSoftware);
                    break;
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm("Сотрудники", DBConnect.bsEmployee);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm("Аккаунты", DBConnect.bsUser);
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm("Клиенты", DBConnect.bsClient);
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm("Договоры", DBConnect.bsContract);
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm("Заявки", DBConnect.bsRequest);
        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm("Программные продукты", DBConnect.bsSoftware);
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void softwareClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm("Программные продукты клиентов", DBConnect.bsSoftwareClient);

        }

        
    }

}
