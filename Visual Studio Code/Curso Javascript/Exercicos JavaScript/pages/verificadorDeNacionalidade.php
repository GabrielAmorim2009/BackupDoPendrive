<title>Nacionalidade</title>

<div class="container-nacio">
    
    <h1>Verificar a Nacionalidade</h1>

    <nav class="nav-nacio"> 
        <input type="text" id="nacio" placeholder="Insira uma nacionalidade" required>
        <button id="btn">Verificar</button>
    </nav>

    <div class="div-nacio">
        <p id="txt"></p>
    </div>

    <script>
        let nacionalidade = document.querySelector('input#nacio')
        let btn = document.querySelector('button#btn')
        let txt = document.getElementById('txt')

        btn.onclick = function verificarNacionalidade() {
        let result = nacionalidade.value.toUpperCase()

        if (result == "BRASILEIRO") {
            txt.innerHTML = "Você é Brasileiro 😄"
            txt.innerHTML += `<p>Tu é ${result.toLowerCase()} </p>`
        }
        else {
            txt.innerHTML = "Pra gringo é mais caro"
            txt.innerHTML += `<p>Tu é ${result.toLowerCase()} </p>`
        }
        alert(result)
        }
    </script>

</div>