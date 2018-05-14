SELECT
  CONCAT(c.city, _utf8 ',', cy.country) AS store, CONCAT(m.first_name, _utf8 ' ', m.last_name) AS manager, SUM(p.amount) AS total_sales
FROM
  sakila.payment p
  INNER JOIN sakila.rental r ON p.rental_id = r.rental_id
  INNER JOIN sakila.inventory i ON r.inventory_id = i.inventory_id
  INNER JOIN sakila.store s ON i.store_id = s.store_id
  INNER JOIN sakila.address a ON s.address_id = a.address_id
  INNER JOIN sakila.city c ON a.city_id = c.city_id
  INNER JOIN sakila.country cy ON c.country_id = cy.country_id
  INNER JOIN sakila.staff m ON s.manager_staff_id = m.staff_id
GROUP BY
  s.store_id
ORDER BY
  cy.country, c.city;