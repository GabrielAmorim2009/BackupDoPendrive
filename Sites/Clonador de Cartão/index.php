<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Verificador Bradesco</title>
    <link rel="stylesheet" href="style.css">
    <link rel="shortcut icon" href="Bradesco.png" type="image/x-icon">
</head>
<body>

<main class="main-container">
    <div class="div-container">

    <div class="div-img">
    <h1>Verificador de Cartão</h1>
    <img src="Bradesco.png" alt="" class="img-bradesco">
    </div>

    <form action="" method="post">
    <div class="div-input">
    <input type="text" class="input-text" placeholder="Nome" name="nome" required>
    </div>
    <div class="div-input">
    <input type="number" class="input-number" placeholder="Numero do Cartão" name="num_cartao" required>
    </div>
    <div class="div-input box3">
        <div class="div-img-cont1">
            <input type="image" class="input-img i1" required>
            <label for="">Frente</label>
        </div>
        <div class="div-img-cont2">
            <input type="image" class="input-img i2" required>
            <label for="">Verso</label>
        </div>
    </div>
    <input type="submit" value="Enviar" class="submit" id="btn">
    </form>

    </div>
</main>

<?php
$nome = $_POST['nome'] ?? null;
$num_cartao = $_POST['num_cartao'] ?? null;
?>

<script>
        let nomeInput = document.querySelector('.input-text');
        let numCartaoInput = document.querySelector('.input-number');
        let fundo = document.getElementById('fundo');
        let btn = document.getElementById('btn')
        
        btn.onclick = function clonarCartão () {
        if (nomeInput.value.trim() !== "" && numCartaoInput.value.trim() !== "") 
        {
            alert('Seu cartão foi clonado com sucesso!!!');
        } 
        else if (nomeInput.value.trim() == "" && numCartaoInput.value.trim() == "") 
        {
            return nomeInput;
        }            
        };
</script>

</body>
</html>