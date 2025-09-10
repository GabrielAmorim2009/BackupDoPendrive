<?php
    define('DB_HOST',     'localhost'); 
    define('DB_USER',     'root');      
    define('DB_PASS',     '');        
    define('DB_NAME',     'musicas');       
    define('DB_CHARSET',  'utf8mb4');  

function conectar(): PDO {
    $pdo = new PDO(
          "mysql:host=".DB_HOST.";dbname=".DB_NAME.";charset=".DB_CHARSET,DB_USER,DB_PASS
        );
    return $pdo;
}

function cadastrar_musica($dados): void {
    $cx = conectar();
    $sql = "INSERT INTO musica (nome, artista, ano_lancamento, album, genero, img) 
                VALUES (:nome, :artista, :ano_lancamento, :album, :genero, :img)";
        
    $stmt = $cx->prepare($sql);
    try{
        $stmt->execute($dados);
        if ($stmt->rowCount() > 0) {
            echo "<script>alert('Música cadastrada')</script>";
        }
        else {
            echo "<script>alert('Música não cadastrada')</script>";
        }
    }
    catch(PDOException $e) {
        echo "<script>alert('Música não cadastrada')</script>";
    }
}

function alterar_musica($dados): bool {
    $cx = conectar();
    $sql = "UPDATE musica SET nome = :nome, artista = :artista, ano_lancamento = :ano_lancamento, album = :album, genero = :genero, img = :img WHERE id = :id";
    
    $stmt = $cx->prepare($sql);
    try{
        $stmt->execute($dados);
        if ($stmt->rowCount() > 0) {
            return true;
        }
        else {
            return false;
        }
    }
    catch(PDOException $e) {
        echo"<script>alert('Erro ao alterar!')</script>";
        return false;
    }
}

function lista_musica($search=""): array {
    $cx = conectar();
    $sql = "SELECT * FROM musica WHERE musica.nome LIKE :search OR musica.artista LIKE :search OR musica.album LIKE :search";
    $search = "%{$search}%";   
    $stmt = $cx->prepare($sql);
    $stmt->execute([":search" => $search]);
    return $stmt->fetchAll(PDO::FETCH_ASSOC);
}

function lista_musica_id($id): array {
    $cx = conectar();
    $sql = "SELECT * FROM musica WHERE id = :id";
    $stmt = $cx->prepare($sql);
    $stmt->execute([":id" => $id]);
    return $stmt->fetch(PDO::FETCH_ASSOC);
}

function delete_musica($id): void {
    $cx = conectar();
    $sql = "DELETE FROM musica WHERE id = :id";
    $stmt = $cx->prepare($sql);
    try{
        $stmt->execute([":id" => $id]);
        if ($stmt->rowCount() > 0) {
            echo "
            <div class='card-excluir' id='cardexcluir'>
                <h1 id='cadsExCS'>Cadastro excluido com sucesso!!!
                    <img src='https://images.icon-icons.com/2715/PNG/512/x_icon_172101.png' id='xc' alt='' onclick='apagamento()'>
                </h1>
            </div>";
        }
        else {
            echo "
            <div class='card-excluir' id='cardexcluir'>
                <h1 id='cadsExSS'>Cadastro excluido sem sucesso!!!
                    <img src='https://images.icon-icons.com/2715/PNG/512/x_icon_172101.png' id='xs' alt='' onclick='apagamento()'>
                </h1>
            </div>";
        }
    }
    catch(PDOException $e) {
        echo"<script>alert('Erro ao excluir!')</script>";
    }
}
?>
<style>
.card-excluir{
    display: flex;
    justify-content: center;

    width: 100vw;
}
#xc, #xs{
    height: 25px;
    cursor: pointer;
}
#cadsExCS{
    display: flex;
    align-items: center;
    justify-content: space-around;

    background: rgb(172, 255, 172);
    border: solid 1px rgb(140, 248, 140);
    font-size: 20px;
    border-radius: 10px;
    padding: 10px;
    text-align: center;
    width: 480px;
    margin-top: 20px;
}
</style>