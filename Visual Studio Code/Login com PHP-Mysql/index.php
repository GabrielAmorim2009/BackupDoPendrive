<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário</title>
    <link rel="stylesheet" href="./css/style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.7.2/css/all.min.css" integrity="sha512-Evv84Mr4kqVGRNSgIGL/F/aIDqQb7xQ2vcrdIwxfjThSH8CSR7PBEakCr51Ck+w+/U6swU2Im1vVX0SVk9ABhg==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="shortcut icon" href="./img/KingBet.png" type="image/x-icon">
</head>
<body>
    <form action="" method="" class="form-login">
        <h1 class="titulo">Formulário</h1>

        <div class="div-dados">            
            <input type="text" name="" id="" class="input-nome">
            <label for="" class="lbl-nome">Nome</label>
            <i class="fa-solid fa-user"></i>
        </div>

        <div class="div-dados">            
            <input type="email" name="" id="" class="input-email">
            <label for="" class="lbl-email">Email</label>
            <i class="fa-solid fa-envelope"></i>
        </div>

        <div class="div-dados">            
            <input type="tel" name="" id="" class="input-telefone">
            <label for="" class="lbl-telefone">Telefone</label>
            <i class="fa-solid fa-phone"></i>
        </div>

        <div class="container-genero">            
            <h1 class="titulo-genero">Gênero:</h1>
            <fieldset>
                <div class="div-genero">
                    <input type="radio" name="g" id="" class="">
                    <label for="">Feminino</label>
                </div>
                <div class="div-genero">
                    <input type="radio" name="g" id="" class="">
                    <label for="">Masculino</label>
                </div>
                <div class="div-genero">
                    <input type="radio" name="g" id="" class="">
                    <label for="">Outro</label>
                </div>
            </fieldset>
        </div>

        <div class="div-data">    
            <h1 class="titulo-genero">Data de Nascimento:</h1>        
            <fieldset>
                <input type="date" name="" id="" class="input-nome">
            </fieldset>
        </div>

        <div class="div-dados">            
            <input type="text" name="" id="" class="input-cidade">
            <label for="" class="lbl-cidade">Cidade</label>
            <i class="fa-solid fa-location-dot"></i>
        </div>

        <div class="div-dados">            
            <input type="text" name="" id="" class="input-estado">
            <label for="" class="lbl-estado">Estado</label>
            <i class="fa-solid fa-location-dot"></i>
        </div>

        <div class="div-dados">            
            <input type="text" name="" id="ipt-n" class="input-endereco">
            <label for="" class="lbl-endereco">Endereço</label>
            <i class="fa-solid fa-location-dot"></i>
        </div>

        <button class="btn-enviar" type="submit">Enviar</button>
    </form>

    <script src="./js/script.js"></script>
</body>
</html>