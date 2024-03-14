// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener('DOMContentLoaded', function () {
    const searchButton = document.querySelector('.search-button-container');
    const registrationButton = document.querySelector('.registration-button');
    const searchBar = document.querySelector('.search-bar');
    const infoButton = document.querySelector('.info-button');

    searchButton.addEventListener('focus', function () {
        this.classList.add('focused');
    });

    searchButton.addEventListener('blur', function () {
        this.classList.remove('focused');
    });

    registrationButton.addEventListener('focus', function () {
        this.classList.add('focused');
        window.location.href = 'pop.up.html';
    });

    registrationButton.addEventListener('blur', function () {
        this.classList.remove('focused');
    });

    searchBar.addEventListener('focus', function () {
        this.classList.add('focused');
    });

    searchBar.addEventListener('blur', function () {
        this.classList.remove('focused');
    });
    infoButton.addEventListener('focus', function () {
        this.classList.add('focused');
    });

    infoButton.addEventListener('blur', function () {
        this.classList.remove('focused');
    });
});
