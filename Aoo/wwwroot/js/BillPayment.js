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
    html = '<label><span>Tạm tính('+count+' Sản phẩm) ' + TotalPrice + '</span></label>';
    $("#payarea").append(html);
}
function LoadItemBill() {
    var ListItems = JSON.parse(getCookie("ListCartItem"));
    var TotalPrice = 0;
    //$(".items").html('');
    var html2 = '<tr><td><span>Image</span></td><td><span>Model</span></td><td><span>Color</span></td><td><span>Size</span></td><td><span>Quantity</span></td><td><span>Price</span></td></tr >'
    $("#CartTable").html('');
    $("#CartTable").append(html2);
    $('.total').html('');
    var html = "";
    for (var i = 0; i < ListItems.length; i++) {
        html += '<tr>' + '<td>' + '<img src="' + ListItems[i].ImagePath.substring(1, ListItems[i].ImagePath.length) + '">' + '</td>' + '<td>' + '<span>' + ListItems[i].Model + '</span>' + '</td>' + '<td>' + '<span>' + ListItems[i].Color + '</span>' + '</td>' + '<td>' + '<span>' + ListItems[i].CurrentSize + '</span>' + '</td>'
            + '<td>' + '<span>' + ListItems[i].Quantity + '</span>' + "  " + '</td>'
            + '<td>' + '<span>' + ListItems[i].Price * ListItems[i].Quantity + '</span>' + '</td>'
        //html += '<div class="item1">' + '<div class="close1">' + '<div class="alert-close1"> </div>'
        //   + '<div class="image1">' + '<img src="' + ListItems[i].ImagePath.substring(1, ListItems[i].ImagePath.length) + '" alt="item1">' + '</div>' + '<div class="title1">' + '<p>' + ListItems[i].Model + '</p>' + ' </div>'
        //    + '<div class="quantity1">' + '<p>' + ListItems[i].Quantity + '</p>' + '</div>' + '<div>' + '<p>' + ListItems[i].Color + '</p>' + '</div>' + '<div>' + '<p>' + ListItems[i].CurrentSize + '</p>' + '</div>' + '<div class="price1">' + '<p>' + ListItems[i].Price * ListItems[i].Quantity + '</p>' + '<button  onclick=Up("' + ListItems[i].ID + '")>' + "+" + '</button>' + '<button class="UD" value="Sub" onclick=Down("' + ListItems[i].ID +'")>' + "-" + '</button>' + '</div>' + '<div><button onclick=RemoveItem("' + ListItems[i].ID+'")>'+"Remove"+'</button></div>'

        TotalPrice += ListItems[i].Price * ListItems[i].Quantity;
    };
    //$(".items").append(html);
    $("#CartTable").append(html);
    $(".total").append('<div class="total1">Total Price:' + TotalPrice + '</div>');
}

