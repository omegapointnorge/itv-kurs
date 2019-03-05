---
theme : "Black"
customTheme: "custom-theme"
separator: ^---$
title: "Code quality"
---

## ITverket AS

---

## Om oss
<br />
<div class="info">
    <p>Sindre Berge<br/>snb@itverket.no</p>
    <img src="/images/sindre.jpg" width="150px" height="150px">
</div>
<hr />
<div class="info">
    <img src="/images/magne.jpg" width="150px" height="150px">
    <p>Magne Ingvaldsen<br/>mi@itverket.no</p>
</div>

---
## Dagen i dag

* Kodekvalitet
* LINQ
* Middag 

---

### Kodekvalitet

```
long tab1[]={ 989L,5L,26L,0L,88319L,123L,0L,9367L };
int tab2[]={ 4,6,10,14,22,26,34,38,46,58,62,74,82,86 };
 
main(m1,s) char *s; {
 int a,b,c,d,o[k],n=(int)s;
 if(m1==1){ char b[2*j+f-g]; main(l(h+e)+h+e,b); printf(b); }
 else switch(m1-=h){
	case f:
	 a=(b=(c=(d=g)<<g)<<g)<<g;
	 return(m(n,a|c)|m(n,b)|m(n,a|d)|m(n,c|d));
	case h:
	 for(a=f;a<j;++a)if(tab1[a]&&!(tab1[a]%((long)l(n))))return(a);
	case g:
	 if(n<h)return(g);
	 if(n<j){n-=g;c='D';o[f]=h;o[g]=f;}
	 else{c='\r'-'\b';n-=j-g;o[f]=o[g]=g;}
	 if((b=n)>=e)for(b=g<<g;b<n;++b)o[b]=o[b-h]+o[b-g]+c;
	 return(o[b-g]%n+k-h);
	default:
	 if(m1-=e) main(m1-g+e+h,s+g); else *(s+g)=f;
	 for(*s=a=f;a<e;) *s=(*s<<e)|main(h+a++,(char *)m1);
	}
} 
```
Note: 
- snakkes mye om 
- finnes masse litteratur om
- ung bransje, men det er en del prinsipper som er satt
- Drøss med forkortelser og fancy navn	
- personlig preferanser
- prosjekt / team preferanser 
- Kommer med erfaring
- Hva betyr det for dere? 
- Viktig å tenke på
- Kommer med erfaring
- Ikke overtenk

---
<blockquote id="quote">Always code as if the guy who ends up maintaining your code will be a violent psychopath who knows where you live.<span>John F. Woods</span></blockquote>
<div class="shining"></div>

Note:
- Bruker mye mer tid på å lese kode enn å skrive kode
- raskt å skjønne hva som er ment og hvordan det fungerer
- enkelt å se eventuelle feil og logiske brister
- enkelt å utvikle videre eller endre oppførsel 
- holdbarheten til kode
- robusthet 

---
#### Hva er det vanskeligste du gjør som utvikler? 
<img src="/images/hard_task.jpg" />

Note:
- Enkel ting som viser seg å være vanskelig
- gi gode navn er vanskelig
- Verdt å bruke tiden på
- Lurt å se det sammen med kunden - context
- Konsistent. Eks customer
- Casing 

---
<blockquote id="quote">It’s OK to figure out murder mysteries, but you shouldn’t need to figure out code. You should be able to read it.
<span>Steve McConnell</span></blockquote>

Note: 
- lesbarhet - lese som god prosa
- korte metoder klasser  
- gode navn
- Lengden på linjer. 
- Kodestandard
- Gruppering av kode som hører sammen
- Folder og filorganisering 
- Kommentarer? opplagte vs spesielle 


---

### Indentering
<img src="/images/indentation.jpg" />

Note:
- Viktig faktor i lesbarhet
- Vanskelig å følge flyten gjennom systemet
- Strategi

---

```
if(empty(post))
{
	return RegisterForm()
}
```
<br />
<hr />
<br />
```
var validationResult = _validator.Validate(input);

if(!validationResult.IsValid)
{
	return validationResult.Messages;
}

CreateUser(input);
return RedirectToLogin();
```

---

<blockquote id="quote">Every piece of knowledge must have a single, unambiguous, authoritative representation within a system
<span>Andy Hunt</span> 
</blockquote>
Note:
- Ikke repeterende kode som gjør det samme
- Endringer
- Vedlikehold
- Flere måter å gjøre samme ting på
- Viktig prinsipp, men ikke overdriv
- Flagg som styrer logikk
- 2 ganger

---
```
public Person 
{
	public string FirstName {get;}
	public string LastName {get;}	
}


public void SendEmail(Person person, string emailAddress)
{
	...
	email.Subject = $"Hello {person.LastName}, {person.FirstName}";
	...
}


public void SendLetter(Person person)
{
	...
	letter.To = $"{person.LastName}, {person.FirstName}";
	...
} 

```
Note:
  - Mellomnavn

---

### "Smart" kode
```
    public interface IParent<TChild, TGrandChild, TGreatGrandChild, TGreatGreatGrandChild> :
        IParent,
        IChildContainer<TChild>,
        IGrandChildContainer<TGrandChild, TGreatGrandChild, TGreatGreatGrandChild>
        where TChild : IChild
        where TGrandChild : IGrandChild<TGreatGrandChild, TGreatGreatGrandChild>
        where TGreatGrandChild : IGreatGrandChild<TGreatGreatGrandChild>
        where TGreatGreatGrandChild : IGreatGreatGrandChild
    { }
```
Note:
	- Faktisk kode
	- Hold ting enkelt
	- Ikke overdriv gjenbrukbarhet
	- Tenk på din neste
---

### Skriv tester
  
Note: 
 - Del av det å være utvikler 
 - En del av prosessen
 - Sikkerhetsnett  
 - TDD

---

### google, StackOverflow og kolleger
<br />
### Legacy og ydmykhet

---

git clone https://github.com/itverket/itv-kurs.git

