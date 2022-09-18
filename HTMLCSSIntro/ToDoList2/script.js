var addBtn = document.getElementById('add-button');

addBtn.addEventListener('click', addTask)

function addTask() {
    var taskInput = document.getElementById('todo-entry-box')
  var inputValue = taskInput.value;
  
  var labelElement = document.createElement('label');
  labelElement.classList.add('task')

  var inputElement = document.createElement('input');
  inputElement.setAttribute("type", "checkbox");

  var iconElement = document.createElement('i');
  iconElement.classList.add('fa');
  iconElement.classList.add('fa-check');

  var spanElement = document.createElement('span');
  spanElement.classList.add('text');
  spanElement.innerHTML = inputValue

  labelElement.appendChild(inputElement)
  labelElement.appendChild(iconElement)
  labelElement.appendChild(spanElement)

  var containerElement = document.getElementById('tasks-containers');
  containerElement.appendChild(labelElement)

  taskInput.value = ''
}