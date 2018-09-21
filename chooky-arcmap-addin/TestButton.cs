using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace chooky_arcmap_addin
{
    public class TestButton : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public TestButton()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            ArcMap.Application.CurrentTool = null;
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
