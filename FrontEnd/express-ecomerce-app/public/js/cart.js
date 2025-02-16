document.addEventListener('DOMContentLoaded', async () => {
  const cartItems = document.getElementById('cartItems');
  const userId = localStorage.getItem('userId');

  if (!userId) {
    alert('You must be logged in to view your cart.');
    window.location.href = 'login.html';
    return;
  }

  try {
    // Fetch cart items from the server
    const response = await fetch(`http://localhost:5000/cart?userId=${userId}`);
    const cart = await response.json();

    if (cart.length === 0) {
      cartItems.innerHTML = '<p>Your cart is empty.</p>';
      return;
    }

    // Fetch product details for each item in the cart
    const productsResponse = await fetch('http://localhost:5000/products');
    const products = await productsResponse.json();

    // Display cart items
    cart.forEach(itemId => {
      const product = products.find(p => p.id === itemId);
      if (product) {
        const cartItem = `
          <div class="card mb-3">
            <div class="row g-0">
              <div class="col-md-4">
                <img src="${product.image}" class="img-fluid rounded-start" alt="${product.name}">
              </div>
              <div class="col-md-8">
                <div class="card-body">
                  <h5 class="card-title">${product.name}</h5>
                  <p class="card-text">${product.description}</p>
                  <p class="card-text"><strong>Price:</strong> $${product.price}</p>
                </div>
              </div>
            </div>
          </div>
        `;
        cartItems.innerHTML += cartItem;
      }
    });
  } catch (error) {
    console.error('Error fetching cart:', error);
    alert('An error occurred while fetching your cart.');
  }
});

// Checkout function
function checkout() {
  alert('Checkout functionality is not implemented yet.');
}