$(document).ready(function () {
    $(".content").hide();
    $(".button").on("click", function () {
        var txt = $(".content").is(':visible') ? 'Read More' : 'Read Less';
        $(this).text(txt);
        $(this).prev("div").slideToggle(200);
    });
});