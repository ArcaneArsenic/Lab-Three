/* UserInterface.cs
 * Author: Rod Howell
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// A GUI for a simple text editor.
    /// </summary>
    public partial class UserInterface : Form
    {
        string fileName;
        Exception error;
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            fileName = "";
           // error = null;
        }

        /// <summary>
        /// displays an error message
        /// </summary>
        /// <param name="ex"></param>
        private void errorHandler(Exception ex)
        {
            error = ex;
            MessageBox.Show("The following error occured: " + Convert.ToString(error.InnerException));
        }

        /// <summary>
        /// Handles a Click event on the "Open . . ." file menu item.g
        /// display file contents in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    File.ReadAllText(fileName);
                    uxEditBuffer.Text = fileName;
                }
            }
            catch { errorHandler(error); }
         
            
        }

        /// <summary>
        /// Handles a Click event on the "Save As . . ." file menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.ReadAllText(fileName);
                    fileName.Replace("",uxEditBuffer.Text);
                }
            }
            catch { errorHandler(error); }
        }
        
    }
}
