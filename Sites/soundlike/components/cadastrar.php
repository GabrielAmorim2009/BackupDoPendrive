<title>SoundLike - Cadastrar</title>

<?php
require_once(__DIR__ . "/funcao.php");

if ($_SERVER['REQUEST_METHOD'] === 'POST') {

    $dados_musica = [
        ':nome' => $_POST['nome'],
        ':artista' => $_POST['artista'],
        ':ano_lancamento' => $_POST['ano_lancamento'],
        ':album' => $_POST['album'],
        ':genero' => $_POST['genero'],
        ':img' => $_POST['img']
    ];

    cadastrar_musica($dados_musica);
    echo "
    <div class='card-excluir a' id='cardexcluir'>
        <h1 id='cadsExCS' class='cads-com-sucess'>Cadastrado com sucesso!!!
            <img src='https://images.icon-icons.com/2715/PNG/512/x_icon_172101.png' id='xc' alt='' onclick='apagamento()'>
        </h1>
    </div>";
}
?>

<link rel="stylesheet" href="/css/style.css">

<div class="container-cadastro">
    <h2 class="titulo-cadastro">Cadastro de Músicas</h2>
    <form method="post" enctype="multipart/form-data">
        <div class="dados-cadastro" style="background: linear-gradient(to bottom, rgb(14, 14, 14),rgb(26, 26, 26));">
            <input type="text" class="" id="nome" name="nome" placeholder="Nome" required>
            <input type="text" class="" id="artista" name="artista" placeholder="Artista" required>
            <input type="date" class="" id="ano_lancamento" name="ano_lancamento" placeholder="Ano de Lançamento" required>
            <input type="text" class="" id="album" name="album" placeholder="Álbum" required>
            <input type="text" class="" id="genero" name="genero" placeholder="Gênero" required>
            <input type="text" class="" id="img" name="img" placeholder="Endereço da imagem">
            <button type="submit" class="btn-cadastrar">Cadastrar</button>
        </div>
    </form>
</div>

<script>
    const delete_musica = (id) => {
        if (confirm("Deseja realmente excluir?")) {
            window.location.href = "?listar&acao=excluir&id=" + id;
        }
    }
    let xc = document.getElementById('xc')
    let xs = document.getElementById('xs')
    let cs = document.getElementById('cadsExCS')
    let ss = document.getElementById('cadsExSS')
    let card = document.getElementById('cardexcluir')

    function apagamento() {
        card.style.display = 'none'
    }
</script>

<style>
    .a{
        width: 99vw;
        margin-bottom: 0;
    }
    #cadsExCS{
        width: 380px;
    }
</style>