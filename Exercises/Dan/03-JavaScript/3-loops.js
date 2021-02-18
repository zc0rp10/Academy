loop7();
function loop1() {
    /*
        Använd en for-loop för att skriva ut alla siffror mellan 5 och 18
    */
    for (let index = 5; index < 19; index++) {
        console.log(index);
    }
}

function loop2() {
    /*
        Använd en for-loop för att skriva ut alla siffror mellan 0 och 9
    */
    for (let index = 1; index < 10; index++) {
        console.log(index);
    }
}

function loop3() {
    /*
        Använd en forloop för att skriva ut:
            "Siffran 4 är tjusig". 
            "Siffran 5 är tjusig"
            "Siffran 6 är tjusig"
            "Siffran 7 är tjusig"
            "Siffran 8 är tjusig"
    */
    for (let index = 4; index < 9; index++) {
        console.log(`Siffran ${index} är tjusig.`);
    }
    /* Extra: använd en forloop för att skriva ut:
        "1:a"
        "2:a"
        "3:e"
        "4:e"
        "5:e"
        ...
        "99:e"
    */
    for (let index = 1; index < 100; index++) {
        console.log(`Siffran ${index}:a är tjusig.`);
    }
}

function loop4() {
    /*
        Lös föregående uppgift men använd en while-loop
    */
    let i = 1;
    while (i < 100) {
        console.log(`Siffran ${i++}:a är tjusig.`);   
}

function loop5() {
    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
        Använd "for of" för att skriva ut alla årtal
    */
    const importantYears = [1492, 1789, 1859, 1929];

    for (const iterator of importantYears) {
        console.log(iterator);
    }
    /*
    Extra: 

        Skriv ut "Året är 1492", "Året är 1789" ...

        Skapa en array med färger "blå", "röd", "grön", "gul", "lila". 
        Använd "for of" för att skriva ut alla färger 

    */
    for (const iterator of importantYears) {
        console.log(`Året är ${iterator}`);
    }

    const colors = ["blå", "röd", "grön", "gul", "lila"];

    for (const iterator of colors) {
        console.log(iterator);
    }
}

function loop6() {
    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
	    Använd "for of" för att skriva ut alla årtal med en siffra till vänster:
	    1) 1492
	    2) 1789
	    3) 1859
	    4) 1929
    */
    const importantYears = [1492, 1789, 1859, 1929];

    // for (const iterator of importantYears) {
    //     console.log(`${importantYears.indexOf(iterator) + 1}) ${iterator}`);
    // }

    /*
     Extra: lös uppgiften med ".forEach"

     Lösning:

        const importantYears = [1492, 1789, 1859, 1929];
        importantYears.forEach((x, index) => console.log(`${index + 1}) ${x}`))

     */

    importantYears.forEach((x, index) => console.log(`${index + 1}) ${x}`));
}

function loop7() {
    /*
	    Samma som sist men avbryt loopen om årtalet är högre än 1800. Ska alltså ge:
	    1) 1492
	    2) 1789
    */

    const importantYears = [1492, 1789, 1859, 1929];

    for (const iterator of importantYears) {
        if (iterator > 1800) break;
        console.log(`${importantYears.indexOf(iterator) + 1}) ${iterator}`);
    }
}
