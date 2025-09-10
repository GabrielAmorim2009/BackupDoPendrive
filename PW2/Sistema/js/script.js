fetch('clube/listar.html')
    .then(response => response.text())
    .then(dadosTexto => {
        document.getElementById('conteudo').innerHTML = dadosTexto;
    })
    .catch(error => {
        document.getElementById('conteudo').innerText = 'Erro ao carregar'
    })

const form = document.getElementById('clubeForm');
const tabela = document.getElementById('tabelaClubes').getElementsByTagName('tbody')[0];

function salvarClubes(clubes) {
    localStorage.setItem('clubes', JSON.stringify(clubes));
}

function carregarClubes() {
    const clubes = JSON.parse(localStorage.getItem('clubes')) || [];
    tabela.innerHTML = ''; // Limpa tabela
    clubes.forEach(clube => adicionarLinhaTabela(clube));
}

function adicionarLinhaTabela(clube) {
    const row = tabela.insertRow();
    row.innerHTML = `
        <td>${clube.nome}</td>
        <td>${clube.estadio || '-'}</td>
        <td>${clube.capacidade_estadio || '-'}</td>
        <td>${clube.num_titulos}</td>
        <td><button onclick="removerClube('${clube.nome}')" class="btnExcluir">Excluir</button></td>
    `;
}

function removerClube(nome) {
    let clubes = JSON.parse(localStorage.getItem('clubes')) || [];
    clubes = clubes.filter(c => c.nome.toLowerCase() !== nome.toLowerCase());
    salvarClubes(clubes);
    carregarClubes(); // Recarrega a tabela
}

form.addEventListener('submit', function(e) {
    e.preventDefault();

    const clube = {
        nome: document.getElementById('nome').value.trim(),
        estadio: document.getElementById('estadio').value.trim(),
        capacidade_estadio: parseInt(document.getElementById('capacidade_estadio').value) || null,
        num_titulos: parseInt(document.getElementById('num_titulos').value)
    };

    // Carregar dados existentes
    const clubes = JSON.parse(localStorage.getItem('clubes')) || [];

    // Checa chave primária única (nome)
    if (clubes.some(c => c.nome.toLowerCase() === clube.nome.toLowerCase())) {
        alert('Já existe um clube com este nome.');
        return;
    }

    clubes.push(clube);
    salvarClubes(clubes);
    adicionarLinhaTabela(clube);
    form.reset();
});

// Carrega dados ao abrir
carregarClubes();