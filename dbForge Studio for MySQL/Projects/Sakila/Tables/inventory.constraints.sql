ALTER TABLE inventory
  ADD CONSTRAINT fk_inventory_film FOREIGN KEY (film_id)
  REFERENCES film (film_id) ON UPDATE CASCADE;
ALTER TABLE inventory
  ADD CONSTRAINT fk_inventory_store FOREIGN KEY (store_id)
  REFERENCES store (store_id) ON UPDATE CASCADE;