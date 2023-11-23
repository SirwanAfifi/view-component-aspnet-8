using Microsoft.AspNetCore.Mvc;

namespace ViewComponents;

public class SidebarViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string contractorId, string contractorName)
    {
        return View(new { contractorId, contractorName });
    }
}