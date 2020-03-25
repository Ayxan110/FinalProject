$(document).ready(function () {
        $(".mini-img").click(function () {
            let srcc = $(this).children().attr('src');
            $(".main-img").children().attr('src', srcc);
        })
    });
