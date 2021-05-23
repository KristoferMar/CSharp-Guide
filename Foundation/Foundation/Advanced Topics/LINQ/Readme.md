<h2>What is LINQ?</h2>

- Stands for: Language Integrated Query
- Gives you the capability to query objects

<h2>You can query</h2>

- Objects in memory, eg collections (LINQ to Objects)
- Databases (LINQ to Entities)
- XML (LINQ to XML)
- ADO.NET Data Sets (LINQ to Data Sets)

<h2>Important to know</h2>

<h3>Chaining</h3>
You can chain LINQ queries like: <br>
<pre>var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title);</pre>

<h3>Select</h3>
- You can use select to transform a list of objects to a list of eg strings.
- In this case we explecitly only "select" Title meaning we will get returned a list of the titles.
<pre>.Select(b => b.Title);</pre>

<h3>.OrderBy</h3>
- We can order a list with the OrderBy Method.
<pre>.OrderBy(b => b.Title)</pre>

<h3>.Where</h3>
- We can define what to filter out or in with the .Where method
<pre>.Where(b => b.Price < 10)</pre>

<h3>.Single & .SingleOrDefault</h3>
- We use this method when we want to find a single object in eg a collection
- The method SingleOrDefault will return null if our object does not exist
<pre>var book = books.Single(b => b.Title == "ASP.NET MVC");</pre>

<h3>.First & .FirstOrDefault</h3>
- We use this method to get the first object returned with a specific name
- The method .FirstOrDefault will return null if our object does not exist
<pre>books.First(b => b.Title == "C# Advanced Topics");</pre>

<h3>.Last & .LastOrDefault</h3>
- We use this method to get the last object returned with a specific name
- The method .LastOrDefault will return null if our object does not exist
<pre>books.Last(b => b.Title == "C# Advanced Topics");</pre>

<h3>.Skip</h3>
- We use this method to skip x amount of elements in eg a collection
<pre>var book4 = books.Skip(2).Take(3);</pre>

<h3>.Take</h3>
- We use this method to take/select x amount of elements. 
<pre>var book4 = books.Skip(2).Take(3);</pre>

<h3>.Max & .Min</h3>
- Returns us the max or min amout of something
<pre>var maxPrice = books.Max(b => b.Price);</pre>
<pre>var minPrice = books.Min(b => b.Price);</pre>

<h3>.Avarage</h3>
- Gives you the average of a value in eg a collection of values.