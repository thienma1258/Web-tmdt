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
            console.log(ListItem);
            setCookie(key, JSON.stringify(ListItem), 60);
            alert("Them Thanh Cong");
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
            alert("Them Moi Thanh Cong");
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
}
function LoadItem() {
    var ListItems = JSON.parse(getCookie(key));
    var TotalPrice = 0;
    $(".items").html('');
    $('.total2').html('');
    var html = "";
    for (var i = 0; i < ListItems.length;i++) {
       
         html += '<div class="item1">' + '<div class="close1">' + '<div class="alert-close1"> </div>'
            + '<div class="image1">' + '<img src="' + ListItems[i].ImagePath.substring(1, ListItems[i].ImagePath.length) + '" alt="item1">' + '</div>' + '<div class="title1">' + '<p>' + ListItems[i].Model + '</p>' + ' </div>'
             + '<div class="quantity1">' + '<p>' + ListItems[i].Quantity + '</p>' + '</div>' + '<div class="price1">' + '<p>' + ListItems[i].Price * ListItems[i].Quantity + '</p>'+'<button>'+"+"+'</button>' + '</div>' + '<div><button onclick=RemoveItem("' + ListItems[i].ID+'")>'+"Remove"+'</button></div>'
     
        TotalPrice += ListItems[i].Price * ListItems[i].Quantity;
    };
    $(".items").append(html);
    $(".total2").append("<p>" + TotalPrice + "</p>");
}

