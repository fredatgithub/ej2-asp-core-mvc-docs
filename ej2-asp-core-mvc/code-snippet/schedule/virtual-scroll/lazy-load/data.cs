public ActionResult Index()
{
    ViewBag.resourcesData = this.GenerateResourceData(1, 1000);
    string[] resources = new string[] { "Resources" };
    ViewBag.Resource = resources;
    return View();
}
private List<ResourceData> GenerateResourceData(int start, int end)
{
    List<ResourceData> resources = new List<ResourceData>(300);
    var colors = new string[] { "#ff8787", "#9775fa", "#748ffc", "#3bc9db", "#69db7c",
    "#fdd835", "#748ffc", "#9775fa", "#df5286", "#7fa900",
    "#fec200", "#5978ee", "#00bdae", "#ea80fc"};
    for (int a = start; a <= end; a++)
    {
        int index = a % colors.Length;
        index = index == 0 ? (colors.Length / a):index;  
        resources.Add(new ResourceData
        {
            Id = a,
            Text = "Resource " + a,
            Color = colors[index]
        });
    }
    return resources;
}

class ResourceData
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string Color { get; set; }
}