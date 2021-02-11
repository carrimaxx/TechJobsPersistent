--Part 1
--SELECT *, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE table_schema = "techjobs" AND table_name = "jobs"

--Part 2
-- SELECT name FROM employers WHERE location LIKE "St. Louis";


--Part 3
--SELECT name, description FROM skills INNER JOIN jobskills ON skills.id = jobskills.skillId WHERE jobId IS NOT NULL;
