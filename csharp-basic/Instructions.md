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

Oppgaver finnes i ```Excercises```-mappen.