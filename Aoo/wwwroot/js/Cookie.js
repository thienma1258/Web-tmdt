function Item(ID,ImagePath, Model, Price, Color, CurrentSize, Quantity) {
    this.ID = ID;
    this.Model = Model;
    this.Price = Price;
    this.Color = Color;
    this.CurrentSize = CurrentSize;
    this.Quantity = Quantity;
    this.ImagePath = ImagePath;
    return this;
}
var key = "ListCartItem";
function setCookie(cname, cvalue, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}
function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}
function IsEmpty(name) {
    if (getCookie(name) == "")
        return null;
}
function AddToCart(imagepath, model, price, color) {
    var e = document.getElementById("currentSize"); 
    
    if (e.childElementCount=="0") {
        alert("Xin Chon Size || Hang Chua Ve");
    }
    else {
        var Id = e.options[e.selectedIndex].value;
        var Size = e.options[e.selectedIndex].text;

        if (getCookie(key) == "") {
            var ListItem = new Array();
            var item = new Item(
                ID = Id,
                ImagePath = imagepath,
                Model = model,
                Price = price,
                Color = color,
                CurrentSize = Size,
                Quantity = 1
            );
            ListItem.push(item);
            setCookie(key, JSON.stringify(ListItem), 60);
            alert("Them Thanh Cong");
            //CartCout();
            //LoadPopup();
            //GiveInfo();
            location.reload();
        }
        else {
            var ListResult = JSON.parse(getCookie(key));
            console.log(ListResult);
            var isExist = false;
            ListResult.forEach(function (e) {
                if (e.ID == Id) {
                    e.Quantity++;
                    isExist = true;
                }
            });
            if (isExist == false) {
                var item = new Item(
                    ID = Id,
                    ImagePath = imagepath,
                    Model = model,
                    Price = price,
                    Color = color,
                    CurrentSize = Size,
                    Quantity = 1
                );
                ListResult.push(item);
                console.log(ListResult);
            }
            setCookie(key, JSON.stringify(ListResult), 60);
            //LoadCartCout();
            alert("Them Moi Thanh Cong");
            //CartCout();
            ////LoadPopup();
            location.reload();
        }
    }
}
function RemoveItem(idCanMove) {
    var ListItems = JSON.parse(getCookie(key));
    for (var i = 0; i < ListItems.length; i++) {
        if (ListItems[i].ID == idCanMove) {
            ListItems.splice(i,1);
        }
    }
    setCookie(key, JSON.stringify(ListItems), 60);
    LoadItem();
    //CartCout();
    location.reload();
}
function LoadItem() {
    var ListItems = JSON.parse(getCookie(key));
    var TotalPrice = 0;
    var html2 = '<tr><td><span>Image</span></td><td><span>Model</span></td><td><span>Color</span></td><td><span>Size</span></td><td><span>Quantity</span></td><td><span>Price</span></td><td><span>Total Price</span></td></tr >'
    $("#CartTable").html('');
    $("#CartTable").append(html2);
    $('.total').html('');
    var html = "";
    for (var i = 0; i < ListItems.length;i++) {
        html += '<tr>' + '<td>' + '<img src="' + ListItems[i].ImagePath.substring(1, ListItems[i].ImagePath.length) + '">' + '</td>' + '<td>' + '<span>' + ListItems[i].Model + '</span>' + '</td>' + '<td>' + '<span>' + ListItems[i].Color + '</span>' + '</td>' + '<td>' + '<span>' + ListItems[i].CurrentSize + '</span>' + '</td>'
            + '<td>' + '<button  onclick=Down("' + ListItems[i].ID + '")>'+"  " + "-" + '</button>'  + '<span>' + ListItems[i].Quantity + '</span>'+"  " + '<button  onclick=Up("' + ListItems[i].ID + '")>' + "+" + '</button>'+ '</td>'
            + '<td>' + '<span>' + (ListItems[i].Price).toLocaleString('it-IT', { style: 'currency', currency: 'VND' }) + '</span>' + '</td>' + '<td>' + '<span>' + ListItems[i].Price*ListItems[i].Quantity + '</span>' + '</td>'+ '<td>' + '<button onclick=RemoveItem("' + ListItems[i].ID+'") > '+"Remove"+'</button >'+'</td>'
        TotalPrice += ListItems[i].Price * ListItems[i].Quantity;
    };
    $("#CartTable").append(html);
    $(".total").append('<div class="total1">Total Price:' + TotalPrice.toLocaleString('it-IT', { style: 'currency', currency: 'VND' }) +'</div>');
}
function Up(idCanUp) {
    var ListItems = JSON.parse(getCookie(key));
    for (var i = 0; i < ListItems.length; i++) {
        if (ListItems[i].ID == idCanUp) {
            ListItems[i].Quantity += 1;
            setCookie(key, JSON.stringify(ListItems), 60);
            LoadItem();
            //CartCout();
            //LoadPopup();
            
        }
    }
    location.reload();
}
function Down(idCanDown) {
    var ListItems = JSON.parse(getCookie(key));
    for (var i = 0; i < ListItems.length; i++) {
        if (ListItems[i].ID == idCanDown) {
            if (ListItems[i].Quantity <1) {
                RemoveItem(idCanDown);
            }
            else {
                ListItems[i].Quantity -= 1;
                setCookie(key, JSON.stringify(ListItems), 60);
                LoadItem();
                //CartCout();
                //LoadPopup(); 
               
            }
        }
    }
    location.reload();
}
function CartCout() {
    var count = 0;
    var html = '';
    $("#count").html('');
    var ListItems = JSON.parse(getCookie("ListCartItem"));
    for (var i = 0; i < ListItems.length; i++) {
        count += ListItems[i].Quantity;
    }
    html = '<span class="cart-num" id="topActionCartNumber" style="display: block;" data-spm-anchor-id="a2o4n.cart.dcart.i0.4f25705bGOvobf">' + count + '</span>';
    $("#count").append(html);
}
function LoadPopup() {
    var ListItems = JSON.parse(getCookie(key));
    var TotalPrice = 0;
    var html2 = '<tr><td><span>Image</span></td><td><span>Model</span></td><td><span>Color</span></td><td><span>Size</span></td><td><span>Quantity</span></td><td><span>Price</span></td><td><span>Total Price</span></td></tr >'
    $("#bodyPopup").html('');
    $("#bodyPopup").append(html2);
    $('.total').html('');
    var html = "";
    for (var i = 0; i < ListItems.length; i++) {
        html += '<tr>' + '<td>' + '<img src="' + ListItems[i].ImagePath.substring(1, ListItems[i].ImagePath.length) + '">' + '</td>' + '<td>' + '<span>' + ListItems[i].Model + '</span>' + '</td>' + '<td>' + '<span>' + ListItems[i].Color + '</span>' + '</td>' + '<td>' + '<span>' + ListItems[i].CurrentSize + '</span>' + '</td>'
            + '<td>' + '<button  onclick=Down("' + ListItems[i].ID + '")>' + "  " + "-" + '</button>' + '<span>' + ListItems[i].Quantity + '</span>' + "  " + '<button  onclick=Up("' + ListItems[i].ID + '")>' + "+" + '</button>' + '</td>'
            + '<td>' + '<span>' + (ListItems[i].Price).toLocaleString('it-IT', { style: 'currency', currency: 'VND' }) + '</span>' + '</td>' + '<td>' + '<span>' + (ListItems[i].Price * ListItems[i].Quantity).toLocaleString('it-IT', { style: 'currency', currency: 'VND' }) + '</span>' + '</td>' + '<td>' + '<button onclick=RemoveItem("' + ListItems[i].ID + '") > ' + "Remove" + '</button >' + '</td>'
        TotalPrice += ListItems[i].Price * ListItems[i].Quantity;
    };
    $("#bodyPopup").append(html);
}

