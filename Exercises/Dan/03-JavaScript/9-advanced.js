adv14();
function loglist(listname, list) {
    console.log("***" + listname + "***");
    for (let x of list) console.log(x);
}

function adv1() {
    const evens = [2, 4, 6, 8];

    // Använd ".map" för att skapa en ny lista "odds" utifrån listan "evens"
    const odds = evens.map((x) => x + 1);
    loglist("adv1", odds);
}

function adv2() {
    const evens = [2, 4, 6, 8];

    // Använd ".map" för att skapa en ny lista "--2--", "--4--", "--6--", "--8--"
    const list = evens.map((x) => `--${x}--`);
    loglist("adv2", list);
}

function adv3() {
    const evens = [2, 4, 6, 8];

    // Använd ".map" för att skapa en ny lista [{row:1, num:200}, {row:2, num:400} ...]

    const list = evens.map((x, index) => (x = { row: index + 1, num: x * 100 }));
    loglist("adv3", list);
}

function adv4() {
    const evens = [2, 4, 6, 8];
    // Använd ".forEach" för att skriva ut alla element i listan
    evens.forEach((x) => console.log(x));
    // Använd "forEach" för att skriva ut:
    //Element 0) 2
    //Element 1) 4
    //Element 2) 6
    //Element 3) 8
    evens.forEach((x, index) => console.log(`Element ${index}) ${x}`));
}

function adv5() {
    // Gör om metoden "sum" så default för a är 30 och b är 40.
    // alltså om t.ex sum(15) anropas så returneras 55
    function sumNew(a = 30, b = 40) {
        return a + b;
    }

    console.log(sumNew()); // 70
    console.log(sumNew(1)); // 41
    console.log(sumNew(1, 2)); // 3
}

function adv6() {
    // Skapa en funktion "sum" som summerar valfritt antal tal
    // Ex sum(2, 10, 3) ska returnera 15
    // Ex sum(2, 10) ska returnera 12
    // Använd "spread operator"

    console.log(sum(2, 10, 3));
    console.log(sum(2, 10));

    function sum(...arr) {
        let sum = 0;
        for (const item of arr) {
            sum += item;
        }
        return sum;

        // return arr.reduce((prev, curr => {
        //     return prev + curr;
        // }))
    }
}

function adv7() {
    /* Skapa en funktion "supersum" som ska funkar såhär:
   
       supersum("<", ">", 3, 4, 5);  ==>  "<12>"
       supersum("[", "]", 55, 2)     ==>  "[57]"
       supersum("A", "B", 6)         ==>  "A6B"

       Använd "spread operator"

    */

    console.log(supersum("<", ">", 3, 4, 5));
    console.log(supersum("[", "]", 55, 2));
    console.log(supersum("A", "B", 6));

    function supersum(...arr) {
        let sum = 0;
        for (const iterator of arr) {
            if (typeof iterator == "number") sum += iterator;
        }

        return `${arr[0]}${sum}${arr[1]}`;
    }
}

function adv8() {
    /*
     Skapa metoden "starify" som ska funka såhär:

     starify("ab")           ==>   ["*a*", "*b*"]
     starify("XYZ")          ==>   ["*X*", "*Y*", "*Z*"]

    Använd "map" och "spread operator"
     */

    const starify = (string) => {
        return [...string].map((x) => `*${x}*`);
    };

    console.log(starify("ab"));
    console.log(starify("XYZ"));
}

function adv9() {
    let firstName = "Simon";
    let lastName = "Larsson";

    // Skapa ett objekt "person" som innehåller {firstName: "Simon", lastName: "Larsson"} på enklast möjliga sätt
    person = {
        firstName: firstName,
        lastName: lastName,
    };

    console.log(person);
}

function adv10() {
    /*
     Skapa ett objekt "myMath" som rymmer metoderna "addOne" och "double":

        myMath.addOne(100)   ==>   101
        myMath.double(100)   ==>   200
     */

    const myMath = {
        addOne: function (num) {
            return num + 1;
        },
        double: (num) => num * 2,
    };

    console.log(myMath.addOne(100));
    console.log(myMath.double(100));
}

function adv11() {
    let x = 100;
    let y = 200;

    // Byt värde på x och y på enklast möjliga sätt. Tips: använd "array matching"
    [x, y] = [y, x];
    console.log("x", x); // 200
    console.log("y", y); // 100
}

function adv12() {
    let list = [10, 20, 30, 40, 50];
    // Sätt "a" till 10, "b" till 30 och "c" till 40 på enklast möjliga sätt.
    // Tips: använd "array matching"
    [a, b, c] = [list[0], list[2], list[3]];

    console.log("a", a); // 10
    console.log("b", b); // 30
    console.log("c", c); // 40
}

function adv13() {
    function getPerson() {
        return { firstName: "Lisa", age: 66 };
    }

    // Sätt "firstName" till "Lisa" och "age" till "66" genom att anropa "getPerson" och använda "object matching"
    let { firstName, age } = getPerson();

    console.log("First Name: ", firstName);
    console.log("Age: ", age);
}

function adv14() {
    // Skapa en funktion som skriver ut "Lisa" och 66 utifrån "person"
    // Använd "Parameter Context Matching"
    let person = { firstName: "Lisa", age: 66, favColor: "red" };
    fun(person);
}
