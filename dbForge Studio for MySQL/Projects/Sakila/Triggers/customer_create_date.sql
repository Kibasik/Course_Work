DELIMITER $$

--
-- Definition for trigger customer_create_date
--
CREATE TRIGGER customer_create_date
BEFORE INSERT
ON customer
FOR EACH ROW
SET NEW.create_date = NOW()
$$

DELIMITER ;