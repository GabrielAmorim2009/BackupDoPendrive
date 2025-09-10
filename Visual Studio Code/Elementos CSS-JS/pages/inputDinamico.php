<title>Input Dinâmico</title>

<main class="container">
    <div class="div-inputdin">
        <main class="main-inputdin">
            <input type="text" id="input" class="inputdin">
            <label for="" class="lbl-inputdin">Escreva</label>
        </main>
        <p id="p" class="txt-inputdin"></p>
    </div>
</main>

<script>
    let input = document.getElementById('input')
    let p = document.getElementById("p")
    
    input.addEventListener("keyup", () => {
        let txt = input.value
        p.innerHTML = txt
    })
</script>