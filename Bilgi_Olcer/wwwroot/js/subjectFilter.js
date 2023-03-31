const derslerDiv = document.querySelector(".dersler")
//console.log(derslerDiv)
//----------------------
//const dersler = document.querySelectorAll(".list-group-item");
//console.log(dersler)
//----------------------
const konularget = document.querySelectorAll(".konular li")
//console.log(konularget)
//----------------------

derslerDiv.addEventListener("click", (event) => {
    //----------------------------------------------------
    const clickedDers = event.target.innerText
    //console.log(clickedDers)
    //-----------------------
    konularget.forEach((konu) => {
        if (clickedDers == konu.className) {
            konu.setAttribute("style", "display: block");
        } else {
            konu.setAttribute("style", "display: none");
        }
    });
    //----------------------------------------------------
})


