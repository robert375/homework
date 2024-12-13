function checkFunction(value) {
  let variable = typeof value;
  console.log(`The type of the value is: ${variable}`);
  return variable;
}
checkFunction();

function dogAge(human) {
  let result = human * 7;
  return result;
}
function humanAge(dog) {
  let result = dog / 7;
  return result;
}
let calculate = prompt("Choose (human/dog)");
let dogOrHuman = parseInt(prompt("enter age"));
if (calculate === "human") {
  console.log(`${dogAge(dogOrHuman)}years`);
} else if ((calculate = "dog")) {
  console.log(`${humanAge(dogOrHuman)}years`);
}

function atm() {
  let balance = 1000;
  let amountToWithdraw = parseInt(
    prompt("Enter the amount you want to withdraw:")
  );
  if (amountToWithdraw <= 0) {
    console.log("Please enter a valid amount.");
    return;
  }

  if (amountToWithdraw > balance) {
    console.log("Not enough money.");
  } else {
    balance -= amountToWithdraw;
    console.log(
      `You have withdrawn $${amountToWithdraw}. Your remaining balance is $${balance} .`
    );
  }
}
atm();
//
