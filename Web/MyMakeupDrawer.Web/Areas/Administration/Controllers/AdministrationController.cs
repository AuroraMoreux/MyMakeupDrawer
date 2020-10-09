namespace MyMakeupDrawer.Web.Areas.Administration.Controllers
{
    using MyMakeupDrawer.Common;
    using MyMakeupDrawer.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
