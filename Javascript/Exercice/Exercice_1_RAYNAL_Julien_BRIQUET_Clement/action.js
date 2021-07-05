$("#nine").on("click", addNine);
$("#eight").on("click", addEight);
$("#seven").on("click", addSeven);
$("#six").on("click", addSix);
$("#five").on("click", addFive);
$("#four").on("click", addFour);
$("#three").on("click", addThree);
$("#two").on("click", addTwo);
$("#one").on("click", addOne);
$("#zero").on("click", addZero);
$("#plus").on("click", addPlus);
$("#minus").on("click", addMinus);
$("#multiplicator").on("click", addMultiplicator);
$("#dividor").on("click", addDividor);
$("#equal").on("click", calculateResult);
$("#ac").on("click", acCalled);

//main variables for the code to work
// the text that will be displayed in the calculator
let text = "";
// checks if their's a + - / * to change the variables the number are assigned to
let shouldUseSecondNumber = false;
// takes the iterator (+ - * /) to do the final math
let iterator = "";
// numbers on the left of the iterator
let firstNumber = null;
//numbers on the right of the iterator
let secondNumber = null;
// checks if the first number should be negative or not
let firstNumberIsMinus = false;
// checks if the second number should be negative or not
let secondNumberIsMinus = false;

// functions to get the number clicked: adds it to the number being calculated and to the text
function addNine() {
  text += "9";
  if (shouldUseSecondNumber) {
    if (secondNumberIsMinus) {
      secondNumber = secondNumber * 10 - 9;
    } else {
      secondNumber = secondNumber * 10 + 9;
    }
  } else {
    if (firstNumberIsMinus) {
      firstNumber = firstNumber * 10 - 9;
    } else {
      firstNumber = firstNumber * 10 + 9;
    }
  }
  $("#result").text(text);
}

function addEight() {
  text += "8";

  if (shouldUseSecondNumber) {
    if (secondNumberIsMinus) {
      secondNumber = secondNumber * 10 - 8;
    } else {
      secondNumber = secondNumber * 10 + 8;
    }
  } else {
    if (firstNumberIsMinus) {
      firstNumber = firstNumber * 10 - 8;
    } else {
      firstNumber = firstNumber * 10 + 8;
    }
  }
  $("#result").text(text);
}

function addSeven() {
  text += "7";
  if (shouldUseSecondNumber) {
    if (secondNumberIsMinus) {
      secondNumber = secondNumber * 10 - 7;
    } else {
      secondNumber = secondNumber * 10 + 7;
    }
  } else {
    if (firstNumberIsMinus) {
      firstNumber = firstNumber * 10 - 7;
    } else {
      firstNumber = firstNumber * 10 + 7;
    }
  }
  $("#result").text(text);
}

function addSix() {
  text += "6";
  if (shouldUseSecondNumber) {
    if (secondNumberIsMinus) {
      secondNumber = secondNumber * 10 - 6;
    } else {
      secondNumber = secondNumber * 10 + 6;
    }
  } else {
    if (firstNumberIsMinus) {
      firstNumber = firstNumber * 10 - 6;
    } else {
      firstNumber = firstNumber * 10 + 6;
    }
  }
  $("#result").text(text);
}

function addFive() {
  text += "5";
  if (shouldUseSecondNumber) {
    if (secondNumberIsMinus) {
      secondNumber = secondNumber * 10 - 5;
    } else {
      secondNumber = secondNumber * 10 + 5;
    }
  } else {
    if (firstNumberIsMinus) {
      firstNumber = firstNumber * 10 - 5;
    } else {
      firstNumber = firstNumber * 10 + 5;
    }
  }
  $("#result").text(text);
}

