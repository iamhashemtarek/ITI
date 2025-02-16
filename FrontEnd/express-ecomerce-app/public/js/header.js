document.addEventListener('DOMContentLoaded', () => {
  const logoutButton = document.getElementById('logoutButton');
  const userId = localStorage.getItem('userId');

  // Show user dropdown if logged in
  if (userId) {
    const userDropdown = document.querySelector('.navbar-nav .dropdown-toggle');
    userDropdown.style.display = 'block';
  }

  // Logout functionality
  if (logoutButton) {
    logoutButton.addEventListener('click', () => {
      localStorage.removeItem('userId');
      window.location.href = 'login.html';
    });
  }
});