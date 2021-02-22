// let bulbService = (
//     function () {
//     function init(id) {

//     }

//     return {
//         init: init,
//     };
// })();

// class BulbService {
//     constructor() {
//         this.nbrOfBulbs = 0;
//         this.bulbArr = [];
//     }

//     render() {
//         for (let i = 0; i < this.nbrOfBulbs; i++) {
//             console.log(this.bulbArr[i]);
//             if (!this.bulbArr[i]) bulbArr[i] = new LightBulb();
//         }
//     }
// }

$ = document.getElementById.bind(document);

let bulbArr = [];

class LightBulb {
    constructor() {
        this.lit = false;
    }
}

const bulbService = new BulbService(); 
const bulbInput = $("bulb-input");

bulbInput.addEventListener("input", () => {
    const value = parseInt(bulbInput.value);
    if (value >= 0) {
        for (let i = 0; i < value; i++) {
            bulbArr[i] = new LightBulb();
            const lB = 
        }
    }
});

