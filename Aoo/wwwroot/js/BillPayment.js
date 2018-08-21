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
    html = '<label><span>Tạmtính('+count+' Sản phẩm) ' + TotalPrice + '</span></label>';
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
            + '<td>' + '<span>' + (ListItems[i].Price).toLocaleString('it-IT', { style: 'currency', currency: 'VND' }) +'</span>' + '</td>'
    };
    $("#CartTable1").append(html);
}
    function getTotalPrice() {
        var ListItems = JSON.parse(getCookie("ListCartItem"));
    var TotalPrice = 0;
        for (var i = 0; i < ListItems.length; i++) {
        TotalPrice += ListItems[i].Price * ListItems[i].Quantity;
    }
    return TotalPrice;
}
var listProvince;
var listtransportType;
var listtransportPrice;
    (function () {
        $.get('/api/Common/District', function (data) {
            listProvince = data;
        })
    })();

    function myFunction(event) {
            var index = event.target.value;
    var listDistrict = listProvince[index].districts;
    $('#district').html('');
    var html = '';
            for (i in listDistrict) {

        html += '<option class="form-control" value="' + listDistrict[i].districtID + '">' + listDistrict[i].name + '</option>';
    }
    $('#district').append(html);
};
    (function () {
        $.get('/api/Common/Price', function (data) {
            listtransportPrice = data;
            console.log(listtransportPrice);
        })
        $.get('/api/Common/Type', function (data) {
        listtransportType = data;
    console.log(listtransportType);
})
})();
function GetFee() {
    getTotalPrice();
    $('#fee').html('');
    $('#thanhtien').html('');
    $('#delivery').html('');
    var e = document.getElementById("district");
    var IdDis = e.options[e.selectedIndex].value;
    var f = document.getElementById("transport");
    var IdTran = f.options[f.selectedIndex].value;
    var fee = 0;
    for (var i = 0; i < listtransportPrice.length; i++) {
        console.log(IdDis == listtransportPrice[i].districtID);
        if (listtransportPrice[i].districtID == IdDis && listtransportPrice[i].transportTypeID == IdTran) {
            fee = listtransportPrice[i].price;
            for (var j = 0; j < listtransportType.length; j++) {
                if (listtransportType[j].id == IdTran) {
                    $('#delivery').append('<button id="transportTypeID" value="' + listtransportType[j].id + '"disable>NHA VAN CHUYEN: ' + listtransportType[j].name + '</button>');
                }
            }
            $('#fee').append('<button disable id="transportPriceID" value="' + listtransportPrice[i].id + '"> PHÍ GIAO HÀNG: ' + fee.toLocaleString('it-IT', { style: 'currency', currency: 'VND' }) + '</button>');
        }
    }
    if (fee == 0) {
        for (var j = 0; j < listtransportType.length; j++) {
            if (listtransportType[j].id == IdTran) {
                fee = listtransportType[j].price;
                $('#delivery').append('<button id="transportTypeID" value="' + listtransportType[j].id + '"disable>NHA VAN CHUYEN: ' + listtransportType[j].name + '</button>');
                $('#fee').append('<button disable id="transportPriceID" value="' + listtransportType[j].id + '"> PHÍ GIAO HÀNG: ' + fee.toLocaleString('it-IT', { style: 'currency', currency: 'VND' }) + '</button>');
            }
        }
    }
    var total = getTotalPrice() + fee;
    var t = total.toLocaleString('it-IT', { style: 'currency', currency: 'VND' });
    $('#thanhtien').append('<button id="money" value="' + total + '"disable>THÀNH TIỀN: ' + t + '</button>')
};