document.addEventListener('DOMContentLoaded', function() {
    const searchButton = document.querySelector('.search-button-container');
    const registrationButton = document.querySelector('.registration-button');
    const searchBar = document.querySelector('.search-bar');

    searchButton.addEventListener('focus', function() {
        this.classList.add('focused');
    });

    searchButton.addEventListener('blur', function() {
        this.classList.remove('focused');
    });

    registrationButton.addEventListener('focus', function() {
        this.classList.add('focused');
    });

    registrationButton.addEventListener('blur', function() {
        this.classList.remove('focused');
    });

    searchBar.addEventListener('focus', function() {
        this.classList.add('focused');
    });

    searchBar.addEventListener('blur', function() {
        this.classList.remove('focused');
    });
});
