CREATE TABLE `companhias` (
  `idcompanhia` int NOT NULL AUTO_INCREMENT,
  `companhia` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idcompanhia`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `avioes`;

CREATE TABLE `avioes` (
  `idaviao` int NOT NULL AUTO_INCREMENT,
  `modelo` varchar(45) DEFAULT NULL,
  `capacidade` int DEFAULT NULL,
  `anoFabricacao` int DEFAULT NULL,
  `fk_companhia` int DEFAULT NULL,
  PRIMARY KEY (`idaviao`),
  KEY `companhia_idx` (`fk_companhia`),
  CONSTRAINT `companhia` FOREIGN KEY (`fk_companhia`)
  REFERENCES `companhias` (`idcompanhia`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
