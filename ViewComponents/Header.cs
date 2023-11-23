using Microsoft.AspNetCore.Mvc;
using Settings;

namespace ViewComponents;

public class HeaderViewComponent : ViewComponent
{
    private readonly SettingService _service;
    public HeaderViewComponent(SettingService service)
    {
        _service = service;
    }
    public IViewComponentResult Invoke()
    {
        var contractorId = _service.ContractorID;
        var contractorName = _service.ContractorName;
        // ViewBag.ContractorId = contractorId;
        return View(new { contractorId, contractorName });
    }
}