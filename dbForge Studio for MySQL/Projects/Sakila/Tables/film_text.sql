--
-- Definition for table film_text
--
CREATE TABLE film_text(
  film_id SMALLINT(6) NOT NULL,
  title VARCHAR(255) NOT NULL,
  description TEXT DEFAULT NULL,
  PRIMARY KEY (film_id),
  FULLTEXT INDEX idx_title_description (title, description)
)
ENGINE = MYISAM
CHARACTER SET utf8
COLLATE utf8_general_ci;