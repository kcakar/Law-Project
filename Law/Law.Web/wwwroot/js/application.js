/* Open the sidenav */
function openNav() {
    document.getElementById("mySidenav").style.width = "100%";
}

/* Close/hide the sidenav */
function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}

$(function () {
    $(".select2.contributors").select2({
        placeholder: 'Select a contributor',
        allowClear: true,
        ajax: {
            url: '/Data/Contributors',
            dataType: 'json',
            // Additional AJAX parameters go here; see the end of this chapter for the full code of this example
            cache: true
        }
    });

    $(".select2.countries").select2({
        placeholder: 'Select a country',
        allowClear: true
    });

    $(".select2.affiliates").select2({
        placeholder: 'Select an affiliate',
        allowClear: true
    });

    $(".select2.countries").on("change", function () {
        if ($(this).val() == "") {
            $(".select2.cities").attr("disabled", true);
        }
        else {
            $(".select2.cities").attr("disabled", false);
            $(".select2.cities").val("");
        }
    });

    let citySelect = $(".select2.cities").select2({
        placeholder: 'Select a city',
        allowClear: true,
        ajax: {
            url: '/Data/Cities',
            dataType: 'json',
            // Additional AJAX parameters go here; see the end of this chapter for the full code of this example
            cache: true,
            data: function (params) {
                var query = {
                    q: params.term,
                    country: $(".select2.countries").val()
                }

                // Query parameters will be ?search=[term]&type=public
                return query;
            }
        },

    });

    $(".select2.practices").select2({
        placeholder: 'Select a practice',
        allowClear: true
    });
});


$(function () {

    $("a.cbox").colorbox();

    $('#slider').owlCarousel({
        loop: true,
        dots: false,
        nav: true,
        navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
        autoplay: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            993: {
                items: 3
            },
            1200: {
                items: 4
            }
        }
    });

    $('#authors').owlCarousel({
        loop: true,
        dots: false,
        autoplay: true,
        nav: true,
        navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            993: {
                items: 3
            },
            1200: {
                items: 4
            }
        }
    });

    $(".drop-down-overlay").on("click", function () {
        $.a.closeDropDowns(event);
    });

    $(".content").mCustomScrollbar({
        axis: "y",
        theme: "inset-dark"
    });



    checkStick();

    $(".tabs a").on("click", function () {
        var rel = $(this).attr("data-rel");

        $(".tabs a").removeClass("active");
        $(this).addClass("active");

        $(".tab-content").removeClass("active");
        $("#" + rel).addClass("active");

    });

}).keyup(function (e) {

    if (e.keyCode === 27) {
        $.a.closeDropDowns(event);
    }

    });

$(window).resize(function () {
    checkStick();
});

$(window).scroll(function () {
    checkStick();
});

function checkStick() {
    var windowWidth = $(window).width();
    if (windowWidth > 992) {
        stick();
    }
    else {
        unstick();
    }
}

function stick() {
    var LH = $(".BlogViewLeft").height();
    var RH = $(".BlogViewRight").height();
    if (RH < LH) {
        $(".BlogViewRight").height(LH);
    }

    $(".BlogViewRight-Wrapper").sticky({ topSpacing: 150, bottomSpacing: 300 });
}

function unstick() {
    $(".BlogViewRight").css({ "height": "initial" });
    $('.BlogViewRight-Wrapper').unstick();
}

function share(target) {

    if (target === "facebook") { wpop('http://www.facebook.com/sharer/sharer.php?u=' + window.location.href, 560, 500); }
    else if (target === "twitter") { wpop('http://twitter.com/intent/tweet?url=' + window.location.href, 575, 300); }
    else if (target === "linkedin") { wpop('https://www.linkedin.com/shareArticle?mini=true&url=' + window.location.href, 600, 400); }
    else if (target === "google") { wpop('https://plus.google.com/share?url=' + window.location.href, 400, 550); }

}

function wpop(url, w, h) {

    var SL = window.screenLeft != undefined ? window.screenLeft : screen.left;
    var ST = window.screenTop != undefined ? window.screenTop : screen.top;

    var width = window.innerWidth ? window.innerWidth : document.documentElement.clientWidth ? document.documentElement.clientWidth : screen.width;
    var height = window.innerHeight ? window.innerHeight : document.documentElement.clientHeight ? document.documentElement.clientHeight : screen.height;

    var left = ((width / 2) - (w / 2)) + SL;
    var top = ((height / 2) - (h / 2)) + ST;
    var newWindow = window.open(url, "WPop", 'scrollbars=yes, width=' + w + ', height=' + h + ', top=' + top + ', left=' + left);

    if (window.focus) { newWindow.focus(); }

}
