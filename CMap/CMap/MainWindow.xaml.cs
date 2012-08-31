using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ESRI.ArcGIS.Controls;
using System.Windows.Forms;

namespace CMap
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        private AxMapControl mapControl;
		public MainWindow()
		{
			this.InitializeComponent();
            CreateMapControl();
            SetMapProperties();
            
			// Insert code required on object creation below this point.
		}

        private void CreateMapControl()
        {
            mapControl = new AxMapControl();
            mapHost.Child = mapControl;
        }

        private void SetMapProperties()
        {
            //Set the properties of AxMapControl.
            mapControl.Dock = DockStyle.Fill;
            //mapControl.BackColor = Color.FromRgb(15, 15, 15);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetMapProperties();
            WireMapEvents();

            // Specify your .mxd file here.
            mapControl.LoadMxFile(
              "C:\\Program Files\\ArcGIS\\DeveloperKit\\SamplesNET\\data\\GulfOfStLawrence\\Gulf_of_St._Lawrence.mxd");
            System.Windows.MessageBox.Show("add");
        }

        private void WireMapEvents()
        {
            mapControl.OnMouseMove += new IMapControlEvents2_Ax_OnMouseMoveEventHandler
              (mapControl_OnMouseMove);
        }

        private void mapControl_OnMouseMove(object sender,
          IMapControlEvents2_OnMouseMoveEvent e)
        {
            System.Console.WriteLine(e.mapX.ToString());
            System.Windows.MessageBox.Show(e.mapX.ToString());
        }
	}
}