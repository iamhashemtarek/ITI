import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from "./header/header.component";
import { CategoryListComponent } from "./category-list/category-list.component";
import { ProductListComponent } from "./product-list/product-list.component";
import { Iproduct } from '../core/interfaces/iproduct';
import { FooterComponent } from "./footer/footer.component";

@Component({
  selector: 'app-root',
  // imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [CategoryListComponent, ProductListComponent, HeaderComponent, FooterComponent]
})
export class AppComponent {
  products: Iproduct[] = [
    // Books
    { id: 1, name: 'Book', price: 200, category: 'Books', stock: 0, imageUrl: 'https://images.unsplash.com/photo-1495446815901-a7297e633e8d' },
    { id: 2, name: 'Notebook', price: 100, category: 'Books', stock: 1, imageUrl: 'https://images.unsplash.com/photo-1506880018603-83d5b814b5a6' },
    { id: 3, name: 'Science Magazine', price: 150, category: 'Books', stock: 30, imageUrl: 'https://images.unsplash.com/photo-1512820790803-83ca734da794' },
    { id: 4, name: 'Kindle Paperwhite', price: 400, category: 'Books', stock: 20, imageUrl: 'https://images.unsplash.com/photo-1553729784-e91953dec042' },
    { id: 5, name: 'Cookbook', price: 250, category: 'Books', stock: 40, imageUrl: 'https://images.unsplash.com/photo-1506880018603-83d5b814b5a6' },
    { id: 6, name: 'Fantasy Novel', price: 180, category: 'Books', stock: 60, imageUrl: 'https://images.unsplash.com/photo-1507842217343-583bb7270b66' },
  
    // Makeup
    { id: 7, name: 'Lipstick', price: 90, category: 'Makeup', stock: 100, imageUrl: 'https://images.unsplash.com/photo-1522335789203-aabd1fc54bc9' },
    { id: 8, name: 'Foundation', price: 150, category: 'Makeup', stock: 80, imageUrl: 'https://images.unsplash.com/photo-1522335789203-aabd1fc54bc9' },
    { id: 9, name: 'Eyeliner', price: 70, category: 'Makeup', stock: 120, imageUrl: 'https://images.unsplash.com/photo-1522335789203-aabd1fc54bc9' },
    { id: 10, name: 'Mascara', price: 80, category: 'Makeup', stock: 110, imageUrl: 'https://images.unsplash.com/photo-1522335789203-aabd1fc54bc9' },
    { id: 11, name: 'Blush', price: 65, category: 'Makeup', stock: 90, imageUrl: 'https://images.unsplash.com/photo-1522335789203-aabd1fc54bc9' },
    { id: 12, name: 'Compact Powder', price: 95, category: 'Makeup', stock: 85, imageUrl: 'https://images.unsplash.com/photo-1522335789203-aabd1fc54bc9' },
    { id: 13, name: 'Concealer', price: 85, category: 'Makeup', stock: 95, imageUrl: 'https://images.unsplash.com/photo-1522335789203-aabd1fc54bc9' },
  
    // Phones
    { id: 14, name: 'iPhone 14', price: 1200, category: 'Phones', stock: 15, imageUrl: 'https://images.unsplash.com/photo-1511707171634-5f897ff02aa9' },
    { id: 15, name: 'Samsung Galaxy S23', price: 1100, category: 'Phones', stock: 10, imageUrl: 'https://images.unsplash.com/photo-1511707171634-5f897ff02aa9' },
    { id: 16, name: 'Google Pixel 8', price: 950, category: 'Phones', stock: 12, imageUrl: 'https://images.unsplash.com/photo-1511707171634-5f897ff02aa9' },
    { id: 17, name: 'OnePlus 11', price: 850, category: 'Phones', stock: 18, imageUrl: 'https://images.unsplash.com/photo-1511707171634-5f897ff02aa9' },
    { id: 18, name: 'Sony Xperia 5 V', price: 900, category: 'Phones', stock: 8, imageUrl: 'https://images.unsplash.com/photo-1511707171634-5f897ff02aa9' },
    { id: 19, name: 'Motorola Edge 40', price: 780, category: 'Phones', stock: 20, imageUrl: 'https://images.unsplash.com/photo-1511707171634-5f897ff02aa9' },
    { id: 20, name: 'Huawei P60 Pro', price: 820, category: 'Phones', stock: 14, imageUrl: 'https://images.unsplash.com/photo-1511707171634-5f897ff02aa9' }
  ];
  
  

  filteredProducts: Iproduct[] = this.products;

  onCategorySelected(category: string): void {
    if (category === 'All') {
      this.filteredProducts = this.products;
    } else {
      this.filteredProducts = this.products.filter(product => product.category === category);
    }
  }
}
