/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : projekat_baza

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2022-04-06 17:15:16
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
`artikal_id`  int(11) NOT NULL AUTO_INCREMENT ,
`naziv_artikla`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`vrsta_artikla`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`cijena`  double NULL DEFAULT NULL ,
PRIMARY KEY (`artikal_id`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
/*!50003 AUTO_INCREMENT=16 */

;

-- ----------------------------
-- Records of artikal
-- ----------------------------
BEGIN;
INSERT INTO `artikal` VALUES ('1', 'ABC sir', 'Prehrambeni', '3'), ('14', 'Huawei P7', 'Mobitel', '490'), ('15', 'Xiaomi Airdots', 'Slušalice', '60');
COMMIT;

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
`kupac_id`  int(11) NOT NULL AUTO_INCREMENT ,
`ime`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`prezime`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`grad`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`adresa`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`telefon`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`user`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`pass`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
PRIMARY KEY (`kupac_id`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
/*!50003 AUTO_INCREMENT=4 */

;

-- ----------------------------
-- Records of kupac
-- ----------------------------
BEGIN;
INSERT INTO `kupac` VALUES ('1', 'Admin', 'Ministrator', 'Sarajevo', 'Sarajevska 1', '0611111', 'Admin', '1234'), ('2', 'Amina', 'Kazazovic', 'Sarajevo', 'Doljani 52', '062241331', 'Kazaz', '5678'), ('3', 'Rasim', 'Rasimović', 'Banja  Luka', 'Banjalučka 17', '063666666', 'Rasko', '4321');
COMMIT;

-- ----------------------------
-- Table structure for `narudzbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudzbenica`;
CREATE TABLE `narudzbenica` (
`narudzbenica_id`  int(11) NOT NULL AUTO_INCREMENT ,
`kupac_id`  int(11) NULL DEFAULT NULL ,
`datum_narudzbe`  date NULL DEFAULT NULL ,
PRIMARY KEY (`narudzbenica_id`),
FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`) ON DELETE RESTRICT ON UPDATE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
COMMENT='InnoDB free: 3072 kB; (`kupac_id`) REFER `projekat/kupac`(`k'
/*!50003 AUTO_INCREMENT=20 */

;

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------
BEGIN;
INSERT INTO `narudzbenica` VALUES ('2', '2', '2022-04-06'), ('3', '2', '2022-04-06'), ('4', '2', '2022-04-06'), ('5', '2', '2022-04-06'), ('6', '2', '2022-04-06'), ('7', '2', '2022-04-06'), ('8', '2', '2022-04-06'), ('9', '2', '2022-04-06'), ('10', '2', '2022-04-06'), ('11', '2', '2022-04-06'), ('12', '2', '2022-04-06'), ('13', '2', '2022-04-06'), ('14', '2', '2022-04-06'), ('15', '2', '2022-04-06'), ('16', '2', '2022-04-06'), ('17', '2', '2022-04-06'), ('18', '3', '2022-04-06'), ('19', '2', '2022-04-06');
COMMIT;

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
`id`  int(11) NOT NULL AUTO_INCREMENT ,
`artikal_id`  int(11) NULL DEFAULT NULL ,
`kolicina_stanje`  int(11) NULL DEFAULT NULL ,
PRIMARY KEY (`id`),
FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`) ON DELETE RESTRICT ON UPDATE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
COMMENT='InnoDB free: 3072 kB; (`artikal_id`) REFER `projekat/artikal'
/*!50003 AUTO_INCREMENT=7 */

;

-- ----------------------------
-- Records of skladiste
-- ----------------------------
BEGIN;
INSERT INTO `skladiste` VALUES ('1', '1', '10'), ('5', '14', '10'), ('6', '15', '10');
COMMIT;

-- ----------------------------
-- Table structure for `stavka_narudzbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudzbenice`;
CREATE TABLE `stavka_narudzbenice` (
`stavka_id`  int(11) NOT NULL AUTO_INCREMENT ,
`narudzbenica_id`  int(11) NULL DEFAULT NULL ,
`artikal_id`  int(11) NULL DEFAULT NULL ,
`kolicina`  int(11) NULL DEFAULT NULL ,
PRIMARY KEY (`stavka_id`),
FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`) ON DELETE RESTRICT ON UPDATE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
COMMENT='InnoDB free: 3072 kB; (`artikal_id`) REFER `projekat/artikal'
/*!50003 AUTO_INCREMENT=37 */

;

-- ----------------------------
-- Records of stavka_narudzbenice
-- ----------------------------
BEGIN;
INSERT INTO `stavka_narudzbenice` VALUES ('2', '15', '15', '10'), ('3', '16', '14', '10'), ('4', '17', '15', '1'), ('5', '17', '1', '12');
COMMIT;

-- ----------------------------
-- Auto increment value for `artikal`
-- ----------------------------
ALTER TABLE `artikal` AUTO_INCREMENT=16;

-- ----------------------------
-- Auto increment value for `kupac`
-- ----------------------------
ALTER TABLE `kupac` AUTO_INCREMENT=4;

-- ----------------------------
-- Indexes structure for table `narudzbenica`
-- ----------------------------
CREATE INDEX `narudzbenica_kupac_id` USING BTREE ON `narudzbenica`(`kupac_id`);

-- ----------------------------
-- Auto increment value for `narudzbenica`
-- ----------------------------
ALTER TABLE `narudzbenica` AUTO_INCREMENT=20;

-- ----------------------------
-- Indexes structure for table `skladiste`
-- ----------------------------
CREATE INDEX `skladiste_artikal_id` USING BTREE ON `skladiste`(`artikal_id`);

-- ----------------------------
-- Auto increment value for `skladiste`
-- ----------------------------
ALTER TABLE `skladiste` AUTO_INCREMENT=7;

-- ----------------------------
-- Indexes structure for table `stavka_narudzbenice`
-- ----------------------------
CREATE INDEX `stavka_narudzbenice_narudzbenica_id` USING BTREE ON `stavka_narudzbenice`(`narudzbenica_id`);
CREATE INDEX `stavka_narudzbenice_artikal_id` USING BTREE ON `stavka_narudzbenice`(`artikal_id`);

-- ----------------------------
-- Auto increment value for `stavka_narudzbenice`
-- ----------------------------
ALTER TABLE `stavka_narudzbenice` AUTO_INCREMENT=37;
