ALTER TABLE rental
  ADD CONSTRAINT fk_rental_customer FOREIGN KEY (customer_id)
  REFERENCES customer (customer_id) ON UPDATE CASCADE;
ALTER TABLE rental
  ADD CONSTRAINT fk_rental_inventory FOREIGN KEY (inventory_id)
  REFERENCES inventory (inventory_id) ON UPDATE CASCADE;
ALTER TABLE rental
  ADD CONSTRAINT fk_rental_staff FOREIGN KEY (staff_id)
  REFERENCES staff (staff_id) ON UPDATE CASCADE;

