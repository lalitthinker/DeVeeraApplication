
var table = new Tabulator("#tabulator1",
    {
        index: "id",
        layout: "fitColumns",
        responsiveLayout: "collapse",
        pagination: "local",
        paginationSize: 10,
        paginationSizeSelector: [10, 20, 30, 40,50,60],
        columns: [
            {
                formatter: "responsiveCollapse",
            },
            { title: "#", field: "LevelNo", headerSort: false, width: 50 /*formatter: "rownum" */},
            { title: "Title", field: "Title", sorter: "string", width: 250 },
            { title: "Subtitle", field: "Subtitle", sorter: "string", width: 250 },
            { title: "VideoName", field: "VideoName", sorter: "string", width: 240 },
            //{ title: "Like", field: "LikeId", sorter: "string", width: 85 },
            //{ title: "Dislike", field: "DisLikeId", sorter: "string", width: 100 },
            { title: "Edit", field: "", hozAlign: "center", width: 85, formatter: function (e, t) { return `<div class="flex lg:justify-center items-center">\n  <a href="/Admin/Level/Edit/${e.getData().Id}" >\n <i data-feather="edit" class="text-theme-10"></i> \n</a>\n</div>   ` }, },
            { title: "Delete", field: "", hozAlign: "center", width: 95, formatter: function (e, t) { return `<div class="flex lg:justify-center items-center">\n  <a onclick="ShowDeleteConfirmation('PostDeleteLevel(${e.getData().Id})')"" >\n <i data-feather="trash-2" class="text-theme-24"></i> \n</a>\n</div>   ` }, },],

    });

