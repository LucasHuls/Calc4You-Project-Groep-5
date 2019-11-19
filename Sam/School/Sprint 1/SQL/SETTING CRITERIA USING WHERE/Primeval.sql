USE WorldEvents

SELECT * FROM tblEvent
      WHERE CategoryID IN (5,6)
      AND
      EventDetails NOT LIKE '%War%'
      AND
      EventDetails not like '%Death&';