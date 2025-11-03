using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace testForms.pkgInterfaz
{
    public class placeHolderBox : TextBox
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        private string placeHolder;
        public string PlaceHolder
        {
            get { return placeHolder; }
            set
            {
                placeHolder = value;
                UpdatePlaceholder();
            }
        }

        public placeHolderBox()
        {
            this.MinimumSize = new Size(250, 10);
            this.AutoSize = false;
            this.Padding = new Padding(0, 120, 0, 0);
        }


        private void UpdatePlaceholder()
        {
            if (IsHandleCreated && !string.IsNullOrEmpty(placeHolder))
            {
                SendMessage(this.Handle, EM_SETCUEBANNER, 0, placeHolder);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdatePlaceholder();
        }
    }
}
