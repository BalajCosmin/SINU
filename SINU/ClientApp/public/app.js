var modal = document.getElementById('id01');

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

var content = document.getElementById("teacherContainer")
var button = document.getElementById("teacherButton")

button.onclick = function () {
    if (content.className == "open") {
        content.className = "";
    } else {
        content.className = "open";
    }
}

var content1 = document.getElementById("studentContainer")
var button1 = document.getElementById("studentButton")

button1.onclick = function () {
    if (content1.className == "open") {
        content1.className = "";
    } else {
        content1.className = "open";
    }
}