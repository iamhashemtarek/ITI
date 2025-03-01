import { Component, Input } from '@angular/core';
import { Iproduct } from '../../core/interfaces/iproduct';

@Component({
  selector: 'app-product-list',
  imports: [],
  templateUrl: './product-list.component.html',
  styleUrl: './product-list.component.css'
})
export class ProductListComponent {
  @Input() products: Iproduct[] = [];
}
