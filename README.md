# TTRPG Campaign Manager

> **Status: Under Active Development** 
> *Core CRUD infrastructure is established. Currently implementing relational database links between Towns, NPCs, Items, and interactive Map elements.*

A full-stack desktop web application built with C# and Entity Framework Core. Designed to streamline tabletop RPG campaign management through real-time state filtering, dynamic CRUD interfaces, modular Blazor components, and secure local data tracking.

<img width="1264" height="952" alt="dashboard" src="https://github.com/user-attachments/assets/91192162-1306-4226-84d0-1ab1b50028a1" />


## 🛠 Tech Stack

* **Frontend:** Blazor, HTML/CSS, Bootstrap 5
* **Backend:** C#, .NET 9.0
* **Database:** Entity Framework Core (EF Core)
* **Architecture:** Component-based UI, native OS integration

## 🚀 Technical Highlights

This application is built to handle complex, heavily relational tabletop data without sacrificing UI responsiveness. Key technical achievements include:

* **Dynamic Component Rendering:** Engineered "Two-Faced" Blazor forms that seamlessly adapt between `Create` and `Edit` states, drastically reducing code duplication. UI elements dynamically shift based on database Enums (e.g., conditionally rendering specific stat blocks if an item is a "Weapon" versus "Armor").
* **Native File Handling & Base64 Conversion:** Implemented C# native file pickers that allow users to upload local images, converting them into Base64 strings for secure, lightweight database storage without requiring an external asset server.
* **Complex Data Modeling:** Built an Entity Framework database schema capable of handling granular TTRPG mechanics, including custom currency conversion logic, automatic Rarity-based CSS styling, and boolean-triggered UI badges (e.g., Attunement/Magical toggles).
* **Application Lifecycle Management:** Configured custom window dimensions and minimum resolution boundaries to ensure a consistent, app-like desktop experience.

<img width="1264" height="952" alt="item-details" src="https://github.com/user-attachments/assets/e8e4450c-e403-471d-9f8e-64afc838c958" />


## 📋 Current Features

### 🗺️ Maps & Locations
* **Maps:** Full Create, Read, and Update functionality. Features custom image uploading and Grid Scale tracking.
* **Towns:** Initial infrastructure built. Currently engineering the ability to bind Map images to specific Town records and layer Points of Interest (POIs).

### ⚔️ Inventory & Items
* **Items:** Comprehensive Create and Read operations complete. Includes automated copper-to-platinum cost conversion and dynamic UI rendering based on Item Type. Update and Delete workflows are actively in development.

### 🐉 Entities (NPCs & Enemies)
* **Creatures:** Base creation forms and high-level Directory (Read) views established. In-depth read views and relational linking are in progress.

<img width="1920" height="1020" alt="map-upload" src="https://github.com/user-attachments/assets/061ef453-4fe6-4d1f-87c0-d1c581c810c6" />


## 💻 Running Locally

To run this project locally on your machine:

1. Clone the repository: `git clone https://github.com/ryansitner/TTRPG-Campaign-Manager.git`
2. Open the solution (`.sln`) in Visual Studio.
3. Open the Package Manager Console and run `Update-Database` to build the local EF Core schema.
4. Press `F5` to run the application.
