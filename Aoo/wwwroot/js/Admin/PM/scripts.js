function callback(IsDelete,id) {
    switch (IsDelete) {
        case true:
            DeleteBrand(id);
        case false:
            CloseWindow();
           
    }
}
function CloseWindow() {
    window.close();
}
DeleteConfirm(callback);
function DeleteBrand(id) {
    $.ajax({
        url: 'Delete/'+id,
        data: JSON.stringify({ id: id }), //use id here
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function () {
            window.location.reload();
        },
        type: 'DELETE',
        data: { id: id }
    });
}