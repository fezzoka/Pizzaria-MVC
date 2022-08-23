// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//navbar
$(document).ready(function () {
    $('#navbarDropdown').mouseenter(function () {
        $('.dropdown-menu').slideToggle(300, "linear");
    });

    $('.dropdown-menu').mouseleave(function () {
        $(this).slideToggle(300, "linear");
    });
});
//navbar