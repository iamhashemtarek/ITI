document.addEventListener('DOMContentLoaded', async () => {
  const productList = document.getElementById('productList');
  const userId = localStorage.getItem('userId');

  if (!userId) {
    alert('You must be logged in to view products.');
    window.location.href = 'login.html';
    return;
  }

  try {
    // Fetch products from the server
    const response = await fetch('http://localhost:5000/products');
    const products = await response.json();

    // Display products
    products.forEach(product => {
      const productCard = `
   <div class="col-md-4 mb-4">
    <div class="card h-100">
        <img src="${product.image}" class="card-img-top" alt="${product.name}" style="width: 100%; height: auto; object-fit: cover;">
        <div class="card-body">
            <h5 class="card-title">${product.name}</h5>
            <p class="card-text">${product.description}</p>
            <p class="card-text"><strong>Price:</strong> $${product.price}</p>
            <p class="card-text"><small class="text-muted">Category: ${product.category}</small></p>
            <button class="btn btn-primary" onclick="addToCart(${product.id})">Add to Cart</button>
        </div>
    </div>
</div>
      `;
      productList.innerHTML += productCard;
    });
  } catch (error) {
    console.error('Error fetching products:', error);
    alert('An error occurred while fetching products.');
  }
});

// Add to cart function
async function addToCart(productId) {
  const userId = localStorage.getItem('userId');

  try {
    const response = await fetch('http://localhost:5000/add-to-cart', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ userId, productId }),
    });
    const data = await response.json();

    if (data.success) {
      alert('Product added to cart!');
    } else {
      alert('Failed to add product to cart.');
    }
  } catch (error) {
    console.error('Error adding to cart:', error);
    alert('An error occurred while adding the product to the cart.');
  }
}