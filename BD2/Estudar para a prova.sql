
-- IMPORTANTE 1: Realize um backup do banco de dados antes de executar os comandos abaixo.
-- IMPORTANTE 2: Execute os comandos abaixo um de cada vez, verificando o resultado de cada um antes de executar o próximo.
-- IMPORTANTE 3: Caso algum comando retorne um erro, verifique o comando e corrija-o antes de executar o próximo comando.
-- IMPORTANTE 4: Caso algum comando retorne um resultado diferente do esperado, verifique o comando e corrija-o antes de executar o próximo comando.
-- IMPORTANTE 5: Caso algum comando delete ou altere dados, verifique se os dados foram realmente deletados ou alterados antes de executar o próximo comando.


-- 1) Selecione todos os dados (Id, Nome, ValorDeMercado) de todas as empresas existentes na tabela empresa;
SELECT * FROM empresa;

-- 2) Selecione todos os dados (Simbolo, Nome, Densidade, PesoAtomico, TempFunsao) de todos os metais existentes na tabela metal;
SELECT * FROM metal;

-- 3) Selecione todos os dados (Id, FK_Empresa_Id, FK_Metal_Simbolo, Data, Quantidade) de todas as extrações existentes na tabela extracao;
SELECT * FROM extracao;

-- 4) Selecione apenas o campo Nome da tabela empresa para as empresas que possuem o valor de mercado maior que 5000;
SELECT Nome FROM empresa WHERE ValorDeMercado > 5000;


-- 5) Selecione (Nome, Densidade, TempFusao) da tabela metal para os metais que possuem um peso atômico entre 50 e 100;
SELECT Nome, Densidade, TempFusao FROM metal WHERE PesoAtomico BETWEEN 50 AND 100;

-- 6) Selecione (Nome, ValorDeMercado) da tabela empresa para as empresas que possuem o nome começando com a letra "A";
SELECT Nome, ValorDeMercado FROM empresa WHERE Nome LIKE 'A%';

-- 7) Selecione todos os dados da tabela metal para os metais que possuem uma densidade maior que 10 e um peso atômico menor que 100;
SELECT * FROM metal WHERE Densidade > 10 AND PesoAtomico < 100;

-- 8) Selecione (Nome, ValorDeMercado) da tabela empresa para as empresas que possuem o nome começando com a letra "v" e terminando com a letra "e";
SELECT Nome, ValorDeMercado FROM empresa WHERE Nome LIKE 'v%e';

-- 9) Selecione todos os dados (Simbolo, Nome, Densidade, PesoAtomico, TempFunsao) da tabela metal para os metais que possuam como parte do nome a palavra "pra";
SELECT * FROM metal WHERE Nome LIKE '%pra%';

-- 10) Selecione (FK_Empresa_Id, FK_Metal_Simbolo, Data, QuantEmTonelada) da tabela extracao para as extrações que ocorreram no mês de janeiro de 2020 cuja quantidade é maior que 99 e o fk_Empresa_Id é igual a 1;
SELECT FK_Empresa_Id, FK_Metal_Simbolo, Data, QuantEmTonelada FROM extracao 
WHERE MONTH(Data) = 1 AND YEAR(Data) = 2020 AND `QuantEmTonelada` > 99 AND FK_Empresa_Id = 1;

-- 11) Selecione o Nome e o PesoAtomico do metal que possui o maior peso atômico;
SELECT Nome, PesoAtomico FROM metal WHERE PesoAtomico = (SELECT MAX(PesoAtomico) FROM metal);

-- 12) Selecione o Nome e o ValorDeMercado da empresa que possui o menor valor de mercado;
SELECT Nome, ValorDeMercado FROM empresa WHERE ValorDeMercado = (SELECT MIN(ValorDeMercado) FROM empresa);

-- 13) Selecione o Nome e o ValorDeMercado da empresa que possui o maior valor de mercado;
SELECT Nome, ValorDeMercado FROM empresa WHERE ValorDeMercado = (SELECT MAX(ValorDeMercado) FROM empresa);

