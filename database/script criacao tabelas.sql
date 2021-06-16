-- MySQL Workbench Synchronization
-- Generated: 2021-06-14 22:17
-- Model: New Model
-- Version: 1.0
-- Project: Name of the project
-- Author: Marcio

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

CREATE SCHEMA IF NOT EXISTS `WmModas` DEFAULT CHARACTER SET utf8 ;

CREATE TABLE IF NOT EXISTS `WmModas`.`endereco` (
  `enderecoID` INT(11) NOT NULL AUTO_INCREMENT,
  `logradouro` VARCHAR(45) NULL DEFAULT NULL,
  `numero` VARCHAR(45) NULL DEFAULT NULL,
  `complemento` VARCHAR(45) NULL DEFAULT NULL,
  `bairro` VARCHAR(45) NULL DEFAULT NULL,
  `cep` VARCHAR(45) NULL DEFAULT NULL,
  `cidadeID` INT(11) NOT NULL,
  `estadoID` INT(11) NOT NULL,
  PRIMARY KEY (`enderecoID`),
  INDEX `fk_endereco_cidade1_idx` (`cidadeID` ASC) VISIBLE,
  INDEX `fk_endereco_estado1_idx` (`estadoID` ASC) VISIBLE,
  CONSTRAINT `fk_endereco_cidade1`
    FOREIGN KEY (`cidadeID`)
    REFERENCES `WmModas`.`cidade` (`cidadeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_endereco_estado1`
    FOREIGN KEY (`estadoID`)
    REFERENCES `WmModas`.`estado` (`estadoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COMMENT = '		';

CREATE TABLE IF NOT EXISTS `WmModas`.`cidade` (
  `cidadeID` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL DEFAULT NULL,
  `estadoID` INT(11) NOT NULL,
  PRIMARY KEY (`cidadeID`),
  INDEX `fk_cidade_estado1_idx` (`estadoID` ASC) VISIBLE,
  CONSTRAINT `fk_cidade_estado1`
    FOREIGN KEY (`estadoID`)
    REFERENCES `WmModas`.`estado` (`estadoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`cliente` (
  `clienteID` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL DEFAULT NULL,
  `email` VARCHAR(45) NULL DEFAULT NULL,
  `numeroCelular` VARCHAR(45) NULL DEFAULT NULL,
  `ativo` TINYINT(4) NULL DEFAULT NULL,
  `clienteCategoriaID` INT(11) NOT NULL,
  PRIMARY KEY (`clienteID`),
  INDEX `fk_cliente_clienteCategoria1_idx` (`clienteCategoriaID` ASC) VISIBLE,
  CONSTRAINT `fk_cliente_clienteCategoria1`
    FOREIGN KEY (`clienteCategoriaID`)
    REFERENCES `WmModas`.`clienteCategoria` (`clienteCategoriaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`clienteCategoria` (
  `clienteCategoriaID` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`clienteCategoriaID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`estado` (
  `estadoID` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL DEFAULT NULL,
  `uf` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`estadoID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`clienteEndereco` (
  `clienteEnderecoID` INT(11) NOT NULL AUTO_INCREMENT,
  `clienteID` INT(11) NOT NULL,
  `enderecoID` INT(11) NOT NULL,
  PRIMARY KEY (`clienteEnderecoID`),
  INDEX `fk_clienteEndereco_cliente1_idx` (`clienteID` ASC) VISIBLE,
  INDEX `fk_clienteEndereco_endereco1_idx` (`enderecoID` ASC) VISIBLE,
  CONSTRAINT `fk_clienteEndereco_cliente1`
    FOREIGN KEY (`clienteID`)
    REFERENCES `WmModas`.`cliente` (`clienteID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_clienteEndereco_endereco1`
    FOREIGN KEY (`enderecoID`)
    REFERENCES `WmModas`.`endereco` (`enderecoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`pedido` (
  `pedidoID` INT(11) NOT NULL AUTO_INCREMENT,
  `dataPedido` DATETIME NULL DEFAULT NULL,
  `valorPedido` FLOAT(11) NULL DEFAULT NULL,
  `entrega` TINYINT(4) NULL DEFAULT NULL,
  `clienteID` INT(11) NOT NULL,
  `estabelecimentoID` INT(11) NOT NULL,
  PRIMARY KEY (`pedidoID`),
  INDEX `fk_clienteVenda_estabelecimento1_idx` (`estabelecimentoID` ASC) VISIBLE,
  INDEX `fk_clienteVenda_cliente1_idx` (`clienteID` ASC) VISIBLE,
  CONSTRAINT `fk_clienteVenda_estabelecimento1`
    FOREIGN KEY (`estabelecimentoID`)
    REFERENCES `WmModas`.`estabelecimento` (`estabelecimentoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_clienteVenda_cliente1`
    FOREIGN KEY (`clienteID`)
    REFERENCES `WmModas`.`cliente` (`clienteID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`produtoPedido` (
  `produtoPedidoID` INT(11) NOT NULL AUTO_INCREMENT,
  `produtoID` INT(11) NOT NULL,
  `pedidoID` INT(11) NOT NULL,
  PRIMARY KEY (`produtoPedidoID`),
  INDEX `fk_produtoVenda_produto1_idx` (`produtoID` ASC) VISIBLE,
  INDEX `fk_produtoPedido_clientePedido1_idx` (`pedidoID` ASC) VISIBLE,
  CONSTRAINT `fk_produtoVenda_produto1`
    FOREIGN KEY (`produtoID`)
    REFERENCES `WmModas`.`produto` (`produtoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_produtoPedido_clientePedido1`
    FOREIGN KEY (`pedidoID`)
    REFERENCES `WmModas`.`pedido` (`pedidoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`estabelecimento` (
  `estabelecimentoID` INT(11) NOT NULL AUTO_INCREMENT,
  `razaoSocial` VARCHAR(45) NULL DEFAULT NULL,
  `nomeFantasia` VARCHAR(45) NULL DEFAULT NULL,
  `cnpj` VARCHAR(45) NULL DEFAULT NULL,
  `inscricaoEstadual` VARCHAR(45) NULL DEFAULT NULL,
  `ativo` TINYINT(4) NULL DEFAULT NULL,
  `estabelecimentoCatregoriaID` INT(11) NOT NULL,
  PRIMARY KEY (`estabelecimentoID`),
  INDEX `fk_estabelecimento_estabelecimentoCatregoria1_idx` (`estabelecimentoCatregoriaID` ASC) VISIBLE,
  CONSTRAINT `fk_estabelecimento_estabelecimentoCatregoria1`
    FOREIGN KEY (`estabelecimentoCatregoriaID`)
    REFERENCES `WmModas`.`estabelecimentoCatregoria` (`estabelecimentoCatregoriaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`estabelecimentoEndereco` (
  `estabelecimentoEnderecoID` INT(11) NOT NULL AUTO_INCREMENT,
  `estabelecimentoID` INT(11) NOT NULL,
  `enderecoID` INT(11) NOT NULL,
  PRIMARY KEY (`estabelecimentoEnderecoID`),
  INDEX `fk_estabelecimentoEndereco_estabelecimento1_idx` (`estabelecimentoID` ASC) VISIBLE,
  INDEX `fk_estabelecimentoEndereco_endereco1_idx` (`enderecoID` ASC) VISIBLE,
  CONSTRAINT `fk_estabelecimentoEndereco_estabelecimento1`
    FOREIGN KEY (`estabelecimentoID`)
    REFERENCES `WmModas`.`estabelecimento` (`estabelecimentoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_estabelecimentoEndereco_endereco1`
    FOREIGN KEY (`enderecoID`)
    REFERENCES `WmModas`.`endereco` (`enderecoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`produto` (
  `produtoID` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(45) NULL DEFAULT NULL,
  `precoUnidatrio` FLOAT(11) NULL DEFAULT NULL,
  `ativo` TINYINT(4) NULL DEFAULT NULL,
  `produtoCategoriaID` INT(11) NOT NULL,
  PRIMARY KEY (`produtoID`),
  INDEX `fk_produto_produtoCategoria1_idx` (`produtoCategoriaID` ASC) VISIBLE,
  CONSTRAINT `fk_produto_produtoCategoria1`
    FOREIGN KEY (`produtoCategoriaID`)
    REFERENCES `WmModas`.`produtoCategoria` (`produtoCategoriaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`estabelecimentoCatregoria` (
  `estabelecimentoCatregoriaID` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`estabelecimentoCatregoriaID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`estabelecimentoProduto` (
  `idestabelecimentoProduto` INT(11) NOT NULL AUTO_INCREMENT,
  `estabelecimentoID` INT(11) NOT NULL,
  `produtoID` INT(11) NOT NULL,
  PRIMARY KEY (`idestabelecimentoProduto`),
  INDEX `fk_estabelecimentoProduto_estabelecimento1_idx` (`estabelecimentoID` ASC) VISIBLE,
  INDEX `fk_estabelecimentoProduto_produto1_idx` (`produtoID` ASC) VISIBLE,
  CONSTRAINT `fk_estabelecimentoProduto_estabelecimento1`
    FOREIGN KEY (`estabelecimentoID`)
    REFERENCES `WmModas`.`estabelecimento` (`estabelecimentoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_estabelecimentoProduto_produto1`
    FOREIGN KEY (`produtoID`)
    REFERENCES `WmModas`.`produto` (`produtoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`log` (
  `logID` INT(11) NOT NULL,
  `descricao` VARCHAR(45) NULL DEFAULT NULL,
  `dataLog` DATETIME NULL DEFAULT NULL,
  `moduloID` INT(11) NOT NULL,
  PRIMARY KEY (`logID`),
  INDEX `fk_log_modulo1_idx` (`moduloID` ASC) VISIBLE,
  CONSTRAINT `fk_log_modulo1`
    FOREIGN KEY (`moduloID`)
    REFERENCES `WmModas`.`modulo` (`moduloID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`modulo` (
  `moduloID` INT(11) NOT NULL,
  `descricao` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`moduloID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`produtoCategoria` (
  `produtoCategoriaID` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`produtoCategoriaID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`entrega` (
  `entregaID` INT(11) NOT NULL AUTO_INCREMENT,
  `dataEntrega` DATETIME NULL DEFAULT NULL,
  `pedidoID` INT(11) NOT NULL,
  `entregaEnderecoID` INT(11) NOT NULL,
  PRIMARY KEY (`entregaID`),
  INDEX `fk_entrega_pedido1_idx` (`pedidoID` ASC) VISIBLE,
  INDEX `fk_entrega_entregaEndereco1_idx` (`entregaEnderecoID` ASC) VISIBLE,
  CONSTRAINT `fk_entrega_pedido1`
    FOREIGN KEY (`pedidoID`)
    REFERENCES `WmModas`.`pedido` (`pedidoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_entrega_entregaEndereco1`
    FOREIGN KEY (`entregaEnderecoID`)
    REFERENCES `WmModas`.`entregaEndereco` (`entregaEnderecoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`entregaEndereco` (
  `entregaEnderecoID` INT(11) NOT NULL AUTO_INCREMENT,
  `enderecoID` INT(11) NOT NULL,
  PRIMARY KEY (`entregaEnderecoID`),
  INDEX `fk_entregaEndereco_endereco1_idx` (`enderecoID` ASC) VISIBLE,
  CONSTRAINT `fk_entregaEndereco_endereco1`
    FOREIGN KEY (`enderecoID`)
    REFERENCES `WmModas`.`endereco` (`enderecoID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`Usuario` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `DataRegistro` DATETIME NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Login` VARCHAR(45) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Login_UNIQUE` (`Login` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COMMENT = '		';

CREATE TABLE IF NOT EXISTS `WmModas`.`Cidade` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `DataRegistro` DATETIME NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Capital` BIT(1) NOT NULL,
  `EstadoId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Cidade_Estado1_idx` (`EstadoId` ASC) VISIBLE,
  CONSTRAINT `fk_Cidade_Estado1`
    FOREIGN KEY (`EstadoId`)
    REFERENCES `WmModas`.`Estado` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COMMENT = '	';

CREATE TABLE IF NOT EXISTS `WmModas`.`Estado` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `DataRegistro` DATETIME NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Uf` VARCHAR(2) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`Cliente` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `DataRegistro` DATETIME NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Cpf` VARCHAR(11) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`Endereco` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Endereco` VARCHAR(45) NOT NULL,
  `Bairro` VARCHAR(45) NOT NULL,
  `Cep` VARCHAR(45) NOT NULL,
  `Numero` VARCHAR(45) NULL DEFAULT NULL,
  `Complemento` VARCHAR(45) NULL DEFAULT NULL,
  `Referencia` VARCHAR(45) NULL DEFAULT NULL,
  `LogradouroId` INT(11) NOT NULL,
  `CidadeId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Endereco_Cidade1_idx` (`CidadeId` ASC) VISIBLE,
  INDEX `fk_Endereco_Logradouro1_idx` (`LogradouroId` ASC) VISIBLE,
  CONSTRAINT `fk_Endereco_Cidade1`
    FOREIGN KEY (`CidadeId`)
    REFERENCES `WmModas`.`Cidade` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Endereco_Logradouro1`
    FOREIGN KEY (`LogradouroId`)
    REFERENCES `WmModas`.`Logradouro` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`Logradouro` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`ClienteEndereco` (
  `ClienteId` INT(11) NOT NULL,
  `EnderecoId` INT(11) NOT NULL,
  INDEX `fk_ClienteEndereco_Cliente1_idx` (`ClienteId` ASC) VISIBLE,
  INDEX `fk_ClienteEndereco_Endereco1_idx` (`EnderecoId` ASC) VISIBLE,
  CONSTRAINT `fk_ClienteEndereco_Cliente1`
    FOREIGN KEY (`ClienteId`)
    REFERENCES `WmModas`.`Cliente` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ClienteEndereco_Endereco1`
    FOREIGN KEY (`EnderecoId`)
    REFERENCES `WmModas`.`Endereco` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`Item` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `CodigoInterno` VARCHAR(7) NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  `Estoque` INT(11) NOT NULL,
  `ValorUnitario` DECIMAL NOT NULL,
  `ItemCategoriaId` INT(11) NOT NULL,
  `ItemModeloId` INT(11) NOT NULL,
  `ItemCorId` INT(11) NOT NULL,
  `RegistroStatusId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Item_ItemModelo1_idx` (`ItemModeloId` ASC) VISIBLE,
  INDEX `fk_Item_ItemTipo1_idx` (`ItemCategoriaId` ASC) VISIBLE,
  INDEX `fk_Item_ItemCor1_idx` (`ItemCorId` ASC) VISIBLE,
  UNIQUE INDEX `CodigoInterno_UNIQUE` (`CodigoInterno` ASC) VISIBLE,
  INDEX `fk_Item_RegistroStatus1_idx` (`RegistroStatusId` ASC) VISIBLE,
  CONSTRAINT `fk_Item_ItemModelo1`
    FOREIGN KEY (`ItemModeloId`)
    REFERENCES `WmModas`.`ItemModelo` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Item_ItemTipo1`
    FOREIGN KEY (`ItemCategoriaId`)
    REFERENCES `WmModas`.`ItemCategoria` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Item_ItemCor1`
    FOREIGN KEY (`ItemCorId`)
    REFERENCES `WmModas`.`ItemCor` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Item_RegistroStatus1`
    FOREIGN KEY (`RegistroStatusId`)
    REFERENCES `WmModas`.`ItemStatus` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`ItemCategoria` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`ItemModelo` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`Compra` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `FornecedorId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Compra_Fornecedor1_idx` (`FornecedorId` ASC) VISIBLE,
  CONSTRAINT `fk_Compra_Fornecedor1`
    FOREIGN KEY (`FornecedorId`)
    REFERENCES `WmModas`.`Fornecedor` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`ItemCor` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`ItemStatus` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`Fornecedor` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Nome` VARCHAR(45) NULL DEFAULT NULL,
  `Cnpj` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`FornecedorEndereco` (
  `FornecedorId` INT(11) NOT NULL,
  `EnderecoId` INT(11) NOT NULL,
  INDEX `fk_FornecedorEndereco_Fornecedor1_idx` (`FornecedorId` ASC) VISIBLE,
  INDEX `fk_FornecedorEndereco_Endereco1_idx` (`EnderecoId` ASC) VISIBLE,
  CONSTRAINT `fk_FornecedorEndereco_Fornecedor1`
    FOREIGN KEY (`FornecedorId`)
    REFERENCES `WmModas`.`Fornecedor` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_FornecedorEndereco_Endereco1`
    FOREIGN KEY (`EnderecoId`)
    REFERENCES `WmModas`.`Endereco` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`Contato` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` VARCHAR(45) NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  `ContatoTipoId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Contato_ContatoTipo1_idx` (`ContatoTipoId` ASC) VISIBLE,
  CONSTRAINT `fk_Contato_ContatoTipo1`
    FOREIGN KEY (`ContatoTipoId`)
    REFERENCES `WmModas`.`ContatoTipo` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`ContatoTipo` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`ClienteContato` (
  `ClienteId` INT(11) NOT NULL,
  `ContatoId` INT(11) NOT NULL,
  INDEX `fk_ClienteContato_Cliente1_idx` (`ClienteId` ASC) VISIBLE,
  INDEX `fk_ClienteContato_Contato1_idx` (`ContatoId` ASC) VISIBLE,
  CONSTRAINT `fk_ClienteContato_Cliente1`
    FOREIGN KEY (`ClienteId`)
    REFERENCES `WmModas`.`Cliente` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ClienteContato_Contato1`
    FOREIGN KEY (`ContatoId`)
    REFERENCES `WmModas`.`Contato` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`FornecedorContato` (
  `FornecedorId` INT(11) NOT NULL,
  `ContatoId` INT(11) NOT NULL,
  INDEX `fk_FornecedorContato_Contato1_idx` (`ContatoId` ASC) VISIBLE,
  INDEX `fk_FornecedorContato_Fornecedor1_idx` (`FornecedorId` ASC) VISIBLE,
  CONSTRAINT `fk_FornecedorContato_Contato1`
    FOREIGN KEY (`ContatoId`)
    REFERENCES `WmModas`.`Contato` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_FornecedorContato_Fornecedor1`
    FOREIGN KEY (`FornecedorId`)
    REFERENCES `WmModas`.`Fornecedor` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`Venda` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `DataRegistro` DATETIME NOT NULL,
  `ClienteId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Venda_Cliente1_idx` (`ClienteId` ASC) VISIBLE,
  CONSTRAINT `fk_Venda_Cliente1`
    FOREIGN KEY (`ClienteId`)
    REFERENCES `WmModas`.`Cliente` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`OperacaoItem` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Quantidade` VARCHAR(45) NOT NULL,
  `ValorUnitario` DECIMAL NOT NULL,
  `Desconto` DECIMAL NOT NULL,
  `Brinde` BIT(1) NOT NULL,
  `Observacao` VARCHAR(45) NOT NULL,
  `CompraId` INT(11) NOT NULL,
  `VendaId` INT(11) NOT NULL,
  `ItemId` INT(11) NOT NULL,
  `OperacaoTipoId` INT(11) NOT NULL,
  `ItemOperacaoTipoId` INT(11) NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_VendaItem_Venda1_idx` (`VendaId` ASC) VISIBLE,
  INDEX `fk_VendaItem_Item1_idx` (`ItemId` ASC) VISIBLE,
  INDEX `fk_VendaItem_OperacaoTipo1_idx` (`OperacaoTipoId` ASC) VISIBLE,
  INDEX `fk_OperacaoItem_Compra1_idx` (`CompraId` ASC) VISIBLE,
  INDEX `fk_OperacaoItem_ItremOperacaoTipo1_idx` (`ItemOperacaoTipoId` ASC) VISIBLE,
  CONSTRAINT `fk_VendaItem_Venda1`
    FOREIGN KEY (`VendaId`)
    REFERENCES `WmModas`.`Venda` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_VendaItem_Item1`
    FOREIGN KEY (`ItemId`)
    REFERENCES `WmModas`.`Item` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_VendaItem_OperacaoTipo1`
    FOREIGN KEY (`OperacaoTipoId`)
    REFERENCES `WmModas`.`OperacaoTipo` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_OperacaoItem_Compra1`
    FOREIGN KEY (`CompraId`)
    REFERENCES `WmModas`.`Compra` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_OperacaoItem_ItremOperacaoTipo1`
    FOREIGN KEY (`ItemOperacaoTipoId`)
    REFERENCES `WmModas`.`ItemOperacaoTipo` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`OperacaoTipo` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `WmModas`.`ItemOperacaoTipo` (
  `Id` INT(11) NOT NULL,
  `DataRegistro` DATETIME NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
