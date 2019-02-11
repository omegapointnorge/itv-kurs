---
separator: ^---$
title: 'LINQ'
theme: Black
---

### LINQ

---

#### Create a function that takes a list of persons and return a list with only the persons that has a name starting with A.

---

```
PersonsWithFirstnameStartingByA(List<Person> persons)
{
      var result = new List<Person>();
      foreach (var person in persons)
      {
            if (person.FirstName.StartsWith("A"))
            {
                  result.Add(person);
            }
      }
      return result;
}

```

---

#### Ahh...so much code!

---

#### I want similar to this!

```
      return persons.ThatHas(Firstname.StartingWith(A));
```

---

LINQ to the rescue

```
      return data.Where(x => x.FirstName.StartsWith("A"));
```

---

### Lambda

A lambda expression is an anonymous function that you can use to create delegates or expression tree types. By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. Lambda expressions are particularly helpful for writing LINQ query expressions.

---

### Lambda

A lambda expression is an <mark>anonymous function</mark> that you can use to create delegates or expression tree types. By using lambda expressions, you can write local functions that can be passed as <mark> arguments or returned as the value of function calls </mark>. Lambda expressions are particularly helpful for writing <mark> LINQ </mark> query expressions.

---

### Anonymous function

```
      (input-parameters) => expression
```

```
int Square(x){
      return x*x;
}
```

```
      (x) => x*x;
```

---

### Anonymous function

```
      (input-parameters) => expression
```

```
      (x,y) => x*y;
```

---

### JavaScript
