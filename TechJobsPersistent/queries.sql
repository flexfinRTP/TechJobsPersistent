----Part 1
--Id int PK, Name longtext, EmployerId int

----Part 2
--SELECT * FROM employers WHERE Location = 'St. Louis City'

----Part 3
--SELECT s.Name,s.Description FROM skills AS s
--INNER JOIN jobskills AS js
--ON s.Id = js.Skillid
--ORDER BY s.Name