<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cardápio</title>
    <link rel="shortcut icon" href="img/Burguer Classic-Logo.png" type="image/x-icon">
    <style>
        body{
            margin: 0;
            background-color: rgb(211, 211, 211);
        }
        div{
            padding: 0px 80px;
            display: flex;
            justify-content: center;
        }
        a img{
            position: fixed;
            left: 0;
            top: 0;
            top: 5px;
            width: 78px;
        }
        a img:hover{
            transition: 0.4s;
            filter: invert(0.15);
        }
        .cardapio-mx{
            flex: auto;
            width: 1px;
            box-shadow: 0px 0px 15px black;
        }
    </style>
</head>
<body>

    <div>
        <a href="index.php"><img src="img/Home Simbolo.png" alt=""></a>
        <img src="img/Cardápio.png" alt="" class="cardapio-mx">
    </div>

</body>
</html>