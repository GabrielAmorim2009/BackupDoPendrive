<?php

session_start();
//print_r($_SESSION);

if ((!isset($_SESSION['email']) == true) and (!isset($_SESSION['senha']) == true)) {
    unset($_SESSION['email']);
    unset($_SESSION['senha']);
    header("Location: login.php");
}
$logado = $_SESSION['email'];

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sistema</title>
</head>
<body>

<header class="header-sistema">
    <p>Sistema</p>
    <a href="sair.php">Sair</a>
</header>
<?php 
echo "<h1 class='titulo-bemvindo'>Bem Vindo-<u>$logado</u></h1>";
?>

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
    flex-direction: column;

    background: rgb(46, 46, 46);
    height: 100vh;
}
.header-sistema{
    display: flex;
    justify-content: space-between;
    align-items: center;
    
    background: white;
    box-shadow: 0 0 15px black;
    width: 100vw;
    height: 13%;
}
.header-sistema p{
    margin: 20px;
}
.header-sistema a{
    border: none;
    background: black;
    color: white;
    text-decoration: none;
    box-shadow: 0 0 10px black;
    font-size: 14px;
    margin: 20px;
    padding: 10px;
    border-radius: 5px;
    transition: .4s;
}
.header-sistema a:hover{
    background: rgba(24, 24, 24, 1);
}
.header-sistema a:active{
    transition: .2s;
    transform: scale(0.9);
    box-shadow: 0 0 15px black;
}
.titulo-bemvindo{
    display: flex;
    justify-content: center;
    align-items: center;

    color: white;
    width: 100vw;
    height: 87%;
}
</style>
</html>