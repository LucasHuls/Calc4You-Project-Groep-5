USE WorldEvents

SELECT
	EventName
	,EventDate
	FROM
		dbo.tblEvent
WHERE EventName = '%Teletubbies%' OR EventName = '%Pandy%'