-- 14) Crie um comando que mostre a diferença entre o maior e o menor valor de mercado das empresas;
SELECT MAX(ValorDeMercado) - MIN(ValorDeMercado) AS Diferenca FROM empresa;

-- 15) Selecione o Nome e o ValorDeMercado da empresa que possui o nome começando com a letra "n" e terminando com a letra "t";
SELECT Nome, ValorDeMercado FROM empresa WHERE Nome LIKE 'n%t';

-- 16) Selecione (Nome do metal, Data da cotação e valor da cotação) para o Maior valor histórico do metal cujo nome é "Prata", considerando que o valor do metal está na tabela cotacao.
-- Dica: Utilize o comando JOIN para unir as tabelas metal e cotacao.
-- Dica 2: Utilize uma subconsulta para encontrar o maior valor histórico do metal "Prata".
-- Dica 3: Construa a subconsulta primeiro, para obter o maior valor da contação deste metal e depois construa a consulta principal.

-- Subconsulta para encontrar o maior valor histórico do metal "Prata"
SELECT 
        MAX(cotacao.ValorKg)
    FROM
        cotacao
            INNER JOIN
        metal ON metal.Simbolo = cotacao.FK_Metal_Simbolo
    WHERE metal.Nome = "Prata";

-- Consulta principal para obter o Nome do metal, Data da cotação e valor da cotação para o maior valor histórico do metal "Prata"
SELECT
    metal.`Nome`,
    cotacao.`ValorKg`,
    cotacao.`Data`
FROM 
    metal
        INNER JOIN
    cotacao ON metal.Simbolo = cotacao.FK_Metal_Simbolo
WHERE 
    metal.Nome = "Prata" 
        AND cotacao.ValorKg = ( -- a subconsulta é utilizada aqui
                SELECT 
                    MAX(cotacao.ValorKg)
                FROM
                    cotacao
                        INNER JOIN
                    metal ON metal.Simbolo = cotacao.FK_Metal_Simbolo
                WHERE metal.Nome = "Prata"
            );


-- 17) Selecione (Nome do metal, Data da cotação e valor da cotação) para o Menor valor histórico do metal cujo nome é "Cobre", considerando que o valor do metal está na tabela cotacao.
-- Dica: Utilize o comando JOIN para unir as tabelas metal e cotacao.
-- Dica 2: Utilize uma subconsulta para encontrar o menor valor histórico do metal "Cobre".
-- Dica 3: Construa a subconsulta primeiro, para obter o menor valor da contação deste metal e depois construa a consulta principal.
-- Subconsulta para encontrar o menor valor histórico do metal "Cobre"
SELECT 
        MIN(cotacao.ValorKg)
    FROM
        cotacao
            INNER JOIN
        metal ON metal.Simbolo = cotacao.FK_Metal_Simbolo
    WHERE metal.Nome = "Cobre"; 
-- Consulta principal para obter o Nome do metal, Data da cotação e valor da cotação para o menor valor histórico do metal "Cobre"
SELECT
    metal.`Nome`,
    cotacao.`ValorKg`,
    cotacao.`Data`
FROM 
    metal
        INNER JOIN
    cotacao ON metal.Simbolo = cotacao.FK_Metal_Simbolo
WHERE 
    metal.Nome = "Cobre" 
        AND cotacao.ValorKg = ( -- a subconsulta é utilizada aqui
                SELECT 
                    MIN(cotacao.ValorKg)
                FROM
                    cotacao
                        INNER JOIN
                    metal ON metal.Simbolo = cotacao.FK_Metal_Simbolo
                WHERE metal.Nome = "Cobre"
            );

