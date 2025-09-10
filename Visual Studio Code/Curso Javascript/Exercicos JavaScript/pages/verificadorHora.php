<title>Hora do Dia</title>

<div class="container-verfhora">

<div class="div-verfhora">
    <h1>Hora do Dia</h1>
    <div class="msg-hora" id="msg">
        Aqui vai aparecer a mensagem
    </div>
    <div class="foto-hora" id="foto">
    <img src="/img//imgVerificadorHora//Noite.png" class="imagem" id="imagem">
    </div>
</div>

</div>

<script>
    
document.body.onload = function carregar() {
    var msg = document.getElementById('msg')
    var img = document.getElementById('imagem')
    var data = new Date()
    var hora = data.getHours()
    msg.innerHTML = `Agora são ${hora} horas`
    if (hora >= 0 && hora < 12) {
        img.src = '/img//imgVerificadorHora//Manha.png'
    }
    else if (hora >= 12 && hora <= 18) {    
        img.src = '/img//imgVerificadorHora//Tarde.png'
    }
    else {
        img.src = '/img//imgVerificadorHora//Noite.png'
    }
}

</script>