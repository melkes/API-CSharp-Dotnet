-- MySQL dump 10.13  Distrib 8.0.32, for macos13 (x86_64)
--
-- Host: localhost    Database: shelter_api
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Pets`
--

DROP TABLE IF EXISTS `Pets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Pets` (
  `PetId` int NOT NULL AUTO_INCREMENT,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Species` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Sex` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Color` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Age` int NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`PetId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Pets`
--

LOCK TABLES `Pets` WRITE;
/*!40000 ALTER TABLE `Pets` DISABLE KEYS */;
INSERT INTO `Pets` VALUES 
(1,'Matilda','Cat','Female','brown',7,'est. Nunc laoreet lectus quis massa. Mauris vestibulum,'),
(2,'Rexie','Cat','Female','black',2,'pellentesque massa lobortis ultrices. Vivamus rhoncus. Donec'),
(3,'Matilda','Dog','Male','white',4,'tincidunt tempus risus. Donec egestas. Duis ac arcu.'),
(4,'Pip','Dog','Female','white',4,'enim. Mauris quis turpis vitae purus gravida sagittis. Duis gravida'),
(5,'Bartholomew','Dog','Male','cream',1,'ultrices posuere cubilia Curae Phasellus ornare.'),
(6,'Phoenix','dog','female','brown',0,'Loves belly rubs.'),
(7,'Randall','Cat','Male','brown',13,'a quiet, older gentleman looking for a home to bring him out of his shell.'),
(8,"Adrian","Dog","female","white",20,"Nunc ullamcorper, velit in aliquet lobortis, nisi nibh lacinia orci,"),
(9,"Octavius","Dog","male","black",4,"ultrices. Vivamus rhoncus. Donec est. Nunc ullamcorper, velit in aliquet"),
(10,"Calvin","Cat","female","cream",1,"justo. Proin non massa non ante bibendum ullamcorper. Duis"),
(11,"Joel","Bird","female","brown",28,"Donec nibh. Quisque nonummy ipsum non arcu."),
(12,"Patience","Dog","male","black",20,"pellentesque. Sed dictum. Proin eget odio."),
(13,"Adrian","Dog","female","tan",12,"neque sed dictum eleifend, nunc risus varius orci, in"),
(14,"Porter","Cat","female","brown",12,"Sed auctor odio a purus."),
(15,"Sage","Cat","female","cream",4,"sed turpis nec mauris blandit"),
(16,"Marshall","Cat","male","red",12,"penatibus et magnis dis parturient montes, nascetur ridiculus mus."),
(17,"Rosalyn","Dog","male","grey",8,"convallis erat, eget tincidunt dui augue"),
(18,"Gareth","Cat","female","brown",2,"Nullam enim. Sed nulla ante,"),
(19,"Kai","Dog","female","black",3,"tristique senectus et netus et malesuada fames ac"),
(20,"Madonna","Cat","male","brown",2,"pretium et, rutrum non, hendrerit id, ante. Nunc mauris"),
(21,"Iona","Cat","female","red",2,"Nullam vitae diam. Proin"),
(22,"Justina","Dog","male","black",3,"Mauris nulla. Integer urna. Vivamus molestie"),
(23,"Alvin","Cat","female","red",2,"lacus, varius et, euismod et, commodo at, libero."),
(24,"Fitzgerald","Dog","female","cream",16,"dui quis accumsan convallis, ante lectus convallis est,"),
(25,"Abra","Cat","male","brown",20,"tempor, est ac mattis semper, dui lectus rutrum"),
(26,"Jenna","Fish","female","grey",20,"a nunc. In at pede. Cras vulputate velit eu"),
(27,"Quon","Dog","female","white",7,"tristique ac, eleifend vitae, erat. Vivamus nisi."),
(28,"Amos","Dog","female","tan",20,"lobortis. Class aptent taciti sociosqu ad litora"),
(29,"Richard","Fish","female","grey",20,"lectus, a sollicitudin orci sem eget massa. Suspendisse eleifend."),
(30,"Gray","Reptile","female","grey",13,"leo elementum sem, vitae aliquam eros turpis"),
(31,"Cyrus","Dog","male","brown",8,"ut eros non enim commodo hendrerit."),
(32,"Perry","Fish","female","brown",12,"ut, nulla. Cras eu tellus eu augue porttitor interdum."),
(33,"Abel","Dog","female","black",6,"ac libero nec ligula consectetuer rhoncus. Nullam"),
(34,"Norman","Fish","male","grey",10,"risus odio, auctor vitae, aliquet nec, imperdiet nec, leo."),
(35,"Ursula","Cat","female","black",3,"erat neque non quam. Pellentesque"),
(36,"Calista","Dog","female","black",13,"pede. Suspendisse dui. Fusce diam nunc, ullamcorper eu,"),
(37,"Ruby","Dog","female","red",2,"nascetur ridiculus mus. Proin vel nisl. Quisque fringilla euismod"),
(38,"Geoffrey","Dog","male","brown",17,"arcu iaculis enim, sit"),
(39,"Ivory","Dog","female","tan",17,"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aliquam"),
(40,"Macey","Dog","male","brown",6,"in aliquet lobortis, nisi nibh lacinia orci, consectetuer"),
(41,"Alden","Dog","male","grey",1,"sapien. Cras dolor dolor, tempus non, lacinia at,"),
(42,"Florence","Fish","female","white",21,"Nulla tincidunt, neque vitae semper"),
(43,"Michael","Dog","male","tan",11,"mus. Aenean eget magna. Suspendisse tristique neque"),
(44,"Seth","Dog","female","tan",2,"Sed id risus quis"),
(45,"Celeste","Dog","female","black",5,"nisi a odio semper cursus. Integer mollis. Integer tincidunt"),
(46,"Vance","Cat","female","white",17,"et, euismod et, commodo at, libero. Morbi accumsan laoreet ipsum."),
(47,"Kenneth","Fish","female","tan",1,"pellentesque, tellus sem mollis"),
(48,"Jordan","Reptile","female","brown",3,"congue. In scelerisque scelerisque dui."),
(49,"Tarik","Cat","female","grey",18,"malesuada malesuada. Integer id magna et ipsum cursus vestibulum."),
(50,"Wyatt","Cat","male","grey",5,"urna justo faucibus lectus,");
/*!40000 ALTER TABLE `Pets` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-23  2:37:26
