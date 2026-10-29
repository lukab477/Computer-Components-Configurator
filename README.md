# Inicijalne upute za prijavu projekta iz Razvoja Windows aplikacija

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Razvoj Windows proizvoda, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak je **kratko opisati projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, **umjesto ovoga teksta**.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. Mentor će vam slati povratne informacije kroz sekciju Discussions također dostupnu na GitHubu vašeg projekta. A sada, vrijeme je da opišete vaš projekt. Za opis vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Aplikacija za odabir računalnih komponenta


## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Lovro Končić  | lkoncic23@foi.hr | 0016165046 | lkoncic23
Luka Bočkaj   | lbockaj23@foi.hr | 0016166480 | lbockaj23
Robert Božičković | rbozickov23@foi.hr | 0016165249 | rbozickov23

## Opis domene
Projektom "Aplikacija za odabir računalnih komponenti" riješit ćemo problem ljudi koji žele trebaju ili planiraju kupiti novo osobno računalo te pomoći zaposlenicima da se lakše nose za željama i potrebama klijenata. Najčešće ljudi nisu upoznati sa time koje su računalne komponente potrebne za određene aktivnosti bile one poslovne, osobne(surfanje internetom i sl.) ili igranje igrica. Kako bismo im olakšali odabir najprikladnijeg računala za njihove potrebe kreirat ćemo aplikaciju koja će unosom potreba korisnika predložiti računalo sa svim potrebnim komponentama za nesmetan rad i zahtjeve pojedinih korisnika.Također aplikacija će pomoći i zaposlenicima da ne moraju svaki put iznova kreirati konfiguraciju za svakog pojedinog korisnika nego će ona biti jednom napravljenja te ponuđena korisnicima s mogučnošću uređivanja prema vlastitim željama i mogućnostima, a iskusnim korisnicima će biti omogućiti samostalno sastavljanje svih komponenti. Aplikacija će pratiti stanje zaliha, kompatibilnost između komponenti, cijene, kategorije, nazive proizvođača i sl. Apliakcija će imati intuitivan korisnički dizajn i pomoć prilikom kreiranja vlastitih konfiguracija. Nakon odabira i konfiguriranja klijenti će imati mogućnost sačuvati konfiguracije, proslijediti ih zaposleniku na pregled i obradu ili odmah obaviti kupnju.

## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti. Također uzmite u obzir da je u ovom trenutku dovoljno opisati 3 funkcionalnosti, dok će sve funkcionalnoisti biti pobrojane u sklopu rada na projektu i specifikacija zahtjeva. Funkcionalnosti sustava pobrojite u tablici ispod koristeći predložak koji slijedi:

Oznaka | Naziv | Kratki opis |Zaduženi student
------ | ----- | ----------- | --------------
F01 | Unos novih  računalnih komponenti u sustav | Zaposlenici imaju mogućnost unosa novih komponenti u aplikaciju, svaka komponenta treba biti kategorizirana prema svojoj namjeni. Treba sadržavati naziv komponente, naziv proizvođača, tehničke specifikacije, cijene te definiranje kompatibilnosti s drugim dijelovima, kako bi kupci uvijek imali pristup ažurnim podacima o računalnim komponentama. | Robert Božičković
F02 | Kreiranje unaprijed definiranih konfiguracija | Zaposlenici imaju mogućnost kreiranja raznolikih unaprijed definiranih računalnih konfiguracija koje su prilagođene različitim namjenama i sadržavaju komponente koje su optimalno usklađene i međusobno kompatibilne. | Robert Božičković
F03 | Pregled unaprijed definiranih konfiguracija | Kupci imaju mogućnost pregleda unaprijed definiranih računalnih konfiguracija koje su kategorizirane prema potrebama, poput "Gaming PC", "Uredski PC" ili "Radna stanica za obradu videa". Svaka konfiguracija prikazuje sve komponente s njihovim cijenama te ukupnu cijenu konfiguracije. | Robert Božičković
F04 | Kreiranje vlastitih konfiguracija | Kupci mogu kreirati vlastite konfiguracije birajući pojedinačne komponente kao što su procesor, grafička kartica, matična ploča, memorija, napajanje i slično. Prikazuju se tehničke specifikacije i cijena za svaku komponentu. | Lovro Končić
F05 | Pomoć pri kreiranju vlastitih konfiguracija | Aplikacija interaktivno vodi kupca kroz cijeli proces konfiguriranja, može mu sugerirati odgovarajuće dijelove te time osigurava da sve komponente budu međusobno kompatibilne i da konfiguracija bude potpuna. Na svakom koraku kupac treba biti obaviješten o eventualnim problemima s kompatibilnošću ili nedostatku potrebnih dijelova. | Lovro Končić
F06 | Pregled konfiguracije | Kada kupac završi sa kreiranjem konfiguracije, aplikacija treba imati pregled svih odabranih komponenata prikazujući cijene svih komponenti zasebno te ukupnu cijenu. | Luka Bočkaj
F07 | Generiranje ispisa konfiguracije | Nakon kreiranja konfiguracije kupac treba imati mogućnost generirati ispis konfiguracije, koji bi mogao poslati sebi na e-mail i kasnije mogao pregledati. | Luka Bočkaj
F08 | Slanje konfiguracije zaposlenicima | Kada je kupac zadovoljan svojom konfiguracijom ima mogućnost slanja svoje vlastite konfiguracije zaposlenicima. | Lovro Končić
F09 |Potvrda konfiguracije| Nakon što korisnik pošalje svoju konfiguraciju, zaposlenici pregledavaju komponente kako bi potvrdili njihovu međusobnu kompatibilnost. Ako su sve komponente kompatibilne, konfiguracija se označava kao valjana. | Luka Bočkaj
F10 |Dovršetak kupnje| Nakon što je konfiguracija potvrđena kao valjana, zaposlenik ju potvrđuje. Korisniku na email dolaze detalji narudžbe sa komentarom zaposlenika. Također ako je odbijena, korisniku dolazi obavijest na email sa komentarom zaposlenika. | Luka Bočkaj


## Tehnologije i oprema
Za izradu aplikacije za odabir računalnih komponenti koristit ćemo Visual Studio 2022. Projekt će biti u WinForms obliku. Za verzioniranje programskog koda koristit ćemo git i GitHub, a za pisanje projektne i tehničke dokumnetacije koristit ćemo GitHub Wiki. Projekttne zadatke planirat ćemo i pratiti u alatu GitHub projects. Ostale alate navodit ćemo sukladno potrebama našeg projekta.

