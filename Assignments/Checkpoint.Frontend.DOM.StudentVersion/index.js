// Write all your code in this file
$ = document.getElementById.bind(document);
const btA = $("aa");
const btB = $("bb");
const btC = $("cc");
const para = $("dd");
const theDiv = $("ee");

const setBlueBorder = () => (para.style.borderColor = "blue");
const setRedBorder = () => (para.style.borderColor = "red");
const toggleMintBackground = () => para.classList.toggle("mintbackground");

const btD = document.createElement("button");
const btE = document.createElement("button");

btD.textContent = "<<";
btE.textContent = ">>";

theDiv.style.marginTop = "150px"; // Paragraphen täckte delar av knapparna i vissa rotationslägen.
theDiv.appendChild(btD);
theDiv.appendChild(btE);

let pRotation = 0;
btD.addEventListener("click", () => {
    pRotation -= 45;
    updatePRotation();
});

btE.addEventListener("click", () => {
    pRotation += 45;
    updatePRotation();
});

const updatePRotation = () => {
    para.style.transform = `rotate(${pRotation}deg)`;
};
