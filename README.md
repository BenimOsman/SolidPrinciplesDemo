📚 SOLID Principles Overview
1️⃣ Single Responsibility Principle (SRP)

Definition: A class should have only one reason to change.

🛠 Implementation:

Book class holds book data (e.g., title and author).

BookRepository handles book data storage and retrieval.

Student and Professor classes manage borrowing and/or reserving behavior.

EmailNotification is responsible solely for sending notifications.

Library depends on an abstraction (INotificationService) for notifications.

✅ Benefits:

Each class has a single focus.

Easier to maintain and test.

Improves code readability.

2️⃣ Open/Closed Principle (OCP)

Definition: Software entities should be open for extension, but closed for modification.

🛠 Implementation:

LibraryMember is an abstract class with the method BorrowLimit().

RegularMember and PremiumMember extend LibraryMember and override BorrowLimit().

✅ Benefits:

New member types can be added without changing existing code.

Encourages scalability and flexibility.

3️⃣ Liskov Substitution Principle (LSP)

Definition: Subtypes must be substitutable for their base types.

🛠 Implementation:

RegularMember and PremiumMember inherit from LibraryMember.

Can be used interchangeably wherever LibraryMember is expected.

✅ Benefits:

Promotes polymorphism.

Ensures consistency across subtypes.

4️⃣ Interface Segregation Principle (ISP)

Definition: No client should be forced to depend on interfaces it does not use.

🛠 Implementation:

IBorrowable interface handles borrowing functionality.

IReservable interface handles reservation functionality.

Student implements only IBorrowable.

Professor implements both IBorrowable and IReservable.

✅ Benefits:

Reduces unused dependencies.

Easier to implement and maintain.

5️⃣ Dependency Inversion Principle (DIP)

Definition: High-level modules should not depend on low-level modules. Both should depend on abstractions.

🛠 Implementation:

EmailNotification implements the INotificationService interface.

Library depends on the INotificationService abstraction instead of a concrete implementation.

✅ Benefits:

Loosely coupled components.

Enhances flexibility and testability.

🔧 Technologies Used

C# / .NET (assumed)

Object-Oriented Programming (OOP)

SOLID Design Principles
