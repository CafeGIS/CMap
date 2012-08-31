using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows;
using ESRI.ArcGIS.esriSystem;

namespace CMap
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
        private static LicenseInitializer m_AOLicenseInitializer = new LicenseInitializer();
        public App()
        {
            this.Startup += this.App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            //m_AOLicenseInitializer.InitializeApplication(new esriLicenseProductCode[] { esriLicenseProductCode.esriLicenseProductCodeArcInfo },
            //new esriLicenseExtensionCode[] { esriLicenseExtensionCode.esriLicenseExtensionCodeNetwork, esriLicenseExtensionCode.esriLicenseExtensionCodeSchematics, esriLicenseExtensionCode.esriLicenseExtensionCodeMLE, esriLicenseExtensionCode.esriLicenseExtensionCodeSpatialAnalyst, esriLicenseExtensionCode.esriLicenseExtensionCodeDataInteroperability, esriLicenseExtensionCode.esriLicenseExtensionCodeTracking });
            InitializeEngineLicense();
        }

        private void InitializeEngineLicense()
        {
            AoInitialize aoi = new AoInitializeClass();

            //more license choices could be included here
            esriLicenseProductCode productCode = esriLicenseProductCode.esriLicenseProductCodeEngine;
            if (aoi.IsProductCodeAvailable(productCode) == esriLicenseStatus.esriLicenseAvailable)
            {
                aoi.Initialize(productCode);
            }
        }
	}

}