function addFour() {
  text += "4";
  if (shouldUseSecondNumber) {
    if (secondNumberIsMinus) {
      secondNumber = secondNumber * 10 - 4;
    } else {
      secondNumber = secondNumber * 10 + 4;
    }
  } else {
    if (firstNumberIsMinus) {
      firstNumber = firstNumber * 10 - 4;
    } else {
      firstNumber = firstNumber * 10 + 4;
    }
  }
  $("#result").text(text);
}

function addThree() {
  text += "3";
  if (shouldUseSecondNumber) {
    if (secondNumberIsMinus) {
      secondNumber = secondNumber * 10 - 3;
    } else {
      secondNumber = secondNumber * 10 + 3;
    }
  } else {
    if (firstNumberIsMinus) {
      firstNumber = firstNumber * 10 - 3;
    } else {
      firstNumber = firstNumber * 10 + 3;
    }
  }
  $("#result").text(text);
}

function addTwo() {
  text += "2";
  if (shouldUseSecondNumber) {
    if (secondNumberIsMinus) {
      secondNumber = secondNumber * 10 - 2;
    } else {
      secondNumber = secondNumber * 10 + 2;
    }
  } else {
    if (firstNumberIsMinus) {
      firstNumber = firstNumber * 10 - 2;
    } else {
      firstNumber = firstNumber * 10 + 2;
    }
  }
  $("#result").text(text);
}

function addOne() {
  text += "1";
  if (shouldUseSecondNumber) {
    if (secondNumberIsMinus) {
      secondNumber = secondNumber * 10 - 1;
    } else {
      secondNumber = secondNumber * 10 + 1;
    }
  } else {
    if (firstNumberIsMinus) {
      firstNumber = firstNumber * 10 - 1;
    } else {
      firstNumber = firstNumber * 10 + 1;
    }
  }
  $("#result").text(text);
}

function addZero() {
  text += "0";
  shouldUseSecondNumber
    ? (secondNumber = secondNumber * 10)
    : (firstNumber = firstNumber * 10);
  $("#result").text(text);
}

//checks what type of calculus is used and adapts the calculus + changes the text
function addPlus() {
  if (iterator.length == 0 && firstNumber != null) {
    text += " + ";
    iterator = "plus";
    shouldUseSecondNumber = true;
    $("#result").text(text);
  }
}

function addMinus() {
  if (iterator.length == 0 && firstNumber != null) {
    text += " - ";
    iterator = "minus";
    shouldUseSecondNumber = true;
    $("#result").text(text);
  } else if (
    firstNumber == null &&
    secondNumber == null &&
    iterator.length == 0
  ) {
    text += "-";
    firstNumberIsMinus = true;
    $("#result").text(text);
  } else if (
    firstNumber != null &&
    secondNumber == null &&
    iterator.length > 0
  ) {
    text += " -";
    secondNumberIsMinus = true;
    $("#result").text(text);
  }
}

function addMultiplicator() {
  if (iterator.length == 0 && firstNumber != null) {
    text += " * ";
    iterator = "multiplicator";
    shouldUseSecondNumber = true;
    $("#result").text(text);
  }
}

function addDividor() {
  if (iterator.length == 0 && firstNumber != null) {
    text += " / ";
    iterator = "dividor";
    shouldUseSecondNumber = true;

    $("#result").text(text);
  }
}

function calculateResult() {
  result = 0;
  switch (iterator) {
    case "plus":
      result = firstNumber + secondNumber;
      break;
    case "minus":
      result = firstNumber - secondNumber;
      break;
    case "multiplicator":
      result = firstNumber * secondNumber;
      break;
    case "dividor":
      result = firstNumber / secondNumber;
      break;
  }
  $("#result").text(result);
  resetValues();
}

function acCalled() {
  resetValues();
  $("#result").text(text);
}

// used to reset all the basic variables needed to recalculate everything
function resetValues() {
  text = "";
  shouldUseSecondNumber = false;
  iterator = "";
  firstNumber = null;
  secondNumber = null;
  firstNumberIsMinus = false;
  secondNumberIsMinus = false;
}
