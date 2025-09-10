let txtodd = document.getElementById('odd')
let odd = 1.00
let statusODD

//------------ Resultado Final ------------//
let btn1 = document.getElementById('btn1-resultfinal')    
let btnX = document.getElementById('btnX-resultfinal')
let btn2 = document.getElementById('btn2-resultfinal')

let infoRF = document.getElementById('info-resultfinal')
let btnRF = document.getElementById('btn-resultfinal')
let arrowRF = document.getElementById('arrow-resultfinal')

let state1 = true
let stateX = true
let state2 = true

let odd1 = 1.42
let oddX = 4.40
let odd2 = 7.10

btn1.addEventListener("click", () => {
    if (state1) {
        btn1.classList.remove('unselected')
        btn1.classList.add('selected')
        odd = odd * odd1
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btn1.classList.remove('selected')
        btn1.classList.add('unselected')
        odd = odd / odd1
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    state1 = !state1
    verifyODD()
})
btnX.addEventListener("click", () => {
    if (stateX) {
        btnX.classList.remove('unselected')
        btnX.classList.add('selected')
        odd = odd * oddX
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnX.classList.remove('selected')
        btnX.classList.add('unselected')
        odd = odd / oddX
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateX = !stateX
    verifyODD()
})
btn2.addEventListener("click", () => {
    if (state2) {
        btn2.classList.remove('unselected')
        btn2.classList.add('selected')
        odd = odd * odd2
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btn2.classList.remove('selected')
        btn2.classList.add('unselected')
        odd = odd / odd2
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    state2 = !state2
    verifyODD()
})
infoRF.addEventListener("click", () => {
    if (arrowRF.style.transform != "rotate(180deg)") {
        arrowRF.style.transform = "rotate(180deg)"
        btnRF.style.display = "none"
        infoRF.style.marginBottom = "0"
    }
    else if (arrowRF.style.transform != "rotate(0deg)") {
        arrowRF.style.transform = "rotate(0deg)"
        btnRF.style.display = "flex"
        infoRF.style.marginBottom = "5px"
    }
})
//------------ Resultado Final ------------//


//------------ Gols ------------//
let btnMSGOLS0 = document.getElementById('btn-maisgols0')    
let btnMSGOLS1 = document.getElementById('btn-maisgols1')    
let btnMSGOLS2 = document.getElementById('btn-maisgols2')    
let btnMSGOLS3 = document.getElementById('btn-maisgols3')    
let btnMSGOLS4 = document.getElementById('btn-maisgols4')    
let btnMSGOLS5 = document.getElementById('btn-maisgols5')    
let btnMNGOLS0 = document.getElementById('btn-menosgols0')
let btnMNGOLS1 = document.getElementById('btn-menosgols1')
let btnMNGOLS2 = document.getElementById('btn-menosgols2')
let btnMNGOLS3 = document.getElementById('btn-menosgols3')
let btnMNGOLS4 = document.getElementById('btn-menosgols4')
let btnMNGOLS5 = document.getElementById('btn-menosgols5')

let infoGOLS = document.getElementById('info-gols')
let btnGOLS = document.getElementById('btn-gols')
let arrowGOLS = document.getElementById('arrow-gols')

let stateMSGOLS0 = true
let stateMSGOLS1 = true
let stateMSGOLS2 = true
let stateMSGOLS3 = true
let stateMSGOLS4 = true
let stateMSGOLS5 = true
let stateMNGOLS0 = true
let stateMNGOLS1 = true
let stateMNGOLS2 = true
let stateMNGOLS3 = true
let stateMNGOLS4 = true
let stateMNGOLS5 = true

let oddMSGOLS0 = 1.04
let oddMSGOLS1 = 1.19
let oddMSGOLS2 = 1.48
let oddMSGOLS3 = 2.12
let oddMSGOLS4 = 3.46
let oddMSGOLS5 = 5.98
let oddMNGOLS0 = 9.75
let oddMNGOLS1 = 4.50
let oddMNGOLS2 = 2.33
let oddMNGOLS3 = 1.64
let oddMNGOLS4 = 1.22
let oddMNGOLS5 = 1.09

btnMSGOLS0.addEventListener("click", () => {
    if (stateMSGOLS0) {
        btnMSGOLS0.classList.remove('unselected')
        btnMSGOLS0.classList.add('selected')
        odd = odd * oddMSGOLS0
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMSGOLS0.classList.remove('selected')
        btnMSGOLS0.classList.add('unselected')
        odd = odd / oddMSGOLS0
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMSGOLS0 = !stateMSGOLS0
    verifyODD()
})
btnMSGOLS1.addEventListener("click", () => {
    if (stateMSGOLS1) {
        btnMSGOLS1.classList.remove('unselected')
        btnMSGOLS1.classList.add('selected')
        odd = odd * oddMSGOLS1
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMSGOLS1.classList.remove('selected')
        btnMSGOLS1.classList.add('unselected')
        odd = odd / oddMSGOLS1
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMSGOLS1 = !stateMSGOLS1
    verifyODD()
})
btnMSGOLS2.addEventListener("click", () => {
    if (stateMSGOLS2) {
        btnMSGOLS2.classList.remove('unselected')
        btnMSGOLS2.classList.add('selected')
        odd = odd * oddMSGOLS2
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMSGOLS2.classList.remove('selected')
        btnMSGOLS2.classList.add('unselected')
        odd = odd / oddMSGOLS2
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMSGOLS2 = !stateMSGOLS2
    verifyODD()
})
btnMSGOLS3.addEventListener("click", () => {
    if (stateMSGOLS3) {
        btnMSGOLS3.classList.remove('unselected')
        btnMSGOLS3.classList.add('selected')
        odd = odd * oddMSGOLS3
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMSGOLS3.classList.remove('selected')
        btnMSGOLS3.classList.add('unselected')
        odd = odd / oddMSGOLS3
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMSGOLS3 = !stateMSGOLS3
    verifyODD()
})
btnMSGOLS4.addEventListener("click", () => {
    if (stateMSGOLS4) {
        btnMSGOLS4.classList.remove('unselected')
        btnMSGOLS4.classList.add('selected')
        odd = odd * oddMSGOLS4
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMSGOLS4.classList.remove('selected')
        btnMSGOLS4.classList.add('unselected')
        odd = odd / oddMSGOLS4
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMSGOLS4 = !stateMSGOLS4
    verifyODD()
})
btnMSGOLS5.addEventListener("click", () => {
    if (stateMSGOLS5) {
        btnMSGOLS5.classList.remove('unselected')
        btnMSGOLS5.classList.add('selected')
        odd = odd * oddMSGOLS5
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMSGOLS5.classList.remove('selected')
        btnMSGOLS5.classList.add('unselected')
        odd = odd / oddMSGOLS5
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMSGOLS5 = !stateMSGOLS5
    verifyODD()
})
btnMNGOLS0.addEventListener("click", () => {
    if (stateMNGOLS0) {
        btnMNGOLS0.classList.remove('unselected')
        btnMNGOLS0.classList.add('selected')
        odd = odd * oddMNGOLS0
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMNGOLS0.classList.remove('selected')
        btnMNGOLS0.classList.add('unselected')
        odd = odd / oddMNGOLS0
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMNGOLS0 = !stateMNGOLS0
    verifyODD()
})
btnMNGOLS1.addEventListener("click", () => {
    if (stateMNGOLS1) {
        btnMNGOLS1.classList.remove('unselected')
        btnMNGOLS1.classList.add('selected')
        odd = odd * oddMNGOLS1
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMNGOLS1.classList.remove('selected')
        btnMNGOLS1.classList.add('unselected')
        odd = odd / oddMNGOLS1
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMNGOLS1 = !stateMNGOLS1
    verifyODD()
})
btnMNGOLS2.addEventListener("click", () => {
    if (stateMNGOLS2) {
        btnMNGOLS2.classList.remove('unselected')
        btnMNGOLS2.classList.add('selected')
        odd = odd * oddMNGOLS2
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMNGOLS2.classList.remove('selected')
        btnMNGOLS2.classList.add('unselected')
        odd = odd / oddMNGOLS2
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMNGOLS2 = !stateMNGOLS2
    verifyODD()
})
btnMNGOLS3.addEventListener("click", () => {
    if (stateMNGOLS3) {
        btnMNGOLS3.classList.remove('unselected')
        btnMNGOLS3.classList.add('selected')
        odd = odd * oddMNGOLS3
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMNGOLS3.classList.remove('selected')
        btnMNGOLS3.classList.add('unselected')
        odd = odd / oddMNGOLS3
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMNGOLS3 = !stateMNGOLS3
    verifyODD()
})
btnMNGOLS4.addEventListener("click", () => {
    if (stateMNGOLS4) {
        btnMNGOLS4.classList.remove('unselected')
        btnMNGOLS4.classList.add('selected')
        odd = odd * oddMNGOLS4
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMNGOLS4.classList.remove('selected')
        btnMNGOLS4.classList.add('unselected')
        odd = odd / oddMNGOLS4
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMNGOLS4 = !stateMNGOLS4
    verifyODD()
})
btnMNGOLS5.addEventListener("click", () => {
    if (stateMNGOLS5) {
        btnMNGOLS5.classList.remove('unselected')
        btnMNGOLS5.classList.add('selected')
        odd = odd * oddMNGOLS5
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnMNGOLS5.classList.remove('selected')
        btnMNGOLS5.classList.add('unselected')
        odd = odd / oddMNGOLS5
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateMNGOLS5 = !stateMNGOLS5
    verifyODD()
})
infoGOLS.addEventListener("click", () => {
    if (arrowGOLS.style.transform != "rotate(180deg)") {
        arrowGOLS.style.transform = "rotate(180deg)"
        btnGOLS.style.display = "none"
        infoGOLS.style.marginBottom = "0"
    }
    else if (arrowGOLS.style.transform != "rotate(0deg)") {
        arrowGOLS.style.transform = "rotate(0deg)"
        btnGOLS.style.display = "flex"
        infoGOLS.style.marginBottom = "5px"
    }
})
//------------ Gols ------------//


//------------ Ambas Marcam ------------//
let btnAMBASM = document.getElementById('btn-ambassim')
let btnAMBASN = document.getElementById('btn-ambasnao')

let infoAMBAS = document.getElementById('info-ambas')
let btnAMBAS = document.getElementById('btn-ambas')
let arrowAMBAS = document.getElementById('arrow-ambas')

let stateAMBASM = true
let stateAMBASN = true

let oddAMBASM = 1.82
let oddAMBASN = 1.94

btnAMBASM.addEventListener("click", () => {
    if (stateAMBASM) {
        btnAMBASM.classList.remove('unselected')
        btnAMBASM.classList.add('selected')
        odd = odd * oddAMBASM
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnAMBASM.classList.remove('selected')
        btnAMBASM.classList.add('unselected')
        odd = odd / oddAMBASM
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateAMBASM = !stateAMBASM
    verifyODD()
})
btnAMBASN.addEventListener("click", () => {
    if (stateAMBASN) {
        btnAMBASN.classList.remove('unselected')
        btnAMBASN.classList.add('selected')
        odd = odd * oddAMBASN
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    } else {
        btnAMBASN.classList.remove('selected')
        btnAMBASN.classList.add('unselected')
        odd = odd / oddAMBASN
        txtodd.innerHTML = 'ODD = ' + odd.toFixed(2) + ''
    }
    stateAMBASN = !stateAMBASN
    verifyODD()
})
infoAMBAS.addEventListener("click", () => {
    if (arrowAMBAS.style.transform != "rotate(180deg)") {
        arrowAMBAS.style.transform = "rotate(180deg)"
        btnAMBAS.style.display = "none"
        infoAMBAS.style.marginBottom = "0"
    }
    else if (arrowAMBAS.style.transform != "rotate(0deg)") {
        arrowAMBAS.style.transform = "rotate(0deg)"
        btnAMBAS.style.display = "flex"
        infoAMBAS.style.marginBottom = "5px"
    }
})
//------------ Ambas Marcam ------------//

function verifyODD() {
    if (
    (state1 == false && stateX == false) ||
    (state1 == false && state2 == false) ||
    (stateX == false && state2 == false) ||

    (state1 == false && stateMNGOLS0 == false) ||
    (state2 == false && stateMNGOLS0 == false) ||

    (stateMNGOLS0 == false && stateAMBASM == false) ||
    (stateMNGOLS1 == false && stateAMBASM == false) ||

    (state1 == false && stateMNGOLS2 == false && stateAMBASM == false) ||
    (state2 == false && stateMNGOLS2 == false && stateAMBASM == false) ||

    (stateMSGOLS0 == false && stateMNGOLS0 == false) ||
    (stateMSGOLS1 == false && stateMNGOLS1 == false) ||
    (stateMSGOLS2 == false && stateMNGOLS2 == false) ||
    (stateMSGOLS3 == false && stateMNGOLS3 == false) ||
    (stateMSGOLS4 == false && stateMNGOLS4 == false) ||
    (stateMSGOLS5 == false && stateMNGOLS5 == false) ||

    (stateMSGOLS0 == false && stateMSGOLS1 == false) ||
    (stateMSGOLS0 == false && stateMSGOLS2 == false) ||
    (stateMSGOLS0 == false && stateMSGOLS3 == false) ||
    (stateMSGOLS0 == false && stateMSGOLS4 == false) ||
    (stateMSGOLS0 == false && stateMSGOLS5 == false) ||

    (stateMSGOLS1 == false && stateMSGOLS2 == false) ||
    (stateMSGOLS1 == false && stateMSGOLS3 == false) ||
    (stateMSGOLS1 == false && stateMSGOLS4 == false) ||
    (stateMSGOLS1 == false && stateMSGOLS5 == false) ||

    (stateMSGOLS2 == false && stateMSGOLS3 == false) ||
    (stateMSGOLS2 == false && stateMSGOLS4 == false) ||
    (stateMSGOLS2 == false && stateMSGOLS5 == false) ||

    (stateMSGOLS3 == false && stateMSGOLS4 == false) ||
    (stateMSGOLS3 == false && stateMSGOLS5 == false) ||

    (stateMSGOLS4 == false && stateMSGOLS5 == false) ||

    (stateMNGOLS0 == false && stateMNGOLS1 == false) ||
    (stateMNGOLS0 == false && stateMNGOLS2 == false) ||
    (stateMNGOLS0 == false && stateMNGOLS3 == false) ||
    (stateMNGOLS0 == false && stateMNGOLS4 == false) ||
    (stateMNGOLS0 == false && stateMNGOLS5 == false) ||

    (stateMNGOLS1 == false && stateMNGOLS2 == false) ||
    (stateMNGOLS1 == false && stateMNGOLS3 == false) ||
    (stateMNGOLS1 == false && stateMNGOLS4 == false) ||
    (stateMNGOLS1 == false && stateMNGOLS5 == false) ||

    (stateMNGOLS2 == false && stateMNGOLS3 == false) ||
    (stateMNGOLS2 == false && stateMNGOLS4 == false) ||
    (stateMNGOLS2 == false && stateMNGOLS5 == false) ||

    (stateMNGOLS3 == false && stateMNGOLS4 == false) ||
    (stateMNGOLS3 == false && stateMNGOLS5 == false) ||

    (stateMNGOLS4 == false && stateMNGOLS5 == false) ||

    (stateMNGOLS0 == false && stateMSGOLS1 == false) ||
    (stateMNGOLS0 == false && stateMSGOLS2 == false) ||
    (stateMNGOLS0 == false && stateMSGOLS3 == false) ||
    (stateMNGOLS0 == false && stateMSGOLS4 == false) ||
    (stateMNGOLS0 == false && stateMSGOLS5 == false) ||

    (stateMNGOLS1 == false && stateMSGOLS2 == false) ||
    (stateMNGOLS1 == false && stateMSGOLS3 == false) ||
    (stateMNGOLS1 == false && stateMSGOLS4 == false) ||
    (stateMNGOLS1 == false && stateMSGOLS5 == false) ||

    (stateMNGOLS2 == false && stateMSGOLS3 == false) ||
    (stateMNGOLS2 == false && stateMSGOLS4 == false) ||
    (stateMNGOLS2 == false && stateMSGOLS5 == false) ||

    (stateMNGOLS3 == false && stateMSGOLS4 == false) ||
    (stateMNGOLS3 == false && stateMSGOLS5 == false) ||

    (stateMNGOLS4 == false && stateMSGOLS5 == false) 
    ) {
        txtodd.innerHTML = 'ODD INVÁLIDA!!!'
        statusODD = false
    }
    else{
        statusODD = true
    }
    if (odd < 1.00000001) {
        txtodd.innerHTML = 'Nenhuma odd foi selecionada'
        statusODD = false
    }
    else{
        statusODD = true
    }}

//------------ Depósito ------------//
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
//------------ Depósito ------------//

//------------ Aposta ------------//
function apostar() {
  let iptAposta = document.getElementById("inputAposta")
  let valorAposta = Number(iptAposta.value)

  if (isNaN(valorAposta) || valorAposta <= 0) {
    alert("Digite um valor válido.");
    return;
  }

  let saldoAtual = Number(localStorage.getItem('saldo')) || 0;
  if (valorAposta > saldoAtual) {
    alert("Digite um valor válido.");
    return;
  }
  //let novoSaldo = saldoAtual - valorAposta;
  if (!statusODD) {
      alert("ESTÁ ODD É INVÁLIDA!!!")
      return
    }
      let novoSaldo = saldoAtual + (valorAposta * (odd - 1))
      localStorage.setItem('saldo', novoSaldo);
      
      atualizarSaldoNaTela();
      iptAposta.value = '';
}
//------------ Aposta ------------//