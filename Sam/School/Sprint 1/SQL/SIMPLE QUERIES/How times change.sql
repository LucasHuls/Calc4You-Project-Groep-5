USE [WorldEvents]

SELECT
	EventName AS [Wat]
	,EventDate AS [Wanneer]
	FROM
		dbo.tblEvent
ORDER BY
	EventDate ASC

SELECT
	EventName AS [Wat]
	,EventDate AS [Wanneer]
	FROM
		dbo.tblEvent
ORDER BY
	EventDate DESC