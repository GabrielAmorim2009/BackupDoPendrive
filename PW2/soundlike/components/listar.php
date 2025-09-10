<title>SoundLike - Listar</title>
<?php    
    require_once(__DIR__ . "/funcao.php");


    if (isset($_GET["acao"]) && $_GET["acao"] == "excluir") {
        $id = $_GET["id"];
        delete_musica($id);
    }

    $search = isset($_POST["nome"]) ? $_POST["nome"] : '';
    $lista_musica = lista_musica($search);   
?>

<h4 class="h4-listar">Músicas Cadastradas</h4>

<form method="POST" class="form-listar">
    <div class="input-group">
        <div class="div-input">
            <input type="text" name="nome" class="form-control" placeholder="Filtrar por nome" value="<?php echo isset($_POST['nome']) ? htmlspecialchars($_POST['nome']) : ''; ?>">
            <button type="submit" class="btn-lupa">
                <img src="https://images.vexels.com/media/users/3/143356/isolated/preview/64e14fe0195557e3f18ea3becba3169b-lupa-de-pesquisa.png" alt="" class="lupa-pesquisa">
            </button>
        </div>
        <button type="submit" class="btn-filtrar"><i class="bi bi-search"></i> Filtrar</button>
    </div>
</form>

<div class="container-listar">
    <table class="tabela-listar" style="background: linear-gradient(to bottom, rgb(14, 14, 14),rgb(26, 26, 26));">
        <thead class="table-dark">
            <tr class="container-titulos">
                <th class="titulos-listar">Imagem</th>
                <th class="titulos-listar">Nome</th>
                <th class="titulos-listar">Artista</th>
                <th class="titulos-listar">Ano Lançamento</th>
                <th class="titulos-listar">Album</th>
                <th class="titulos-listar">Genero</th>
                <th class="titulos-listar">Ações</th>
            </tr>
            <img src="" alt="">
        </thead>
        <tbody>
            <?php
                if($lista_musica) {
                    foreach($lista_musica as $musica) {
                        $id = $musica["id"];
                        $nome  = $musica["nome"]; 
                        $artista  = $musica["artista"]; 
                        $ano_lancamento  = $musica["ano_lancamento"]; 
                        $album  = $musica["album"]; 
                        $genero  = $musica["genero"]; 
                        $img  = $musica["img"];

                        $ano_lancamento = (new DateTime($ano_lancamento))->format("d/m/Y"); //ele vai formatar a data logo em seguida


                        echo "
                        <tr>
                            <td class='dados-listar'><img src='{$img}' alt='Imagem' width='80' height='80'></td>
                            <td class='dados-listar'>{$nome}</td>
                            <td class='dados-listar'>{$artista}</td>
                            <td class='dados-listar'>{$ano_lancamento}</td>
                            <td class='dados-listar'>{$album}</td>
                            <td class='dados-listar'>{$genero}</td>
                            <td class='align-btns'>
                                <a class='btn-alterar' title='Alterar' href='?listar&acao=alterar&id={$id}'>
                                    <img src='https://cdn-icons-png.flaticon.com/512/700/700291.png' alt=''>
                                </a>
                                <button class='btn-excluir' title='Excluir' onclick='delete_musica({$id})'>
                                    <img src='https://cdn-icons-png.flaticon.com/512/4812/4812459.png' alt=''>
                                </button>
                            </td>
                        </tr>
                        ";
                    }
                } else {
                    echo "
                        <tr class='nret'>
                            <td colspan='7' class='nre'>Nenhum registro encontrado</td>
                        </tr>
                    ";
                }
            ?>                
        </tbody>
    </table>
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
    .card-excluir{
    display: flex;
    justify-content: center;

    width: 98vw;
}
</style>