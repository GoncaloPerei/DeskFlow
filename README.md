# 🚀 DeskFlow - HelpDesk Desktop System

> **Practical Project for the Object-Oriented Programming II Course**  
> Bachelor's Degree in Computer Engineering | **ISTEC Porto** (Academic Year 2025/2026)  
> **Author:** Gonçalo Silva Pereira

---

## 📝 About DeskFlow
**DeskFlow** is a desktop HelpDesk and technical support system designed to optimize incident management, triage workflows, and communication between customers and technicians. Developed entirely in **C#** using **WPF (Windows Presentation Foundation)** and XAML, the system focuses on operator responsiveness and the rigorous application of **Object-Oriented Programming (OOP)** core principles.

---

## 🔍 Problem Description
Modern organizations face significant difficulties managing support requests through informal channels (emails, phone calls), resulting in:
* **Loss of traceability:** Pending incidents left without proper status control.
* **Lack of prioritization:** Critical incidents treated with the same urgency as simple inquiries.
* **Absence of history:** Difficulty linking incident history to a specific customer to identify recurring infrastructure or product failures.

**DeskFlow** resolves these gaps by centralizing the workflow through a modular architecture powered by reactive RAM state management.

---

## 🛠️ Tech Stack & Specifications
* **Language:** C# (C-Sharp)
* **UI Framework:** WPF (Windows Presentation Foundation) with XAML
* **Data Logic:** In-Memory State Management (`ObservableCollection<T>` and `List<T>`)
* **Queries:** LINQ (*Language Integrated Query*) expressions
* **Recommended IDE:** Visual Studio 2022 or higher

---

## 💎 OOP II Highlights (Applied Concepts)
To strictly meet academic software engineering requirements, the project showcases the implementation of:
1. **Inheritance and Specialization:** An abstract base class `Person` inherited by specialized entities `Customer` and `Technician`.
2. **Polimorphism:** The `ClosedBy` property (typed as `Person`) dynamically accepts either customer or technician objects upon ticket closure.
3. **Association and Composition:** Strict association between users and tickets, with a structured composition relationship handling the incremental `Intervention` history (cascade management).
4. **Clean Architecture (Helpers):** Complete decoupling of the presentation layer (Code-Behind) from data storage using static utility classes (*Helpers*).

---

## 📦 Main Features

### 👤 Customer Portal
* Ticket creation with custom **Title, Description, and Priority** (High, Medium, Low).
* Real-time monitoring of personal open ticket history.
* Technical interaction via message chat and support notes timeline.
* Autonomous ticket closure and profile data management.

### 🛠️ Technician Portal
* **Global Ticket Queue:** Live feed of pending tickets awaiting an assigned agent.
* **Ticket Assignment (Capture):** A double-click mechanism to easily assign tickets to the logged technician's workbench.
* Isolated "My Tickets" dashboard to track personal active workflow.
* Incremental logging of detailed technical interventions on the ticket's timeline.
* Final ticket resolution and closure with automatic auditing of the user who closed it.

---

## 📂 Documentation Structure (`/docs`)
Inside this repository's `/docs` folder, you can find the visual modeling artifacts that back the system architecture:
* 📊 **Class Diagram (UML):** Structural details of all properties, methods, strict encapsulation, and relationships.
* 🗺️ **Use Case Diagram:** Visual mapping of user permissions and interactions per actor.

---

## 🚀 How to Run the Project Locally

1. Ensure you have **Visual Studio 2022** installed with the `.NET Desktop Development` workload.
2. Clone this repository to your machine:
   ```bash
   git clone [https://github.com/your-username/DeskFlow.git](https://github.com/your-username/DeskFlow.git)