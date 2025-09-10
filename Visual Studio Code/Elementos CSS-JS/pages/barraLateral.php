<title>Barra Lateral</title>

<main class="container-barralateral">
    <div class="div-barralateral">
        <div class="div-trespontos" id="trespontos">
            <hr>
            <hr>
            <hr>
        </div>
        <a href="" class="logo"><img src="https://icones.pro/wp-content/uploads/2021/02/instagram-icone-noir.png" alt="" title="Instagram"></a>
        <a href="" class="logo"><img src="https://img.icons8.com/m_outlined/512/whatsapp.png" alt="" title="Whatsapp"></a>
        <a href="" class="logo"><img src="https://images.icon-icons.com/2248/PNG/512/facebook_icon_137647.png" alt="" title="Facebook"></a>
        <a href="" class="logo tiktok"><img src="https://cdn-icons-png.flaticon.com/512/1946/1946552.png" alt="" title="TikTok"></a>
        <a href="" class="logo"><img src="https://img.icons8.com/win10/512/twitch.png" alt="" title="Twitch"></a>
        <div class="div-conf">
            <a href="" class="conf"><img src="https://cdn-icons-png.flaticon.com/512/3524/3524636.png" alt="" title="Configurações"></a>
        </div>
    </div>
</main>

<script>
    let tpts = document.getElementById('trespontos')
    let blateral = document.getElementsByClassName('div-barralateral')[0]
    let logo1 = document.getElementsByClassName('logo')[0]
    let logo2 = document.getElementsByClassName('logo')[1]
    let logo3 = document.getElementsByClassName('logo')[2]
    let logo4 = document.getElementsByClassName('logo')[3]
    let logo5 = document.getElementsByClassName('logo')[4]
    let conf = document.getElementsByClassName('conf')[0]

    tpts.addEventListener('mouseover', () => {
        blateral.style.width = "70px"
        tpts.style.width = "60px"
        logo1.style.height = "57px"
        logo1.style.width = "57px"    
        logo2.style.height = "57px"
        logo2.style.width = "57px"    
        logo3.style.height = "57px"
        logo3.style.width = "57px"    
        logo4.style.height = "57px"
        logo4.style.width = "57px"    
        logo5.style.height = "57px"
        logo5.style.width = "57px"    
        conf.style.width = "57px"
        conf.style.height = "57px"
    })
    tpts.addEventListener('click', () => {
        blateral.style.width = "20px"
        tpts.style.width = "10px"   
        logo1.style.height = "20px"
        logo1.style.width = "20px"    
        logo2.style.height = "20px"
        logo2.style.width = "20px"    
        logo3.style.height = "20px"
        logo3.style.width = "20px"    
        logo4.style.height = "20px"
        logo4.style.width = "20px"    
        logo5.style.height = "20px"
        logo5.style.width = "20px" 
        conf.style.width = "20px"
        conf.style.height = "20px" 
    })
</script>