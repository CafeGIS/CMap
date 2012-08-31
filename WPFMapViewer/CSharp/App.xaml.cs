// Copyright 2008 ESRI
// 
// All rights reserved under the copyright laws of the United States
// and applicable international laws, treaties, and conventions.
// 
// You may freely redistribute and use this sample code, with or
// without modification, provided you include the original copyright
// notice and use restrictions.
// 
// See use restrictions at <your ArcGIS install location>/developerkit/userestrictions.txt.
// 

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using ESRI.ArcGIS.esriSystem;

namespace WPFMapViewer
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App: Application
	{
		public App ()
		{
			InitializeEngineLicense ();
		}

		private void InitializeEngineLicense ()
		{
			AoInitialize aoi = new AoInitializeClass ();

			//more license choices could be included here
			esriLicenseProductCode productCode = esriLicenseProductCode.esriLicenseProductCodeEngine;
			if (aoi.IsProductCodeAvailable (productCode) == esriLicenseStatus.esriLicenseAvailable)
			{
				aoi.Initialize (productCode);
			}
		}
	}
}
