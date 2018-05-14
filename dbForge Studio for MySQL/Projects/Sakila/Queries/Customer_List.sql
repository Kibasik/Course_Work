SELECT
  cu.customer_id AS ID, CONCAT(cu.first_name, _utf8 ' ', cu.last_name) AS name, a.address AS address, a.postal_code AS `zip code`, a.phone AS phone, city.city AS city, country.country AS country, IF(cu.active, _utf8 'active', _utf8 '') AS notes, cu.store_id AS SID
FROM
  sakila.customer cu
  INNER JOIN sakila.address a ON cu.address_id = a.address_id
  INNER JOIN sakila.city ON a.city_id = city.city_id
  INNER JOIN sakila.country ON city.country_id = country.country_id;