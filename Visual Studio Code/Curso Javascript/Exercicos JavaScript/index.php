<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="/img/JS logo.png" type="image/x-icon">
    <link rel="stylesheet" href="/style.css">
</head>
<body>
    
<?php
require "./pages/header.php";

if ($_SERVER['QUERY_STRING'] === 'page=ex1') {
    include "./pages/verificadorDeVelocidade.php";
}
else if ($_SERVER['QUERY_STRING'] === 'page=ex2') {
    include "./pages/verificadorDeNacionalidade.php";
}
else if ($_SERVER['QUERY_STRING'] === 'page=ex3') {
    include "./pages/verificadorHora.php";
}
else if ($_SERVER['QUERY_STRING'] === 'page=ex4') {
    include "./pages/verificadorIdade.php";
}
else if ($_SERVER['QUERY_STRING'] === 'page=ex5') {
    include "./pages/contadorNumeros.php";
}
else if ($_SERVER['QUERY_STRING'] === 'page=ex6') {
    include "./pages/tabuada.php";
}
else {
    include "./pages/erro.php";
}
?>

</body>
</html>