USE WorldEvents

SELECT TOP 5
	EventName AS [Wat]
	,EventDate AS [Wanneer]
	FROM
		dbo.tblEvent
ORDER BY
	EventDate ASC