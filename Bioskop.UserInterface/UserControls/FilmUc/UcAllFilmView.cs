using System;
using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls.FilmUc
{
    public partial class UcAllFilmView : UserControl
    {
        public UcAllFilmView()
        {
            InitializeComponent();

        }

        private void UcFilmViewAll_Load(object sender, EventArgs e)
        {

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvFilmoviLista_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            /*//Convert the image to icon, in order to load it in the row header column
            Bitmap myBitmap = new Bitmap(Properties.Resources.zauzetoSediste);
            Icon myIcon = Icon.FromHandle(myBitmap.GetHicon());

            Graphics graphics = e.Graphics;

            //Set Image dimension - User's choice
            int iconHeight = 30;
            int iconWidth = 30;

            //Set x/y position - As the center of the RowHeaderCell
            int xPosition = e.RowBounds.X + (dgvFilmoviLista.RowHeadersWidth / 2);
            int yPosition = e.RowBounds.Y +
            ((dgvFilmoviLista.Rows[e.RowIndex].Height - iconHeight) / 2);

            Rectangle rectangle = new Rectangle(xPosition, yPosition, iconWidth, iconHeight);
            graphics.DrawIcon(myIcon, rectangle);*/

        }
    }
}
