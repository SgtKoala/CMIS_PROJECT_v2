<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - DASHBOARD</title>
    <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="~/Content/Site.css" />
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
    
<body>

    @RenderBody()
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.5.0/Chart.min.js"></script>
    <script src="~/Content/lib/jquery/dist/jquery.min.js"></script>
    <script src="~/Content/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
    <script src="~/Scripts/site.js" asp-append-version="true"></script>
    <hr />

    <footer>
    </footer>

    @RenderSection("scripts", required:=False)

        

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/javascript")
    @RenderSection("scripts", required:=False)
</body>
</html>
