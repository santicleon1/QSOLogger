# QSOLogger
Projekt za školu, namjenjen za jednostavni zapis veza na kratkom valu (KV).

## Uporaba
Pri prvom pokretanju program zahtjeva unos podataka radio stanice te operatora, nakon toga program je spreman za uporabu.
Svaki sljedeći put program automatski pročita podatke stanice i ne zahtjeva ponovni unos.

Tipkom ```TAB``` i ```ENTER``` obavlja se kretanje sustavom u unosom podataka te ispod sučelja za unos je prikaz upisanih podataka.

# Podaci stanice
Postavke stanice se nalaze na vrhu sustava za unos podataka na prečacu ```Stanica```.

Korisnicima je dopušteno mijenjanje pozivne oznake operatora, a ostale postavke zahtjevaju autorizaciju administratora. (Za sada nije dovršeno!)

### Zadani podaci administratora
* Korisničko ime: ```admin```
* Lozinka: ```admin```

# Veze

## Kako pristupiti vezama?
Na vrhu sustava za unos podataka se nalazi prečac ```Log``` za otvaranje mape ```./LOG```.

Veze se grupiraju po datumu. 

## Što se sve zapisuje?
Prilikom unosa veze, program sprema standardne podatke:
* Pozivni znak stanice (Callsign)
* Frekvenciju i/ili Opseg (Band)
* Vrstu rada (Modulaciju - npr. SSB, CW, FM)
* RST izvještaje (poslano/primljeno)
* Vrijeme i datum veze (automatski)

## Kako radi u pozadini?
Podaci o stanici i sve unesene veze se spremaju lokalno u datoteku svakim unosom.

# Licenca
[MIT Licence](LICENSE)

---
**9A3DCX 73**