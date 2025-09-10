<?php
$host = 'localhost';
$db   = 'campeonato_futbol';
$user = 'root';
$pass = '';
$charset = 'utf8mb4';

$dsn = "mysql:host=$host;dbname=$db;charset=$charset";
$options = [
    PDO::ATTR_ERRMODE            => PDO::ERRMODE_EXCEPTION,
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
    PDO::ATTR_EMULATE_PREPARES   => false,
];


function conectar() {
    global $dsn, $user, $pass, $options;
    try {
        $pdo = new PDO($dsn, $user, $pass, $options);
        return $pdo;
    } catch (\PDOException $e) {
        echo 'Erro na conexão: ' . $e->getMessage();
        exit;
    }
}

function listarClubes($search=""): array {
    $pdo = conectar();
    // Exemplo de consulta
    $stmt = $pdo->prepare(query: 'SELECT * FROM clube WHERE nome LIKE :search ORDER BY nome');
    $search = "%$search%";
    $stmt->bindParam(':search', $search);
    $stmt->execute();

    if($stmt->rowCount() > 0) {
        return $stmt->fetchAll();
    } else {
        return [];
    }     
}

function listarClubesJson($search="") {
    header('Content-Type: application/json');
    $lista = listarClubes($search);
    if($lista) {
        $resposta = [
            'status' => 'success',
            'data' => $lista
        ];
        http_response_code(response_code: 200);
        echo json_encode($resposta);
    } else {
        $resposta = [
            'status' => 'error',
            'message' => 'Nenhum clube encontrado.'
        ];
        echo json_encode($resposta);
    }
}

echo listarClubesJson(search: $_GET['search'])

//var_dump(value: listarClubes());
?>