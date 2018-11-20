/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 8.0.13 : Database - orderserver
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`orderserver` /*!40100 DEFAULT CHARACTER SET gbk */;

USE `orderserver`;

/*Table structure for table `client` */

DROP TABLE IF EXISTS `client`;

CREATE TABLE `client` (
  `客户名` text CHARACTER SET gbk COLLATE gbk_chinese_ci,
  `客户订单号` text CHARACTER SET gbk COLLATE gbk_chinese_ci,
  `客户手机号` text
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

/*Data for the table `client` */

insert  into `client`(`客户名`,`客户订单号`,`客户手机号`) values ('','',NULL);

/*Table structure for table `goods` */

DROP TABLE IF EXISTS `goods`;

CREATE TABLE `goods` (
  `货物编号` int(11) DEFAULT NULL,
  `货物名` text CHARACTER SET gbk COLLATE gbk_chinese_ci,
  `价格` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

/*Data for the table `goods` */

/*Table structure for table `orderdetail` */

DROP TABLE IF EXISTS `orderdetail`;

CREATE TABLE `orderdetail` (
  `订单号` double NOT NULL,
  `订单详情` text CHARACTER SET gbk COLLATE gbk_chinese_ci,
  `客户名` text,
  `货物编号` text CHARACTER SET gbk COLLATE gbk_chinese_ci,
  `客户手机号` text,
  PRIMARY KEY (`订单号`)
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

/*Data for the table `orderdetail` */

/*Table structure for table `orders` */

DROP TABLE IF EXISTS `orders`;

CREATE TABLE `orders` (
  `订单号` text CHARACTER SET gbk COLLATE gbk_chinese_ci NOT NULL,
  `客户名` text,
  `商品名` text,
  `价格` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=gbk;

/*Data for the table `orders` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
