   var kt = {
        init: function () {
            kt.regEvents();;
        },
        regEvents: function () {
            $('#btnkt').off('click').on('click', function () {
                var txt1 = $('#nghia1').val();
                var txt2 = $('#nghia2').val();
                $.ajax({
                    url: '/BaiHoc/KiemTraNghia',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        txt1: txt1,
                        txt2: txt2,
                    },
                    success: function (res) {
                        if (res.status == true) {
                            window.alert('Bạn đã làm đúng rồi!!');
                        }
                        else
                            window.alert('Sai rồi thử lại đi nào!!');
                    }
                });
            });
        },
    }
    kt.init();

