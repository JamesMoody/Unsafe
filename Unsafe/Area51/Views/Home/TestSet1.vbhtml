@Code
    ViewData("Title") = "TestSet1"
End Code

<script type="text/javascript">

    function doTest1(data) {

        $.get('/TestSet1/TestId', { testItem: data })
          .done(function () { alert(":)"); })
          .fail(function () { alert(":("); });
    }

    function doTest2(data) {
        var url = '/TestSet1/TestRawQS?testItem=' + data;

        $.get(url)
          .done(function () { alert(":)"); })
          .fail(function () { alert(":("); });
    }

</script>

<div class="row">
    <div class="col-md-6">
        <h3>Test 1</h3>
        <ul>
            <li><a href="javascript:doTest1(1234);">Good Number Test</a></li>
            <li><a href="javascript:doTest1(-1234);">Bad Number Test</a></li>
        </ul>
    </div>
    <div class="col-md-6">
        <h3>Test 2</h3>
        <ul>
            <li><a href="javascript:doTest2(1234);">Good Number Test</a></li>
            <li><a href="javascript:doTest2(-1234);">Bad Number Test</a></li>
        </ul>
    </div>
</div>

