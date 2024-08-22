using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Blazor;
using DevExpress.Persistent.Base;
using System;
namespace Landing_Page.Blazor.Server.Controllers
{
    public partial class BackToLanding : ViewController <DetailView>
    {
        public BackToLanding()
        {
            InitializeComponent();

            var actionLanding = new SimpleAction(this, "Back to Landing", PredefinedCategory.PopupActions);
            actionLanding.Execute += (_, _) =>
            {
                
            };
        }
    }
}
