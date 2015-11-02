<Query Kind="Expression">
  <Connection>
    <ID>5dccd845-f7a1-4291-9b47-f63d4d321d29</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
</Query>

from result in Shifts where result.PlacementContractID == 3 
group result by result.DayOfWeek into X
select new{
			Day = X.Key,
			EmployeesNeeded = X.Sum(Y => Y.NumberOfEmployees)
}