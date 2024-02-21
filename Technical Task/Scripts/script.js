$(document).ready(function () {
    $('#addTextBoxBtn').click(function () {
        var count = $('#textBoxCount').val();
        $.post('@Url.Action("GenerateTextBoxes", "Home")', { count: count }, function (data) {
            $('#textBoxContainer').html(data);
        });
    });

    $(document).on('change', '.checkbox', function () {
        var textBoxes = $('.checkbox').map(function () {
            return { Id: $(this).data('id'), IsSelected: $(this).is(':checked') };
        }).get();
        $.post('@Url.Action("CalculateTotalSelected", "Home")', { textBoxes: textBoxes }, function (data) {
            $('#totalSelectedContainer').html(data);
        });
    });
});
