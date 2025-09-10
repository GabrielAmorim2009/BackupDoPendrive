let txtsaldo = document.getElementById('saldo')

let btn50rs = document.getElementById('btn50rs');
let btn100rs = document.getElementById('btn100rs');
let btn500rs = document.getElementById('btn500rs');

let txtValorDeposito = document.getElementById('valorDeposito');
let iptValorDeposito = document.getElementById('iptValorDeposito');
let btnDepositar = document.getElementById('btnDepositar');
let valorDeposito = 0;

btnDepositar?.addEventListener('click', () => {
    if (iptValorDeposito.value.length <= 0) {
        alert('Insira um valor válido');
    } else {
        let valorInput = Number(iptValorDeposito.value);
        if (valorInput < 0 || isNaN(valorInput)) {
            alert('Insira um valor válido');
        } else {
            valorDeposito = valorInput;
            verificarDeposito();
            txtValorDeposito.innerHTML = "R$ " + valorDeposito.toFixed(2);
            localStorage.setItem("valorDeposito", valorDeposito);
            if (valorDeposito > 1000) {
                alert('R$ 1000.00 é o valor máximo');
            }
        }
    }
});

btn50rs?.addEventListener('click', () => {
    if (valorDeposito < 1000) {
        valorDeposito += 50;
        verificarDeposito();
        txtValorDeposito.innerHTML = "R$ " + valorDeposito.toFixed(2);
        localStorage.setItem("valorDeposito", valorDeposito);
    } else {
        alert('Valor máximo atingido');
    }
});

btn100rs?.addEventListener('click', () => {
    if (valorDeposito < 1000) {
        valorDeposito += 100;
        verificarDeposito();
        txtValorDeposito.innerHTML = "R$ " + valorDeposito.toFixed(2);
        localStorage.setItem("valorDeposito", valorDeposito);
    } else {
        alert('Valor máximo atingido');
    }
});

btn500rs?.addEventListener('click', () => {
    if (valorDeposito < 1000) {
        valorDeposito += 500;
        verificarDeposito();
        txtValorDeposito.innerHTML = "R$ " + valorDeposito.toFixed(2);
        localStorage.setItem("valorDeposito", valorDeposito);
    } else {
        alert('Valor máximo atingido');
    }
});

function verificarDeposito() {
    if (valorDeposito > 1000) {
        valorDeposito = 1000;
        txtValorDeposito.innerHTML = "R$ " + valorDeposito.toFixed(2);
    }
}

function rodarRoleta() {
    let numeroEscolhido = parseInt(document.getElementById("numeroEscolhido")?.value);
    let resultado = Math.floor(Math.random() * 10) + 1;
    let saldoRoleta = saldo

    let resultadoDiv = document.getElementById("resultado-roleta");

    if (saldoRoleta < 10) {
        resultadoDiv.innerHTML = "Saldo insuficiente, deposite mais dinheiro 😁";
    }
    else {
        if (isNaN(numeroEscolhido) || numeroEscolhido < 1 || numeroEscolhido > 10) {
            resultadoDiv.innerHTML = "Por favor, escolha um número entre 1 e 10!";
        }
        else {
            if (numeroEscolhido === resultado) {
                resultadoDiv.innerHTML = `Parabéns! Você escolheu ${numeroEscolhido} e a roleta parou no ${resultado}. Você ganhou!`;
                saldoRoleta += 90;
                txtsaldo.innerHTML = "R$ " + saldoRoleta.toFixed(2) + "";
            } 
            else {
                resultadoDiv.innerHTML = `A roleta parou no ${resultado}. Tente novamente!`;
                saldoRoleta -= 10;
                txtsaldo.innerHTML = "R$ " + saldoRoleta.toFixed(2) + "";
            }
        }
    }
}

let logo = document.getElementById('logo');

logo?.addEventListener('click', () => {
    if (logo.style.filter != "grayscale(1)") {
        logo.style.filter = "grayscale(1)";
        localStorage.setItem("logo", "apagada");
    }
    else {
        logo.style.filter = "grayscale(0)";
        localStorage.setItem("logo", "acesa");
    }
});

window.addEventListener("load", () => {
    let valorSalvo = localStorage.getItem("valorDeposito");
    if (valorSalvo !== null) {
        valorDeposito = Number(valorSalvo);
        txtValorDeposito.innerHTML = "R$ " + valorDeposito.toFixed(2);
    }
});

window.addEventListener("load", () => {
    let valorSalvo = localStorage.getItem("valorDeposito");
    let saldo = Number(valorSalvo)

    if (txtsaldo && valorSalvo !== null) {
        txtsaldo.innerHTML = "R$ " + saldo.toFixed(2);
    }
});

window.addEventListener("load", () => {
    let fundo = localStorage.getItem("logo");
    
    if (fundo === "apagada") {
        logo.style.filter = "grayscale(1)"
    } else {
        logo.style.filter = "grayscale(0)"
    }
});
