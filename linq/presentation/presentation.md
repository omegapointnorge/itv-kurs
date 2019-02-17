---
separator: ^---$
title: 'LINQ'
theme: 'Black'
customTheme: 'theme'
---

### LINQ

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
return data.Where(x => x.FirstName.StartsWith("A"));
```

Note:
What do we need in order to make this work?

Break the LINQ-query into parts and explain them

- data is the list of persons
- Where is a function that can be called on a list
- Lambda is a function sent as parameter to where

---

### Lambda

A lambda expression is an <mark> anonymous function</mark> that you can use to create delegates or expression tree types. By using lambda expressions, you can write <mark> local functions </mark> that can be passed as <mark> arguments or returned as the value of function calls </mark>.

---

##### Predicate as return value

```
Func<Person, bool> NameStartingWithA()
{
      return x => x.FirstName.StartsWith("A");
}
```
...

```

return data.Where(NameStartingWithA());

```

---

##### Predicate as local constant

```
Func<Person, bool> predicate =
      x => x.FirstName.StartsWith("A");

return data.Where(predicate);
```

---

##### Lambda

```
return data.Where(x => x.FirstName.StartsWith("A"));
```

<div class="note">

<br>
Since lambda can be an anonymous, no need to create the predicate as a variable
</div>
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

#### JavaScript

```

```
