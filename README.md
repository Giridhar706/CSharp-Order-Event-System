# CSharp-Order-Event-System

## 📌 Problem Statement

Design a simple Order Processing System using C# that demonstrates the use of **Delegates and Events**.

The system should:

* Take order details from the user
* Process the order
* Trigger multiple services like:

  * Email notification
  * SMS notification
  * Logging

---

## ⚙️ Concepts Used

* Delegates
* Events
* Classes & Objects
* User Input (Console)
* Basic OOP

---

## 📂 Project Structure

* `Order.cs` → Stores order details
* `OrderProcessor.cs` → Handles order processing using events
* `EmailService.cs` → Sends email notification 
* `SMSService.cs` → Sends SMS notification 
* `LoggerService.cs` → Logs order details 
* `Program.cs` → Main execution file 

---

## 🔁 How It Works

1. User enters:

   * Order ID
   * Customer Name
   * Amount

2. Order object is created 

3. `OrderProcessor` triggers an event 

4. Multiple services respond:

   * Email sent
   * SMS sent
   * Order logged

---

## ▶️ How to Run

1. Open project in **Visual Studio**
2. Build the solution
3. Run the program
4. Enter inputs when prompted

---

## 💻 Sample Output

```
Enter Order ID: 101
Enter Customer Name: Akanksha
Enter Amount: 5000

Processing Order...

Email sent to Akanksha
SMS sent to Akanksha
Order logged successfully (ID: 101)
```

---

## ⚠️ Exception Handling

Basic input conversion is used:

* `Convert.ToInt32()`
* `Convert.ToDouble()`

(You can enhance by adding try-catch blocks)

---

## 🚀 Future Improvements

* Add exception handling
* Save orders to file/database
* Add multiple orders support
* GUI interface

---

## 📌 Author

Giridhar Gopal
