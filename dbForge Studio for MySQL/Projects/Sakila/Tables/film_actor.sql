--
-- Definition for table film_actor
--
CREATE TABLE film_actor(
  actor_id SMALLINT(5) UNSIGNED NOT NULL,
  film_id SMALLINT(5) UNSIGNED NOT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (actor_id, film_id),
  INDEX idx_fk_film_id USING BTREE (film_id),
  CONSTRAINT fk_film_actor_actor FOREIGN KEY (actor_id)
  REFERENCES actor (actor_id) ON UPDATE CASCADE,
  CONSTRAINT fk_film_actor_film FOREIGN KEY (film_id)
  REFERENCES film (film_id) ON UPDATE CASCADE
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;