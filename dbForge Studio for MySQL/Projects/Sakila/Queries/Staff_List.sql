SELECT
  s.staff_id AS ID, CONCAT(s.first_name, _utf8 ' ', s.last_name) AS name, a.address AS address, a.postal_code AS `zip code`, a.phone AS phone, city.city AS city, country.country AS country, s.store_id AS SID
FROM
  sakila.staff s
  INNER JOIN sakila.address a ON s.address_id = a.address_id
  INNER JOIN sakila.city ON a.city_id = city.city_id
  INNER JOIN sakila.country ON city.country_id = country.country_id;