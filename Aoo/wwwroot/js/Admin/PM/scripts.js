
    function callback(IsDelete, id) {
        switch (IsDelete) {
            case true:
                DeleteBrand(id);
            case false:


        }
    }
    function DeleteBrand(id) {
        $.ajax({
            url: 'Delete/' + id,
            data: JSON.stringify({ id: id }), //use id here
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.success=="true")
                    window.location.reload();
                else
                    alert("Xoa that bai")
            },
            type: 'DELETE',
            data: { id: id }
        });
}
function myFunction() {
  // Declare variables 
  var input, filter, table, tr, th, i;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName("tr");
  
    // Loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
        th = tr[i].getElementsByTagName("th")[0];
        if (th) {
            if (th.innerHTML.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}

