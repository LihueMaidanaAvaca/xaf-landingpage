using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Blazor;
using Microsoft.AspNetCore.Components;

namespace Landing_Page.Blazor.Server.Controllers
{
    public partial class BackToLanding : ViewController<DetailView>
    {
        public BackToLanding()
        {
            InitializeComponent();

            var actionLanding = new SimpleAction(this, "Back to Landing", PredefinedCategory.PopupActions);
            actionLanding.Execute += (s, e) =>
            {
                // Redirije a "/"
                var navigationManager
                = ((BlazorApplication)Application).ServiceProvider.GetRequiredService<NavigationManager>();
                navigationManager.NavigateTo("/", forceLoad: true);
            };
        }
    }
}
