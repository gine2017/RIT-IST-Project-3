// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#employTable').DataTable({
        responsive: true,
        "pageLength": 10
    });
    $('#coopTable').DataTable({
        responsive: true,
        "pageLength": 10
    });
    var options = {
        useDefaultCSS: false
    }
    $('.facData').slick({
        arrows: true,
        infinite: true,
        speed: 500,
        fade: true,
        cssEase: 'linear'
    });
    $("#undergradAcc").accordion();
    $("#gradAcc").accordion();
    $("#minorAcc").accordion();

});
