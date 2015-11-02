<Query Kind="Expression">
  <Connection>
    <ID>5dccd845-f7a1-4291-9b47-f63d4d321d29</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

from result in EmployeeSkills where result.YearsOfExperience >3 select result.Employee.FirstName + " " + result.Employee.LastName
