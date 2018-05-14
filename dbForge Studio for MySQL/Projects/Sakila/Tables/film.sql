--
-- Definition for table film
--
CREATE TABLE film(
  film_id SMALLINT(5) UNSIGNED NOT NULL AUTO_INCREMENT,
  title VARCHAR(255) NOT NULL,
  description TEXT DEFAULT NULL,
  release_year YEAR(4) DEFAULT NULL,
  language_id TINYINT(3) UNSIGNED NOT NULL,
  original_language_id TINYINT(3) UNSIGNED DEFAULT NULL,
  rental_duration TINYINT(3) UNSIGNED NOT NULL DEFAULT 3,
  rental_rate DECIMAL (4, 2) NOT NULL DEFAULT 4.99,
  length SMALLINT(5) UNSIGNED DEFAULT NULL,
  replacement_cost DECIMAL (5, 2) NOT NULL DEFAULT 19.99,
  rating ENUM ('G', 'PG', 'PG-13', 'R', 'NC-17') DEFAULT 'G',
  special_features SET ('Trailers', 'Commentaries', 'Deleted Scenes', 'Behind the Scenes') DEFAULT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (film_id),
  INDEX idx_title USING BTREE (title),
  INDEX idx_fk_language_id USING BTREE (language_id),
  INDEX idx_fk_original_language_id USING BTREE (original_language_id),
  CONSTRAINT fk_film_language FOREIGN KEY (language_id)
  REFERENCES language (language_id) ON UPDATE CASCADE,
  CONSTRAINT fk_film_language_original FOREIGN KEY (original_language_id)
  REFERENCES language (language_id) ON UPDATE CASCADE
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;