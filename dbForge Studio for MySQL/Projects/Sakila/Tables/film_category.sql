--
-- Definition for table film_category
--
CREATE TABLE film_category(
  film_id SMALLINT(5) UNSIGNED NOT NULL,
  category_id TINYINT(3) UNSIGNED NOT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (film_id, category_id),
  INDEX fk_film_category_category USING BTREE (category_id),
  CONSTRAINT fk_film_category_category FOREIGN KEY (category_id)
  REFERENCES category (category_id) ON UPDATE CASCADE,
  CONSTRAINT fk_film_category_film FOREIGN KEY (film_id)
  REFERENCES film (film_id) ON UPDATE CASCADE
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;