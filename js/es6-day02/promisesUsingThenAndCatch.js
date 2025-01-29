const fetchUsers = () => {
    fetch('https://jsonplaceholder.typicode.com/users')
      .then(response => response.json())
      .then(users => {
        const tabsContainer = document.getElementById('tabs');
  
        users.forEach(user => {
          const tab = document.createElement('button');
          tab.classList.add('tab');
          tab.innerText = user.username;
          tabsContainer.appendChild(tab);
  
          tab.addEventListener('click', () => {
            fetchPosts(user.id);
          });
        });
      })
      .catch(error => {
        console.error('Error fetching users:', error);
      });
  };
  
  const fetchPosts = (userId) => {
    fetch(`https://jsonplaceholder.typicode.com/posts?userId=${userId}`)
      .then(response => response.json())
      .then(posts => {
        const postsContainer = document.getElementById('posts');
        postsContainer.innerHTML = '<h3>Posts:</h3>';
        posts.forEach(post => {
          const postElement = document.createElement('div');
          postElement.textContent = post.title;
          postsContainer.appendChild(postElement);
        });
      })
      .catch(error => {
        console.error('Error fetching posts:', error);
      });
  };
  
  fetchUsers();