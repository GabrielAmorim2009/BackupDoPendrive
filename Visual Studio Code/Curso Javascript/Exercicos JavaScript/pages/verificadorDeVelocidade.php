<title>Verificar Velocidade</title>

<div class="container-verfvelo">

    <h1 class="titulo-multa">Sistema de Multas</h1>
    
    <div class="div-velo">
        <input type="number" name="" id="velocidade">
        <input type="button" value="Verificar" id="btn-verificar">
    </div>

    <main class="main-result">
        <p id="result"></p>
        <p id="dica"></p>
    </main>

    <script>
        let btn = document.getElementById('btn-verificar')

        btn.onclick = function calcularVelocidade() {
            let txtvel = document.querySelector('input#velocidade')
            let result = document.querySelector('p#result')
            let velocidade = Number(txtvel.value)
            let status = document.getElementById('dica')

            result.innerHTML = "Sua velocidade é " + velocidade + " Km/h "
            
            if (velocidade <= 120) {
                status.innerHTML = "Você está dentro do limite de velocidade"
            }
            else if (velocidade > 120) {
                status.innerHTML = "Você passou do limite de velocidade"
            }
        }
    </script>