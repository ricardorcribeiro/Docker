CREATE DATABASE produtosdb;

USE produtosdb;

DROP TABLE IF EXISTS `Produtos`;

CREATE TABLE `Produtos`(
    `ProdutoId` int auto_increment,
    `Nome` VARCHAR(80) NOT NULL,
    `Categoria` VARCHAR(50) NOT NULL,
    `Preco` DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (`ProdutoId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLE `Produtos` WRITE;
INSERT INTO `Produtos` VALUES(1, 'Caneta','material escolar', '6.50');
INSERT INTO `Produtos` VALUES(2, 'estojo','material escolar', '3.40');
INSERT INTO `Produtos` VALUES(3, 'borracha','material escolar', '2.50');
UNLOCK TABLE;