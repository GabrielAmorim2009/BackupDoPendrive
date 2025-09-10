<?php 
require_once(__DIR__ . "/funcao.php");

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    
    $dados_musica = [
        ':id' => $_POST['id'] ?? null,
        ':nome' => $_POST['nome'] ?? null,
        ':artista' => $_POST['artista'] ?? null,
        ':ano_lancamento' => $_POST['ano_lancamento'] ?? null,
        ':album' => $_POST['album'] ?? null,
        ':genero' => $_POST['genero'] ?? null,
        ':img' => $_POST['img'] ?? null
    ];
    alterar_musica($dados_musica);     
}

$id = isset($_GET['id']) ? $_GET['id'] : null;
if (!$id) {
    header("Location: /?listar");
    exit;
}
$musica = lista_musica_id($id);
if (!$musica) {
    header("Location: /?listar");
    exit;
}
?>

<h2 class="h4-alterar">Alterar Músicas</h2>
<main class="main-alterar">
    <form method="post" class="container-alterar" enctype="multipart/form-data" style="background: linear-gradient(to bottom, rgb(14, 14, 14),rgb(26, 26, 26));">
        <input type="hidden" name="id" value="<?php echo $musica['id']; ?>">

        <div class="col-md-4">
            <label for="nome" class="form-label">Nome</label>
            <input type="text" class="form-control" id="nome" name="nome" value="<?php echo $musica['nome']; ?>">
        </div>

        <div class="col-md-4">
            <label for="artista" class="form-label">Artista</label>
            <input type="text" class="form-control" id="artista" name="artista" value="<?php echo $musica['artista']; ?>">
        </div>

        <div class="col-md-4">
            <label for="ano_lancamento" class="form-label">Ano de Lançamento</label>
            <input type="date" class="form-control" id="ano_lancamento" name="ano_lancamento" value="<?php echo $musica['ano_lancamento']; ?>">
        </div>

        <div class="col-md-4">
            <label for="album" class="form-label">Álbum</label>
            <input type="text" class="form-control" id="album" name="album" value="<?php echo $musica['album']; ?>">
        </div>

        <div class="col-md-4">
            <label for="genero" class="form-label">Gênero</label>
            <input type="text" class="form-control" id="genero" name="genero" value="<?php echo $musica['genero']; ?>">
        </div>

        <div class="col-md-4">
            <label for="genero" class="form-label">Imagem</label>
            <input type="text" class="form-control" id="genero" name="img" value="<?php echo $musica['img']; ?>">
        </div>
        
        <button type="submit" class="btnDEalterar">Alterar</button>
    </form>
</main>