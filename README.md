# Naprendszer bolygói

## File szerkezete
	- sorokban az egyes bolygók adatai
	- név, földközeli távolság, földtávoli távolság
	- 7 db bolygó adatát tartalmazza
	- "bolygok.txt"

## Feladat
	[x] Megfelelő struktúra elkészítése
	[x] Adatok beolvasása és eltárolása
	[x] Adatok kiírása

### Megfelelő struktrúra elkészítése
	- 3 adattagja lesz
	- string, int, int
	- neve: Bolygo
	- adattagok:
		- nev
		- fk
		- ft

### Adatok beolvasása és eltárolása
	- using System.IO;
	- tudjuk, hogy 7 db adat van!
	- Bolygo[] bolygok = new Bolygo[7] (7 elemű tömb, Bolygo típusú elemeket tartalmaz)
	- StreamReader file = new StreamReader("bolygok.txt")
	- !!!! használat után file.Close() !!!!
	- Ciklus az adatok beolvasására
	- soronként beolvasni
	- sorokat adatokra bontani
	- megfelelő adattagonak -> megfelelő értékeket átadni

### Adatok kiírása (képernyőre)
	- Ciklus
	- Kultúrált kiírás


## Ha nem tudjuk, hogy mennyi adat van a fájlban
	- Azt tudjuk, hogy max. mennyi lehet, pl.: 100 db
	- Bolygo[] bolygok = new Bolygo[100] 
	- mindig annyit használunk -> amennyit beolvasunk