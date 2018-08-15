function validateEmail(email) {
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}
$(document).ready(function () {
    $('#SUBSCRIBEEMAIL').click(function () {
        var Email = $('#EmailValue').val();
        if (Email === "") {
            alert("Mời bạn nhập Email");
        }
        else if (!validateEmail(Email)) {
            alert("Định dạnh Email không đúng");
        }
        else {
            var postdata = {
                "Email": Email
            };

            $.ajax({
                url: 'api/Common/SubscribeEmail',
                type: 'post',
                dataType: 'json',
                contentType: 'application/json',
                success: function (data) {
                    console.log(data)
                    if (data.success==="true")
                        alert("Bạn đã đăng ký nhận email thành công");
                    else
                        alert(data.message);
                },
                data: JSON.stringify(postdata)
            });
          
        }
    });

});