-- Query die alleen eigenaren laat zien die minimaal 1 dier heeft
SELECT DISTINCT E.*
FROM EIGENAAR E
JOIN DIER D ON E.eigenaarid = D.eigenaar

-- Query die alleen eigenaren laat zien zonder dieren
SELECT E.*
FROM EIGENAAR E
LEFT JOIN DIER D ON E.eigenaarid = D.eigenaar
WHERE D.chipnr IS NULL;