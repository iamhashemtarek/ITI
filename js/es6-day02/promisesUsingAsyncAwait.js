const fetchUsers = async () => {
    const response = await fetch('https://jsonplaceholder.typicode.com/users');
    const users = await response.json();
    const tabsContainer = document.getElementById('tabs');

    users.forEach(user => {
        try {
            const tab = document.createElement('button');
            tab.classList.add('tab');
            tab.innerText = user.username;
            tabsContainer.appendChild(tab);

            tab.addEventListener('click', async () => {
                await fetchPosts(user.id);
            });
        } catch (error) {
            console.error('Error fetching users:', error);
        }
    })
}

const fetchPosts = async (userId) => {
    try {
        const response = await fetch(`https://jsonplaceholder.typicode.com/posts?userId=${userId}`)
        const posts = await response.json();
        const postsContainer = document.getElementById('posts');
        postsContainer.innerHTML = '<h3>Posts:</h3>';
        posts.forEach(post => {
          const postElement = document.createElement('div');
          postElement.textContent = post.title;
          postsContainer.appendChild(postElement);
        });
    } catch (error) {
        console.error('Error fetching posts:', error);
    }
}

fetchUsers()