-- 18) Na tabela cotacao, altere todos os registros da cotação do metal cobre (Cu) cujo valor seja igual a 0, para o valor 0.1.
-- Dica 1: Antes de executar o comando de alteração, faça uma consulta (SELECT) para verificar quais registros serão alterados.
-- Dica 2: Utilize o comando UPDATE.
-- Dica 3: Utilize o comando WHERE para filtrar os registros do metal cobre (Cu) e cujo valor seja menor que 1.
-- Dica 4: Utilize o comando SET para alterar o valor da cotação para 1.

SELECT * FROM cotacao WHERE FK_Metal_Simbolo = 'Cu' AND ValorKg = 0;
UPDATE cotacao SET ValorKg = 0.1 WHERE FK_Metal_Simbolo = 'Cu' AND ValorKg = 0;

-- 19) Na tabela empresa, altere o valor de mercado da empresa "Anglo American" para 7500.
-- Dica 1: Antes de executar o comando de alteração, faça uma consulta (SELECT) para verificar o registro que será alterado.
-- Dica 2: Utilize o comando UPDATE.
-- Dica 3: Utilize o comando WHERE para filtrar o registro da empresa "Anglo American".
-- Dica 4: Utilize o comando SET para alterar o valor de mercado para 7500.
SELECT * FROM empresa WHERE Nome = "Anglo American"; 
UPDATE empresa SET ValorDeMercado = 7500 WHERE Nome = "Anglo American";

-- 20) Qual é o valor médio da cotação do metal "Tungstênio"?
SELECT AVG(cotacao.ValorKg) AS ValorMedio
FROM cotacao
INNER JOIN metal ON metal.Simbolo = cotacao.FK_Metal_Simbolo
WHERE metal.Nome = "Tungstênio";

--  21) Qual é o total em extração e a média diária que a empresa "PotashCorp" extrai em relação ao "ferro"?


SELECT
    empresa.Nome AS NomeEmpresa,
    metal.Nome AS NomeMetal,
    COUNT(extracao.`QuantEmTonelada`) AS TotalDeExtracoesEmToneladas,
    AVG(extracao.`QuantEmTonelada`) AS MediaToneladasDiarias
FROM
empresa
    INNER JOIN 
extracao ON empresa.Id = extracao.FK_Empresa_Id
    INNER JOIN 
metal ON metal.Simbolo = extracao.FK_Metal_Simbolo
WHERE 
    empresa.Nome = "PotashCorp" 
    AND 
    metal.Nome = "Ferro"
GROUP BY
    empresa.Nome;

-- 22) Liste os dados da tabela metal, ordenados pelo peso atômico em ordem decrescente.
SELECT * FROM metal ORDER BY PesoAtomico DESC;

-- 23) Liste os dados da tabela empresa, ordenados pelo valor de mercado em ordem crescente.
SELECT * FROM empresa ORDER BY ValorDeMercado ASC;

-- 24) Liste os dados da tabela extracao, ordenados pela data em ordem decrescente.
SELECT * FROM extracao ORDER BY Data DESC;

-- 25) Liste os 10 maiores valores históricos da contação do metal "Ouro".
SELECT * FROM 
    cotacao
WHERE 
    FK_Metal_Simbolo = (SELECT Simbolo FROM metal WHERE Nome = "Ouro")
ORDER BY ValorKg DESC 
LIMIT 10;
-- 26) Liste os 30 maiores valores de contação do metal "Ouro", posteriormente ordenando-os pelo valor em ordem crescente.

SELECT * FROM 
    (SELECT * FROM 
        cotacao
    WHERE 
        FK_Metal_Simbolo = (SELECT Simbolo FROM metal WHERE Nome = "Ouro")
    ORDER BY ValorKg DESC 
    LIMIT 30) AS OuroCotacoes
ORDER BY ValorKg ASC;

-- 27) Liste o valor de cotação médio de cada metal, ordenado pelo nome do metal em ordem alfabética.
SELECT 
    metal.Nome AS NomeMetal,
    AVG(cotacao.ValorKg) AS ValorMedioCotacao
