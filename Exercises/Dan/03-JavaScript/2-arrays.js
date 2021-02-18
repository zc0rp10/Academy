arr8();

function arr1() {

    /*
        I---------I---------I---------I
        0         1         2         3
    
        Skapa en array "cities" med städerna Stockholm, Göteborg och New York
        Skriv ut det första, andra och tredje elementet i arrayen
        Vad händer om du försöker komma åt det fjärde elementet (som inte finns)?
    */

    // Extra: skriv ut det andra elementet ("Göteborg") två gånger
    // Extra: Skriv ut de två första elementen vid sidan av varandra ("StockholmGöteborg")

    const cities = ["Stockholm", "Göteborg", "New York"];
    console.log(cities[0],cities[1],cities[2])
}

function arr2() {

    /*
        Skapa en array "cities" med städerna Stockholm, Göteborg och New York
	    Lägg till en till stad "Krakow" mha "push"
	    Skriv ut det fjärde elementet i "cities" ("Krakow")
    */

    // Extra: använd push för att lägga till två till städer. Skriv ut den sista staden i listan.
    let cities = ["Stockholm", "Göteborg", "New York"];
    cities.push("Krakow");
    console.log(cities[5]);
}


function arr3() {
    /*
	    Skapa en array "cities" med städerna Stockholm, Göteborg och New York
	    Lägg till en till stad "Krakow" mha "push"
	    Lägg till ytterligare en till stad "Berlin" mha "push" 
	    Skriv ut antalet städer i arrayen
	    Plocka ut den andra och fjärde staden i listan. Skriv ut "Mina favoritstäder är Göteborg och Krakow"
    */
   // Extra: använd push för att lägga till två till städer. Skriv ut den sista staden i listan.
   let cities = ["Stockholm", "Göteborg", "New York"];
   cities.push("Krakow");
   cities.push("Berlin");
   console.log(cities.length);
   console.log(`Mina favoritstäder är ${cities[1]} och ${cities[3]}`);

}

function arr4() {

    /*
	    Skapa en array "cities" med städerna Stockholm, Göteborg och New York
	    Använd "pop" för att plocka ut den sista staden och placera i en variabel "poppedCity"
	    Skriv ut längen av listan (2)
	    Skriv ut den poppade staden (New York)
	    Använd cities.length för att plocka ut det sista elementet i listan (Göteborg)
    */
   let cities = ["Stockholm", "Göteborg", "New York"];
   const poppedCity = cities.pop();
   console.log(cities.length);
   console.log(poppedCity)
   console.log(cities[cities.length-1]);
}

function arr5() {

    /*
	    Skapa en array "numbers" med talen 5,66,777,12
	    Skriv ut antalet nummer i listan (4)
	    Skriv ut det tredje numret i listan (777)
    */
   const numbers = [5,66,777,12];
   console.log(numbers.length)
   console.log(numbers[2])
}

function arr6() {
    
    /*
    Skapa en array "numbers" med talen 5,66,777,12
    Sortera talen genom att skriva: numbers.sort();
    Sortera talen genom att skriva: numbers.sort( (a,b) => a-b );
    Skriv ut värdet av "numbers"
    Jämför de två resultaten
    */
    const numbers = [5,66,777,12];
    numbers.sort();
    console.log(numbers)
    numbers.sort((a,b) => a-b);
    console.log(numbers)
}

function arr7() {

    /*
        Sortera listan baklänges
    */
   const numbers = [5,66,777,12];
   numbers.sort((a,b) => b-a); 
   console.log(numbers); 
}

function arr8() {
    
    /*
    Skapa en array "numbers" med talen 5,66,777,12
    Vänd på ordningen mha "reverse"
    Skriv ut arrayen ([ 12, 777, 66, 5 ])
    */
    const numbers = [5,66,777,12];
    numbers.reverse();
    console.log(numbers)
}