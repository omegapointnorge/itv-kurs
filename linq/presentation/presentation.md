---
separator: ^---$
title: 'LINQ'
theme: 'Black'
customTheme: 'theme'
---

### LINQ

Note:
Why LINQ?

- You already know Java
- Highlight the one major difference you will possible encounter during the summer.

---

Create a function that takes a list of persons and return a list with only the persons that has a name starting with A.

---

##### Possible solution

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

LINQ to the rescue

```

persons.Where(x => x.FirstName.StartsWith("A"));

```


Note:
What do we need in order to make this work?

Break the LINQ-query into parts and explain them

- Where is a function that can be called on a list
- Lambda is a function sent as parameter to where

---

#### Chaining

```

persons
.Where(x => x.FirstName.StartsWith("A"))
.OrderBy(x => x.LastName)
.Select(x => x.LastName);

```
---

<mark>persons.Where</mark>(x => x.FirstName.StartsWith("A"));

<hr>

```
PersonsWithFirstnameStartingByA(List<Person> persons){ ...
```

---

### Extension methods

```
public static class PersonExtensions
{
      public static string GetFullName(this Person person)
      {
            return $"{person.FirstName} {person.LastName}";
      }
}

```

<hr>
```
var fullName = person.GetFullName();
```

---

persons.Where( <mark> x => x.FirstName.StartsWith("A")</mark> );



---

### Lambda

A lambda expression is an

- anonymous function
- ... that can be passed as arguments to a function
- ... or returned as the value of function calls.

---

#### Syntax
```
Func<int, int> squareNumber = x => x * x;
squareNumber(2);
```

<hr>
```
public int SquareNumber(int x){
      return x * x;
}
```

---

#### Naming of lambda variable

<div class="small">
<br>
persons.Where(<mark>x</mark> => x.FirstName.StartsWith("A"));
<br>

persons.Where(<mark>p</mark> => p.FirstName.StartsWith("A"));
<br>

persons.Where(<mark>person</mark> => person.FirstName.StartsWith("A"));
<br>

persons.Where(<mark>pizza</mark> => pizza.FirstName.StartsWith("A"));

</div>

---

```
Func<Person, bool> NameStartingWithA()
{
      return x => x.FirstName.StartsWith("A");
}
return persons.Where(NameStartingWithA());

```

<hr>

```

Func<Person, bool> cond = x => x.FirstName.StartsWith("A");
return persons.Where(cond);

```

<hr>

```

return persons.Where(x => x.FirstName.StartsWith("A"));
```

<div class="note">

<br>
Since lambda can be anonymous it is optional to create the expression as a variable
</div>
---

#### Generics
```
public class IntComparer
{
      public bool IsTheSame(int value1, int value2)
      {
            return value1.Equals(value2);
      }
}
```

<hr>

```
public class StringComparer
{
      public bool IsTheSame(string value1, string value2)
      {
            return value1.Equals(value2);
      }
}
```

---
#### Generics
```
     public class Comparer<T>
     {
           public bool IsTheSame(T value1, T value2)
           {
                 return value1.Equals(value2);
           }
     }
```
<hr>

```
     var numberComparer = new Comparer<int>();
     var stringComparer = new Comparer<string>();

     numberComparer.IsTheSame(1,2);
     stringComparer.IsTheSame("1","2");

     numberComparer.IsTheSame("1","2"); //compile error
     stringComparer.IsTheSame(1,2);  //compile error
```

---

#### Query vs method syntax

```
      //Query syntax:
      var numQuery1 =
            from num in numbers
            where num % 2 == 0
            orderby num
            select num;

      //Method syntax:
      var numQuery2 = numbers
            .Where(num => num % 2 == 0)
            .OrderBy(n => n);
```

---

#### Exercises

<div class="note">
Open
<br>
../itv-kurs/linq/exercises/LinqExercises.cs
</div>

<img src="/content/exampletask.png">

<div class="note">
run command **_dotnet test_** in folder ../itv-kurs/linq/code to test implementation
</div>
---

#### Helpful operators

<div class="note">

<div class="col-2">
<ul>

<li> Select </li>
<li> Where </li>
<li> First </li>
<li> Last </li>
<li> Max / Min </li>
<li> Sum </li>
<li> Aggregate </li>
<li> GroupBy </li>
</div>
<div class="col-2">
<ul>
<li> OrderBy / OrderByDescending </li>
<li> ThenBy / ThenByDescending </li>
<li> All </li>
<li> Any </li>
<li> Count </li>
<li> SelectMany </li>
<li> Skip </li>
<li> Take </li>
</div>

</div>

---

Lambda is not unique to C#

---

#### Bonus exercise

<div class="note">
Open
<br>
../itv-kurs/linq/exercises/ThatHasExercise.cs
<br>
<br>
Implement a method called ThatHas that works in the same way as LINQ.Where()
</div>
