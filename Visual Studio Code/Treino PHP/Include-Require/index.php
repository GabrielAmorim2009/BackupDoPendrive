<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="./css/style.css">
    <link rel="shortcut icon" href="./img/Cassino Logo.png" type="image/x-icon">

</head>
<body>
    
<?php 
include "./pages/header.php";

if ($_SERVER['QUERY_STRING'] === "page=home") {
    include "./pages/home.php";
?>
<script>
    let home = document.getElementById('home')

    home.classList.add('link-selecionado')
    home.classList.remove('link')
    sobre.classList.add('link')
    login.classList.add('link')
</script>
<?php
}
else if ($_SERVER['QUERY_STRING'] === "page=sobre") {
    include "./pages/sobre.php";
?>
<script>
    let sobre = document.getElementById('sobre')

    sobre.classList.add('link-selecionado')
    sobre.classList.remove('link')
    login.classList.add('link')
    home.classList.add('link')
</script>
<?php
}
else if ($_SERVER['QUERY_STRING'] === "page=login") {
    include "./pages/login.php";
?>
<script>
    let login = document.getElementById('login')

    login.classList.add('link-selecionado')
    login.classList.remove('link')
    sobre.classList.add('link')
    home.classList.add('link')
</script>
<?php
}
else {
    echo "<h1>Pagina não encontrada</h1>";
};
?>

</body>
</html>