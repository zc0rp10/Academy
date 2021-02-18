obj4();
function obj1() {
    /*
        Skapa ett objekt "person" med uppgifter om Johan Rheborg: förnamn, efternamn, födelseår
        Skriv ut förnamnet
        Skriv ut hans fullständiga namn
    */
    let person = {
        förnamn: "Johan",
        efternamn: "Rheborg",
        födelseår: 1963,
    };

    console.log(person.förnamn);
    console.log(`${person.förnamn} ${person.efternamn}`);
}

function obj2() {
    /*
       Fortsätt bygg vidare på "person"
       Lägg till ett par rollkaraktärer till objektet "person" (Percy Nilegård, Farbror Barbro...)
       Lägg till adressuppgifter (street, city, country)

       Skriv ut info om Johan utifrån objektet "person":
            Johan är född år 1963
            Johan bor på gatan Kammakargatan 38 lgh 1401
            Johan har spelat 3 roller, bland annat Percy Nilegård
    */

    let person = {
        förnamn: "Johan",
        efternamn: "Rheborg",
        födelseår: 1963,
        rollkaraktärer: ["Percy Nilegård", "Farbror Barbro"],
        street: "Kammakargatan 38 lgh 1401",
        city: "Stockholm",
        country: "Sweden",
    };

    console.log(`${person.förnamn} är född år ${person.födelseår}`);
    console.log(`${person.förnamn} bor på ${person.street}`);
    console.log(
        `${person.förnamn} har spelat ${person.rollkaraktärer.length} roller, bland annat ${person.rollkaraktärer[1]}`
    );
}

function obj3() {
    /*
       Skapa en array "paintings" med tre målningar (tre element)
       För varje målning finns info: namn, konstnär och året den blev målad
       Skriv ut antalet målningar: "Det finns 3st målningar i arrayen"
       Skriv ut info om den tredje målningen: "Pablo Picasso målade Guernica år 1937"
       Loopa igenom alla målningar med "for of" och skriv ut all info i tabellform
       Tips: använd "padEnd" för att skriva ut tabellen snyggt
    */
    const paintings = [
        { namn: "Guernica", konstnär: "Pablo Picasso", år: 1937 },
        { namn: "Kludd", konstnär: "Björn Fällbom", år: 1986 },
        { namn: "Bättre kludd", konstnär: "Björn Fällbom", år: 1987 },
    ];

    console.log(`Det finns ${paintings.length} målningar i arrayen`);
    console.log(
        `${paintings[2].konstnär} målade ${paintings[2].namn} år ${paintings[2].år}`
    );
}

function obj4() {
    /*
       Skapa ett objekt "skriet" (av Edvard Munch 1893). Lägg till den i "paintings" mha "push".
       Skriv ut dess år mha variablen "paintings" (alltså 1893) 
       Använd "pop" flera gånger för att plocka bort de tre sista målningarna
       Skriv ut antalet målningar i arrayen 
    */

    const paintings = [
        { namn: "Guernica", konstnär: "Pablo Picasso", år: 1937 },
        { namn: "Kludd", konstnär: "Björn Fällbom", år: 1986 },
        { namn: "Bättre kludd", konstnär: "Björn Fällbom", år: 1987 },
    ];

    const skriet = { namn: "Skriet", konstnär: "Edvard Munch", år: 1893 };
    paintings.push(skriet);

    console.log(`${paintings[3].år}`);

    paintings.pop();
    paintings.pop();
    paintings.pop();
    console.log(paintings.length);
}
