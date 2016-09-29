# Analyseer

Bekijk de volledige commit-geschiedenis om te bestuderen hoe dit project tot stand gekomen is.

Probeer volgende vragen te beantwoorden:

i.v.m. MSTest:

- Welke Assert-methods worden naast `Assert.AreEqual` nog allemaal gebruikt?
- Waarom heeft `TestDirectories` een `Initialize`- en `CleanUp`-method?
- Zijn de attributen `[TestMethod]`, `[TestClass]`, ... noodzakelijk? (Test uit!)
- Wat is de shortcut om alle tests uit te voeren in VS?

i.v.m. Files en Directories:

- Wat is het voordeel van `Path.Combine` i.v.m. strings aan elkaar plakken?
- Wordt de return-waarde van `Directory.CreateDirectory(...)` steeds opgevangen? (TIP: gebruik `CTRL-SHIFT-F`)
- Wat is de return-waarde van `Directory.CreateDirectory(...)`?
- Wanneer is het nuttig om de return-waarde van `Directory.CreateDirectory(...)` op te vangen?

i.v.m. duidelijkheid/geschiedenis van de code:

- Lukken de testen in de commit 3ffe2c86? Waarom (niet)?
- Wat lost commit d0320b6a op?
- Wat is het probleem met de files in commit 9d184949?
- Wat doet commit 9b3e4065? Maakt dit de code makkelijker leesbaar? Makkelijker uitbreidbaar?


# Opdracht 1 : FileOpenText

Voeg aan `TestReadFiles` een nieuwe test toe die handelt over `File.OpenText`.

- zie https://msdn.microsoft.com/en-us/library/system.io.file.opentext%28v=vs.110%29.aspx
- zet de test na `TestReadAllLines`
- noem de test `TestFileOpenText`
- test enkele nuttige dingen



