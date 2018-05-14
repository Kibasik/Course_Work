ALTER TABLE customer
  ADD CONSTRAINT fk_customer_address FOREIGN KEY (address_id)
  REFERENCES address (address_id) ON UPDATE CASCADE;
ALTER TABLE customer
  ADD CONSTRAINT fk_customer_store FOREIGN KEY (store_id)
  REFERENCES store (store_id) ON UPDATE CASCADE;