//var tableData = [{ "LevelNo": 1, "VideoId": 1, "Image1": 0, "Image2": 0, "Image3": 0, "Title": "Happyness", "Subtitle": "scar Wilde.", "Quote": null, "VideoUrl": null, "VideoName": "Happyness", "FullDescription": "<p>aaaa</p>", "Modules": { "LevelId": 0, "VideoId": null, "FullDescription": null, "Level": null, "Video": null, "Id": 0 }, "Video": { "LazyLoader": {}, "Name": "Happyness", "VideoUrl": "", "Key": null, "Id": 1 }, "Image": null, "ModuleList": null, "AvailableVideo": [], "AvailableImages": [], "srno": 0, "DiaryText": null, "DiaryLatestUpdateDate": null, "Id": 19 }, { "LevelNo": 2, "VideoId": 3, "Image1": 0, "Image2": 0, "Image3": 0, "Title": "Forgivenes", "Subtitle": "scar Wilde.", "Quote": null, "VideoUrl": null, "VideoName": "Presence", "FullDescription": "<p>aaaa</p>", "Modules": { "LevelId": 0, "VideoId": null, "FullDescription": null, "Level": null, "Video": null, "Id": 0 }, "Video": { "LazyLoader": {}, "Name": "Presence", "VideoUrl": "", "Key": null, "Id": 3 }, "Image": null, "ModuleList": null, "AvailableVideo": [], "AvailableImages": [], "srno": 0, "DiaryText": null, "DiaryLatestUpdateDate": null, "Id": 20 }, { "LevelNo": 3, "VideoId": 3, "Image1": 0, "Image2": 0, "Image3": 0, "Title": " Experience", "Subtitle": "Wilde Data", "Quote": null, "VideoUrl": null, "VideoName": "Presence", "FullDescription": "<p><span style=\"background-color:rgb(255,255,255);color:rgb(32,33,36);\">1a : direct observation of or participation in events as a basis of knowledge. b : the fact or state of having been affected by or gained knowledge through direct observation or participation.</span></p>", "Modules": { "LevelId": 0, "VideoId": null, "FullDescription": null, "Level": null, "Video": null, "Id": 0 }, "Video": { "LazyLoader": {}, "Name": "Presence", "VideoUrl": "", "Key": null, "Id": 3 }, "Image": null, "ModuleList": null, "AvailableVideo": [], "AvailableImages": [], "srno": 0, "DiaryText": null, "DiaryLatestUpdateDate": null, "Id": 21 }, { "LevelNo": 4, "VideoId": 3, "Image1": 0, "Image2": 0, "Image3": 0, "Title": "Presence", "Subtitle": "Wilde", "Quote": null, "VideoUrl": null, "VideoName": "Presence", "FullDescription": "<p><i>The </i><a href=\"https://dictionary.cambridge.org/dictionary/english/strong\"><i>strong</i></a><i> </i><a href=\"https://dictionary.cambridge.org/dictionary/english/police\"><i>police</i></a><i> presence only </i><a href=\"https://dictionary.cambridge.org/dictionary/english/heighten\"><i>heightened</i></a><i> the </i><a href=\"https://dictionary.cambridge.org/dictionary/english/tension\"><i>tension</i></a><i> among the </i><a href=\"https://dictionary.cambridge.org/dictionary/english/crowd\"><i>crowd</i></a><i>.Some </i><a href=\"https://dictionary.cambridge.org/dictionary/english/worker\"><i>workers</i></a><i> were </i><a href=\"https://dictionary.cambridge.org/dictionary/english/inhibited\"><i>inhibited</i></a><i> from </i><a href=\"https://dictionary.cambridge.org/dictionary/english/speaking\"><i>speaking</i></a><i> by the presence of </i><a href=\"https://dictionary.cambridge.org/dictionary/english/their\"><i>their</i></a><i> </i><a href=\"https://dictionary.cambridge.org/dictionary/english/manager\"><i>managers</i></a><i>.He didn't </i><a href=\"https://dictionary.cambridge.org/dictionary/english/even\"><i>even</i></a><i> </i><a href=\"https://dictionary.cambridge.org/dictionary/english/acknowledge\"><i>acknowledge</i></a><i> my presence.He </i><a href=\"https://dictionary.cambridge.org/dictionary/english/sign\"><i>signed</i></a><i> the </i><a href=\"https://dictionary.cambridge.org/dictionary/english/treaty\"><i>treaty</i></a><i> in the presence of two </i><a href=\"https://dictionary.cambridge.org/dictionary/english/witness\"><i>witnesses</i></a><i>.He </i><a href=\"https://dictionary.cambridge.org/dictionary/english/stood\"><i>stood</i></a><i> there in the </i><a href=\"https://dictionary.cambridge.org/dictionary/english/corner\"><i>corner</i></a><i> of the </i><a href=\"https://dictionary.cambridge.org/dictionary/english/room\"><i>room</i></a><i>, a </i><a href=\"https://dictionary.cambridge.org/dictionary/english/dark\"><i>dark</i></a><i>, </i><a href=\"https://dictionary.cambridge.org/dictionary/english/brooding\"><i>brooding</i></a><i> presence.</i></p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>", "Modules": { "LevelId": 0, "VideoId": null, "FullDescription": null, "Level": null, "Video": null, "Id": 0 }, "Video": { "LazyLoader": {}, "Name": "Presence", "VideoUrl": "", "Key": null, "Id": 3 }, "Image": null, "ModuleList": null, "AvailableVideo": [], "AvailableImages": [], "srno": 0, "DiaryText": null, "DiaryLatestUpdateDate": null, "Id": 22 }]
var tableData = $("#tabledata").val();
table.setData(tableData);

function DisplaySelectedImages() {
    var count = $("#count").val();
    var imageList = [];
    var i;
    var html = "";
    $("#selected_images").empty();
    for (i = 0; i < count; i++) {
        imageList.push({
            Id: $(`#ImageLists_${i}__Id`).val(),
            Key: $(`#ImageLists_${i}__Key`).val(),
            Name: $(`#ImageLists_${i}__Name`).val(),
            ImageUrl: $(`#ImageLists_${i}__ImageUrl`).val(),
            Selected: $(`#ImageLists_${i}__Selected`).is(":checked")
        });
    }
    $.each(imageList, function (index, value) {
        debugger
        if (value.Selected == true) {
            debugger
            html += `<label class="form-label mr-2">${value.Key}</label>`;
        }
    })
    $("#selected_images").append(html);

}





function hideshowqoute(){
$("randomquote").attr("checked",true);

  $("#quotes").removeClass("hidden",true);


//document.getElementById("quotes").removeAttribute("hidden");
}



