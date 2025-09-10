let olho = document.getElementById("olho")
let input = document.getElementById('input-senha')

olho.onclick = function mostrarSenha() {
    if (input.type != "text"){
        input.type = "text"
        olho.src = "img/OlhoF.png"
    }
    else if (input.type != "password") {
        input.type = "password"
        olho.src = "img/OlhoA.png"
    }
}