USE WorldEvents

SELECT
	EventName
	,EventDate
	FROM
		dbo.tblEvent
ORDER BY
	EventDate DESC