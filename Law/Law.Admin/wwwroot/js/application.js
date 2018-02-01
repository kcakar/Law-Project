$(function () {
    $(".select2.contributors").select2({
        placeholder: 'Yazar seçin',
        allowClear: true,
        ajax: {
            url: '/Data/Contributors',
            dataType: 'json',
            cache: true
        }
    });

    $(".select2.practices").select2({
        placeholder: 'Uzmanlık alanı seçin',
        allowClear: true,
        ajax: {
            url: '/Data/PracticeAreas',
            dataType: 'json',
            cache: true
        }
    });
    
    $(".select2.countries").select2({
        placeholder: 'Select a country',
        allowClear: true
    });

    $(".select2.countries").on("change", function () {
        if ($(this).val() === "") {
            $(".select2.cities").attr("disabled", true);
        }
        else {
            $(".select2.cities").attr("disabled", false);
            $(".select2.cities").val("");
        }
    });

    let citySelect = $(".select2.cities").select2({
        placeholder: 'Select a city',
        allowClear: true,
        ajax: {
            url: '/Data/Cities',
            dataType: 'json',
            // Additional AJAX parameters go here; see the end of this chapter for the full code of this example
            cache: true,
            data: function (params) {
                var query = {
                    search: params.term,
                    country: $(".select2.countries").val()
                };

                // Query parameters will be ?search=[term]&type=public
                return query;
            }
        }

    });
});