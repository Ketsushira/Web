const number = document.getElementById("number");
const buttons = document.querySelectorAll(".buttons button");
let count = 0;

buttons.forEach(button => {
    button.addEventListener("click", () => {
        if (button.textContent === "Artır") {
            count++;
        }
        else if (button.textContent === "Azalt") {
            count--;
        }
        else {
            count = 0;
        }
        number.textContent = count;
    });
});