--
-- Definition for table actor
--
CREATE TABLE actor(
  actor_id SMALLINT(5) UNSIGNED NOT NULL AUTO_INCREMENT,
  first_name VARCHAR(45) NOT NULL,
  last_name VARCHAR(45) NOT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (actor_id),
  INDEX idx_actor_last_name USING BTREE (last_name)
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;