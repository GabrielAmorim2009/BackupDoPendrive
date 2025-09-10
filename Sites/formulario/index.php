<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Home</title>
    <link rel="stylesheet" href="/css/style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.7.2/css/all.min.css" integrity="sha512-Evv84Mr4kqVGRNSgIGL/F/aIDqQb7xQ2vcrdIwxfjThSH8CSR7PBEakCr51Ck+w+/U6swU2Im1vVX0SVk9ABhg==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="shortcut icon" href="/img/KingBet.png" type="image/x-icon">
</head>
<body>

<main class="main-home">
    <a href="/components/login.php" class="link-home">Login</a>
    <a href="/components/formulario.php" class="link-home">Formulário</a>
</main>

<script src="/js/script.js"></script>

</body>
<style>
.main-home{
    display: flex;
    align-items: center;
    justify-content: space-between;

    background: white;
    height: 30px;
    width: 280px;
    padding: 25px;
    border-radius: 5px;
    box-shadow: 0 0 15px black;
}
.link-home{
    display: flex;
    align-items: center;
    flex-direction: column;    
    position: relative;

    color: black;
    text-decoration: none;
    height: auto;
    font-size: 24px;
    transition: .4s;
}
.link-home::after{
    content: "";
    display: block;
    position: absolute;

    background: black;
    height: 4px;
    width: 0;
    bottom: 0;
    transition: .4s;
}
.link-home:hover{
    color: rgb(0, 255, 200);
}
.link-home:hover::after{
    width: 100%;
    background: rgb(0, 255, 200);
}
</style>
</html>