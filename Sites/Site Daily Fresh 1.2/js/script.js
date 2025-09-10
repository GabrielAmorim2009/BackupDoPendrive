function fundoClaro() {
    document.body.style.backgroundImage = "linear-gradient(to bottom, gray, white)";
    document.getElementById('btn-mudarfundo-claro').style.zIndex = "1";
    document.getElementById('btn-mudarfundo-escuro').style.zIndex = "2";
    tmClaro.innerText = 'Tema Escuro';
    tmClaro.style.color = "black";
    document.getElementById('ball').style.transform = "translateX(0px)"
    localStorage.setItem("fundo", "claro");
}

function fundoEscuro() {
    document.body.style.backgroundImage = "linear-gradient(to bottom, black, gray)";
    document.getElementById('btn-mudarfundo-escuro').style.zIndex = "1";
    document.getElementById('btn-mudarfundo-claro').style.zIndex = "2";
    tmClaro.innerText = 'Tema Claro';
    tmClaro.style.color = "white";
    document.getElementById('ball').style.transform = "translateX(-128px)";
    localStorage.setItem("fundo", "escuro");
}

window.onload = function() {
    let fundo = localStorage.getItem("fundo");
    
    if (fundo === "escuro") {
        document.body.style.backgroundImage = "linear-gradient(to bottom, black, gray)";
        document.getElementById('btn-mudarfundo-escuro').style.zIndex = "1";
        document.getElementById('btn-mudarfundo-claro').style.zIndex = "2";
        tmClaro.innerText = 'Tema Claro';
        tmClaro.style.color = "white";
        document.getElementById('ball').style.transform = "translateX(-128px)"
    } else {
        document.body.style.backgroundImage = "linear-gradient(to bottom, gray, white)";
        document.getElementById('btn-mudarfundo-claro').style.zIndex = "1";
        document.getElementById('btn-mudarfundo-escuro').style.zIndex = "2";
        tmClaro.innerText = 'Tema Escuro';
        tmClaro.style.color = "black";
        document.getElementById('ball').style.transform = "translateX(0px)"
    }
};

document.getElementsByClassName('dailyclub-btn')[0].onclick = function escurecer () {
    document.getElementsByClassName('escuro')[0].style.display = "block"
    document.getElementsByClassName('escuro2')[0].style.display = "none"
}

document.getElementById('btn-voltarlogin').onclick = function voltarLogin() {
    document.getElementsByClassName('escuro')[0].style.display = "none"
    document.getElementsByClassName('escuro2')[0].style.display = "none"
}

document.getElementById('cadastro-btn').onclick = function cadastro() {
    document.getElementsByClassName('escuro')[0].style.display = "none"
    document.getElementsByClassName('escuro2')[0].style.display = "block"
}