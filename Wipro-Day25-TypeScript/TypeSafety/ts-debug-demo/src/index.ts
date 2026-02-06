// here we will have  simple typescript code to test the debugging capabilities of vscode for typescript
// we will define fwo simple functions and then we will set breakpoints and debug them in vscode
//function to Calculate total price of items in a shopping cart
 function calculateTotalPrice(items: Item[]): number {
    let total = 0;  
    for (const item of items) {
        total += item.price;
    }
    return total;
}
// Function checkout takes an array of items, where each item has a name and a price, and returns the total price of all items in the cart.
interface Item {
    name: string;
    price: number;
}
// Example usage:
const shoppingCart: Item[] = [
    { name: "Laptop", price: 999.99 },
    { name: "Headphones", price: 199.99 },
    { name: "Mouse", price: 49.99 }
];
const totalPrice = calculateTotalPrice(shoppingCart);
console.log("Total Price:", totalPrice);
// Checkout function to display the total price of items in the shopping cart
function checkout(items: Item[]): void {
    const total = calculateTotalPrice(items);
    console.log("Total Price at Checkout:", total);
}
checkout(shoppingCart);