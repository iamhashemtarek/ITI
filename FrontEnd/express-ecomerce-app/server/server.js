const express = require('express');
const fs = require('fs');
const path = require('path');
const app = express();
const port = 5000;

app.use(express.json());
app.use(express.static(path.join(__dirname, '../public')));

const dbPath = path.join(__dirname, 'db/db.json');
let db = JSON.parse(fs.readFileSync(dbPath, 'utf-8'));

app.post('/login', (req, res) => {
  const { username, password } = req.body;
  const user = db.users.find(u => u.username === username && u.password === password);
  if (user) {
    res.json({ success: true, userId: user.id });
  } else {
    res.status(401).json({ success: false, message: 'Invalid credentials' });
  }
});

app.get('/products', (req, res) => {
  res.json(db.products);
});

app.post('/add-to-cart', (req, res) => {
  const { userId, productId } = req.body;
  if (!db.carts[userId]) {
    db.carts[userId] = [];
  }
  db.carts[userId].push(productId);
  fs.writeFileSync(dbPath, JSON.stringify(db, null, 2));
  res.json({ success: true });
});

app.get('/cart', (req, res) => {
  const { userId } = req.query;
  const userCart = db.carts[userId] || [];
  res.json(userCart);
});

app.listen(port, () => {
  console.log(`Server running at http://localhost:${port}`);
});