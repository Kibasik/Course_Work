--
-- Скрипт сгенерирован Devart dbForge Studio for MySQL, Версия 7.4.201.0
-- Домашняя страница продукта: http://www.devart.com/ru/dbforge/mysql/studio
-- Дата скрипта: 12.05.2018 14:35:19
-- Версия сервера: 5.5.25
-- Версия клиента: 4.1
--

-- 
-- Отключение внешних ключей
-- 
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;

-- 
-- Установить режим SQL (SQL mode)
-- 
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- 
-- Установка кодировки, с использованием которой клиент будет посылать запросы на сервер
--
SET NAMES 'utf8';

--
-- Установка базы данных по умолчанию
--
USE course;

--
-- Удалить таблицу `chosenadditionalservices`
--
DROP TABLE IF EXISTS chosenadditionalservices;

--
-- Удалить таблицу `additionalservices`
--
DROP TABLE IF EXISTS additionalservices;

--
-- Удалить таблицу `chosenservicemaintenance`
--
DROP TABLE IF EXISTS chosenservicemaintenance;

--
-- Удалить таблицу `servicemaintenance`
--
DROP TABLE IF EXISTS servicemaintenance;

--
-- Удалить таблицу `sale`
--
DROP TABLE IF EXISTS sale;

--
-- Удалить таблицу `client`
--
DROP TABLE IF EXISTS client;

--
-- Удалить таблицу `paymentmethod`
--
DROP TABLE IF EXISTS paymentmethod;

--
-- Удалить таблицу `specificcharacteristics`
--
DROP TABLE IF EXISTS specificcharacteristics;

--
-- Удалить таблицу `characteristiclist`
--
DROP TABLE IF EXISTS characteristiclist;

--
-- Удалить таблицу `defaultcharacteristic`
--
DROP TABLE IF EXISTS defaultcharacteristic;

--
-- Удалить таблицу `componentslist`
--
DROP TABLE IF EXISTS componentslist;

--
-- Удалить таблицу `goodslist`
--
DROP TABLE IF EXISTS goodslist;

--
-- Удалить таблицу `supplystructure`
--
DROP TABLE IF EXISTS supplystructure;

--
-- Удалить таблицу `warehouse`
--
DROP TABLE IF EXISTS warehouse;

--
-- Удалить представление `stationarygoods`
--
DROP VIEW IF EXISTS stationarygoods CASCADE;

--
-- Удалить представление `stationarygoodsquantity`
--
DROP VIEW IF EXISTS stationarygoodsquantity CASCADE;

--
-- Удалить таблицу `goodscatalog`
--
DROP TABLE IF EXISTS goodscatalog;

--
-- Удалить таблицу `goodsmanufacturer`
--
DROP TABLE IF EXISTS goodsmanufacturer;

--
-- Удалить представление `typegoodslist`
--
DROP VIEW IF EXISTS typegoodslist CASCADE;

--
-- Удалить таблицу `categorygoods`
--
DROP TABLE IF EXISTS categorygoods;

--
-- Удалить таблицу `typecategory`
--
DROP TABLE IF EXISTS typecategory;

--
-- Удалить таблицу `chosensoftware`
--
DROP TABLE IF EXISTS chosensoftware;

--
-- Удалить таблицу `basket`
--
DROP TABLE IF EXISTS basket;

--
-- Удалить таблицу `assembly`
--
DROP TABLE IF EXISTS assembly;

--
-- Удалить таблицу `software`
--
DROP TABLE IF EXISTS software;

--
-- Удалить таблицу `softwaretype`
--
DROP TABLE IF EXISTS softwaretype;

--
-- Удалить таблицу `goodsdescription`
--
DROP TABLE IF EXISTS goodsdescription;

--
-- Удалить таблицу `manufacturecountry`
--
DROP TABLE IF EXISTS manufacturecountry;

--
-- Удалить таблицу `warranty`
--
DROP TABLE IF EXISTS warranty;

--
-- Удалить таблицу `delivery`
--
DROP TABLE IF EXISTS delivery;

--
-- Удалить таблицу `deliverymethod`
--
DROP TABLE IF EXISTS deliverymethod;

--
-- Удалить таблицу `supply`
--
DROP TABLE IF EXISTS supply;

--
-- Удалить таблицу `suppliers`
--
DROP TABLE IF EXISTS suppliers;

