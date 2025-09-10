<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário</title>
    <link rel="stylesheet" href="/css/style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.7.2/css/all.min.css" integrity="sha512-Evv84Mr4kqVGRNSgIGL/F/aIDqQb7xQ2vcrdIwxfjThSH8CSR7PBEakCr51Ck+w+/U6swU2Im1vVX0SVk9ABhg==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="shortcut icon" href="/img/KingBet.png" type="image/x-icon">
</head>
<body>

    <a href="/index.php" class="seta-voltar"><i class="fa-solid fa-arrow-left"></i></a>

    <form action="formulario.php" method="post" class="form-login">
        <h1 class="titulo">Formulário</h1>

        <div class="div-dados">            
            <input type="text" name="nome" id="" class="input-nome" required>
            <label for="" class="lbl-nome">Nome</label>
            <i class="fa-solid fa-user"></i>
        </div>

        <div class="div-dados">
            <input type="password" name="senha" id="senha" class="input-senha" required>
            <label for="" class="lbl-senha">Senha</label>
            <img src="/img/OlhoA.png" alt="" class="" id="olho" onclick="mostrarSenha()">
        </div>

        <div class="div-dados">            
            <input type="email" name="email" id="" class="input-email" required>
            <label for="" class="lbl-email">Email</label>
            <i class="fa-solid fa-envelope"></i>
        </div>

        <div class="div-dados">            
            <input type="tel" name="telefone" id="" class="input-telefone" required>
            <label for="" class="lbl-telefone">Telefone</label>
            <i class="fa-solid fa-phone"></i>
        </div>

        <div class="container-genero">            
            <h1 class="titulo-genero">Gênero:</h1>
            <fieldset>
                <div class="div-genero">
                    <input type="radio" name="genero" id="" class="" value="feminino">
                    <label for="">Feminino</label>
                </div>
                <div class="div-genero">
                    <input type="radio" name="genero" id="" class="" value="masculino">
                    <label for="">Masculino</label>
                </div>
                <div class="div-genero">
                    <input type="radio" name="genero" id="" class="" value="outro">
                    <label for="">Outro</label>
                </div>
            </fieldset>
        </div>

        <div class="div-data">    
            <h1 class="titulo-genero">Data de Nascimento:</h1>        
            <fieldset>
                <input type="date" name="data_nasc" id="" class="input-nome" required>
            </fieldset>
        </div>

        <div class="div-dados">            
            <input type="text" name="cidade" id="" class="input-cidade" required>
            <label for="" class="lbl-cidade">Cidade</label>
            <i class="fa-solid fa-location-dot"></i>
        </div>

        <div class="div-dados">            
            <input type="text" name="estado" id="" class="input-estado" required>
            <label for="" class="lbl-estado">Estado</label>
            <i class="fa-solid fa-location-dot"></i>
        </div>

        <div class="div-dados">            
            <input type="text" name="endereco" id="ipt-n" class="input-endereco" required>
            <label for="" class="lbl-endereco">Endereço</label>
            <i class="fa-solid fa-location-dot"></i>
        </div>

        <input class="btn-enviar" type="submit" name="submit" value="enviar">
    </form>

    <?php

    if (isset($_POST['submit'])) {
        //echo($_POST['nome']);
        //echo('<br>');
        //echo($_POST['email']);
        //echo('<br>');
        //echo($_POST['telefone']);
        //echo('<br>');
        //echo($_POST['genero']);
        //echo('<br>');
        //echo($_POST['data_nasc']);
        //echo('<br>');
        //echo($_POST['cidade']);
        //echo('<br>');
        //echo($_POST['estado']);
        //echo('<br>');
        //echo($_POST['endereco']);

        require_once "./config.php";

        $nome = $_POST['nome'];
        $senha = $_POST['senha'];
        $email = $_POST['email'];
        $telefone = $_POST['telefone'];
        $genero = $_POST['genero'];
        $data_nasc = $_POST['data_nasc'];
        $cidade = $_POST['cidade'];
        $estado = $_POST['estado'];
        $endereco = $_POST['endereco'];

        $result = mysqli_query($conexao, "INSERT INTO dados(nome,senha,email,telefone,genero,data_nasc,cidade,estado,endereco)
        VALUES ('$nome','$senha','$email','$telefone','$genero','$data_nasc','$cidade','$estado','$endereco')");
    
        header("Location: login.php");
    }

    ?>

<script>
let iptnome = document.getElementsByClassName('input-nome')[0]
let iptsenha = document.getElementsByClassName('input-senha')[0]
let iptemail = document.getElementsByClassName('input-email')[0]
let ipttelefone = document.getElementsByClassName('input-telefone')[0]
let iptcidade = document.getElementsByClassName('input-cidade')[0]
let iptestado = document.getElementsByClassName('input-estado')[0]
let iptendereco = document.getElementsByClassName('input-endereco')[0]
let lblnome = document.getElementsByClassName('lbl-nome')[0]
let lblsenha = document.getElementsByClassName('lbl-senha')[0]
let lblemail = document.getElementsByClassName('lbl-email')[0]
let lbltelefone = document.getElementsByClassName('lbl-telefone')[0]
let lblcidade = document.getElementsByClassName('lbl-cidade')[0]
let lblestado = document.getElementsByClassName('lbl-estado')[0]
let lblendereco = document.getElementsByClassName('lbl-endereco')[0]

iptnome.addEventListener("keyup", () => {
    if (iptnome.value.length != 0) {
        lblnome.style.transform = "translateY(-28px)"
        lblnome.style.fontSize = "8px"
        iptnome.addEventListener("focus", () => {
            lblnome.style.transform = "translateY(-28px)"
            lblnome.style.fontSize = "8px"
        })
        iptnome.addEventListener("focusout", () => {
            lblnome.style.transform = "translateY(-28px)"
            lblnome.style.fontSize = "8px"
        })
    }
    else if (iptnome.value.length < 1) {
        lblnome.style.transform = "translateY(-9px)"
        lblnome.style.fontSize = "12px"
        iptnome.addEventListener("focus", () => {
            lblnome.style.transform = "translateY(-28px)"
            lblnome.style.fontSize = "8px"
        })
        iptnome.addEventListener("focusout", () => {
            lblnome.style.transform = "translateY(-9px)"
            lblnome.style.fontSize = "12px"
        })
    }
})

iptemail.addEventListener("keyup", () => {
    if (iptemail.value.length != 0) {
        lblemail.style.transform = "translateY(-28px)"
        lblemail.style.fontSize = "8px"
        iptemail.addEventListener("focus", () => {
            lblemail.style.transform = "translateY(-28px)"
            lblemail.style.fontSize = "8px"
        })
        iptemail.addEventListener("focusout", () => {
            lblemail.style.transform = "translateY(-28px)"
            lblemail.style.fontSize = "8px"
        })
    }
    else if (iptemail.value.length < 1) {
        lblemail.style.transform = "translateY(-9px)"
        lblemail.style.fontSize = "12px"
        iptemail.addEventListener("focus", () => {
            lblemail.style.transform = "translateY(-28px)"
            lblemail.style.fontSize = "8px"
        })
        iptemail.addEventListener("focusout", () => {
            lblemail.style.transform = "translateY(-9px)"
            lblemail.style.fontSize = "12px"
        })
    }
})

iptsenha.addEventListener("keyup", () => {
    if (iptsenha.value.length != 0) {
        lblsenha.style.transform = "translateY(-28px)"
        lblsenha.style.fontSize = "8px"
        iptsenha.addEventListener("focus", () => {
            lblsenha.style.transform = "translateY(-28px)"
            lblsenha.style.fontSize = "8px"
        })
        iptsenha.addEventListener("focusout", () => {
            lblsenha.style.transform = "translateY(-28px)"
            lblsenha.style.fontSize = "8px"
        })
    }
    else if (iptsenha.value.length < 1) {
        lblsenha.style.transform = "translateY(-9px)"
        lblsenha.style.fontSize = "12px"
        iptsenha.addEventListener("focus", () => {
            lblsenha.style.transform = "translateY(-28px)"
            lblsenha.style.fontSize = "8px"
        })
        iptsenha.addEventListener("focusout", () => {
            lblsenha.style.transform = "translateY(-9px)"
            lblsenha.style.fontSize = "12px"
        })
    }
})

ipttelefone.addEventListener("keyup", () => {
    if (ipttelefone.value.length != 0) {
        lbltelefone.style.transform = "translateY(-28px)"
        lbltelefone.style.fontSize = "8px"
        ipttelefone.addEventListener("focus", () => {
            lbltelefone.style.transform = "translateY(-28px)"
            lbltelefone.style.fontSize = "8px"
        })
        ipttelefone.addEventListener("focusout", () => {
            lbltelefone.style.transform = "translateY(-28px)"
            lbltelefone.style.fontSize = "8px"
        })
    }
    else if (ipttelefone.value.length < 1) {
        lbltelefone.style.transform = "translateY(-9px)"
        lbltelefone.style.fontSize = "12px"
        ipttelefone.addEventListener("focus", () => {
            lbltelefone.style.transform = "translateY(-28px)"
            lbltelefone.style.fontSize = "8px"
        })
        ipttelefone.addEventListener("focusout", () => {
            lbltelefone.style.transform = "translateY(-9px)"
            lbltelefone.style.fontSize = "12px"
        })
    }
})

iptcidade.addEventListener("keyup", () => {
    if (iptcidade.value.length != 0) {
        lblcidade.style.transform = "translateY(-28px)"
        lblcidade.style.fontSize = "8px"
        iptcidade.addEventListener("focus", () => {
            lblcidade.style.transform = "translateY(-28px)"
            lblcidade.style.fontSize = "8px"
        })
        iptcidade.addEventListener("focusout", () => {
            lblcidade.style.transform = "translateY(-28px)"
            lblcidade.style.fontSize = "8px"
        })
    }
    else if (iptcidade.value.length < 1) {
        lblcidade.style.transform = "translateY(-9px)"
        lblcidade.style.fontSize = "12px"
        iptcidade.addEventListener("focus", () => {
            lblcidade.style.transform = "translateY(-28px)"
            lblcidade.style.fontSize = "8px"
        })
        iptcidade.addEventListener("focusout", () => {
            lblcidade.style.transform = "translateY(-9px)"
            lblcidade.style.fontSize = "12px"
        })
    }
})

iptestado.addEventListener("keyup", () => {
    if (iptestado.value.length != 0) {
        lblestado.style.transform = "translateY(-28px)"
        lblestado.style.fontSize = "8px"
        iptestado.addEventListener("focus", () => {
            lblestado.style.transform = "translateY(-28px)"
            lblestado.style.fontSize = "8px"
        })
        iptestado.addEventListener("focusout", () => {
            lblestado.style.transform = "translateY(-28px)"
            lblestado.style.fontSize = "8px"
        })
    }
    else if (iptestado.value.length < 1) {
        lblestado.style.transform = "translateY(-9px)"
        lblestado.style.fontSize = "12px"
        iptestado.addEventListener("focus", () => {
            lblestado.style.transform = "translateY(-28px)"
            lblestado.style.fontSize = "8px"
        })
        iptestado.addEventListener("focusout", () => {
            lblestado.style.transform = "translateY(-9px)"
            lblestado.style.fontSize = "12px"
        })
    }
})

iptendereco.addEventListener("keyup", () => {
    if (iptendereco.value.length != 0) {
        lblendereco.style.transform = "translateY(-28px)"
        lblendereco.style.fontSize = "8px"
        iptendereco.addEventListener("focus", () => {
            lblendereco.style.transform = "translateY(-28px)"
            lblendereco.style.fontSize = "8px"
        })
        iptendereco.addEventListener("focusout", () => {
            lblendereco.style.transform = "translateY(-28px)"
            lblendereco.style.fontSize = "8px"
        })
    }
    else if (iptendereco.value.length < 1) {
        lblendereco.style.transform = "translateY(-9px)"
        lblendereco.style.fontSize = "12px"
        iptendereco.addEventListener("focus", () => {
            lblendereco.style.transform = "translateY(-28px)"
            lblendereco.style.fontSize = "8px"
        })
        iptendereco.addEventListener("focusout", () => {
            lblendereco.style.transform = "translateY(-9px)"
            lblendereco.style.fontSize = "12px"
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
    justify-content: center;

    background: rgb(46, 46, 46);
    height: 100vh;
}

.form-login{
    display: flex;
    justify-content: space-around;
    align-items: center;
    flex-direction: column;

    background: white;
    box-shadow: 0 0 15px black;
    border-radius: 10px;
    height: 500px;
    width: 320px;
    padding: 20px;
}
.form-login *{
    border: none;
}
.titulo{
    font-size: 22px;
}
.div-dados{
    display: flex;
    justify-content: end;
    align-items: center;
    flex-direction: column;
    position: relative;

    width: 100%;
    height: 32px;
}
.div-dados i{
    position: absolute;

    right: 0;
    transform: translateY(-7px);
    pointer-events: none;
    background: white;
    padding: 2px 6.5px 2px 4px;
}
.div-dados input{
    background: transparent;
    border-bottom: solid 2px black;
    width: 100%;
    height: 30px;
    font-size: 12px;
}
.div-dados label{
    position: absolute;

    color: black;
    pointer-events: none;
    left: 7px;
    font-size: 12px;
    transform: translateY(-9px);
    transition: .4s;
}
.container-genero, .div-data{
    width: 100%;
}
.container-genero fieldset, .div-data fieldset{
    border: solid 2px black;
    padding: 10px;
    border-radius: 5px;
}
.titulo-genero{
    font-size: 12px;
    font-weight: normal;
    margin-left: 7px;
}
.div-genero{
    display: flex;
    justify-content: space-between;
    align-items: center;
    position: relative;

    margin: 2px 0;
}
.div-genero input[type="radio"]{
    height: 14px;
    width: 14px;
    border: solid 1px black;
}
.div-genero label{
    display: flex;
    justify-content: end;
    align-items: center;
    position: absolute;

    height: 12px;
    right: 0;
    font-size: 12px;
}
.div-data input{
    width: 100%;
    font-size: 12px;
}
.div-data input::-webkit-calendar-picker-indicator{
    height: 16px;
    width: 16px;
    cursor: pointer;
}
.input-nome:focus + .lbl-nome,
.input-senha:focus + .lbl-senha,
.input-email:focus + .lbl-email,
.input-telefone:focus + .lbl-telefone,
.input-cidade:focus + .lbl-cidade,
.input-estado:focus + .lbl-estado,
.input-endereco:focus + .lbl-endereco{
    transform: translateY(-28px);
    font-size: 8px;
}
#olho{
    position: absolute;

    right: 0;
    transform: translateY(-7px);
    cursor: pointer;
    background: white;
    padding: 2px 4px 2px 4px;
}
.btn-enviar{
    background: black;
    color: white;
    cursor: pointer;
    box-shadow: 0 0 7px black;
    width: 100%;
    height: 35px;
    border-radius: 5px;
    font-size: 10px;
    transition: .4s;
}
.btn-enviar:active{
    transform: scale(0.9);
    transition: .2s;
}
</style>
</html>