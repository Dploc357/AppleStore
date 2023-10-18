$(document).ready(function () {
    $('.btn-plus').click(function () {
        var varValue = $(this).parent().find('.var-value');
        var val = parseInt(varValue.text());
        val++;
        varValue.text(val); // Sử dụng .text(val) thay vì .html(val)
        return false;
    });

    $('.btn-minus').click(function () {
        var varValue = $(this).parent().find('.var-value');
        var val = parseInt(varValue.text());
        val = (val === 1) ? 1 : val - 1;
        varValue.text(val); // Sử dụng .text(val) thay vì .html(val)
        return false;
    });
    function closePopup() {
        var popupContainer = document.querySelector(".popup-container");
        popupContainer.style.display = "none";
    }
});
