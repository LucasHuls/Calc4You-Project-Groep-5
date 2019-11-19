USE WorldEvents

SELECT  EventName AS [What]
        ,EventDate AS [When]
		FROM  tblEvent
WHERE EventDate between '2005-02-01' and '2005-02-28'