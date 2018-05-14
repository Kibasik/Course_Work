ALTER TABLE payment
  ADD CONSTRAINT fk_payment_customer FOREIGN KEY (customer_id)
  REFERENCES customer (customer_id) ON UPDATE CASCADE;
ALTER TABLE payment
  ADD CONSTRAINT fk_payment_rental FOREIGN KEY (rental_id)
  REFERENCES rental (rental_id) ON DELETE SET NULL ON UPDATE CASCADE;
ALTER TABLE payment
  ADD CONSTRAINT fk_payment_staff FOREIGN KEY (staff_id)
  REFERENCES staff (staff_id) ON UPDATE CASCADE;

