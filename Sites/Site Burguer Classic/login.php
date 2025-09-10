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

    <div class="div-btncads">
        <a href="index.php"><img src="img/Home Simbolo.png" alt=""></a>
    </div>

    <div class="divform">
    <form action="" method="post">
        <h1>Login</h1>
        <input type="text" placeholder="Nome" name="nome" required>
        <input type="password" placeholder="Senha" name="senha" minlength="8" maxlength="30" required>
        <input type="submit" value="Logar">
        <div>
            <a href="">Esqueci minha senha</a>
            <a href="cadastro.html">Cadastrar</a>
        </div>
    </form>
    </div>

</body>
</html>