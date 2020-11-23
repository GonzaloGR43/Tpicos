-- --------------------------------------------------------
-- Host:                         localhost
-- Versión del servidor:         8.0.22 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para realdelmar
CREATE DATABASE IF NOT EXISTS `realdelmar` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `realdelmar`;

-- Volcando estructura para tabla realdelmar.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `IDClientes` int NOT NULL AUTO_INCREMENT,
  `Nombre_Cliente` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Apellido_P` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Apellido_M` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Clave_Terrenos` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IDContrato` int DEFAULT NULL,
  PRIMARY KEY (`IDClientes`),
  UNIQUE KEY `IDClientes_UNIQUE` (`IDClientes`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla realdelmar.clientes: ~1 rows (aproximadamente)
DELETE FROM `clientes`;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`IDClientes`, `Nombre_Cliente`, `Apellido_P`, `Apellido_M`, `Clave_Terrenos`, `IDContrato`) VALUES
	(4, 'adada', 'sdasd', 'Apellido M', '3', 1);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla realdelmar.contrato
CREATE TABLE IF NOT EXISTS `contrato` (
  `IDContrato` int NOT NULL AUTO_INCREMENT,
  `Fecha_Creacion` datetime DEFAULT NULL,
  `Persona_Fisica` varchar(50) DEFAULT NULL,
  `Nombre_Cliente` varchar(50) DEFAULT NULL,
  `Apellido_P` varchar(45) DEFAULT NULL,
  `Apellido_M` varchar(45) DEFAULT NULL,
  `Clave_Terreno` varchar(50) DEFAULT NULL,
  `Precio` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`IDContrato`),
  UNIQUE KEY `IDContrato_UNIQUE` (`IDContrato`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla realdelmar.contrato: ~0 rows (aproximadamente)
DELETE FROM `contrato`;
/*!40000 ALTER TABLE `contrato` DISABLE KEYS */;
INSERT INTO `contrato` (`IDContrato`, `Fecha_Creacion`, `Persona_Fisica`, `Nombre_Cliente`, `Apellido_P`, `Apellido_M`, `Clave_Terreno`, `Precio`) VALUES
	(1, '2020-10-11 00:00:00', 'Joel', 'Ana Karen ', 'Chavez', 'Castro', '1', 12000);
/*!40000 ALTER TABLE `contrato` ENABLE KEYS */;

-- Volcando estructura para tabla realdelmar.promotores
CREATE TABLE IF NOT EXISTS `promotores` (
  `Clave_Terreno` varchar(50) NOT NULL DEFAULT '',
  `Nombre_promotoro` varchar(50) NOT NULL DEFAULT '',
  `Apellido_P` varchar(50) NOT NULL DEFAULT '',
  `Apellido_M` varchar(50) NOT NULL DEFAULT '',
  `Comision` decimal(10,0) NOT NULL,
  PRIMARY KEY (`Clave_Terreno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla realdelmar.promotores: ~0 rows (aproximadamente)
DELETE FROM `promotores`;
/*!40000 ALTER TABLE `promotores` DISABLE KEYS */;
/*!40000 ALTER TABLE `promotores` ENABLE KEYS */;

-- Volcando estructura para tabla realdelmar.terrenos
CREATE TABLE IF NOT EXISTS `terrenos` (
  `IDTerrenos` varchar(50) NOT NULL DEFAULT '',
  `Clave_Terrenos` varchar(50) DEFAULT NULL,
  `Precio` decimal(10,0) DEFAULT NULL,
  `Superficie` double DEFAULT NULL,
  `Cliente` varchar(50) DEFAULT NULL,
  `Descuento` decimal(10,0) NOT NULL,
  `Abonado` decimal(10,0) NOT NULL,
  `Restante` decimal(10,0) NOT NULL,
  PRIMARY KEY (`IDTerrenos`),
  UNIQUE KEY `IDTerrenos_UNIQUE` (`IDTerrenos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla realdelmar.terrenos: ~0 rows (aproximadamente)
DELETE FROM `terrenos`;
/*!40000 ALTER TABLE `terrenos` DISABLE KEYS */;
/*!40000 ALTER TABLE `terrenos` ENABLE KEYS */;

-- Volcando estructura para tabla realdelmar.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `Usuario` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla realdelmar.usuarios: ~0 rows (aproximadamente)
DELETE FROM `usuarios`;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- Volcando estructura para tabla realdelmar.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `Folio` int NOT NULL AUTO_INCREMENT,
  `Cliente` varchar(50) NOT NULL DEFAULT '',
  `Fecha_de_Pago` datetime NOT NULL,
  `Lugar_de_Pago` varchar(50) NOT NULL DEFAULT '',
  `Cantidad` decimal(10,0) NOT NULL DEFAULT '0',
  `Persona_Fisica` varchar(50) DEFAULT NULL,
  `Fecha_de_Creacion` datetime NOT NULL,
  `Direccion_Deudor` varchar(50) DEFAULT NULL,
  `Poblacion_Deudor` varchar(50) DEFAULT NULL,
  `Intereses` decimal(10,0) DEFAULT NULL,
  `Descuento` decimal(10,0) DEFAULT NULL,
  `Status` varchar(50) NOT NULL DEFAULT '0x',
  PRIMARY KEY (`Folio`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla realdelmar.ventas: ~5 rows (aproximadamente)
DELETE FROM `ventas`;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` (`Folio`, `Cliente`, `Fecha_de_Pago`, `Lugar_de_Pago`, `Cantidad`, `Persona_Fisica`, `Fecha_de_Creacion`, `Direccion_Deudor`, `Poblacion_Deudor`, `Intereses`, `Descuento`, `Status`) VALUES
	(1, 'Gonzalo', '2020-10-05 00:00:00', 'Banco', 1000, 'Jose', '2020-10-06 00:00:00', 'Calle lucas', 'tijuama', 15, 15, 'Cancelado'),
	(8, '', '2020-11-24 00:00:00', 'ggggg', 200, 'ffffggg', '2020-11-23 00:00:00', 'ddddd', 'eeeee', 0, 0, 'Pendiente'),
	(9, '', '2020-11-24 00:00:00', 'dd', 1000, 'pp', '2020-11-23 00:00:00', 'rr', 'aa', 0, 0, 'Pendiente');
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
