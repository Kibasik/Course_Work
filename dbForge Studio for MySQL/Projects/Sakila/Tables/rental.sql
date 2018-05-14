--
-- Definition for table rental
--
CREATE TABLE rental(
  rental_id INT (11) NOT NULL AUTO_INCREMENT,
  rental_date DATETIME NOT NULL,
  inventory_id MEDIUMINT (8) UNSIGNED NOT NULL,
  customer_id SMALLINT (5) UNSIGNED NOT NULL,
  return_date DATETIME DEFAULT NULL,
  staff_id TINYINT (3) UNSIGNED NOT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (rental_id),
  UNIQUE INDEX rental_date USING BTREE (rental_date, inventory_id, customer_id),
  INDEX idx_fk_inventory_id USING BTREE (inventory_id),
  INDEX idx_fk_customer_id USING BTREE (customer_id),
  INDEX idx_fk_staff_id USING BTREE (staff_id)
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;

