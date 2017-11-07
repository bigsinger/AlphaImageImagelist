using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;

namespace AlphaImageImagelist
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ImageList imageListAlpha;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
        private Panel panel1;
        private ToolBar toolBar2;
        private ToolBarButton toolBarButton5;
        private ToolBarButton toolBarButton6;
        private ToolBarButton toolBarButton7;
        private ToolBarButton toolBarButton8;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.imageListAlpha = new System.Windows.Forms.ImageList(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolBar2 = new System.Windows.Forms.ToolBar();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListAlpha
            // 
            this.imageListAlpha.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListAlpha.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListAlpha.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolBar1
            // 
            this.toolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton4});
            this.toolBar1.ButtonSize = new System.Drawing.Size(32, 32);
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageListAlpha;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(600, 29);
            this.toolBar1.TabIndex = 0;
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ImageList = this.imageListAlpha;
            this.tabControl1.Location = new System.Drawing.Point(14, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 142);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(496, 115);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(496, 115);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(496, 115);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(496, 115);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Images";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.ImageList = this.imageListAlpha;
            this.tabControl2.Location = new System.Drawing.Point(18, 278);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(504, 245);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(496, 218);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPage1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageListAlpha;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(496, 218);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 156;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(496, 218);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage2";
            this.tabPage6.Visible = false;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 23);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(496, 218);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "tabPage3";
            this.tabPage7.Visible = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 23);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(496, 218);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "tabPage4";
            this.tabPage8.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolBar2);
            this.panel1.Location = new System.Drawing.Point(433, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 259);
            this.panel1.TabIndex = 5;
            // 
            // toolBar2
            // 
            this.toolBar2.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton5,
            this.toolBarButton6,
            this.toolBarButton7,
            this.toolBarButton8});
            this.toolBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBar2.DropDownArrows = true;
            this.toolBar2.ImageList = this.imageListAlpha;
            this.toolBar2.Location = new System.Drawing.Point(0, 0);
            this.toolBar2.Name = "toolBar2";
            this.toolBar2.ShowToolTips = true;
            this.toolBar2.Size = new System.Drawing.Size(63, 50);
            this.toolBar2.TabIndex = 2;
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.Name = "toolBarButton6";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.Name = "toolBarButton7";
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.Name = "toolBarButton8";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(600, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			// These two calls MUST be made before the .Run method to enable 32bit icons to be used.
			Application.EnableVisualStyles();
			Application.DoEvents();

			Application.Run(new Form1());
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			// First we are going to set the ColorDepth property to 32 bit and the ImageSize property of our imageList control.
			// These properties do not have to be set during runtime.
			imageListAlpha.ColorDepth = ColorDepth.Depth32Bit;
			imageListAlpha.ImageSize = new Size(32, 32);

			// Now we will add some images using the built in .Add method provided by the imageListAlpha imageList control
			// We are doing this for demonstration purposes that will compare the images that were added.
			imageListAlpha.Images.Add( Image.FromFile( "folder.ico" ) );
			imageListAlpha.Images.Add( Image.FromFile( "notepad.png" ) );
			imageListAlpha.Images.Add( Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream( "AlphaImageImagelist.ie.ico" ) ) );
			imageListAlpha.Images.Add( Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream( "AlphaImageImagelist.msn.png" ) ) );

			// Now we will use our AddToImagelist class to add these same images to the imageListAlpha imagelist.
			// We will use two methods of loading images with different file formats to give a better example.
			Narbware.Imagelist.AddFromFile( "folder.ico", imageListAlpha );
			Narbware.Imagelist.AddFromFile( "notepad.png", imageListAlpha );
			Narbware.Imagelist.AddEmbeddedResource( "AlphaImageImagelist.ie.ico", imageListAlpha );
			Narbware.Imagelist.AddEmbeddedResource( "AlphaImageImagelist.msn.png", imageListAlpha );
			
			// Now we will assign the first set of images that used the default .Add method to the first toolbar control
			// These images have been corrupt due to the bug that resides in the imagelist control.
			toolBarButton1.ImageIndex = 0;
			toolBarButton2.ImageIndex = 1;
			toolBarButton3.ImageIndex = 2;
			toolBarButton4.ImageIndex = 3;

			// Now we assign the same images that were added using our AddToImagelist class to the second toolbar control
			// These images have not been corrupted and have the correct formatting.
			toolBarButton5.ImageIndex = 4;
			toolBarButton6.ImageIndex = 5;
			toolBarButton7.ImageIndex = 6;
			toolBarButton8.ImageIndex = 7;

			// We simply repeat the same thing as above to the tab control for another example.
			tabPage1.ImageIndex = 0;
			tabPage2.ImageIndex = 1;
			tabPage3.ImageIndex = 2;
			tabPage4.ImageIndex = 3;
			tabPage5.ImageIndex = 4;
			tabPage6.ImageIndex = 5;
			tabPage7.ImageIndex = 6;
			tabPage8.ImageIndex = 7;

			// Populate the listview with files in the windows directory and extract their icon using
			// the .AddIconOfFile() method.
			int nIndex = 8;
			DirectoryInfo di = new DirectoryInfo( Environment.GetFolderPath(Environment.SpecialFolder.System) );
			foreach (FileInfo fi in di.Parent.GetFiles())
			{
				try
				{
					if (nIndex > 100) break;
					Narbware.Imagelist.AddIconOfFile( fi.FullName, Narbware.IconSize.Large, false, false, false, imageListAlpha );
					listView1.Items.Add(fi.Name, nIndex++);
				}
				catch( Exception err )
				{
					Console.WriteLine( err.Message.ToString() );
				}
			}
		}
	}
}
