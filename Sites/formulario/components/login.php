<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.7.2/css/all.min.css" integrity="sha512-Evv84Mr4kqVGRNSgIGL/F/aIDqQb7xQ2vcrdIwxfjThSH8CSR7PBEakCr51Ck+w+/U6swU2Im1vVX0SVk9ABhg==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="shortcut icon" href="./img/KingBet.png" type="image/x-icon">
</head>
<body>

    <a href="/index.php" class="seta-voltar"><i class="fa-solid fa-arrow-left"></i></a>

    <form action="testLogin.php" method="post" class="form-login">
        <h1 class="titulo">Login</h1>
        <div class="div-dados">            
            <input type="email" name="email" id="ipt-e" class="input-email" required>
            <label for="" class="lbl-email">Email</label>
            <img src="/img/Perfil.png" alt="" class="img-dados">
        </div>
        <div class="div-dados">
            <input type="password" name="senha" id="ipt-s" class="input-senha" required>
            <label for="" class="lbl-senha">Senha</label>
            <img src="/img/OlhoA.png" alt="" class="img-dados" id="olho" onclick="mostrarSenha()">
        </div>
        <input type="submit" class="btn-enviar" name="submit" value="Enviar">
    </form>

<script>
let iptemail = document.getElementById('ipt-e')
let iptsenha = document.getElementById('ipt-s')
let lblemail = document.getElementsByClassName('lbl-email')[0]
let lblsenha = document.getElementsByClassName('lbl-senha')[0]

iptemail.addEventListener("keyup", () => {
    if (iptemail.value.length != 0) {
        lblemail.style.transform = "translateY(-33px)"
        lblemail.style.fontSize = "12px"
        iptemail.addEventListener("focus", () => {
            lblemail.style.transform = "translateY(-33px)"
            lblemail.style.fontSize = "12px"
        })
        iptemail.addEventListener("focusout", () => {
            lblemail.style.transform = "translateY(-33px)"
            lblemail.style.fontSize = "12px"
        })
    }
    else if (iptemail.value.length < 1) {
        lblemail.style.transform = "translateY(-8px)"
        lblemail.style.fontSize = "20px"
        iptemail.addEventListener("focus", () => {
            lblemail.style.transform = "translateY(-33px)"
            lblemail.style.fontSize = "12px"
        })
        iptemail.addEventListener("focusout", () => {
            lblemail.style.transform = "translateY(-8px)"
            lblemail.style.fontSize = "20px"
        })
    }
})

iptsenha.addEventListener("keyup", () => {
    if (iptsenha.value.length != 0) {
        lblsenha.style.transform = "translateY(-33px)"
        lblsenha.style.fontSize = "12px"
        iptsenha.addEventListener("focus", () => {
            lblsenha.style.transform = "translateY(-33px)"
            lblsenha.style.fontSize = "12px"
        })
        iptsenha.addEventListener("focusout", () => {
            lblsenha.style.transform = "translateY(-33px)"
            lblsenha.style.fontSize = "12px"
        })
    }
    else if (iptsenha.value.length < 1) {
        lblsenha.style.transform = "translateY(-8px)"
        lblsenha.style.fontSize = "20px"
        iptsenha.addEventListener("focus", () => {
            lblsenha.style.transform = "translateY(-33px)"
            lblsenha.style.fontSize = "12px"
        })
        iptsenha.addEventListener("focusout", () => {
            lblsenha.style.transform = "translateY(-8px)"
            lblsenha.style.fontSize = "20px"
        })
    }
})

let olho = document.getElementById("olho")

olho.onclick = function mostrarSenha() {
    if (iptsenha.type != "text"){
        iptsenha.type = "text"
        olho.src = "/img/OlhoF.png"
    }
    else if (iptsenha.type != "password") {
        iptsenha.type = "password"
        olho.src = "/img/OlhoA.png"
    }
}
</script>
</body>
<style>
@import url('https://fonts.googleapis.com/css2?family=Bungee&display=swap');

*{
    margin: 0;
    padding: 0;
    outline: 0;
    font-family: "Bungee";
}
body{
    display: flex;
    align-items: center;

    background: rgb(46, 46, 46);
    height: 100vh;
}

.form-login{
    display: flex;
    justify-content: space-evenly;
    align-items: center;
    flex-direction: column;

    background: white;
    margin: auto;
    box-shadow: 0 0 15px black;
    border-radius: 10px;
    height: 280px;
    width: 280px;
    padding: 20px;
}
.form-login *{
    border: none;
}
.titulo{
    font-size: 36px;
}
.div-dados{
    display: flex;
    justify-content: end;
    align-items: center;
    flex-direction: column;
    position: relative;

    width: 100%;
    height: 42px;
}
.div-dados input{
    background: transparent;
    border-bottom: solid 2px black;
    width: 100%;
    height: 40px;
    font-size: 20px;
}
.div-dados label{
    position: absolute;

    color: black;
    pointer-events: none;
    left: 8px;
    font-size: 20px;
    transform: translateY(-8px);
    transition: .4s;
}
.input-email:focus + .lbl-email, .input-senha:focus + .lbl-senha{
    transform: translateY(-33px);
    font-size: 12px;
}
.btn-enviar{
    background: black;
    color: white;
    cursor: pointer;
    box-shadow: 0 0 7px black;
    width: 100%;
    height: 40px;
    border-radius: 5px;
    transition: .4s;
}
.btn-enviar:active{
    transform: scale(0.9);
    transition: .2s;
}
.img-dados{
    position: absolute;

    background: white;
    pointer-events: none;
    height: 25px;
    width: 25px;
    right: 0;
    padding: 2px 7px 0 3px;
    transform: translateY(-8px);
    z-index: 2;
}
#olho{
    pointer-events: visible;
    cursor: pointer;
}
.seta-voltar{
    position: fixed;

    color: white;
    top: 20px;
    left: 30px;
    font-size: 40px;
    transition: .1s;
}
.seta-voltar:active{
    left: 20px;
}
</style>
</html>