FROM
    metal 
        INNER JOIN
    cotacao ON metal.Simbolo = cotacao.FK_Metal_Simbolo
GROUP BY
    metal.Nome
ORDER BY
    metal.Nome ASC;

-- 28) Liste a quantidade total de extrações por empresa, ordenada pelo nome da empresa em ordem alfabética.
SELECT 
    empresa.Nome AS NomeEmpresa,
    SUM(extracao.QuantEmTonelada) AS QuantidadeTotalExtracoes
FROM
    empresa
        INNER JOIN 
    extracao ON empresa.Id = extracao.FK_Empresa_Id
GROUP BY
    empresa.Nome
ORDER BY
    empresa.Nome ASC;

-- 29) Liste (Nome da empresa, Nome do metal, Quantidade total extraída), ordenada pelo nome da empresa em ordem alfabética e posteriormente pela quantidade total de extração em ordem decrescente.

SELECT 
    empresa.Nome AS NomeEmpresa,
    metal.Nome AS NomeMetal,
    SUM(extracao.QuantEmTonelada) AS QuantidadeTotalExtraida
FROM
    empresa
        INNER JOIN
    extracao ON empresa.Id = extracao.FK_Empresa_Id
        INNER JOIN
    metal ON metal.Simbolo = extracao.FK_Metal_Simbolo
GROUP BY
    empresa.Nome, metal.Nome
ORDER BY
    empresa.Nome ASC, QuantidadeTotalExtraida DESC;


-- 30) Levando em conta cada extração realizada por cada empresa e o valor de cotação do metal na data da extração, liste (Nome da empresa, Nome do metal, Data da extração, Quantidade extraída, Valor da cotação na data da extração, Valor total da extração (Quantidade extraída * Valor da cotação na data da extração)), ordenada pelo nome da empresa em ordem alfabética e posteriormente pela data da extração em ordem decrescente.
SELECT 
    empresa.Nome AS NomeEmpresa,
    metal.Nome AS NomeMetal,
    extracao.Data AS DataExtracao,
    extracao.QuantEmTonelada AS QuantidadeExtraida,
    cotacao.ValorKg AS ValorCotacaoNaData,
    (extracao.QuantEmTonelada * cotacao.ValorKg) AS ValorTotalDaExtracao
FROM
    empresa
        INNER JOIN 
    extracao ON empresa.Id = extracao.FK_Empresa_Id
        INNER JOIN
    metal ON metal.Simbolo = extracao.FK_Metal_Simbolo
        INNER JOIN
    cotacao ON metal.Simbolo = cotacao.FK_Metal_Simbolo
WHERE
    extracao.Data = cotacao.Data
ORDER BY
    empresa.Nome ASC, extracao.Data DESC;

-- Em teoria: Reescrever a query (mesma lógica, mas ajudando o otimizador para melhorar a performance)
SELECT 
    e.Nome AS NomeEmpresa,
    m.Nome AS NomeMetal,
    ex.Data AS DataExtracao,
    ex.QuantEmTonelada AS QuantidadeExtraida,
    c.ValorKg AS ValorCotacaoNaData,
    (ex.QuantEmTonelada * c.ValorKg) AS ValorTotalDaExtracao
FROM 
    extracao ex
        INNER JOIN 
    empresa e ON e.Id = ex.FK_Empresa_Id
        INNER JOIN 
    metal m ON m.Simbolo = ex.FK_Metal_Simbolo
        INNER JOIN 
    cotacao c ON c.FK_Metal_Simbolo = ex.FK_Metal_Simbolo
   AND -- sem utilizar o WHERE, mas sim o AND na junção diretamente
   c.Data = ex.Data
ORDER BY 
    e.Nome ASC, ex.Data DESC;


-- 31) Para cada empresa e para cada dia de extração, calcule o valor bruto obtido.
-- O valor bruto deve considerar a quantidade extraída de cada metal multiplicada pelo valor de cotação correspondente na mesma data.
-- O resultado deve exibir: (Nome da empresa, Data da extração, ValorBruto do dia).

