const generateRandomBetween = (min, max, exclude) => {
    let ranNum = Math.floor(Math.random() * (max - min)) + min;

    if (ranNum === exclude) {
        ranNum = generateRandomBetween(min, max, exclude);
    }
    return ranNum;
}

function FiftyFifty() {
    document.getElementById("fiftyFiftyUsed").value = 'True';
    const falseAnswers = document.getElementsByClassName('FalseAnswer');

    let firstToDelete = Math.floor(Math.random() * falseAnswers.length);
    falseAnswers[firstToDelete].style.visibility = 'hidden';

    let secondToDelete = generateRandomBetween(0, falseAnswers.length, firstToDelete);
    falseAnswers[secondToDelete].style.display = 'none';
    const button = document.getElementById('FiftyFiftyButton');
    button.disabled = true;
}