<Query Kind="Expression">
  <Connection>
    <ID>5dccd845-f7a1-4291-9b47-f63d4d321d29</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>



2.	from res in Skills orderby res.Description ascending 
		select new
		{
			Description = res.Description
		}