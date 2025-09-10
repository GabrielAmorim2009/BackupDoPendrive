CREATE DATABASE formulario;
USE formulario;
CREATE TABLE `dados` 
(   
    `ID` INT NOT NULL AUTO_INCREMENT ,
    `nome` VARCHAR(45) NOT NULL ,
    `email` VARCHAR(110) NOT NULL ,
    `telefone` VARCHAR(15) NOT NULL ,
    `genero` VARCHAR(15) NOT NULL ,
    `data_nasc` DATE NOT NULL ,
    `cidade` VARCHAR(45) NOT NULL ,
    `estado` VARCHAR(45) NOT NULL ,
    `endereco` VARCHAR(45) NOT NULL ,
    PRIMARY KEY (`ID`)
)