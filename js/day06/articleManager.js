class ArticleManager {
  constructor(articleText, { wordsPerLine = 12, linesPerPage = 20, paymentStructure = { 0: 0, 1: 30, 2: 60, 3: 100, 4: 100 } }) {
    if (typeof articleText !== 'string') {
      throw new Error('Invalid article text. Must be a string.');
    }
    this.articleText = articleText;
    this.wordsPerLine = wordsPerLine;
    this.linesPerPage = linesPerPage;
    this.paymentStructure = paymentStructure;
    this.pages = [];
    this.words = [];
  }

  splitIntoPages() {
    this.words = this.articleText.trim().split(/\s+/);
    const lines = [];
    for (let i = 0; i < this.words.length; i += this.wordsPerLine) {
      lines.push(this.words.slice(i, i + this.wordsPerLine).join(" "));
    }
    this.pages = [];
    for (let i = 0; i < lines.length; i += this.linesPerPage) {
      this.pages.push(lines.slice(i, i + this.linesPerPage).join("\n"));
    }
  }

  calculatePayment() {
    const totalPages = this.pages.length;
    if (totalPages < 1) return 0;

    // Modified payment calculation logic based on the specified structure
    if (totalPages === 1 || totalPages === 2) {
      return this.paymentStructure[1]; // Payment for 1-2 pages: $30
    } else if (totalPages === 3 || totalPages === 4) {
      return this.paymentStructure[2]; // Payment for 3-4 pages: $60
    } else {
      return this.paymentStructure[3]; // Payment for more than 4 pages: $100
    }
  }

  displayPages() {
    const payment = this.calculatePayment();
    console.log(`Total Pages: ${this.pages.length}`);
    console.log(`Paid Pages: ${this.pages.length}`);
    console.log(`Payment Due: $${payment}`);
    this.pages.forEach((page, index) => {
      console.log(`\nPage ${index + 1}:\n${page}\n`);
    });
  }

  processArticle() {
    this.splitIntoPages();
    this.displayPages();
  }
}

// Example
// Example usage
const articleText = `This is a test article to check the page splitting logic and payment calculation. The article has enough content to split across multiple pages, and we want to ensure the logic works correctly. This will check how many pages are generated and if the payment logic applies correctly.`; // Replace with actual article text
const options = {
  wordsPerLine: 12,
  linesPerPage: 20,
  paymentStructure: { 0: 0, 1: 30, 2: 60, 3: 100, 4: 120 } // Adjustable payment structure
};

const articleManager = new ArticleManager(articleText, options);
articleManager.processArticle();
