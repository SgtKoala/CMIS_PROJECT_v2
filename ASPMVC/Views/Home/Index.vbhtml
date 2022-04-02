
@Code
    ViewData("Title") = "Home Page"



End Code

<!--
@*<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
    <p><a href="https://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>*@

<div class="row">
    @*<div class="col-md-4">
        <h2>Getting started</h2>
        <p>
            ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that
            enables a clean separation of concerns and gives you full control over markup
            for enjoyable, agile development.
        </p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Get more libraries</h2>
        <p>NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.</p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Web Hosting</h2>
        <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p>
        <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
    </div>*@

    <div class="col-md-12">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <th>User ID</th>
                <th>User Name</th>
            </tr>


            @For Each customer In Model
                @<tr>
                    <td>@customer.UserID</td>
                    <td>@customer.UserName</td>
                </tr>
            Next

        </table>

    </div>
</div>

-->



<!--SIDE BAR-->
<div class="sidebar" id="sidebar">
    <a class="active" href="#home">Dashboard</a>
    <a asp-area="" asp-page="/Utilities">Utilities</a>
</div>

<!---CONTENT--->

<div class="content">

    <!---FIRST ROW CARDS--->

    <div class="cards">
        <div class="card">
            <div class="card-content">
                <div class="number">45</div>
                <div class="card-name">Total no. of beds</div>
                <div class="icon-box">
                    <i class="fas fa-user-graduate"></i>
                </div>
            </div>
        </div>

        <div class="card">
            <div class="card-content">
                <div class="number">15</div>
                <div class="card-name">ICU Beds</div>
            </div>
            <div class="icon-box">
                <i class="fas fa-user-graduate"></i>
            </div>
        </div>

        <div class="card">
            <div class="card-content">
                <div class="number">10</div>
                <div class="card-name">Isolation Beds</div>
            </div>
            <div class="icon-box">
                <i class="fas fa-user-graduate"></i>
            </div>
        </div>

        <div class="card">
            <div class="card-content">
                <div class="number">20</div>
                <div class="card-name">Ward Beds</div>
            </div>
            <div class="icon-box">
                <i class="fas fa-user-graduate"></i>
            </div>
        </div>
    </div>

    <!---SECOND ROW CHARTS--->

    <div class="charts">
        <div class="card" id="card-chart1">
            <canvas id="barChart"></canvas>
        </div>

        <div class="card" id="card-chart2">
            <canvas id="pieChart"></canvas>
        </div>
    </div>

    <!----THIRD ROW CHARTS--->

    <div class="charts">
        <div class="card" id="card-chart3">
            <canvas id="doughnutChart"></canvas>
        </div>

        <div class="card" id="card-chart4">
            <canvas id="lineChart"></canvas>
        </div>
    </div>
</div>