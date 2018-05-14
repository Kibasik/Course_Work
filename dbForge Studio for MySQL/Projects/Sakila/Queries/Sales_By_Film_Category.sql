SELECT
  c.name AS category, SUM(p.amount) AS total_sales
FROM
  sakila.payment p
  INNER JOIN sakila.rental r ON p.rental_id = r.rental_id
  INNER JOIN sakila.inventory i ON r.inventory_id = i.inventory_id
  INNER JOIN sakila.film f ON i.film_id = f.film_id
  INNER JOIN sakila.film_category fc ON f.film_id = fc.film_id
  INNER JOIN sakila.category c ON fc.category_id = c.category_id
GROUP BY
  c.name
ORDER BY
  total_sales DESC;