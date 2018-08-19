function include(file) {

    var script = document.createElement('script');
    script.src = file;
    script.type = 'text/javascript';
    script.defer = true;

    document.getElementsByTagName('head').item(0).appendChild(script);

}
include('/js/Cookie.js');
function GiveInfo() {
    var ListResult = JSON.parse(getCookie("ListCartItem"));
    var html = "";
    $("#payarea").html('');
    var count = 0;
    var TotalPrice = 0;
    var ListModel = null;
    for (var i = 0; i < ListResult.length; i++) {
        TotalPrice += ListResult[i].Quantity * ListResult[i].Price;
        count += ListResult[i].Quantity;
    }
    var t = TotalPrice.toLocaleString('it-IT', { style: 'currency', currency: 'VND' });
    html = '<label><span>Tạm tính(' + count + ' Sản phẩm): ' + t + '</span></label>';
    $("#payarea").append(html);
}
function LoadItemBill() {
    var ListItems = JSON.parse(getCookie("ListCartItem"));
    var TotalPrice = 0;
    var html2 = '<tr><td><span>Image</span></td><td><span>Model</span></td><td><span>Color</span></td><td><span>Size</span></td><td><span>Quantity</span></td><td><span>Price</span></td></tr >'
    $("#CartTable1").html('');
    $("#CartTable1").append(html2);
    $('.total').html('');
    var html = "";
    for (var i = 0; i < ListItems.length; i++) {
        html += '<tr>' + '<td>' + '<img src="' + ListItems[i].ImagePath.substring(1, ListItems[i].ImagePath.length) + '">' + '</td>' + '<td>' + '<span>' + ListItems[i].Model + '</span>' + '</td>' + '<td>' + '<span>' + ListItems[i].Color + '</span>' + '</td>' + '<td>' + '<span>' + ListItems[i].CurrentSize + '</span>' + '</td>'
            + '<td>' + '<span>' + ListItems[i].Quantity + '</span>' + "  " + '</td>'
            + '<td>' + '<span>' + ListItems[i].Price +'</span>' + '</td>'
        TotalPrice += ListItems[i].Price * ListItems[i].Quantity;
    };
    $("#CartTable1").append(html);
    $(".total").append('<div class="total1">Total Price:' + TotalPrice + '</div>');
}
