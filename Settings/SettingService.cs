using Microsoft.AspNetCore.Mvc;

namespace Settings;

public class SettingService
{
    public string ContractorID { get; set; } = "123456";
    public string ContractorName { get; set; } = "Acme";
}