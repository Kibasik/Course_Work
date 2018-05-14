SELECT
  category.name AS `category name`, payment.amount AS `payment amount`, payment.payment_date AS `payment date`, film.title AS `film title`, film.rating AS `film rating`
FROM
  sakila.film_category
  INNER JOIN sakila.category ON film_category.category_id = category.category_id
  INNER JOIN sakila.film ON film_category.film_id = film.film_id
  INNER JOIN sakila.inventory ON inventory.film_id = film.film_id
  INNER JOIN sakila.payment
  INNER JOIN sakila.rental ON payment.rental_id = rental.rental_id AND inventory.inventory_id = rental.inventory_id;