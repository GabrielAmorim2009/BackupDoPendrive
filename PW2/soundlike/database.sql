CREATE DATABASE musicas;
USE musicas;
CREATE TABLE musica (
  id int UNSIGNED PRIMARY KEY AUTO_INCREMENT NOT NULL,
  nome varchar(100) NOT NULL,
  artista varchar(100) NOT NULL,
  ano_lancamento date NOT NULL,
  album varchar(100) NOT NULL,
  genero varchar(100) NOT NULL,
  img varchar(1000)
);
INSERT INTO
  musica (nome, artista, ano_lancamento, album, genero, img)
VALUES 
  ('Yes or no', 'Teto', '2025-03-26', 'Maior que o tempo', 'Trap', 'https://akamai.sscdn.co/uploadfile/letras/albuns/7/0/4/8/2916631743168369.jpg'),
  ('A nova era', 'Chefin', '2022-07-07', 'A nova era', 'Trap', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTF7NkFMXOSi3Lum_3o5FZ4KnnfxkIRArFK3w&s'),
  ('Tropa do mais novo', 'Chefin', '2022-07-07', 'A nova era', 'Trap', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTF7NkFMXOSi3Lum_3o5FZ4KnnfxkIRArFK3w&s'),
  ('Mansão privada', 'Love Funk', '2024-03-13', 'Mansão privada', 'Funk', 'https://is1-ssl.mzstatic.com/image/thumb/Music221/v4/86/52/3e/86523eb5-3929-7b6c-a8cf-4cf092a2cd5c/0.jpg/600x600bf-60.jpg'),
  ('Set dos casados', 'GR6', '2021-09-05', 'Set dos casados', 'Funk', 'https://i.scdn.co/image/ab67616d00001e026c0c8fdf92c40838b5bb70cf'),
  ('Na onda da maconha', 'Pedrin', '2024-08-12', 'Na onda da maconha', 'Trap', 'https://cdn-images.dzcdn.net/images/cover/fcbdd0cdf534448372481bea29e81bbe/0x1900-000000-80-0-0.jpg'),
  ('Pavuna 2', 'Pedrin', '2024-09-22', 'Pavuna 2', 'Trap', 'https://cdn-images.dzcdn.net/images/cover/7fe3ab5430144535d6f16b07d56b6e00/500x500.jpg'),
  ('Maloqueiro visionário', 'MC IG', '2022-06-08', 'Maloqueiro visionário', 'Funk', 'https://i.scdn.co/image/ab67616d0000b27364edffc1d6b3c59761f87963'),
  ('Rap do minecraft', 'Player Tauz', '2014-03-25', 'Rap do minecraft', 'Rap', 'https://i1.sndcdn.com/artworks-000171523881-l6r0ak-t500x500.jpg'),
  ('Armamento do irã', 'Tokiodk', '2022-02-22', 'Armamento do irã', 'Trap', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS_W4OjRLaxK7rIRkstdxB86W9u5Z2XyRIrQg&s');
SELECT * FROM musica;