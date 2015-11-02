<Query Kind="Program">
  <Connection>
    <ID>95e59ecd-6819-4ccd-96f8-c50c88236815</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

void Main()
{
	var data = from cat in MenuCategories
					orderby cat.Description
					select new 
					{
					Description =  cat.Description,
					MenuItems = from item in cat.Items
								where item.Active
								orderby item.Description
								select new 
								{
									Description = item.Description,
									Price = item.CurrentPrice,
									Calories = item.Calories,
									Comment = item.Comment
								}
				};
		data.Dump();
}

// Define other methods and classes here