//---------------------------E-------------------------
//---------------------------N-------------------------
//---------------------------E-------------------------
//---------------------------S-------------------------
//-----------------------------------------------------
//---------------------------Ş-------------------------
//---------------------------İ-------------------------
//---------------------------M-------------------------
//---------------------------Ş-------------------------
//---------------------------E-------------------------
//---------------------------K-------------------------
const answer = document.getElementById("answer").value;
//--------------------------------------------------
let correctAnswer = 0;
//------------------
let falseAnswer = 0;
//------------------
let emptyAnswer = 0;
//------------------
document.getElementById('submit').onclick = function () {
    //-----------------------------------------------
    var value = document.getElementsByName('option');
    //-----------------------------------------------
    
    for (var radio of value) {
        if (radio.checked) {
            //alert(radio.value)
            if (radio.value == answer) {
                //alert("correct");
                correctAnswer++;
            } else {
                //falseAnswer++;
                alert("false");
            }
        } else {
            //emptyAnswer++;
            alert("empty");
        }
    }
};



//const btn_finish = document.querySelector("#btn-finish");
//btn_finish.addEventListener("click", function () {
//    var dialog_res = confirm("Testi Bitirmek İstediğinize Emin misiniz?")
//    if (dialog_res) {

//        var data = {
//            "correctAnswer": correctAnswer,
//            "falseAnswer": falseAnswer,
//            "emptyAnswer": emptyAnswer
//        }

//        $.ajax({
//            url: "/Class/Test",
//            type: "POST",
//            data: JSON.stringify(data);
//            success: function (data) {
//                if (data.success) {
//                    alert("Veriler başarıyla işlendi.");
//                } else {
//                    alert("Veriler işlenirken bir hata oluştu.");
//                }
//            },
//            error: function () {
//                alert("İsteğiniz işlenirken bir hata oluştu.");
//            }
//        });
//    } else {
//        alert("çıkış yapılmadı")
//    }
    
//});










//---------------------------E-------------------------
//---------------------------N-------------------------
//---------------------------E-------------------------
//---------------------------S-------------------------
//-----------------------------------------------------
//---------------------------Ş-------------------------
//---------------------------İ-------------------------
//---------------------------M-------------------------
//---------------------------Ş-------------------------
//---------------------------E-------------------------
//---------------------------K------------------------- 