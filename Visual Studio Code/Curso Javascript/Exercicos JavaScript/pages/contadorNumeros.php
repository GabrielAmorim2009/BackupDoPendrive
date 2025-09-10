<title>Contar Números</title>

<div class="container-contnumeros">
    <h1>Contar Números</h1>
    <div>
        <input type="number" class="ipt-inicio" id="numIni" placeholder="Inicio">
        <input type="number" class="ipt-fim" id="numFim" placeholder="Fim">
        <input type="number" class="ipt-passo" id="numPasso" placeholder="Passo">
        <button class="btn-calcnumeros" id="btnCalc">Calcular</button>
        <p id="txtResult">Digite os dados...</p>
    </div>
</div>

<script>
    let btn = document.getElementById('btnCalc')

    btn.onclick = function calcularPassada() {
        let i = document.getElementById('numIni')
        let f = document.getElementById('numFim')
        let p = document.getElementById('numPasso')
        let txt = document.getElementById('txtResult')

        if (i.value.length == 0 || f.value.length == 0 || p.value.length == 0) {
            alert('A COBRA FUMOU')
        }
        else {
            txt.innerHTML = 'Contando... <br>'
            let ini = Number(i.value)
            let fim = Number(f.value)
            let pas = Number(p.value)

            if (pas <= 0) {
                alert('PASSO NÃO USÁVEL!!!!!!!!!')
            }
            if (ini < fim) {
                //contagem crescente
                for (let contador = ini; contador <= fim; contador += pas) {
                    txt.innerHTML += '👉🏿 ' + contador + ' '
                }
            }
            else {
                //contagem decrescente
                for (let contador = ini; contador >= fim; contador -= pas) {
                    txt.innerHTML += '👉🏿 ' + contador + ' '
                }
            }
            txt.innerHTML += ' 🏁'
        }

    }
</script>