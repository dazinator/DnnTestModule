using System;
using DotNetNuke.Entities.Modules;

namespace DnnTestModule
{
    public partial class Default : PortalModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Page.Title = "I have no respect for page titles";
        }
    }
}