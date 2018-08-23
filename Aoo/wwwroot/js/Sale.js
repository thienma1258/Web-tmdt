function include(file) {

    var script = document.createElement('script');
    script.src = file;
    script.type = 'text/javascript';
    script.defer = true;

    document.getElementsByTagName('head').item(0).appendChild(script);

}
include('/js/Cookie.js');
include('/js/BillPayment.js');

function CustomerModel(Name, Phone ,CMND) {
    this.Name = Name;
    this.Phone = Phone;
    this.CMND = CMND;
    return this;
}
function SaleOrderModel(TransportTypeID, TransportPriceID, TotalPrice, ReceiveAddress, PaymentMethod, DistrictID)
{
    this.TransportTypeID = TransportTypeID;
    this.TransportPriceID = TransportPriceID;
    this.TotalPrice = TotalPrice;
    this.ReceiveAddress = ReceiveAddress;
    this.PaymentMethod = PaymentMethod;
    this.DistrictID = DistrictID;
    return this;
}
function SaleOrderDetailsModel(ProductDetailIDSale, QuantitySale, PriceSale) {
    this.ProductDetailIDSale = ProductDetailIDSale;
    this.QuantitySale = QuantitySale;
    this.PriceSale = PriceSale;
    return this;
}
function FullParamModel(saleOrder, saleOrderDetails, Customer) {
    this.saleOrder = saleOrder;
    this.saleOrderDetails = saleOrderDetails;
    this.Customer = Customer;
}
function payment(methodPayment) {
    GetFullParam(methodPayment);
}
function GetFullParam(methodPayment) {

    var NameI = document.getElementById("NameCustomer").value;
    var PhoneI = document.getElementById("PhoneCustomer").value;
    var CM = document.getElementById("CMND").value;
    if (NameI == "" || PhoneI == "" || CM == "") {
        return alert("Vui long nhap day du thong tin ca nhan");
    }
    else {
        if (document.getElementById("money") == undefined || document.getElementById("transportPriceID") == undefined || document.getElementById("transportTypeID") == undefined) {
            return alert("Vui long chon dia chi va nha van chuyen");
        }
        else {
            var Total = document.getElementById("money").value;
            var PriceID = document.getElementById("transportPriceID").value;
            var TypeID = document.getElementById("transportTypeID").value;
            var e = document.getElementById("province");
            var Provine = e.options[e.selectedIndex].text;
            var f = document.getElementById("district");
            var District = f.options[f.selectedIndex].text;
            var DistrictID = f.options[f.selectedIndex].value;
            var Adress = document.getElementById("adress").value;
            var fullAdress = Adress + "," + District + "," + Provine;
            var ListItems = JSON.parse(getCookie("ListCartItem"));
            var ListDetails = new Array();
            for (var i = 0; i < ListItems.length; i++) {
                var details = new SaleOrderDetailsModel(
                    ProductDetailIDSale = ListItems[i].ID,
                    QuantitySale = ListItems[i].Quantity,
                    PriceSale = ListItems[i].Price
                );
                ListDetails.push(details);
            }
            var CustomerI = new CustomerModel(
                Name = NameI,
                Phone = PhoneI,
                CMND = CM,
            );
            var saleOrderI = new SaleOrderModel(
                TransportTypeID = TypeID,
                TransportPriceID = PriceID,
                TotalPrice = Total,
                ReceiveAddress = fullAdress,
                PaymentMethod = methodPayment,
                DistrictID = DistrictID

            );
            var ListFullParam = new FullParamModel(
                saleOrder = saleOrderI,
                saleOrderDetails = ListDetails,
                Customer = CustomerI
            );
            var postdata = ListFullParam;
            LoadingScript.loading();
            $.ajax({
                url: '/Bill/GetFullParam',
                type: 'post',
                async: true,
                dataType: 'json',
                contentType: 'application/json',
                success: function (data) {
                    console.log(data);
                    LoadingScript.finish();
                    if (data.errorSaleOrder == "0") {
                        var confirmCode = prompt("nhap vao ma xac nhan");
                        $.ajax({
                            url: '/Bill/ConfirmCode?code=' + confirmCode,
                            type: 'post',
                            async: true,
                            dataType: 'json',
                            contentType: 'application/json',
                            success: function (data) {
                                if (data.issuccess) {
                                    alert("Ban da xac nhan thanh cong vui long thanh toan lai");
                                }
                                alert(data.message);
                            },
                            data: JSON.stringify(postdata)

                        });
                        return;
                    }
                    else if (data.errorSaleOrder == "3") {
                        var httt = alert("Tiep tuc hoan thanh thanh toan ");
                        deleteCookie("ListCartItem");
                        if (!httt) {
                            window.location.replace(data.redirectoURl);
                        }
                    }
                    else {
                        alert(data.message);
                    }
                },
                //error: function () {
                //    alert('Server Paypal is unavailable!');
                //},
                data: JSON.stringify(postdata)
            });
        }
    }
}