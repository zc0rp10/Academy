cond9();

function cond1() {
    /*
	    Skapa en variabel shoeMaria och sätt till 36
	    Skapa en variabel shoeAli och sätt till 42
	    Skriv en if-sats som kollar om de har samma skostorlek (skriv ut olika texter)
	    Experimentera med att ändra värden på "shoeMaria" och "shoeAli"
    */

    const shoeMaria = 36;
    const shoeAli = 42;
    if (shoeAli === shoeMaria)
        console.log("Ali and Maria have the same shoe size.");
    else console.log("Ali and Maria DON'T have the same shoe size.");
}

function cond2() {
    /*
      	Skapa en variabel shoeMaria 
	    Skapa en variabel shoeAli 

        Beroende på vilken skostorlek som är störst skriv ut

        "Ali har större fötter än Maria"    
        "Maria har större fötter än Ali"
    */
    const shoeMaria = 36;
    const shoeAli = 42;
    if (shoeAli > shoeMaria) console.log("Ali have larger feet than Maria.");
    else if (shoeAli < shoeMaria)
        console.log("Maria have larger feet than Ali.");
    else console.log("Ali and Maria have the same feet size.");
}

function cond3() {
    /*
	    Samma som sist, men kolla även om de har samma skostorlek

        "Ali har större fötter än Maria"
        "Maria har större fötter än Ali"
        "De har samma skostorlek"

    */
    const shoeMaria = 36;
    const shoeAli = 42;
    if (shoeAli > shoeMaria) console.log("Ali have larger feet than Maria.");
    else if (shoeAli < shoeMaria)
        console.log("Maria have larger feet than Ali.");
    else console.log("Ali and Maria have the same feet size.");
}

function cond4() {
    /*
        Skapa tre variabler: shoeMaria, shoeAli, bigFoot 

	    Skriv en if-sats som kolla om bigFoot har större skostorlek än både Ali och Maria
    */
    const shoeMaria = 36;
    const shoeAli = 42;
    const bigFoot = 99;

    if (bigFoot > shoeMaria && bigFoot > shoeAli)
        console.log("Big Foot have larget feet than Maria and Ali");
}

function cond5() {
    /*
	    Skriv en ifsats som kollar om någon av Ali, Maria eller BigFoot har en skostorlek som är större än 50

        Extra: 
        1) lös denna uppgift genom att skapa en egen metod "someHigh" som tar flera parametrar. Använd sedan den såhär:

            if (someHigh(50, bigFoot, shoeAli, shoeMaria))
                console.log("Någon av de tre har riktigt stora fötter");

        2) lös denna uppgift med ".some"
        
    */

    const shoeMaria = 36;
    const shoeAli = 42;
    const bigFoot = 99;

    // if (bigFoot > 50 || shoeMaria > 50 || shoeAli > 50)
    //    console.log("Larger than 50");

    if (someHigh(50, bigFoot, shoeAli, shoeMaria))
        console.log("Någon av de tre har riktigt stora fötter");

    function someHigh(target, bF, sA, sM) {
        if (bF > target || sA > target || sM > target) return true;
    }
}

function cond6() {
    /*
	    Skapa en variabel "favoriteVegetable" och sätt den till "kålrot"
	    Använd en switch-sats för att kolla värdet på "favoriteVegetable" och svara på olika sätt
	    Om t.ex värdet av "favoriteVegetable" är "majrova" skriv "Passar till falafel"
    */

    const favoriteVegetable = "kålrot";

    switch (favoriteVegetable) {
        case "majrova":
            console.log("Passar till falafel.");
            break;
        case "kålrot":
            console.log("Kålrot är oxå nice.");
            break;
        default:
            console.log("Ingen träff..");
            break;
    }
}

function cond7() {
    /*
	    Samma som sist men skapa först en variabel "answer"
	    Istället för att använda "console.log" inuti switch-satsen så sätt variabel "answer"
	    Använd tillslut "console.log" för att skriva ut värdet av "answer"
    */

    const favoriteVegetable = "kålrot";
    let answer;

    switch (favoriteVegetable) {
        case "majrova":
            answer = "Passar till falafel.";
            break;
        case "kålrot":
            answer = "Kålrot är oxå nice.";
            break;
        default:
            answer = "Ingen träff..";
            break;
    }

    console.log(answer);
}

function cond8() {
    /*
	    Jämför == och === i en ifsats
	    Testa med en ifsats om 3=="3" är sant
	    Testa med en ifsats om 3==="3" är sant
    */

    if (3 == "3") console.log("Sant..");
    if (3 === "3") console.log("Sant..");
}

function cond9() {
    /*
	    Övning i "ternary operator"
	    Skapa en variabel a och sätt den till 13*13
	    Skapa en variabel b och sätt den till 169
	    Använd "ternary operator" för att kolla om de är lika. Lägg svaret (strängen "lika" eller "olika") i en variabel "result"
	    Skriv ut result
    */

    const a = 13 * 13;
    const b = 169;
    const result = a === b ? "lika" : "olika";
    console.log(result);
}
