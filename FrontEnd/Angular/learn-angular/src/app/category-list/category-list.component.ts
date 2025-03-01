import { Icategory } from './../../core/interfaces/icategory';
import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-category-list',
  imports: [],
  templateUrl: './category-list.component.html',
  styleUrl: './category-list.component.css'
})

export class CategoryListComponent {
  categories: Icategory[] = [
    { id: 1, name: 'All' },
    { id: 2, name: 'Books' },
    { id: 3, name: 'Makeup' },
    { id: 4, name: 'Phones' },
  ];

  @Output() categorySelected = new EventEmitter<string>();

  selectCategory(category: Icategory): void {
    this.categorySelected.emit(category.name);
  }
}
