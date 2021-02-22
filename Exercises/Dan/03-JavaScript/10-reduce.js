reduce4();
function reduce1() {
    const data = [5, 10, 15, 20, 25];

    // Använd "reduce" för att summera alla tal i arrayen (till 75)

    const sum = data.reduce((acc, val) => {
        return acc + val;
    });

    console.log(sum);
}

function reduce2() {
    // Använd "reduce" för att platta till arrayen
    // Alltså ge [1, 2, 3, 4, 5, 6, 7, 8, 9]

    const data = [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9],
    ];

    const flat = data.reduce((total, amount) => {
        return total.concat(amount);
    });

    console.log(flat);
}

function reduce3() {
    let ages = [{ age: 22 }, { age: 43 }, { age: 8 }];

    // Skapa metoden "maxAge" så följande ger siffran 43

    let res = ages.reduce(maxAge, 0);

    function maxAge(prev, cur) {
        if (cur.age > prev) return cur.age;
        else return prev;
    }

    console.log(res);
}

function reduce4() {
    let names = ["Alice", "Bob", "Tiff", "Bruce", "Alice", "Bob", "Bob"];

    // Skapa metoden "countNames" där detta:

    let y = countNames(names);

    // ...ska leda till att y blir
    // {Alice: 2, Bob: 3, Tiff: 1, Bruce: 1}

    function countNames(items) {
        items.reduce((acc, val) => {

            return acc + val;
        });
    }

    console.log("Res: " + y);
}

function reduce5() {
    let names = ["Alice", "Bob", "Leif"];

    combine(names);

    // Skapa metoden "combine"
    // Används "reduce"
    // Ska returnera "ALICEBOBLEIF"
}

function reduce6() {
    let names = ["Alice", "Bob", "Leif"];

    reverse(names);

    // Skapa metoden "reverse" som vänder på en array
    // Används "reduce"
    // Ska returnera ['Leif', 'Bob', 'Alice' ]
}

function reduce7() {
    let names = ["Alice", "Ababababa", "Bob", "Leif", "Abcdefg"];

    // Skapa metoden "countLongWords" som räknar antalet ord som har 6 eller fler tecken
    // Använd "reduce"

    countLongWords(names);
}
