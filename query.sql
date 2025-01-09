SELECT c.id, c.name, p.name AS parent_name
FROM parent c
LEFT JOIN parent p ON p.parent_id = c.id;
