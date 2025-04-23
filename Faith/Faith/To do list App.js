// script.js
// Select form, input field, and task list
const taskForm = document.getElementById("task-form");
const taskInput = document.getElementById("task-input");
const taskList = document.getElementById("task-list");

// Add event listener for the form submission
taskForm.addEventListener("submit", function (e) {
  e.preventDefault(); // Prevent page reload
  
  // Get the task from the input field
  const taskText = taskInput.value.trim();
  
  if (taskText === "") {
    alert("Please enter a task!");
    return;
  }

  // Create a new task item
  const taskItem = document.createElement("li");
  taskItem.innerHTML = `
    <span>${taskText}</span>
    <button class="delete-btn">Delete</button>
  `;

  // Add the task to the list
  taskList.appendChild(taskItem);

  // Clear the input field
  taskInput.value = "";

  // Add event listener to the delete button
  const deleteBtn = taskItem.querySelector(".delete-btn");
  deleteBtn.addEventListener("click", function () {
    taskItem.remove();
  });
});