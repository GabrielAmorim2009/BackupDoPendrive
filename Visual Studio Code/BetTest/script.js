function atualizarSaldoNaTela() {
  let elementoSaldo = document.getElementById('saldo');
  if (elementoSaldo) {
    let saldo = Number(localStorage.getItem('saldo')) || 0;
    elementoSaldo.innerHTML = "R$ " + saldo.toFixed(2);
  }
}

function depositar() {
  let input = document.getElementById('valorDeposito');

  let valor = Number(input.value);

  if (isNaN(valor) || valor <= 0) {
    alert("Digite um valor válido.");
    return;
  }

  let saldoAtual = Number(localStorage.getItem('saldo')) || 0;
  let novoSaldo = saldoAtual + valor;
  localStorage.setItem('saldo', novoSaldo);

  atualizarSaldoNaTela();
  input.value = '';
}

function sacar() {
  let input = document.getElementById('valorDeposito');

  let valor = Number(input.value);

  if (isNaN(valor) || valor <= 0) {
    alert("Digite um valor válido.");
    return;
  }

  let saldoAtual = Number(localStorage.getItem('saldo')) || 0;
  if (valor > saldoAtual) {
    alert("Digite um valor válido.");
    return;
  }
  let novoSaldo = saldoAtual - valor;
  localStorage.setItem('saldo', novoSaldo);

  atualizarSaldoNaTela();
  input.value = '';
}

window.addEventListener("load", () => {
    atualizarSaldoNaTela()
})