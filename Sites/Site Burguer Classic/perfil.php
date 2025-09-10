<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="shortcut icon" href="img/Burguer Classic-Logo.png" type="image/x-icon">
    <link rel="stylesheet" href="css/login.css">
    <style>
    .div-perf{
        background-color: black;
        color: white;
    }
    </style>
</head>
<body>

    <?php
    
    $nome = $_POST['nome'] ?? null;
    $senha = $_POST['senha'] ?? null;

    echo '<div class="div-perf">'.$nome.'<br>'.$senha.'</div>'

    ?>

</body>
</html>