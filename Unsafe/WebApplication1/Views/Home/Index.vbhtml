@Modeltype mdlTestPageStuff
@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
    <p><a href="http://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

<div class="row">
    <table class="table table-hover">
        <tr><th>test</th><th>result</th></tr>
        @For Each item As NameValuePair In Model.Tests
            @<tr>
                <td>@item.Name</td>
                <td>@item.Value</td>
            </tr>
        Next
    </tableclass>

</div>
