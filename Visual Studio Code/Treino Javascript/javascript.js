//let num1 = 10;   <=   assim que se declara uma variavel

//let nota > 5 ? 'Aprovado' : 'Reprovado';
//            ^         ^              ^
//se isso for verdade  acontece isso  senão isso 

//alert('A soma dos valores é ' + s);    <=    use o '+' para juntar uma variavel com o texto
//alert(`${nome} tem ${idade} anos`);     <=     você tambem pode usar crase ao inves de aspas

//document.getElementById('soma');     <=      para pegar algo do HMTL pelo id

//Number.parseInt = converter para usar num inteiro
//Number.parseFloat = converter para usar num com virgula

// String(variavel) converter pra string
// (number + number) para adição
// (string + string) para concatenar

//variavel.Length = limitar o tamanho de string
//variavel.toUpperCase() = deixar a string maiuscula
//variavel.toLowerCase() = deixar a string minuscula

//variavel.toFixed(2) = limita quantas casas decimais vai ter o numero
//variavel.toLocaleString('pt-BR', {style: 'currency', currency: 'BRL'})
//                                             ^                    ^   
//                                  mostra em valor monetário     tipo moeda

// 3 += 3 aumenta 3 no 3
// 3 -= 3 tira 3 do 3               no js usa -= para diminuir e += para aumentar

//function mudarFundo() {
//        document.body.style.backgroundColor = "white"   <=     para mudar um estilo de algo do HTML
//}                                                              document serve para pegar algo sem o uso de class
//                                                               nome da classe.style.tag css (tags compostas, ou
//                                                               seja, com hifen{-} n se coloca o hifen, ex: align-items vira alignItems)
//                                                               para imagens deve colocar aspas simples, ex: "url('Roleta de Cassino.jpg')"
//
//function mudarFundo() {
//    document.body.classList.add('fundo-claro');    <=    Adiciona a classe que altera o fundo, a classe ja tem que estar criada no css
//}                                 

//do {
//    valor1 = parseFloat(prompt("Nota 1"));
//} while (isNaN(valor1) || valor1 < 1 || valor1 > 10);

//var corpo = document.body    <=     Depois você podera acessar o body usando essa variavel;
//corpo.style.background = 'white';
// 
//var a1 = document.getElementsByTagName('h1')[0]   <=    O numero 0 vai pegar o primeiro elemento que aparece no código;
//