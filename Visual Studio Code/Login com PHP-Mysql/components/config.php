<?php

$dbHost = 'localhost';
$dbUser = 'root';
$dbPassword = '1234';
$dbName = 'formulario';

$conexao = new mysqli($dbHost,$dbUser,$dbPassword,$dbName);

if ($conexao->connect_errno) {
    echo "erro";
}
else {
    echo "Tudo certo 👍🏿";
};
?>