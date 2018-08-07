
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
