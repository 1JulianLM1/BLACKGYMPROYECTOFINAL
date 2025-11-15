-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: blackgym
-- ------------------------------------------------------
-- Server version	9.3.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `pagos`
--

DROP TABLE IF EXISTS `pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagos` (
  `ID_PAGO` int NOT NULL AUTO_INCREMENT,
  `ID_CLIENTE` int NOT NULL,
  `Fecha_Pago` date DEFAULT NULL,
  `Fecha_Vencimiento` date NOT NULL,
  `ImportePago` int NOT NULL,
  `IngresosRestantes` int NOT NULL,
  PRIMARY KEY (`ID_PAGO`),
  KEY `ID_CLIENTE` (`ID_CLIENTE`),
  CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`ID_CLIENTE`) REFERENCES `usuarios` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
INSERT INTO `pagos` VALUES (38,29,'2025-11-14','2025-12-14',32000,12);
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rol` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'Admin'),(2,'Cliente'),(3,'Recepcionista'),(4,'Entrenador');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tarjetacliente`
--

DROP TABLE IF EXISTS `tarjetacliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tarjetacliente` (
  `IdTarjeta` int NOT NULL AUTO_INCREMENT,
  `IdCliente` int NOT NULL,
  `NumTarjeta` varchar(20) NOT NULL,
  `Fecha_Vencimiento` datetime NOT NULL,
  `CodigoSeguridad` varchar(10) NOT NULL,
  `Importe` decimal(10,2) NOT NULL,
  PRIMARY KEY (`IdTarjeta`),
  KEY `tarjetacliente_usuarios_FK` (`IdCliente`),
  CONSTRAINT `tarjetacliente_usuarios_FK` FOREIGN KEY (`IdCliente`) REFERENCES `usuarios` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tarjetacliente`
--

LOCK TABLES `tarjetacliente` WRITE;
/*!40000 ALTER TABLE `tarjetacliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tarjetacliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turno`
--

DROP TABLE IF EXISTS `turno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `turno` (
  `idTurno` int NOT NULL AUTO_INCREMENT,
  `dia` varchar(100) NOT NULL,
  `hora` time NOT NULL,
  `idUsuario` int NOT NULL,
  PRIMARY KEY (`idTurno`),
  KEY `fk_turnos_usuarios` (`idUsuario`),
  CONSTRAINT `fk_turnos_usuarios` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=124 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turno`
--

LOCK TABLES `turno` WRITE;
/*!40000 ALTER TABLE `turno` DISABLE KEYS */;
INSERT INTO `turno` VALUES (38,'10/11/2025 12:10:36','00:00:00',26),(64,'27/11/2025 12:49:33','08:00:00',28),(68,'9/11/2025 12:59:53','11:00:00',28),(69,'15/11/2025 12:59:53','10:00:00',28),(70,'16/11/2025 12:59:53','11:00:00',28),(71,'20/11/2025 12:59:53','10:00:00',28),(72,'20/11/2025 12:59:53','10:00:00',28),(73,'20/11/2025 12:59:53','10:00:00',28),(74,'4/11/2025 12:59:53','10:00:00',28),(75,'13/11/2025 13:02:15','09:00:00',28),(76,'14/11/2025 13:02:15','10:00:00',28),(77,'22/11/2025 13:02:15','10:00:00',28),(78,'22/11/2025 13:02:15','10:00:00',28),(79,'22/11/2025 13:02:15','10:00:00',28),(80,'20/11/2025 13:02:15','10:00:00',28),(81,'20/11/2025 13:02:15','08:00:00',28),(83,'27/11/2025 13:40:08','09:00:00',29),(84,'27/11/2025 13:40:08','09:00:00',29),(85,'8/10/2025 13:40:08','08:00:00',29),(86,'21/11/2025 13:43:43','10:00:00',29),(87,'7/11/2025 13:53:42','10:00:00',29),(88,'7/11/2025 13:53:42','10:00:00',29),(89,'7/11/2025 13:53:42','10:00:00',29),(90,'7/11/2025 13:53:42','10:00:00',29),(91,'7/11/2025 13:53:42','10:00:00',29),(92,'7/11/2025 13:53:42','10:00:00',29),(93,'7/11/2025 13:53:42','10:00:00',29),(94,'7/11/2025 13:53:42','10:00:00',29),(95,'7/11/2025 13:53:42','10:00:00',29),(96,'7/11/2025 13:53:42','10:00:00',29),(97,'7/11/2025 13:53:42','10:00:00',29),(98,'7/11/2025 13:53:42','10:00:00',29),(99,'12/11/2025 14:04:31','09:00:00',29),(100,'12/11/2025 14:04:31','09:00:00',29),(101,'12/11/2025 14:04:31','09:00:00',29),(102,'12/11/2025 14:04:31','09:00:00',29),(103,'12/11/2025 14:04:31','09:00:00',29),(104,'12/11/2025 14:04:31','09:00:00',29),(105,'12/11/2025 14:04:31','09:00:00',29),(106,'12/11/2025 14:04:31','09:00:00',29),(107,'12/11/2025 14:04:31','09:00:00',29),(108,'12/11/2025 14:04:31','09:00:00',29),(109,'12/11/2025 14:04:31','09:00:00',29),(110,'12/11/2025 14:04:31','09:00:00',29),(111,'12/11/2025 14:04:31','09:00:00',29),(112,'12/11/2025 14:04:31','09:00:00',29),(113,'14/11/2025 14:12:54','09:00:00',29),(114,'13/11/2025 14:21:07','11:00:00',30),(115,'13/11/2025 15:03:41','10:00:00',29),(116,'13/11/2025 15:03:41','10:00:00',29),(117,'13/11/2025 15:03:41','10:00:00',29),(118,'13/11/2025 15:03:41','10:00:00',29),(119,'13/11/2025 15:03:41','10:00:00',29),(120,'13/11/2025 15:03:41','10:00:00',29),(121,'14/11/2025 15:11:00','11:00:00',31),(122,'14/11/2025 15:49:11','10:00:00',29),(123,'20/11/2025 15:51:39','09:00:00',32);
/*!40000 ALTER TABLE `turno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `NombreUsuario` varchar(255) NOT NULL,
  `Contraseña` varchar(255) NOT NULL,
  `CorreoElectronico` varchar(255) NOT NULL,
  `NumeroTelefono` varchar(20) NOT NULL,
  `IdRol` int DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `usuarios_rol_FK` (`IdRol`),
  CONSTRAINT `usuarios_rol_FK` FOREIGN KEY (`IdRol`) REFERENCES `rol` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (19,'julianlm','0f3fde0103dd44077c040215a2fabd09a097aecc','hola123','hola123',1),(20,'julianlm2','5176ba4b4a316b10474a234240fe5eda454996a0','hola2','hola2',3),(21,'Papagallos','7110eda4d09e062aa5e4a390b0a572ac0d2c0220','hoi1232','123123223',2),(22,'enano','c6bf278f0ccca3fd3469bb3418d2d9e5a0df4bda','enano@gmail.com','+545435422',2),(23,'Enano','05a8ea5382b9fd885261bb3eed0527d1d3b07262','enano@gmail.com','56595',2),(25,'enano2','4cad8ed7248f30c8d91f67107e19a4b2000c0a09','enano2','enano2',2),(26,'milanesa0990','7110eda4d09e062aa5e4a390b0a572ac0d2c0220','123444','11111111111',2),(27,'Recepcionista','9b52320cc7c7a8ca36b2f42fad6ce1d6c9835a67','recepcionista','recepcionista',2),(28,'carlos','ff0edd646698f65fa2c8680d00391e368b6d4315','cespedesmatta@gmail.com','2914415120',2),(29,'benga','403926033d001b5279df37cbbe5287b7c7c267fa','benga@gmail.com','2914141290',2),(30,'jorge','44c9b30f7a5334e5c1c81ad08781cd89d33d02c0','jorge@gmail.com','2916497053',3),(31,'negrito04','668c1c7e73b99d0f10d3bf179e829511fc8e1cc9','elnegritomascapito@gmail.com','2914249487',3),(32,'enzo','7110eda4d09e062aa5e4a390b0a572ac0d2c0220','maidana876@gmail.com','2911234567',3);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'blackgym'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-14 23:59:48
