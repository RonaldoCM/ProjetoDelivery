-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema DLYDB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Table `PESSOA`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `PESSOA` ;

CREATE TABLE IF NOT EXISTS `PESSOA` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `NOME` VARCHAR(100) NULL,
  `SENHA` VARCHAR(4) NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TIPOLOGRADOURO`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `TIPOLOGRADOURO` ;

CREATE TABLE IF NOT EXISTS `TIPOLOGRADOURO` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `DESCRICAO` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `CIDADE`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `CIDADE` ;

CREATE TABLE IF NOT EXISTS `CIDADE` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `NOME` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `LOGRADOURO`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `LOGRADOURO` ;

CREATE TABLE IF NOT EXISTS `LOGRADOURO` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `NOME` VARCHAR(100) NOT NULL,
  `NUMERO` VARCHAR(4) NOT NULL,
  `TIPOLOGRADOURO_ID` INT NOT NULL,
  `CIDADE_ID` INT NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX `fk_LOGRADOURO_TIPOLOGRADOURO1_idx` (`TIPOLOGRADOURO_ID` ASC) VISIBLE,
  INDEX `fk_LOGRADOURO_CIDADE1_idx` (`CIDADE_ID` ASC) VISIBLE,
  CONSTRAINT `fk_LOGRADOURO_TIPOLOGRADOURO1`
    FOREIGN KEY (`TIPOLOGRADOURO_ID`)
    REFERENCES `TIPOLOGRADOURO` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_LOGRADOURO_CIDADE1`
    FOREIGN KEY (`CIDADE_ID`)
    REFERENCES `CIDADE` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BAIRRO`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `BAIRRO` ;

CREATE TABLE IF NOT EXISTS `BAIRRO` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `NOME` VARCHAR(100) NOT NULL,
  `CIDADE_ID` INT NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX `fk_BAIRRO_CIDADE1_idx` (`CIDADE_ID` ASC) VISIBLE,
  CONSTRAINT `fk_BAIRRO_CIDADE1`
    FOREIGN KEY (`CIDADE_ID`)
    REFERENCES `CIDADE` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PRODUTO`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `PRODUTO` ;

CREATE TABLE IF NOT EXISTS `PRODUTO` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `NOME` VARCHAR(100) NOT NULL,
  `PRECO` DECIMAL(5,2) NOT NULL,
  `DESCRICAO` VARCHAR(200) NULL COMMENT 'INSERIR OS ITENS DO PRODUTO',
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SITUACAOPEDIDO`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `SITUACAOPEDIDO` ;

CREATE TABLE IF NOT EXISTS `SITUACAOPEDIDO` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `DESCRICAO` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PEDIDO`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `PEDIDO` ;

CREATE TABLE IF NOT EXISTS `PEDIDO` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `CODIGO` VARCHAR(45) NULL,
  `DATACRIACAO` DATETIME NOT NULL,
  `VALORFRETE` DECIMAL(5,2) NOT NULL,
  `VALORTOTAL` DECIMAL(5,2) NOT NULL,
  `SITUACAOPEDIDO_ID` INT NOT NULL,
  `PESSOA_ID` INT NOT NULL,
  `LOGRADOURO_ID` INT NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX `fk_PEDIDO_SITUACAOPEDIDO1_idx` (`SITUACAOPEDIDO_ID` ASC) VISIBLE,
  INDEX `fk_PEDIDO_PESSOA1_idx` (`PESSOA_ID` ASC) VISIBLE,
  INDEX `fk_PEDIDO_LOGRADOURO1_idx` (`LOGRADOURO_ID` ASC) VISIBLE,
  CONSTRAINT `fk_PEDIDO_SITUACAOPEDIDO1`
    FOREIGN KEY (`SITUACAOPEDIDO_ID`)
    REFERENCES `SITUACAOPEDIDO` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PEDIDO_PESSOA1`
    FOREIGN KEY (`PESSOA_ID`)
    REFERENCES `PESSOA` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PEDIDO_LOGRADOURO1`
    FOREIGN KEY (`LOGRADOURO_ID`)
    REFERENCES `LOGRADOURO` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ITENSPEDIDO`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ITENSPEDIDO` ;

CREATE TABLE IF NOT EXISTS `ITENSPEDIDO` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `VALOR` DECIMAL(5,2) NULL,
  `QUANTIDADE` INT NOT NULL,
  `PEDIDO_ID` INT NOT NULL,
  `PRODUTO_ID` INT NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX `fk_ITENSPEDIDO_PEDIDO_idx` (`PEDIDO_ID` ASC) VISIBLE,
  INDEX `fk_ITENSPEDIDO_PRODUTO1_idx` (`PRODUTO_ID` ASC) VISIBLE,
  CONSTRAINT `fk_ITENSPEDIDO_PEDIDO`
    FOREIGN KEY (`PEDIDO_ID`)
    REFERENCES `PEDIDO` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ITENSPEDIDO_PRODUTO1`
    FOREIGN KEY (`PRODUTO_ID`)
    REFERENCES `PRODUTO` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
