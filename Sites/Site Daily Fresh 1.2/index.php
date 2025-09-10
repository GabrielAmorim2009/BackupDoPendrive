<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Daily Fresh</title>
    <link rel="shortcut icon" href="/img/Logo.png" type="image/x-icon">
    <link rel="stylesheet" href="/css/style.css">
    <link rel="stylesheet" href="/css/responsividade.css">
</head>
<body id="body">

<?php

require_once "./pages/navbar.php";

if ($_SERVER['QUERY_STRING'] === "pg=home") {
    include "./pages/home.php";
}
else if ($_SERVER['QUERY_STRING'] === "pg=cardapio") {
    include "./pages/cardapio.php";
}
else if ($_SERVER['QUERY_STRING'] === "pg=sobre") {
    include "./pages/sobre.php";    
}
else if ($_SERVER['QUERY_STRING'] === "pg=contato") {
    include "./pages/contato.php";    
}
else if ($_SERVER['QUERY_STRING'] === "pg=configuracoes") {
    include "./pages/configuracoes.php";    
}
else {
    include "./pages/erro.php";
}

?>
    <div class="escuro">
<button id="btn-voltarlogin"><img src="/img/Seta Voltar.png" alt=""></button>
    <main class="container-login">
<form method="post" class="form-login">
        <h1 class="login-titulo">Login</h1>
    <div class="div-input">
        <input type="text" name="nome" id="nome" class="input-nome" required>
        <label for="" class="label-input" id="lbl-nome">Nome</label>
    </div>
    <div class="div-input">
        <input type="email" name="email" id="email" class="input-email" required>
        <label for="" class="label-input" id="lbl-email">Email</label>
    </div>
    <div class="div-input">
        <input type="password" name="senha" id="senha" class="input-senha" minlength="8" maxlength="24" autocomplete="off" required>
        <label for="" class="label-input" id="lbl-senha">Senha</label>
    </div>
    <div class="esqsenha-container">
        <div class="div-checkbox">
            <input type="checkbox" name="" id="">
            <label for="">Lembre-me</label>
        </div>
        <div class="div-esqsenha">
            <a href="">Esqueci minha senha</a>
        </div>
    </div>
    <div class="div-input">
        <input type="submit" value="Logar" class="input-submit"> 
    </div>
    <div class="div-cadastrar">
        <p class="paragrafo-cadastrar">Ainda não tem uma conta? <a href="" id="cadastro-btn">Cadastre-se</a></p>
    </div>
</form>
</main>
    </div>

<div class="escuro2">
    <main class="container-cadastro">
<form method="post" class="form-login">
        <h1 class="login-titulo">Cadastrar</h1>
    <div class="div-input">
        <input type="text" name="nome" id="nome" class="input-nome" required>
        <label for="" class="label-input" id="lbl-nome">Nome</label>
    </div>
    <div class="div-input">
        <input type="password" name="senha" id="senha" class="input-senha" minlength="8" maxlength="24" autocomplete="off" required>
        <label for="" class="label-input" id="lbl-senha">Senha</label>
    </div>
    <div class="esqsenha-container">
        <div class="div-checkbox">
            <input type="checkbox" name="" id="">
            <label for="">Lembre-me</label>
        </div>
        <div class="div-esqsenha">
            <a href="">Esqueci minha senha</a>
        </div>
    </div>
    <div class="div-input">
        <input type="submit" value="Logar" class="input-submit"> 
    </div>
    <div class="div-cadastrar">
        <p class="paragrafo-cadastrar">Já tem uma conta? <a href="" id="cadastro-btn">login</a></p>
    </div>
</form>
</main>
</div>
    
    <script src="/js/script.js"></script>
</body>
</html>