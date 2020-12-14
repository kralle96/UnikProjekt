// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Rent slider
$(function () {
    $('.slider').on('input change', function () {
        $(this).next($('.slider_label')).html(this.value);
    });
    $('.slider_label').each(function () {
        var value = $(this).prev().attr('value');
        $(this).html(value);
    });


})