--
-- Удалить таблицу `worker`
--
DROP TABLE IF EXISTS worker;

--
-- Установка базы данных по умолчанию
--
USE course;

--
-- Создать таблицу `worker`
--
CREATE TABLE worker (
  WorkerID int(11) NOT NULL AUTO_INCREMENT,
  WorkerName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  WorkerPost text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (WorkerID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `suppliers`
--
CREATE TABLE suppliers (
  SuppliersID int(11) NOT NULL AUTO_INCREMENT,
  SuppliersName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  SuppliersAddress text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  SuppliersEmail text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  SuppliersPhone int(11) DEFAULT NULL,
  PRIMARY KEY (SuppliersID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `supply`
--
CREATE TABLE supply (
  SupplyID int(11) NOT NULL AUTO_INCREMENT,
  SuppliersID int(11) DEFAULT NULL,
  WorkerID int(11) DEFAULT NULL,
  SupplyDate date DEFAULT NULL,
  PRIMARY KEY (SupplyID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE supply
ADD CONSTRAINT FK_supply_SuppliersID FOREIGN KEY (SuppliersID)
REFERENCES suppliers (SuppliersID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE supply
ADD CONSTRAINT FK_supply_WorkerID FOREIGN KEY (WorkerID)
REFERENCES worker (WorkerID) ON DELETE NO ACTION;

--
-- Создать таблицу `deliverymethod`
--
CREATE TABLE deliverymethod (
  DeliveryMethodID int(11) NOT NULL AUTO_INCREMENT,
  DeliveryMethodName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  DeliveryMethodCost decimal(19, 2) DEFAULT NULL,
  PRIMARY KEY (DeliveryMethodID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `delivery`
--
CREATE TABLE delivery (
  DeliveryID int(11) NOT NULL AUTO_INCREMENT,
  DeliveryAddress text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  DeliveryDate datetime DEFAULT NULL,
  DeliveryMethodID int(11) DEFAULT NULL,
  PRIMARY KEY (DeliveryID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 2,
AVG_ROW_LENGTH = 16384,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE delivery
ADD CONSTRAINT FK_delivery_DeliveryMethodID FOREIGN KEY (DeliveryMethodID)
REFERENCES deliverymethod (DeliveryMethodID) ON DELETE NO ACTION;

--
-- Создать таблицу `warranty`
--
CREATE TABLE warranty (
  WarrantyID int(11) NOT NULL AUTO_INCREMENT,
  WarrantyPeriod int(11) DEFAULT NULL,
  PRIMARY KEY (WarrantyID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 5,
AVG_ROW_LENGTH = 4096,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `manufacturecountry`
--
CREATE TABLE manufacturecountry (
  ManufactureCountryID int(11) NOT NULL AUTO_INCREMENT,
  ManufactureCountryName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (ManufactureCountryID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 6,
AVG_ROW_LENGTH = 3276,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `goodsdescription`
--
CREATE TABLE goodsdescription (
  GoodsDescriptionID int(11) NOT NULL AUTO_INCREMENT,
  GoodsDescription text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (GoodsDescriptionID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 4,
AVG_ROW_LENGTH = 5461,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `softwaretype`
--
CREATE TABLE softwaretype (
  SoftwareTypeID int(11) NOT NULL AUTO_INCREMENT,
  SoftwareTypeName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (SoftwareTypeID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `software`
--
CREATE TABLE software (
  SoftwareID int(11) NOT NULL AUTO_INCREMENT,
  SoftwareName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  SoftwareTypeID int(11) DEFAULT NULL,
  SoftwareCost decimal(19, 2) DEFAULT NULL,
  PRIMARY KEY (SoftwareID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE software
ADD CONSTRAINT FK_software_SoftwareTypeID FOREIGN KEY (SoftwareTypeID)
REFERENCES softwaretype (SoftwareTypeID) ON DELETE NO ACTION;

--
-- Создать таблицу `assembly`
--
CREATE TABLE assembly (
  AssemblyID int(11) NOT NULL AUTO_INCREMENT,
  AssemblyName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (AssemblyID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `basket`
--
CREATE TABLE basket (
  BasketID int(11) NOT NULL AUTO_INCREMENT,
  AssemblyID int(11) DEFAULT NULL,
  PRIMARY KEY (BasketID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 2,
AVG_ROW_LENGTH = 16384,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE basket
ADD CONSTRAINT FK_basket_AssemblyID FOREIGN KEY (AssemblyID)
REFERENCES assembly (AssemblyID) ON DELETE NO ACTION;

--
-- Создать таблицу `chosensoftware`
--
CREATE TABLE chosensoftware (
  BasketID int(11) DEFAULT NULL,
  SoftwareID int(11) DEFAULT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE chosensoftware
ADD CONSTRAINT FK_chosensoftware_BasketID FOREIGN KEY (BasketID)
REFERENCES basket (BasketID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE chosensoftware
ADD CONSTRAINT FK_chosensoftware_SoftwareID FOREIGN KEY (SoftwareID)
REFERENCES software (SoftwareID) ON DELETE NO ACTION;

--
-- Создать таблицу `typecategory`
--
CREATE TABLE typecategory (
  TypeCategoryID int(11) NOT NULL AUTO_INCREMENT,
  TypeCategoryName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (TypeCategoryID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `categorygoods`
--
CREATE TABLE categorygoods (
  CategoryGoodsID int(11) NOT NULL AUTO_INCREMENT,
  CategoryGoodsName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  TypeCategoryID int(11) DEFAULT NULL,
  PRIMARY KEY (CategoryGoodsID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 6,
AVG_ROW_LENGTH = 3276,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE categorygoods
ADD CONSTRAINT FK_categorygoods_TypeCategory2 FOREIGN KEY (TypeCategoryID)
REFERENCES typecategory (TypeCategoryID) ON DELETE NO ACTION;

--
-- Создать представление `typegoodslist`
--
CREATE
DEFINER = 'root'@'localhost'
VIEW typegoodslist
AS
SELECT
  `categorygoods`.`CategoryGoodsName` AS `CategoryGoodsName`
FROM (`categorygoods`
  JOIN `typecategory`
    ON ((`categorygoods`.`TypeCategoryID` = `typecategory`.`TypeCategoryID`)));

--
-- Создать таблицу `goodsmanufacturer`
--
CREATE TABLE goodsmanufacturer (
  GoodsManufacturerID int(11) NOT NULL AUTO_INCREMENT,
  GoodsManufacturerName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (GoodsManufacturerID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 6,
AVG_ROW_LENGTH = 3276,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `goodscatalog`
--
CREATE TABLE goodscatalog (
  GoodsID int(11) NOT NULL AUTO_INCREMENT,
  GoodsName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  GoodsAmount int(11) DEFAULT NULL,
  CategoryGoodsID int(11) DEFAULT NULL,
  ManufactureCountryID int(11) DEFAULT NULL,
  WarrantyID int(11) DEFAULT NULL,
  GoodsDescriptionID int(11) DEFAULT NULL,
  GoodsCost decimal(19, 2) DEFAULT NULL,
  GoodsManufacturerID int(11) DEFAULT NULL,
  GoodsImage longblob DEFAULT NULL,
  PRIMARY KEY (GoodsID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 6,
AVG_ROW_LENGTH = 3276,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE goodscatalog
ADD CONSTRAINT FK_goodscatalog_CategoryGoodsI FOREIGN KEY (CategoryGoodsID)
REFERENCES categorygoods (CategoryGoodsID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE goodscatalog
ADD CONSTRAINT FK_goodscatalog_GoodsDescripti FOREIGN KEY (GoodsDescriptionID)
REFERENCES goodsdescription (GoodsDescriptionID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE goodscatalog
ADD CONSTRAINT FK_goodscatalog_ManufactureCou FOREIGN KEY (ManufactureCountryID)
REFERENCES manufacturecountry (ManufactureCountryID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE goodscatalog
ADD CONSTRAINT FK_goodscatalog_ManufacturerID FOREIGN KEY (GoodsManufacturerID)
REFERENCES goodsmanufacturer (GoodsManufacturerID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE goodscatalog
ADD CONSTRAINT FK_goodscatalog_WarrantyID FOREIGN KEY (WarrantyID)
REFERENCES warranty (WarrantyID) ON DELETE NO ACTION;

--
-- Создать представление `stationarygoodsquantity`
--
CREATE
DEFINER = 'root'@'localhost'
VIEW stationarygoodsquantity
AS
SELECT
  `categorygoods`.`CategoryGoodsName` AS `CategoryGoodsName`,
  COUNT(`categorygoods`.`CategoryGoodsName`) AS `Quantity`,
  `typecategory`.`TypeCategoryName` AS `TypeCategoryName`
FROM ((`goodscatalog`
  JOIN `categorygoods`
    ON ((`goodscatalog`.`CategoryGoodsID` = `categorygoods`.`CategoryGoodsID`)))
  JOIN `typecategory`
    ON ((`categorygoods`.`TypeCategoryID` = `typecategory`.`TypeCategoryID`)))
WHERE (`typecategory`.`TypeCategoryName` = 'Стационарное')
GROUP BY 1,
         `typecategory`.`TypeCategoryName`;

--
-- Создать представление `stationarygoods`
--
CREATE
DEFINER = 'root'@'localhost'
VIEW stationarygoods
AS
SELECT
  `typecategory`.`TypeCategoryName` AS `TypeCategoryName`,
  `categorygoods`.`CategoryGoodsName` AS `CategoryGoodsName`,
  `goodscatalog`.`GoodsName` AS `GoodsName`,
  `goodsmanufacturer`.`GoodsManufacturerName` AS `GoodsManufacturerName`,
  `goodscatalog`.`GoodsCost` AS `GoodsCost`
FROM (((`goodscatalog`
  JOIN `categorygoods`
    ON ((`goodscatalog`.`CategoryGoodsID` = `categorygoods`.`CategoryGoodsID`)))
  JOIN `goodsmanufacturer`
    ON ((`goodscatalog`.`GoodsManufacturerID` = `goodsmanufacturer`.`GoodsManufacturerID`)))
  JOIN `typecategory`
    ON ((`categorygoods`.`TypeCategoryID` = `typecategory`.`TypeCategoryID`)))
WHERE (`typecategory`.`TypeCategoryName` = 'Стационарное');

--
-- Создать таблицу `warehouse`
--
CREATE TABLE warehouse (
  GoodsID int(11) NOT NULL,
  WarehouseGoodsAmount int(11) DEFAULT NULL,
  PRIMARY KEY (GoodsID)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE warehouse
ADD CONSTRAINT FK_warehouse_GoodsID FOREIGN KEY (GoodsID)
REFERENCES goodscatalog (GoodsID) ON DELETE NO ACTION;

--
-- Создать таблицу `supplystructure`
--
CREATE TABLE supplystructure (
  GoodsID int(11) DEFAULT NULL,
  SupplyID int(11) DEFAULT NULL,
  GoodsAmount int(11) DEFAULT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE supplystructure
ADD CONSTRAINT FK_supplystructure_GoodsID FOREIGN KEY (GoodsID)
REFERENCES goodscatalog (GoodsID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE supplystructure
ADD CONSTRAINT FK_supplystructure_SupplyID FOREIGN KEY (SupplyID)
REFERENCES supply (SupplyID) ON DELETE NO ACTION;

--
-- Создать таблицу `goodslist`
--
CREATE TABLE goodslist (
  BasketID int(11) DEFAULT NULL,
  GoodsID int(11) DEFAULT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE goodslist
ADD CONSTRAINT FK_goodslist_BasketID FOREIGN KEY (BasketID)
REFERENCES basket (BasketID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE goodslist
ADD CONSTRAINT FK_goodslist_GoodsID FOREIGN KEY (GoodsID)
REFERENCES goodscatalog (GoodsID) ON DELETE NO ACTION;

--
-- Создать таблицу `componentslist`
--
CREATE TABLE componentslist (
  GoodsID int(11) DEFAULT NULL,
  BasketID int(11) DEFAULT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE componentslist
ADD CONSTRAINT FK_componentslist_BasketID FOREIGN KEY (BasketID)
REFERENCES basket (BasketID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE componentslist
ADD CONSTRAINT FK_componentslist_GoodsID FOREIGN KEY (GoodsID)
REFERENCES goodscatalog (GoodsID) ON DELETE NO ACTION;

--
-- Создать таблицу `defaultcharacteristic`
--
CREATE TABLE defaultcharacteristic (
  DefaultCharacteristicID int(11) NOT NULL AUTO_INCREMENT,
  DefaultCharacteristicValue text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (DefaultCharacteristicID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 13,
AVG_ROW_LENGTH = 1365,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `characteristiclist`
--
CREATE TABLE characteristiclist (
  CharacteristicID int(11) NOT NULL AUTO_INCREMENT,
  CharacteristicName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (CharacteristicID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 7,
AVG_ROW_LENGTH = 2730,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `specificcharacteristics`
--
CREATE TABLE specificcharacteristics (
  SpecificCharacteristicID int(11) NOT NULL AUTO_INCREMENT,
  CharacteristicID int(11) DEFAULT NULL,
  SpecificCharacteristicValue text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  DefaultCharacteristicID int(11) DEFAULT NULL,
  GoodsID int(11) DEFAULT NULL,
  PRIMARY KEY (SpecificCharacteristicID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 5,
AVG_ROW_LENGTH = 4096,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE specificcharacteristics
ADD CONSTRAINT FK_specificcharacteristics_Cha FOREIGN KEY (CharacteristicID)
REFERENCES characteristiclist (CharacteristicID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE specificcharacteristics
ADD CONSTRAINT FK_specificcharacteristics_Def FOREIGN KEY (DefaultCharacteristicID)
REFERENCES defaultcharacteristic (DefaultCharacteristicID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE specificcharacteristics
ADD CONSTRAINT FK_specificcharacteristics_Goo FOREIGN KEY (GoodsID)
REFERENCES goodscatalog (GoodsID) ON DELETE NO ACTION;

--
-- Создать таблицу `paymentmethod`
--
CREATE TABLE paymentmethod (
  PaymentMethodID int(11) NOT NULL AUTO_INCREMENT,
  PaymentMethodName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (PaymentMethodID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `client`
--
CREATE TABLE client (
  ClientID int(11) NOT NULL AUTO_INCREMENT,
  ClientName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  ClientEmail text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  ClientPhone int(11) DEFAULT NULL,
  PRIMARY KEY (ClientID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `sale`
--
CREATE TABLE sale (
  SaleID int(11) NOT NULL AUTO_INCREMENT,
  BasketID int(11) DEFAULT NULL,
  DeliveryID int(11) DEFAULT NULL,
  PaymentMethodID int(11) DEFAULT NULL,
  ClientID int(11) DEFAULT NULL,
  WorkerID int(11) DEFAULT NULL,
  SaleDate date DEFAULT NULL,
  PRIMARY KEY (SaleID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 2,
AVG_ROW_LENGTH = 16384,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE sale
ADD CONSTRAINT FK_sale_BasketID FOREIGN KEY (BasketID)
REFERENCES basket (BasketID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE sale
ADD CONSTRAINT FK_sale_ClientID FOREIGN KEY (ClientID)
REFERENCES client (ClientID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE sale
ADD CONSTRAINT FK_sale_DeliveryID FOREIGN KEY (DeliveryID)
REFERENCES delivery (DeliveryID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE sale
ADD CONSTRAINT FK_sale_PaymentMethodID FOREIGN KEY (PaymentMethodID)
REFERENCES paymentmethod (PaymentMethodID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE sale
ADD CONSTRAINT FK_sale_WorkerID FOREIGN KEY (WorkerID)
REFERENCES worker (WorkerID) ON DELETE NO ACTION;

--
-- Создать таблицу `servicemaintenance`
--
CREATE TABLE servicemaintenance (
  ServiceMaintenanceID int(11) NOT NULL AUTO_INCREMENT,
  ServiceMaintenanceName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  ServiceMaintenanceCost decimal(19, 2) DEFAULT NULL,
  ServiceMaintenancePeriod int(11) DEFAULT NULL,
  PRIMARY KEY (ServiceMaintenanceID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `chosenservicemaintenance`
--
CREATE TABLE chosenservicemaintenance (
  BasketID int(11) DEFAULT NULL,
  ServiceMaintenanceID int(11) DEFAULT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE chosenservicemaintenance
ADD CONSTRAINT FK_chosenservicemaintenance_Ba FOREIGN KEY (BasketID)
REFERENCES basket (BasketID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE chosenservicemaintenance
ADD CONSTRAINT FK_chosenservicemaintenance_Se FOREIGN KEY (ServiceMaintenanceID)
REFERENCES servicemaintenance (ServiceMaintenanceID) ON DELETE NO ACTION;

--
-- Создать таблицу `additionalservices`
--
CREATE TABLE additionalservices (
  AdditionalServiceID int(11) NOT NULL AUTO_INCREMENT,
  AdditionalServiceName text CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  AdditionalServiceCost decimal(19, 2) DEFAULT NULL,
  PRIMARY KEY (AdditionalServiceID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
AVG_ROW_LENGTH = 8192,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать таблицу `chosenadditionalservices`
--
CREATE TABLE chosenadditionalservices (
  BasketID int(11) DEFAULT NULL,
  AdditionalServiceID int(11) DEFAULT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET cp1251,
COLLATE cp1251_general_ci;

--
-- Создать внешний ключ
--
ALTER TABLE chosenadditionalservices
ADD CONSTRAINT FK_chosenadditionalservices_Ad FOREIGN KEY (AdditionalServiceID)
REFERENCES additionalservices (AdditionalServiceID) ON DELETE NO ACTION;

--
-- Создать внешний ключ
--
ALTER TABLE chosenadditionalservices
ADD CONSTRAINT FK_chosenadditionalservices_Ba FOREIGN KEY (BasketID)
REFERENCES basket (BasketID) ON DELETE NO ACTION;

-- 
-- Вывод данных для таблицы typecategory
--
INSERT INTO typecategory VALUES
(1, 'Мобильное'),
(2, 'Стационарное');

-- 
-- Вывод данных для таблицы worker
--
INSERT INTO worker VALUES
(1, 'Иванов Иван Иванович', 'Продавец'),
(2, 'Петров Петр Петрович', 'Продавец-консультант');

-- 
-- Вывод данных для таблицы suppliers
--
INSERT INTO suppliers VALUES
(1, 'Пост1', 'г. Красноярск, ул. Ленина, д. 18', 'post1@mail.ru', 9999999),
(2, 'Пост2', 'г. Красноярск, ул. Пушкина, д.10', 'post2@mail.ru', 1010101);

-- 
-- Вывод данных для таблицы deliverymethod
--
INSERT INTO deliverymethod VALUES
(1, 'Самовывоз', 0.00),
(2, 'Доставка', 500.00);

-- 
-- Вывод данных для таблицы warranty
--
INSERT INTO warranty VALUES
(1, 6),
(2, 12),
(3, 24),
(4, 36);

-- 
-- Вывод данных для таблицы manufacturecountry
--
INSERT INTO manufacturecountry VALUES
(1, 'Китай'),
(2, 'Корея'),
(3, 'Тайвань'),
(4, 'США'),
(5, 'Япония');

-- 
-- Вывод данных для таблицы goodsmanufacturer
--
INSERT INTO goodsmanufacturer VALUES
(1, 'Intel'),
(2, 'AMD'),
(3, 'ASUS'),
(4, 'Acer'),
(5, 'Gigabyte');

-- 
-- Вывод данных для таблицы goodsdescription
--
INSERT INTO goodsdescription VALUES
(1, 'Отличная материнская плата'),
(2, 'Отличный процессор'),
(3, 'Отличная видеокарта');

-- 
-- Вывод данных для таблицы categorygoods
--
INSERT INTO categorygoods VALUES
(1, 'Материнская плата', 2),
(2, 'Процессор', 1),
(3, 'Процессор', 2),
(4, 'Видеокарта', 1),
(5, 'Видеокарта', 2);

-- 
-- Вывод данных для таблицы softwaretype
--
INSERT INTO softwaretype VALUES
(1, 'Операционная система'),
(2, 'Антивирус');

-- 
-- Вывод данных для таблицы assembly
--
INSERT INTO assembly VALUES
(1, 'Игровой компьютер'),
(2, 'Компьютер для офиса');

-- 
-- Вывод данных для таблицы supply
--
INSERT INTO supply VALUES
(1, 1, 1, '2018-05-06'),
(2, 2, 2, '2018-05-05');

-- 
-- Вывод данных для таблицы defaultcharacteristic
--
INSERT INTO defaultcharacteristic VALUES
(1, 'AM4'),
(2, 'LGA 1150'),
(3, 'E-ATX'),
(4, 'Micro-ATX'),
(5, '8 ГБ'),
(6, '11 ГБ'),
(7, 'GeForce GTX 1080 TI'),
(8, 'GeForce GTX 1080'),
(9, '2 мб'),
(10, '4 мб'),
(11, '4'),
(12, '8');

-- 
-- Вывод данных для таблицы characteristiclist
--
INSERT INTO characteristiclist VALUES
(1, 'Сокет'),
(2, 'Форм-фактор'),
(3, 'Объем видеопамяти'),
(4, 'Графический процессор'),
(5, 'Объем кэша L3'),
(6, 'Количество ядер');

-- 
-- Вывод данных для таблицы paymentmethod
--
INSERT INTO paymentmethod VALUES
(1, 'Наличный расчет'),
(2, 'Безналичный расчет');

-- 
-- Вывод данных для таблицы delivery
--
INSERT INTO delivery VALUES
(1, 'г. Красноярск, ул. Вавилова, д. 10, кв. 100', '2018-05-10 15:30:00', 2);

-- 
-- Вывод данных для таблицы client
--
INSERT INTO client VALUES
(1, 'Михайлов Александр Сергеевич', 'mikhailov@mail.ru', 2222222),
(2, 'Киба Александр Сергеевич', 'kiba@mail.ru', 3333333);

-- 
-- Вывод данных для таблицы goodscatalog
--
INSERT INTO goodscatalog VALUES
(1, 'RAMPAGE IV', 100, 1, 1, 1, 1, 150.00, 3, NULL),
(2, 'HD 7850', 200, 4, 2, 2, 3, 350.00, 5, NULL),
(3, 'FX 6350', 100, 3, 4, 2, 2, 500.00, 2, NULL),
(4, 'FX 8350', 100, 3, 4, 2, 2, 550.00, 2, NULL),
(5, 'GeForce GTX 1080Ti', 100, 5, 3, 3, 3, 800.00, 4, NULL);

-- 
-- Вывод данных для таблицы software
--
INSERT INTO software VALUES
(1, 'Windows 10 Home Edition', 1, 150.00),
(2, '360 Security', 2, 200.00);

-- 
-- Вывод данных для таблицы servicemaintenance
--
INSERT INTO servicemaintenance VALUES
(1, 'Проверка', 150.00, 7),
(2, 'Ремонт', 500.00, 21);

-- 
-- Вывод данных для таблицы basket
--
INSERT INTO basket VALUES
(1, 1);

-- 
-- Вывод данных для таблицы additionalservices
--
INSERT INTO additionalservices VALUES
(1, 'Проверка', 100.00),
(2, 'Настройка', 150.00);

-- 
-- Вывод данных для таблицы warehouse
--
INSERT INTO warehouse VALUES
(1, 150),
(2, 400);

-- 
-- Вывод данных для таблицы supplystructure
--
INSERT INTO supplystructure VALUES
(1, 1, 100),
(2, 2, 150);

-- 
-- Вывод данных для таблицы specificcharacteristics
--
INSERT INTO specificcharacteristics VALUES
(1, 1, NULL, 1, 1),
(2, 2, NULL, 3, 1),
(3, 3, '2 ГБ', NULL, NULL),
(4, 4, 'ATI RADEON HD 7850', NULL, NULL);

-- 
-- Вывод данных для таблицы sale
--
INSERT INTO sale VALUES
(1, 1, 1, 2, 2, 1, '2018-05-08');

-- 
-- Вывод данных для таблицы goodslist
--
INSERT INTO goodslist VALUES
(1, 1),
(1, 2);

-- 
-- Вывод данных для таблицы componentslist
--
INSERT INTO componentslist VALUES
(1, 1),
(2, 1);

-- 
-- Вывод данных для таблицы chosensoftware
--
INSERT INTO chosensoftware VALUES
(1, 1),
(1, 2);

-- 
-- Вывод данных для таблицы chosenservicemaintenance
--
INSERT INTO chosenservicemaintenance VALUES
(1, 2);

-- 
-- Вывод данных для таблицы chosenadditionalservices
--
INSERT INTO chosenadditionalservices VALUES
(1, 2);

-- 
-- Восстановить предыдущий режим SQL (SQL mode)
-- 
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;

-- 
-- Включение внешних ключей
-- 
/*!40014 SET FOREIGN_KEY_CHECKS = @OLD_FOREIGN_KEY_CHECKS */;