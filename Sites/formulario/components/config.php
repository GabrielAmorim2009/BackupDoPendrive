<?php

$dbHost = 'localhost';
$dbUser = 'root';
$dbPassword = '';
$dbName = 'formulario';

$conexao = new mysqli($dbHost,$dbUser,$dbPassword,$dbName);

//if ($conexao->connect_errno) {
//    echo "erro";
//}
//else {
//    echo "Tudo certo 👍🏿";
//};
?>