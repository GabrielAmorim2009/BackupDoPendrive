<title>Menu Circular</title>

<main class="container">
    <div class="div-mncircular">
        <button id="btn-p2" class="btn-mncircular btn-mncircular1" onclick="esconderTudo()"><img src="https://cdn-icons-png.freepik.com/512/3524/3524636.png" alt=""></button>
        <button id="btn-p" class="btn-mncircular btn-mncircular2" onclick="mostrarTudo()"><img src="https://cdn-icons-png.freepik.com/512/3524/3524636.png" alt=""></button>
        
        <button id="b1" class="btn-mncircular"><img src="https://cdn-icons-png.flaticon.com/512/126/126341.png" alt=""></button>
        <button id="b2" class="btn-mncircular"><img src="https://cdn-icons-png.flaticon.com/512/1666/1666591.png" alt=""></button>
        <button id="b3" class="btn-mncircular"><img src="https://cdn-icons-png.flaticon.com/512/1390/1390354.png" alt=""></button>
        <button id="b4" class="btn-mncircular"><img src="https://cdn-icons-png.flaticon.com/512/686/686317.png" alt=""></button>
        <button id="b5" class="btn-mncircular"><img src="https://cdn-icons-png.flaticon.com/512/2782/2782895.png" alt=""></button>
        <button id="b6" class="btn-mncircular"><img src="https://cdn-icons-png.flaticon.com/512/202/202680.png" alt=""></button>
        <button id="b7" class="btn-mncircular"><img src="https://cdn-icons-png.flaticon.com/512/93/93377.png" alt=""></button>
        <button id="b8" class="btn-mncircular"><img src="https://cdn-icons-png.flaticon.com/512/32/32175.png" alt=""></button>
    </div>
</main>

<script>
    var btnp = document.getElementById('btn-p')
    var btnp2 = document.getElementById('btn-p2')
    var b1 = document.getElementById('b1')
    var b2 = document.getElementById('b2')
    var b3 = document.getElementById('b3')
    var b4 = document.getElementById('b4')
    var b5 = document.getElementById('b5')
    var b6 = document.getElementById('b6')
    var b7 = document.getElementById('b7')
    var b8 = document.getElementById('b8')

    function mostrarTudo() {
            btnp.style.zIndex = "1"
            btnp2.style.zIndex = "2"
            b8.style.transform != "translate(109px,-109px)"
            b1.style.transform = "translateX(-155px)"
            b2.style.transform = "translate(-109px,-109px)"
            b3.style.transform = "translateY(155px)"
            b4.style.transform = "translate(-109px,109px)"
            b5.style.transform = "translateX(155px)"
            b6.style.transform = "translate(109px,109px)"
            b7.style.transform = "translateY(-155px)"
            b8.style.transform = "translate(109px,-109px)"
    }

    function esconderTudo() {
            btnp.style.zIndex = "2"
            btnp2.style.zIndex = "1"
            b8.style.transform != "translate(0)"
            b1.style.transform = "translateX(0)"
            b2.style.transform = "translate(0)"
            b3.style.transform = "translateY(0)"
            b4.style.transform = "translate(0)"
            b5.style.transform = "translateX(0)"
            b6.style.transform = "translate(0)"
            b7.style.transform = "translateY(0)"
            b8.style.transform = "translate(0)"
    }
</script>