function PrintResume() {
    window.print();
}

function FocusJP()
{
    var jp = document.getElementById("john-peterson");
    jp.focus();
    jp.classList.add("gradient-border");
    setTimeout(function() {
        jp.classList.remove("gradient-border");
    }, 1200)
    console.log("FocusJP clicked")
}