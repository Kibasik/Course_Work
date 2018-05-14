SELECT
  a.actor_id AS actor_id, a.first_name AS first_name, a.last_name AS last_name, GROUP_CONCAT(DISTINCT CONCAT(c.name, ': ', (SELECT
    GROUP_CONCAT(f.title ORDER BY f.title ASC SEPARATOR ', ') AS `GROUP_CONCAT(f.title ORDER BY f.title SEPARATOR ', ')`
  FROM
    sakila.film f
    INNER JOIN sakila.film_category fc ON f.film_id = fc.film_id
    INNER JOIN sakila.film_actor fa ON f.film_id = fa.film_id
  WHERE
    fc.category_id = c.category_id AND fa.actor_id = a.actor_id)) ORDER BY c.name ASC SEPARATOR '; ') AS film_info
FROM
  sakila.actor a
  LEFT OUTER JOIN sakila.film_actor fa ON a.actor_id = fa.actor_id
  LEFT OUTER JOIN sakila.film_category fc ON fa.film_id = fc.film_id
  LEFT OUTER JOIN sakila.category c ON fc.category_id = c.category_id
GROUP BY
  a.actor_id, a.first_name, a.last_name;