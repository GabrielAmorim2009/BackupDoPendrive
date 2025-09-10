<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário</title>
    <link rel="shortcut icon" href="favicon.ico" type="image/x-icon">
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Bungee&display=swap');
        *{
            font-family: "Bungee", sans-serif;
        }
        body{
            display: flex;
            justify-content: center;
            flex-direction: column;
            margin: 0;
        }
        form{
            display: flex;
            justify-content: center;
            flex-direction: column;
            padding: 30px;
            border-radius: 20px;
            border: none;
            box-shadow: 0px 0px 15px;
            margin: 70px 35% 20px 35%;
            background-color: white;
        }
        input{
            font-size: 15px;
            padding: 10px;
            margin: 10px 0px;
            border: solid 2px gray;
            border-radius: 999px;
            outline: 0;
        }
        input[type="submit"]{
            font-size: 20px;
            border: none;
            cursor: pointer;
        }
        input[type="submit"]:hover{
            background-color: gray;
            transition: 0.4s;
        }
        input:focus{
            transition: 0.4s;
            box-shadow: 0px 0px 12px;
        }
        input[type="submit"]:active{
            background-color: black;
            color: white;
        }
        header{
            display: flex;
            justify-content: space-around;
            font-size: 20px;
            background-color: black;
            margin: 0;
            box-shadow: 0px 0px 15px;
        }
        .link{
            text-align: center;
            text-decoration: none;
            color: white;
            padding: 10px;
            width: auto;
            margin: 15px 0px;
            border-radius: 500px;
        }
        .link:hover{
            transition: 0.2s;
            box-shadow: 0px 0px 15px white;
        }
        h1{
            text-align: center;
            font-weight: bold;
        }
        h2{
            text-align: center;
            font-size: 50px;
        }
        .nenhum{
            margin-top: 200px;
            margin-bottom: 150px; 
        }
        .titulo{
            margin: -10px 0px 5px 0px;
            font-size: 30px;
        }
    </style>
</head>
<body>

<header>
    <a href="?op=adicao" class="link">Adição</a>
    <a href="?op=subtracao" class="link">Subtração</a>
    <a href="?op=multiplicacao" class="link">Multiplicação</a>
    <a href="?op=divisao" class="link">Divisão</a>
</header>

    <?php 

    if (@$_GET['op'] == 'adicao') {
        ?>
    <form method="post">
        <h1 class="titulo">ADIÇÃO</h1> 
        <input type="number" name="valor1" placeholder="Numero 1" required>
        <input type="number" name="valor2" placeholder="Numero 2" required>
        <input type="submit" value="Calcular">
    </form>
        <?php
            $valor1 = $_POST['valor1']?? null;
            $valor2 = $_POST['valor2']?? null;
            $result = $valor1 + $valor2;
            echo "<h2>$result</h2>";
    }
    else if(@$_GET['op'] == 'subtracao') {
        ?>
    <form method="post">
        <h1 class="titulo">SUBTRAÇÃO</h1>
        <input type="number" name="valor1" placeholder="Numero 1" required>
        <input type="number" name="valor2" placeholder="Numero 2" required>
        <input type="submit" value="Calcular">
    </form>
        <?php
                $valor1 = $_POST['valor1']?? null;
                $valor2 = $_POST['valor2']?? null;
                $result = $valor1 - $valor2;
                echo "<h2>$result</h2>";
    }
    else if(@$_GET['op'] == 'multiplicacao') {
        ?>
    <form method="post">
        <h1 class="titulo">MULTIPLICAÇÃO</h1>    
        <input type="number" name="valor1" placeholder="Numero 1" required>
        <input type="number" name="valor2" placeholder="Numero 2" required>
        <input type="submit" value="Calcular">
    </form>
        <?php
                $valor1 = $_POST['valor1']?? null;
                $valor2 = $_POST['valor2']?? null;
                $result = $valor1 * $valor2;
                echo "<h2>$result</h2>";
    }
    else if(@$_GET['op'] == 'divisao') {
        ?>
    <form method="post">
        <h1 class="titulo">DIVISÃO</h1>    
        <input type="number" name="valor1" placeholder="Numero 1" required>
        <input type="number" name="valor2" placeholder="Numero 2" min="1" required>
        <input type="submit" value="Calcular">
    </form>
        <?php
                $valor1 = $_POST['valor1']?? 1;
                $valor2 = $_POST['valor2']?? 1;
                $result = $valor1 / $valor2;
                echo "<h2>$result</h2>";
    }
    else {
        echo "<h1 class='nenhum'>Nenhum form foi selecionado</h1>";
    }
    ?>

<script>
        function mudarFundo() {
            let btnMudarFundo = document.getElementById('btnMudarFundo');
            let div = document.getElementById('div');

            if (document.body.style.backgroundColor != "rgb(88, 88, 88)") {
                document.body.style.backgroundColor = "rgb(88, 88, 88)";
                btnMudarFundo.style.backgroundColor = "rgb(43, 43, 43)";
                div.style.transform = "translateX(75px)";
            }
            else if (document.body.style.backgroundColor != "white") {
                document.body.style.backgroundColor = "white";
                btnMudarFundo.style.backgroundColor = "rgb(179, 179, 179)";
                div.style.transform = "translateX(0)";
            }
        }
    </script>

</body>
</html>