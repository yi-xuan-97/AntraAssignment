

//Give me an example of Extension method


//LINQ 
//Filtering employee have a salary higher than 5000
//Filtering employee have a salary higher than average salary
//Output employee name, department, salary


//Query Syntax

var result = (from item in table
        where item.Id>5
        orderby item.Id
        select new
        {
                Id=item.Id,
                Name = item.Name
        });


//Method Syntax

