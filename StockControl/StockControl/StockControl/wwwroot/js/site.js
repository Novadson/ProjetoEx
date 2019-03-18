/*Function CpfCnpj*/
var options = {
    onKeyPress: function (cpf, ev, el, op) {
        var masks = ['000.000.000-000', '00.000.000/0000-00'];
        $('.cpfCnpj').mask((cpf.length > 14) ? masks[1] : masks[0], op);
    }
}
$('.cpfCnpj').length > 11 ? $('.cpfCnpj').mask('00.000.000/0000-00', options)
    : $('.cpfCnpj').mask('000.000.000-00#', options);

/*Celular ou Fixo*/

$(document).ready(function () {
    var SPMaskBehavior = function (val) {
        return val.replace(/\D/g, '').length === 11 ? '(00) 00000-0000' : '(00) 0000-00009';
    },
        spOptions = {
            onKeyPress: function (val, e, field, options) {
                field.mask(SPMaskBehavior.apply({}, arguments), options);
            }
        };

    $('.tel').mask(SPMaskBehavior, spOptions);
});

/*Buscar na tabela*/
$(document).ready(function () {
    $("#myInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});
/*Salvar*/
function Confirm() {
    var input = $("<input />");
    input.attr("type", "hidden").attr("name", "confirm_value");
    if (confirm("Deseja salvar esse registro?")) {
        input.val("Yes");
    } else {
        input.val("No");
    }
    $("form")[0].appendChild(input[0]);
}