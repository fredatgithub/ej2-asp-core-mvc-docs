public IActionResult Index()
{
    var Order = InventoryDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    return View();
} 