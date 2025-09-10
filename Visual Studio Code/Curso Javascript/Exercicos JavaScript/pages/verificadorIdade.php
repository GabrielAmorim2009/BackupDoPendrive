<title>Verificar Idade</title>

<div class="container-verfidade">

<div class="div-verfidade">
    <h1>Verificar Idade</h1>
    <div id="msg" class="dados-idade">
        <input type="number" id="txtano" placeholder="Ano Nascimento" min="1" max="130">
        <div class="container-radio">
            <div class="div-radio">
                <label for="mas">Masculino</label>
                <input type="radio" name="rad" id="mas" checked>
            </div>
            <div class="div-radio">
                <label for="fem">Feminino</label>
                <input type="radio" name="rad" id="fem">
            </div>
        </div>
        <input type="button" value="Verificar" onclick="verificar()">
    </div>
    <div id="foto" class="foto-idade">
    <img id="img-idade">
    </div>
    <p id="result" class="result-idade"></p>
</div>

</div>

<script>
    function verificar() {
        var data = new Date()
        var ano = data.getFullYear()
        var fano = document.getElementById("txtano")
        var res = document.getElementById("foto")
        if (fano.value.length == 0 || fano.value > ano) {
            alert('[ERRO] Verifique os Dados')
        }
        else{
            var fsex = document.getElementsByName("rad")
            var idade = ano - fano.value
            var genero = ""
            var img = document.getElementById('img-idade')
            img.setAttribute('class', 'img-idade')
            if (fsex[0].checked) {
                genero = "Homem"
                img.setAttribute('src', '/img//imgVerificadorIdade/Simbolo Maculino.png')
            }
            else if (fsex[1].checked) {
                genero = "Mulher"
                img.setAttribute('src', '/img//imgVerificadorIdade/Simbolo Feminino.png')
            }
            result.innerHTML = ""+genero+" de "+idade+" anos"
        }
    }
</script>