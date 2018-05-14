--
-- Definition for table store
--
CREATE TABLE store(
  store_id TINYINT(3) UNSIGNED NOT NULL AUTO_INCREMENT,
  manager_staff_id TINYINT(3) UNSIGNED NOT NULL,
  address_id SMALLINT(5) UNSIGNED NOT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (store_id),
  UNIQUE INDEX idx_unique_manager USING BTREE (manager_staff_id),
  INDEX idx_fk_address_id USING BTREE (address_id)
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;