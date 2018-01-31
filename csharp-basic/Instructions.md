# C#-Kurs

Dette kurset går gjennom de grunnleggende byggeklossene i C#. Oppgavene er laget med en tilhørende test som i utgangspunktet feiler, målet er så å få alle testene til å passere.

## Forutsetninger

- [NET Core SDK](https://www.microsoft.com/net/download)
- Valgfri editor:
    * [Visual Studio Code](https://code.visualstudio.com/Download)
    * [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)

## Instruksjoner

Gjenopprett avhengigheter:

```
dotnet restore CSharpKurs.sln
```

Start automatisk kjøring av tester:

```
cd Excercises.Tests

dotnet watch test
```

Oppgaver finnes i ```Excercises```-mappen. Start med oppgavene i `11_ManipulateStrings.cs`. 

Om du setter deg fast ved en oppgave, be om hjelp eller gå videre til neste, det er enkelt å se hvilke oppgaver som er feil eller mangler ut ifra test resultatene.