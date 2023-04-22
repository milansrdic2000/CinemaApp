using System;
using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls
{
    public partial class Test : UserControl
    {
        public int Red = 10;
        public int Kolona = 10;
        public Test()
        {

            InitializeComponent();


        }
        private void Test_Load(object sender, EventArgs e)
        {


            try
            {
                dgvSedistePrikaz.Cursor = Cursors.Hand;
                // dgvSedistePrikaz.RowTemplate.DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
                for (int j = 0; j < Kolona; j++)
                {
                    DataGridViewImageColumn column = new DataGridViewImageColumn();
                    column.HeaderText = (j + 1).ToString();
                    column.Name = (j + 1).ToString();
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.FillWeight = Convert.ToInt32(1.0 / Kolona * 100);

                    column.ImageLayout = DataGridViewImageCellLayout.Stretch;


                    Console.WriteLine("Procenat: " + (1.0 / Kolona * 100).ToString());
                    dgvSedistePrikaz.Columns.Add(column);


                }
                for (int i = 0; i < Red; i++)
                {
                    dgvSedistePrikaz.Rows.Add();
                    dgvSedistePrikaz.Rows[i].Height = dgvSedistePrikaz.Columns[0].Width;

                    for (int j = 0; j < Kolona; j++)
                    {
                        DataGridViewCell cell = dgvSedistePrikaz[j, i];
                        dgvSedistePrikaz[j, i].Value = Properties.Resources.sediste;



                    }

                }

                Console.WriteLine("Sirina :" + dgvSedistePrikaz.Columns[0].Width);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dgvSedistePrikaz_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
                DataGridViewCell cell = dgvSedistePrikaz[e.ColumnIndex, e.RowIndex];
                cell.Value = Properties.Resources.sedisteHover;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void dgvSedistePrikaz_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
                DataGridViewCell cell = dgvSedistePrikaz[e.ColumnIndex, e.RowIndex];
                cell.Value = Properties.Resources.sediste;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSedistePrikaz_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }
    }
}
