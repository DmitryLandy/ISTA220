## NAME: Dmitry Landy
## ASSIGNMENT: Chapter 21
## DATE: 4/5/2021
---
**1. What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary?**
- LINQ processes data in .NET applications while sQL processes SQL data. 

**2. What is the one essential requirement for the datastructures used with LNQ? Why is this requirement important?**
- Data must be stored in a data structure that implements IEnurable

**3. Were does the LINQ Select() method live?**
- In the Enumerable class in System.Linq namespace

**4. (Select) Explain, token by token, each token in this line of code:**
```IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);```

- Query that returns an IEnumerable<String> by querying the first name of the cutstomers in the cutstomers table

**5. (Filter) Explain, token by token, each token in this line of code:**
```IEnumerable<string> usCompanies = addresses.Where(addr =>
String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);```

- Returns an IEnumerable string by querying for Company names in the country of "United States".

**6. (OrderBy) Explain, token by token, each token in this line of code:**
```IEnumerable<string> companyNames = addresses.OrderBy(addr =>
addr.CompanyName).Select(comp => comp.CompanyName);```

- returns a collection of company names in order

**7. (Group) Explain, token by token, each token in this line of code:**
```var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);```

- Gets a collection of companies grouped by countries

**8. (Distinct) Explain, token by token, each token in this line of code:**
```int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();```

- returns the number of distinct countries 

**9. (Join) Explain, token by token, each token in this line of code:**
```var companiesAndCustomers =
customers.Select(c =>
new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs =>
custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) =>
new {custs.FirstName, custs.LastName, addrs.Country });```

- joins two collections and returns it

**10. Explain the difference between a deferred collection and a static, cached collection.**

- cached is a snapshot (doesn't change)
- Deferred changes based on query