--
-- Definition for table payment
--
CREATE TABLE payment(
  payment_id SMALLINT (5) UNSIGNED NOT NULL AUTO_INCREMENT,
  customer_id SMALLINT (5) UNSIGNED NOT NULL,
  staff_id TINYINT (3) UNSIGNED NOT NULL,
  rental_id INT (11) DEFAULT NULL,
  amount DECIMAL (5, 2) NOT NULL,
  payment_date DATETIME NOT NULL,
  last_update TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (payment_id),
  INDEX idx_fk_staff_id USING BTREE (staff_id),
  INDEX idx_fk_customer_id USING BTREE (customer_id),
  INDEX fk_payment_rental USING BTREE (rental_id)
)
ENGINE = INNODB
CHARACTER SET utf8
COLLATE utf8_general_ci;

