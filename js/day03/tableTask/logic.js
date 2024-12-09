const addStButton = document.getElementById('addSt');
const studentNameInput = document.querySelector('.studentName input');
const studentAgeInput = document.querySelector('.studentAge input');
const table = document.querySelector('table');

let studentID = 1;

addStButton.addEventListener('click', () => {
  const studentName = studentNameInput.value.trim();
  const studentAge = studentAgeInput.value.trim();

  if (!studentName || !studentAge) {
    alert('Please enter a valid name and age.');
    return;
  }

  const newRow = document.createElement('tr');

  const idCell = document.createElement('td');
  idCell.textContent = studentID++;
  newRow.appendChild(idCell);

  const nameCell = document.createElement('td');
  nameCell.textContent = studentName;
  newRow.appendChild(nameCell);

  const ageCell = document.createElement('td');
  ageCell.textContent = studentAge;
  newRow.appendChild(ageCell);

  const actionCell = document.createElement('td');
  const deleteButton = document.createElement('button');
  deleteButton.textContent = 'Delete';
  deleteButton.addEventListener('click', () => {
    table.removeChild(newRow);
  });
  actionCell.appendChild(deleteButton);
  newRow.appendChild(actionCell);

  table.appendChild(newRow);

  studentNameInput.value = '';
  studentAgeInput.value = '';
});
