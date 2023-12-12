// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
<script>
    function toggleNavbar() {
        var x = document.querySelector(".navbar");
    if (x.className.indexOf("responsive") === -1) {
        x.className += " responsive";
        } else {
        x.className = x.className.replace(" responsive", ""); }
    }
</script>
