SELECT FORMAT(ROUND(MIN(s.LAT_N), 4), 'F4')
    FROM Station AS s
    WHERE s.LAT_N > 38.7780