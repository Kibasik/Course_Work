--
-- Definition for table staff
--
CREATE TABLE staff(
  staff_id TINYINT(3) UNSIGNED NOT NULL AUTO_INCREMENT,
  first_name VARCHAR(45) NOT NULL,
  last_name VARCHAR(45) NOT NULL,
  address_id SMALLINT(5) UNSIGNED NOT NULL,
  picture BLOB DEFAULT NULL,
  email VARCHAR(50) DEFAULT NULL,
  store_id TINYINT(3) UNSIGNED NOT NULL,
  active TINYINT(1) NOT NULL DEFAULT 1,
  username VARCHAR(16) NOT NULL,
  `password` VARCHAR(40) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (staff_id),
  INDEX idx_fk_store_id USING BTREE (store_id),
  INDEX idx_fk_address_id USING BTREE (address_id)
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;