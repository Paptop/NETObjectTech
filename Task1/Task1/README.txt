Pasirinkti ir realizuoti konkrečią situaciją, tenkinant šiuos reikalavimus.

    1) Programa(klientas) dirba su vienos iš keleto šeimų produktais per bendrus produktų interfeisus ir nori kurti produktus atsietai nuo jų konkrečių klasių.
    2) Šeimų yra bent penkios (nuo "A" iki "E"), produkdų rūšių bent dvi.
    3) Produktai kuriami "Abstrakčios gamyklos" pagalba.
    4) Kuriamiems produktams turi būti perduodami nuo jų rūšies priklausomi kūrimo parametrai. Pastarųjų reikšmes klientinis kodas gauna dinamiškai vykdymo metu (pvz. reikšmės įvedamos interaktyviai), prieš kuriant produktą.
    5) Konkrečios tos pačios rūšies produktų realizacijos turi skirtingas kūrimo/inicializavimo parametrų aibes ir/ar metodus.
    6) Turi būti tokios gamyklos realizacijos:
        6.1) Viena šeima turi turėti konkrečią, šeimai specifinę, gamyklos klasę (šeima A)
        6.2) Antra gamykla yra universali, parametrizuojama prototipais - produktų klasėmis (naudojama dviems šeimoms B, C)
        6.3) Trečia gamykla yra universali, parametrizuojama prototipais - klonuojamais produktų objektais(naudojama dviems šeimoms D, E)
        6.4) Ketvirta gamykla yra universali, parametrizuojama "kūrėjais". "Kūrėjas" atsakingas už tam tikro produkto sukūrimą ir inicializavimą faktiniais kūrimo parametrais ir realizuoja abstrakciją su vienu kūrimo metodu. Realizuoti konkrečių kūrėjų ir universalų "kūrėją" - parametrizuojamą produkto klase ir sukuriantį objektą, panaudojant tos klasės konstruktorių su numatyto tipo parametrais. 
    7) D šeimai gilus prototipų klonavimas turi būti realizuotas poklasiuose atliekant reikiamų atributų gilų klonavimą
    8) E šeimai gilus klonavimas turi būti realizuotas universalia funkcija, panaudojant refleksyvumo API.
    9) Kokia produktų šeima naudojama, turi priklausyti nuo programos komandinės eilutės argumento, kurio reikšmė yra šeimos pavadinimas ("A", ..., "E").



Changes.

1) Implemented the changes stated after the review

2) Added ProductionUniClone, which is an example of deep cloning, also fixed recursion in my solution. But my solution is limited, compared to production code, because
it does not support collections and multidimensional arrays. Also, showed a more hack way to deep clone in C# in UniversalClone.cs .

3) Added standart cloning, using protected constructors

4) Added Test.cs for checking and showing cloning


