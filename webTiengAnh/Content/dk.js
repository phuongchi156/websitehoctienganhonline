
    $(document).ready(function () {

        $("#form-tryRegist").validate({
            rules: {
                FullNameBabyOne: {
                    required: true
                },
                BirthdayBabyOne: {
                    required: true
                },
                NameParent: {
                    required: true
                },
                Mobile: {
                    required: true,
                    number: true,
                    minlength: 10,
                    maxlength: 11,
                },
                Source: {
                    required: true
                },
            },
            messages: {
                contactname: {
                    required: "Vui l&#242;ng nhập t&#234;n của bạn (*)",
                },
                FullNameBabyOne: {
                    required: "Vui l&#242;ng nhập t&#234;n của bạn"
                },
                BirthdayBabyOne: {
                    required: "Vui l&#242;ng nhập ng&#224;y sinh"
                },
                NameParent: {
                    required: "Vui l&#242;ng nhập t&#234;n bố mẹ"
                },
                Mobile: {
                    required: "Vui l&#242;ng nhập số điện thoại của bạn",
                    number: "Chỉ được nhập số!",
                    minlength: "Số điện thoại c&#243; &#237;t nhất 10 chữ số",
                    minlength: "Số điện thoại c&#243; &#237;t nhất 11 chữ số"
                },

            },
            submitHandler: function () {
                doSendContact();
            },
        });
    });
function doSendContact() {
    var d = $("#form-tryRegist").serialize();
    $("#btnRegister").unbind("click").text("Đang gửi...");
    var url = "/Ajax/ModuleHome/Register";
    $.post(url, d, function (errormessage) {
        if (errormessage == "1") {
            swal("Thành công!", "Cảm ơn bạn đã đăng ký học", "success");
            setInterval(function () {
                window.location.reload();
            }, 5000);
        } else {
            swal("Error!", "error");
            $("#btnRegister").text("Đăng ký");
        }
    }, "json");
}
function centerdetail(id) {
    urldetail = '/Ajax/ModuleHome/LoadDetailCentre?id=' + id;
    $.ajax({
        type: "Get",
        url: urldetail,
        data: { id: id },
        dataType: "text",
        success: function (data) {
            $("#detail-centre").html(data);
            $('#detail-centre').remodal().open();
        }
    })
}