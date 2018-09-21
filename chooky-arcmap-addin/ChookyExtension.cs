using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using Common.Logging;

namespace chooky_arcmap_addin
{
    public class ChookyExtension : ESRI.ArcGIS.Desktop.AddIns.Extension
    {
        /// <summary>
        ///     The Log (Common.Logging)
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);


        public ChookyExtension()
        {
        }

        protected override void OnStartup()
        {
            //
            // TODO: Uncomment to start listening to document events
            //
            // WireDocumentEvents();


 




        }

        private void WireDocumentEvents()
        {
            //
            // TODO: Sample document event wiring code. Change as needed
            //

            // Named event handler
            ArcMap.Events.NewDocument += delegate()
            {
                ArcMap_NewDocument();
            };

            // Anonymous event handler
            ArcMap.Events.BeforeCloseDocument += delegate()
            {
                // Return true to stop document from closing
                ESRI.ArcGIS.Framework.IMessageDialog msgBox = new ESRI.ArcGIS.Framework.MessageDialogClass();
                return msgBox.DoModal("BeforeCloseDocument Event", "Abort closing?", "Yes", "No", ArcMap.Application.hWnd);
            };

        }

        void ArcMap_NewDocument()
        {
            // TODO: Handle new document event
        }

    }

}
