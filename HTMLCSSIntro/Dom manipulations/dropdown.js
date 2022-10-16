function addItem() {
//Select the two inputs
var input1= document.getElementById("newItemText")
var input2 = document.getElementById("newItemValue")
var textInput = input1.value;
var valueInput = input2.value;

//Create an option element
var optionEl = document.createElement("option");

//Set the attr of the new option element
optionEl.setAttribute('value', valueInput);
optionEl.innerHTML = textInput;

//Add the new option element into the select box
document.getElementById('menu').appendChild(optionEl)

//Clear the inputs
input1.value ='';
input2.value='';
}


