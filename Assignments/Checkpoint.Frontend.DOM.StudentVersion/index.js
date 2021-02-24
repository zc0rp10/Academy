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

btD.addEventListener("click", () => {
    rotateElement(para, -45);
});

btE.addEventListener("click", () => {
    rotateElement(para, 45);
});

const rotateElement = (element, deg) => {
    const transformString = element.style.transform;
    const hasRot = transformString.match(/rotate\((.*)deg/);
    if (hasRot != null) {
        let transformStrArr = transformString.split(" ");
        for (let i = 0; i < transformStrArr.length; i++) {
            if (transformStrArr[i].match(/rotate/))
                transformStrArr[i] = `rotate(${parseInt(hasRot.pop()) + deg}deg)`;
        }
        element.style.transform = transformStrArr.join(" ");
    } else element.style.transform = transformString + `rotate(${deg}deg)`;
};
