<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./css/style.css">
    <link rel="stylesheet" href="./css/responsividade.css">
    <link rel="shortcut icon" href="/img/CassinoDeluxe.png" type="image/x-icon">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.7.2/css/all.min.css" integrity="sha512-Evv84Mr4kqVGRNSgIGL/F/aIDqQb7xQ2vcrdIwxfjThSH8CSR7PBEakCr51Ck+w+/U6swU2Im1vVX0SVk9ABhg==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>
<body>
    
    <?php
    
    require_once "./pages/header.php";
    
    ?>

<main class="container-geral">
    
<div class="menu-lateral">
    <span></span>
    <a href="" class="menu-lateral-link link" title="Futebol"><img src="/img/Futebol.png" alt=""></a>
    <hr>
    <a href="" class="menu-lateral-link link" title="Basquete"><img src="/img/Basquete.png" alt=""></a>
    <hr>
    <a href="" class="menu-lateral-link link" title="Volei"><img src="/img/Volei.png" alt=""></a>
    <hr>
    <a href="" class="menu-lateral-link link" title="Tenis"><img src="/img/Tenis.png" alt=""></a>
</div>

<?php

if(isset($_GET['home'])){
    include "./pages/home.php";
}
if(isset($_GET['cassino'])){
    include "./pages/cassino.php";
}
if(isset($_GET['configuracoes'])){
    include "./pages/configuracoes.php";
}
if(!isset($_GET['home']) && !isset($_GET['cassino']) && !isset($_GET['configuracoes'])){
    include "./pages/erro.php";
}

?>

</main>

<script src="/js/script.js"></script>

</body>
</html>