<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Funções</title>
    <style>
        *{
            font-family: arial;
            font-weight: bold;
            font-size: 50px;
            color: black;
        }
        body{
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
        }
        div{
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
        }
        hr{
            height: 5px;
            width: 420px;
            background-color: black;
        }
        form{
            display: flex;
            flex-direction: column;

            padding: 15px;
            border: none;
            box-shadow: 0 0 15px;
            margin-top: 20px;
        }
        select{
            position: relative;
            cursor: pointer;
            color: transparent;
        }
        h1{
            position: absolute;
            pointer-events: none;
        }
        div{
            position: relative;
        }
    </style>
</head>
<body>
    <?php
        //require_once 'funcao.php';
        //echo '<div>'.compararValor(x:1, y:2).'<br>'.compararValor(1, 1).'<br>'.compararValor(2, 1).'<br>'.compararValor(x:'a', y:'a').'<br>'.'<hr>'.calcularVolEsfera(raio: 10).'<br>'.calcularVolCubo(aresta: 10).'<br>'.'</div>';
        //soma(a: $_POST['num1'], b: $_POST['num2'], callBack: function($valorSoma):void {
        //    echo 'A soma é '.$valorSoma.'';
        //});
        //echo '<br>';
        //function usarResultCallBack($valor):void {
        //  echo "A soma é $valor";
        //}
        //usarResultCallBack(valor: 100);
        //soma(a: $_POST['num1'], b: $_POST['num2'], callBack: usarResultCallBack(valor: $valor));

    require_once 'funcao.php';
    require_once 'dados.php';
    //getEspecie(animais: $animais, callBack: function($especies): void{
    //    var_dump(value: $especies);
    //});
    ?>
    <form method="get">
        <div>
            <select name="especies" class="pp" id="sel">
                <?php
                getEspecie(animais: $animais, callBack: function($especies): void{
                    var_dump(value: $especies);
                    foreach ($especies as $especies) {
                        echo "<option value='{$especies}'>{$especies}</option>";
                    }
                });
                ?>
        </select>
        <h1 id="h1">Selecione</h1>
        </div>
        <input type="submit" value="Enviar">
    </form>
    <?php
        if(isset($_GET['especies'])){
            $especies = $_GET['especies'];
            getAnimaisPorEspecie(
            especies: $especies, 
            animais: $animais,
            callBack: function($animaisDaEspecie):void{
                foreach ($animaisDaEspecie as $animal => $value) {
                    echo "<p>$animal - $value</p>";
                }
            }
        );
        }
    ?>

<div>
    <p></p>
</div>

</body>
</html>