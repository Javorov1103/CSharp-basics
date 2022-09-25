var heading = document.getElementById('colorValue')
var buttons = document.getElementsByClassName('colorButton')
var answerMessage = document.getElementById("answer")

document.getElementById('reset-button').addEventListener('click', startGame)

startGame()

function setButtonColor(button, red, green, blue) {
    button.setAttribute('style',
        `background-color: rgb(${red},${green},${blue})`)
}

function makeColorValue() {
    return Math.round(Math.random() * 255)
}

function startGame() {
    var answerButton = Math.round(Math.random()*(buttons.length - 1))
    answerMessage.innerHTML = ''
    for (let index = 0; index < buttons.length; index++) {
        var red = makeColorValue()
        var green = makeColorValue()
        var blue = makeColorValue()
    
        setButtonColor(buttons[index],red,green,blue)
    
        if(index === answerButton) {
            heading.innerHTML = `${red} - ${green} - ${blue}`
        }
    
        buttons[index].addEventListener('click', function () {
            if(this === buttons[answerButton]) {
                answerMessage.innerHTML = "Correct" 
            } else {
                answerMessage.innerHTML = "Wrong answer! Please try again!" 
            }
        })
    }
}