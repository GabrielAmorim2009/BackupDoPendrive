<title>Descrição</title>

<main class="container-descricao">
    <div class="div-descricao">
        <p id="p" class="titulo-descricao">Lorem ipsum dolor</p>
        <img id="img" src="https://cdn-icons-png.flaticon.com/512/271/271210.png" alt="">
    </div>
</main>

<script>

let img = document.getElementById('img')
let div = document.getElementsByClassName('div-descricao')[0]
let p = document.getElementById('p')
let cont = 0

img.addEventListener('click', () => {
    if (div.style.height != "300px") {
        div.style.height = "300px"
        p.style.height = "92%"
        p.innerHTML = "Lorem ipsum dolor<br><p class='descricao'>sit amet consectetur adipisicing elit. Molestiae, neque ducimus? Possimus pariatur a, porro distinctio libero quia corrupti, consequuntur quibusdam eius, veritatis ducimus quis modi similique necessitatibus ipsum impedit. Lorem ipsum dolor sit amet consectetur adipisicing elit. Distinctio laudantium illo ratione alias animi modi magni rerum quam, expedita tenetur, error iure voluptas delectus ipsam nobis quas facere placeat reiciendis?</p>"
        img.style.transform = "rotateZ(-180deg)"
    }
    else {
        div.style.height = "40px"
        p.style.height = "75%"
        p.innerHTML = "Lorem ipsum dolor"
        img.style.transform = "rotateX(0deg)"
    }
})

</script>