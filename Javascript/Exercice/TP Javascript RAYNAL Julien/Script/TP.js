function createTopLine() {
  arrayOfLines = [];
  arrayOfSeparator = [];
  for (let i = 0; i < 60; i++) {
    arrayOfLines.push("_");
    if (i % 10 === 0) {
      arrayOfSeparator.push("|");
    } else {
      arrayOfSeparator.push(" ");
    }
  }
  console.log(arrayOfLines.join(""));
  for (let i = 0; i < 3; i++) {
    createSideSeparator(i);
  }
}

function createSideSeparator(i) {
  arrayOfSeparator = [];
    for (let j = 0; j <= 60; j++) {
      if (j % 10 === 0) {
        arrayOfSeparator.push("|");
      } else {
        if (i === 2) {
          arrayOfSeparator.push("_");
        } else {
          arrayOfSeparator.push(" ");
        }
      }
    }

  console.log(arrayOfSeparator.join(""));
}

createTopLine();
