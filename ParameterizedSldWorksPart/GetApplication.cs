using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedSldWorksPart
{
    internal class GetApplication
    {
        private static SldWorks swApp;

        public GetApplication()
        {

        }

        internal static SldWorks GetSwApp()
        {
            if(swApp == null)
            {
                swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application")) as SldWorks;
                swApp.Visible = true;
            }
            return swApp;
        }
    }
}
