<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <link rel="shortcut icon" href="/img/CSS logo.png" type="image/x-icon">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.7.2/css/all.min.css" integrity="sha512-Evv84Mr4kqVGRNSgIGL/F/aIDqQb7xQ2vcrdIwxfjThSH8CSR7PBEakCr51Ck+w+/U6swU2Im1vVX0SVk9ABhg==" crossorigin="anonymous" referrerpolicy="no-referrer" />
</head>
<body>
    <?php
    require_once "pages/header.html";

    if ($_SERVER["QUERY_STRING"] == "pg=menucircular"){
        require "pages/menuCircular.php";
    }
    else if ($_SERVER["QUERY_STRING"] == "pg=inputdinamico"){
        require "pages/inputDinamico.php";
    }
    else if ($_SERVER["QUERY_STRING"] == "pg=barralateral"){
        require "pages/barraLateral.php";
    }
    else if ($_SERVER["QUERY_STRING"] == "pg=descricao"){
        require "pages/descricao.php";
    }
    else if ($_SERVER["QUERY_STRING"] == "pg=botaoneon"){
        require "pages/botaoNeon.php";
    }
    else {
        require "pages/erro.php";
    }
    ?>
</body>
</html>