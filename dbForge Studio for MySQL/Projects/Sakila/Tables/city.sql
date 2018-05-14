--
-- Definition for table city
--
CREATE TABLE city(
  city_id SMALLINT(5) UNSIGNED NOT NULL AUTO_INCREMENT,
  city VARCHAR(50) NOT NULL,
  country_id SMALLINT(5) UNSIGNED NOT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (city_id),
  INDEX idx_fk_country_id USING BTREE (country_id),
  CONSTRAINT fk_city_country FOREIGN KEY (country_id)
  REFERENCES country (country_id) ON UPDATE CASCADE
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;