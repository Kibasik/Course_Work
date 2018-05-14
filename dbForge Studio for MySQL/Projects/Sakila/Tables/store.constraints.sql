ALTER TABLE store
  ADD CONSTRAINT fk_store_address FOREIGN KEY (address_id)
  REFERENCES address (address_id) ON UPDATE CASCADE;
ALTER TABLE store
  ADD CONSTRAINT fk_store_staff FOREIGN KEY (manager_staff_id)
  REFERENCES staff (staff_id) ON UPDATE CASCADE;