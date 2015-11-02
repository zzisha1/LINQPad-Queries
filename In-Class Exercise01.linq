<Query Kind="Program">
  <Connection>
    <ID>5dccd845-f7a1-4291-9b47-f63d4d321d29</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

void Main()
{
	var data = from cat in Skills
					where cat.RequiresTicket
					orderby cat.Description
					select new 
					{
					Description = cat.Description,
					Employees = from item in cat.EmployeeSkills
								
								select new 
								{	
									Name = item.Employee.FirstName + " " +item.Employee.LastName,
									Level = item.Level,
									YearsExperience = item.YearsOfExperience									
									
								}
				};
		data.Dump();
	
}

