--
-- Definition for table customer
--
CREATE TABLE customer(
  customer_id SMALLINT(5) UNSIGNED NOT NULL AUTO_INCREMENT,
  store_id TINYINT(3) UNSIGNED NOT NULL,
  first_name VARCHAR(45) NOT NULL,
  last_name VARCHAR(45) NOT NULL,
  email VARCHAR(50) DEFAULT NULL,
  address_id SMALLINT(5) UNSIGNED NOT NULL,
  active TINYINT(1) NOT NULL DEFAULT 1,
  create_date DATETIME NOT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (customer_id),
  INDEX idx_fk_store_id USING BTREE (store_id),
  INDEX idx_fk_address_id USING BTREE (address_id),
  INDEX idx_last_name USING BTREE (last_name)
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;