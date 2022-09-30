//Вземам всички елементи с клас peng
var pengs = $('.peng')

//Разбърквам елемените на случаен принцип
pengs = shuffle(pengs)

//Избирам случаен индекс, на който ще бъде yeti
var randomIndex = Math.floor(Math.random() *pengs.length);
pengs[randomIndex].classList.add('yeti');

//Копирам само пингвините в нов масив
var onlyPengs = [...pengs].filter(x=>!x.classList.contains('yeti'))

//Слагам на пингвините съответните класове
for (let index = 0; index < onlyPengs.length; index++) {
        const element = onlyPengs[index];
        element.classList.add(`pinguine${index+1}`)
}

//функция разбъркване на масив
function shuffle(array) {
    let currentIndex = array.length,  randomIndex;
  
    // While there remain elements to shuffle.
    while (currentIndex != 0) {
  
      // Pick a remaining element.
      randomIndex = Math.floor(Math.random() * currentIndex);
      currentIndex--;
  
      // And swap it with the current element.
      [array[currentIndex], array[randomIndex]] = [
        array[randomIndex], array[currentIndex]];
    }
  
    return array;
  }