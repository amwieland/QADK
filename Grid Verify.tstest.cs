using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TFS_Project
{

    public class Grid_Verify : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        //[CodedStep(@"Verify 'TextContent' 'Contains' 'abc' on 'AbcTableCell' - DataDriven: [$(CreatedBy)]")]
        //public void Grid_Verify_CodedStep()
        //{
            //// Verify 'TextContent' 'Contains' 'abc' on 'AbcTableCell'
            //Pages.TelerikCustomerRelations0.AbcTableCell.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, ((string)(System.Convert.ChangeType(Data["CreatedBy"], typeof(string)))));
        //}
    }
}
