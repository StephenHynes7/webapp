using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;
namespace WebApplication
{
    public partial class About : Page
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(About));
        protected void Page_Load(object sender, EventArgs e)
        {
            logger.Debug("test");
        }
    }
}