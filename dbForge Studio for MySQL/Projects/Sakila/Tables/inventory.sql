--
-- Definition for table inventory
--
CREATE TABLE inventory(
  inventory_id MEDIUMINT(8) UNSIGNED NOT NULL AUTO_INCREMENT,
  film_id SMALLINT(5) UNSIGNED NOT NULL,
  store_id TINYINT(3) UNSIGNED NOT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (inventory_id),
  INDEX idx_fk_film_id USING BTREE (film_id),
  INDEX idx_store_id_film_id USING BTREE (store_id, film_id)
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;