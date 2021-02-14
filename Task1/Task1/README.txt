Objektines technologijos
Užduotis 1 (Objektų kūrimo šablonai, refleksyvumo taikymas)

Pasirinkti ir realizuoti konkrečią situaciją, tenkinant šiuos reikalavimus.

    1) Programa(klientas) dirba su vienos iš keleto šeimų produktais per bendrus produktų interfeisus ir nori kurti produktus atsietai nuo jų konkrečių klasių.
       The program(client) works with several instances of family products using an abstract interface and to decouple the construction mechanism.

    2) Šeimų yra bent penkios (nuo "A" iki "E"), produkdų rūšių bent dvi.

    3) Produktai kuriami "Abstrakčios gamyklos" pagalba.

    4) Kuriamiems produktams turi būti perduodami nuo jų rūšies priklausomi kūrimo parametrai. Pastarųjų reikšmes klientinis kodas gauna dinamiškai vykdymo metu (pvz. reikšmės įvedamos interaktyviai), prieš kuriant produktą.

    5) Konkrečios tos pačios rūšies produktų realizacijos turi skirtingas kūrimo/inicializavimo parametrų aibes ir/ar metodus.

    6) Turi būti tokios gamyklos realizacijos:
       6.1) Viena šeima turi turėti konkrečią, šeimai specifinę, gamyklos klasę (šeima A) (ConcreteClass)
       6.2) Antra gamykla yra universali, parametrizuojama prototipais - produktų klasėmis (naudojama dviems šeimoms B, C) (Generics)
       6.3) Trečia gamykla yra universali, parametrizuojama prototipais - klonuojamais produktų objektais(naudojama dviems šeimoms D, E) (Clone object)
       6.4) Ketvirta gamykla yra universali, parametrizuojama "kūrėjais". "Kūrėjas" atsakingas už tam tikro produkto sukūrimą ir inicializavimą faktiniais kūrimo parametrais ir realizuoja abstrakciją su vienu kūrimo metodu.
            Realizuoti konkrečių kūrėjų ir universalų "kūrėją" - parametrizuojamą produkto klase ir sukuriantį objektą, panaudojant tos klasės konstruktorių su numatyto tipo parametrais.

    7) D šeimai gilus prototipų klonavimas turi būti realizuotas poklasiuose atliekant reikiamų atributų gilų klonavimą

    8) E šeimai gilus klonavimas turi būti realizuotas universalia funkcija, panaudojant refleksyvumo API.

    9) Kokia produktų šeima naudojama, turi priklausyti nuo programos komandinės eilutės argumento, kurio reikšmė yra šeimos pavadinimas ("A", ..., "E"). 

Literatūra

    Šablonai Abstrakti gamykla, Prototipas Erich Gamma et al. Design Patterns: Elements of Reusable Object-Oriented Software. Addison-Wesley 1994.
    Šablonas "Product Trader"
    Java refleksyvumo API vadovas
    I. Forman, N. Forman. Java Reflection in Action. Manning 2005.