SELECT 
    NomeEmpresa,
    DataExtracao,
    SUM(ValorTotalDaExtracao) AS ValorBrutoDoDia
FROM (
    SELECT 
        empresa.Nome AS NomeEmpresa,
        extracao.Data AS DataExtracao,
        (extracao.QuantEmTonelada * cotacao.ValorKg) AS ValorTotalDaExtracao
    FROM
        empresa
            INNER JOIN 
        extracao ON empresa.Id = extracao.FK_Empresa_Id
            INNER JOIN
        metal ON metal.Simbolo = extracao.FK_Metal_Simbolo
            INNER JOIN
        cotacao ON metal.Simbolo = cotacao.FK_Metal_Simbolo
        AND
        extracao.Data = cotacao.Data
    ORDER BY
        empresa.Nome ASC, extracao.Data DESC
) as ExtracaoComValorDiario
GROUP BY
    NomeEmpresa, DataExtracao;

-- 32) Históricamente, quanto cada empresa lucrou com as suas extrações?
-- O lucro deve considerar a quantidade extraída de cada metal multiplicada pelo valor de cotação correspondente na mesma data.
-- O resultado deve exibir: (Nome da empresa, LucroTotal).

SELECT 
    empresa.Nome AS NomeEmpresa,
    SUM(extracao.QuantEmTonelada * cotacao.ValorKg) AS LucroTotal
FROM
    empresa
        INNER JOIN
    extracao ON empresa.Id = extracao.FK_Empresa_Id
        INNER JOIN
    metal ON metal.Simbolo = extracao.FK_Metal_Simbolo
        INNER JOIN
    cotacao ON metal.Simbolo = cotacao.FK_Metal_Simbolo
WHERE
    extracao.Data = cotacao.Data
GROUP BY
    empresa.Nome
ORDER BY
    empresa.Nome ASC;

-- 33) Se houver, delete todos os registros de extração realizados em finais de semana (sábado e domingo).
-- Dica 1: Antes de executar o comando de deleção, faça uma consulta (SELECT) para verificar quais registros serão deletados.
-- Dica 2: Utilize o comando DELETE.
-- Dica 3: Utilize o comando WHERE para filtrar os registros realizados em finais de semana.
-- Dica 4: Utilize a função DAYOFWEEK() para identificar os dias da semana (1 = Domingo, 7 = Sábado).
SELECT * FROM extracao WHERE DAYOFWEEK(Data) = 1 OR DAYOFWEEK(Data) = 7;
DELETE FROM extracao WHERE DAYOFWEEK(Data) = 1 OR DAYOFWEEK(Data) = 7;

-- 34) Se houver, delete todos os registros de cotação cujo valor seja igual a 0 ou null.;
-- Dica 1: Antes de executar o comando de deleção, faça uma consulta (SELECT) para verificar quais registros serão deletados.
-- Dica 2: Utilize o comando DELETE.    
-- Dica 3: Utilize o comando WHERE para filtrar os registros cujo valor seja igual a 0 ou null.;
SELECT * FROM cotacao WHERE ValorKg = 0 OR ValorKg IS NULL;
DELETE FROM cotacao WHERE ValorKg = 0 OR ValorKg IS NULL;
-- 35) Se houver, delete todas as empresas que não possuem registros de extração.
-- Dica 1: Antes de executar o comando de deleção, faça uma consulta (SELECT) para verificar quais registros serão deletados.
-- Dica 2: Utilize o comando DELETE.    
-- Dica 3: Utilize o comando WHERE para filtrar as empresas que não possuem registros de extração.
SELECT * FROM empresa WHERE Id NOT IN (SELECT DISTINCT FK_Empresa_Id FROM extracao);
DELETE FROM empresa WHERE Id NOT IN (SELECT DISTINCT FK_Empresa_Id FROM extracao);