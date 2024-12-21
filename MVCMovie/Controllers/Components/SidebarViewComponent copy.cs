using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers.Components;

public class SidebarViewComponent : ViewComponent
{
    public Task<IViewComponentResult> InvokeAsync()
    {
        return Task.FromResult((IViewComponentResult)View("Default"));
    }
}