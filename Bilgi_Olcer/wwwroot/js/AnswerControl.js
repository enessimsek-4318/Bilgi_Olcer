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
let correctAnswer = 5;
//------------------
let falseAnswer = 2;
//------------------
let emptyAnswer = 3;
//------------------
document.getElementById('submit').onclick = function () {
    //-----------------------------------------------
    var value = document.getElementsByName('option');
    //-----------------------------------------------
    
    for (var radio of value) {
        if (radio.checked) {
            alert(radio.value)
            if (radio.value == answer) {
                //alert("correct");
                correctAnswer++;
                break;
            } else {
                //falseAnswer++;
                alert("false");
                break;
            }
        } else {
            //emptyAnswer++;
            alert("empty");
            break;
        }
    }
};



const btn_finish = document.querySelector("#btn-finish");
btn_finish.addEventListener("click", function () {
   
    kaydet();
    
});






function kaydet() {
    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/Class/Test", true);
    xhr.setRequestHeader("Content-Type", "application/json");
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            
        }
    };
    var data = JSON.stringify({ correctAnswer: correctAnswer, falseAnswer: falseAnswer, emptyAnswer: emptyAnswer });
    xhr.send(data);
}



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