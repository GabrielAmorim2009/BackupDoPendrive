<?php

function compararValor($x, $y):string //vai retornar uma string
{
    if ($x < $y)
        return ''.$x.' é menor que o '.$y.'';
    else if ($x == $y)
        return ''.$x.' é igual o '.$y.'';
    else
        return ''.$x.' é maior que o '.$y.'';
}
function compararValor2($x, $y):void //não tem retorno,    quando n é void é obrigatorio ter um return
{
    if ($x < $y)
        echo ''.$x.' é menor que o '.$y.'';
    else if ($x == $y)
        echo ''.$x.' é igual o '.$y.'';
    else
        echo ''.$x.' é maior que o '.$y.'';
}

function calcularVolEsfera($raio):float
{
    return (4/3)*pi()*pow(num: $raio, exponent: 3);
}
function calcularVolCubo($aresta):float
{
    return pow(num: $aresta, exponent: 3);
}
function soma($a, $b, $callBack):void 
{
    $valorSoma = $a + $b;
    $callBack($valorSoma);
}

require_once 'dados.php';

function getEspecie($animais, $callBack):void {
    $especies = [];
    foreach ($animais as $key => $values) {
        $especies[] = $key;
    }
    $callBack($especies);
}

function getAnimaisPorEspecie($especies,$animais, $callBack): void{
    $callBack($animais[$especies]);
}
?>