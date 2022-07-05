// Write your JavaScript code.
    $("#TestObjekt").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        alert(value);
    });

    $('#myStateButton').on('click', function () {
        $(this).button('complete') // button text will be "finished!"
    })

$('#myButton').on('click', function () {
    var $btn = $(this).button('loading')
    // business logic...
    $btn.button('reset')
})