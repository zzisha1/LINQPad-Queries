<Query Kind="Expression">
  <Connection>
    <ID>5dccd845-f7a1-4291-9b47-f63d4d321d29</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

from yoe in EmployeeSkills where yoe.Sum(x => x.YearsOfExperience).Max()
select x.Employee.FirstName