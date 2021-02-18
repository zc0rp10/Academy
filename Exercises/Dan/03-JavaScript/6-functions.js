extraFun3();
function fun1() {
    /*
        Gör en metod "sayHi". Anropa den två gånger
    
        sayHi()
        sayHi() 

    Detta ska skrivas ut:

    --------
    -------- VÄLKOMMEN 
    --------

    --------
    -------- VÄLKOMMEN 
    --------

    */

    const sayHi = () => {
        console.log("--------");
        console.log("-------- VÄLKOMMEN");
        console.log("--------");
    };

    sayHi();
    sayHi();
}

function fun2() {
    /*
    Liknande som sist men gör en metod sayHiTo() som tar ett namn som inparameter.

    Ex sayHiTo("DITT_NAMN") ska skriva ut:

    --------
    -------- VÄLKOMMEN DITT_NAMN
    --------

    */
    const sayHiTo = (name) => {
        console.log("--------");
        console.log(`-------- VÄLKOMMEN ${name}`);
        console.log("--------");
    };

    sayHiTo("Björn");
}

function fun3() {
    /*
    Gör en metod "myndig" med två parameterar "name" och "age". Anropa den tre gånger
    
        myndig("Peter", 16);
        myndig("Lisa", 26);
        myndig("Ragnar", 15);

    Detta ska skrivas ut:

        Obs! Peter är inte myndig!
        Lisa är myndig
        Obs! Ragnar är inte myndig!
    */

    const myndig = (name, age) => {
        if (age >= 18) console.log(`${name} är myndig.`);
        else console.log(`Obs! ${name} är inte myndig!`);
    };

    myndig("Peter", 16);
    myndig("Lisa", 26);
    myndig("Ragnar", 15);
}

function fun4() {
    /*
    Gör en metoden "skrivUtMoms" som tar "price" som inparameter.
    Om du t.ex anropas metoden såhär:

        skrivUtMoms(1000)

    ...så ska detta skrivas ut:

        Momsen för varan är 250kr

    */

    const skrivUtMoms = (price) => {
        const moms = price * 0.25;
        console.log(`Momsen för varan är ${moms}kr.`);
    };
    skrivUtMoms(1000);
}

// -------- EXTRA UPPGIFTER -----------------------------------------

function extraFun1() {
    /*

    Gör en metod "recept" med en parameter "recipeName" och "ingredients". Anropa den:
    
        recept("Äpplekaka", ["Äpple", "Mjöl", "Kanel"]);
        recept("Rotmos", ["Potatis", "Kålrot"]);

    Detta ska skrivas ut:

        FÖR ATT GÖRA ÄPPLEKAKA BEHÖVS:
        * ÄPPLE
        * MJÖL
        * KANEL

        FÖR ATT GÖRA ROTMOS BEHÖVS:
        * POTATIS
        * KÅLROT
    */
    recept("Äpplekaka", ["Äpple", "Mjöl", "Kanel"]);
    recept("Rotmos", ["Potatis", "Kålrot"]);
    function recept(recipeName, ingredients) {
        console.log(`FÖR ATT GÖRA ${recipeName} BEHÖVS:`);

        for (const iterator of ingredients) {
            console.log(`* ${iterator}`);
        }
    }
}

function extraFun2() {
    /*

    I sverige finns tre momssatser: 25%, 12% och 6%. Se här:
    https://www.verksamt.se/starta/skatter-och-avgifter/moms/olika-momssatser

    Skriv en metod "skrivUtMoms" som beräknar moms på en vara utifrån vilken typ av vara det är

    Dessa anrop:

        skrivUtMoms("tidning", 1000); 6%
        skrivUtMoms("restaurangbesök", 1000); 12%
        skrivUtMoms("flyg", 1000); 6%
        skrivUtMoms("falafel", 1000); 25%
        skrivUtMoms("hipsteröl", 1000); 25%

    Ska ge svaren:

        Momsen för en/ett tidning som kostar 1000kr är 60kr
        Momsen för en/ett restaurangbesök som kostar 1000kr är 120kr
        Momsen för en/ett flyg som kostar 1000kr är 60kr
        Momsen för en/ett falafel som kostar 1000kr är 250kr
        Momsen för en/ett hipsteröl som kostar 1000kr är 250kr

    */

    const skrivUtMoms = (vara, price) => {
        let momsSats;
        switch (vara) {
            case "tidning":
                momsSats = 0.06;
                break;
            case "restaurangbesök":
                momsSats = 0.12;
                break;
            case "flyg":
                momsSats = 0.06;
                break;
            default:
                momsSats = 0.25;
                break;
        }

        const moms = price * momsSats;
        console.log(`Momsen för en/ett ${vara} som kostar ${price}kr är ${moms}kr.`);
    };
    skrivUtMoms("tidning", 1000);
    skrivUtMoms("restaurangbesök", 1000);
    skrivUtMoms("flyg", 1000);
    skrivUtMoms("falafel", 1000);
    skrivUtMoms("hipsteröl", 1000);
}

function extraFun3() {
    /*

        Modifiera "skrivUtMoms" så funktionen tar hänsyn till om ordet innan ska vara "en" eller "ett":

            Momsen för en tidning som kostar 1000kr är 60kr
            Momsen för ett restaurangbesök som kostar 1000kr är 120kr
            Momsen för ett flyg som kostar 1000kr är 60kr
            Momsen för en falafel som kostar 1000kr är 250kr
            Momsen för en hipsteröl som kostar 1000kr är 250kr

        Tips: skriv en ny metod:

            function enEtt(word) {
            }

        ...som utifrån ord returnerar "en" eller "ett" (eller "en/ett" om ordet inte finns i ordlistan) 

    */
    const skrivUtMoms = (vara, price) => {
        let momsSats;
        switch (vara) {
            case "tidning":
                momsSats = 0.06;
                break;
            case "restaurangbesök":
                momsSats = 0.12;
                break;
            case "flyg":
                momsSats = 0.06;
                break;
            default:
                momsSats = 0.25;
                break;
        }

        const moms = price * momsSats;
        console.log(`Momsen för ${enEtt(vara)} ${vara} som kostar ${price}kr är ${moms}kr.`);
    };
    skrivUtMoms("tidning", 1000);
    skrivUtMoms("restaurangbesök", 1000);
    skrivUtMoms("flyg", 1000);
    skrivUtMoms("falafel", 1000);
    skrivUtMoms("hipsteröl", 1000);

    function enEtt(word) {
        const enWords = ["tidning", "falafel", "hipsteröl"];
        const ettWords = ["restaurangbesök", "flyg"];

        if (enWords.includes(word)) return "en";
        else if (ettWords.includes(word)) return "ett";
        else return "en/ett";
    }
}
