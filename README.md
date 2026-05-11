# Unity Data-Oriented Design (DOD) Project
**Course:** Game Engine Development (DRG310)  
**Student ID:** 2024908099  
**Project Name:** DRG310-Assignment2

#Overview
This project demonstrates a shift from **Object-Oriented Programming (OOP)** to **Data-Oriented Design (DOD)** in Unity. The goal is to optimize performance by separating data (structs) from logic (systems) and handling large numbers of entities (100+ enemies) efficiently.

#Key Features
- **Separation of Concerns:** Data is stored in `structs` (`PlayerData`, `EnemyData`) for cache efficiency.
- **System-Based Logic:** Movement and Enemy updates are handled by pure C# classes, not `MonoBehaviour`.
- **Batch Processing:** A single `Update` loop manages 100+ enemies, reducing overhead.
- **Observer Pattern:** Decoupled communication using an `EventManager`.
- **Singleton Pattern:** Global access to game state via `GameManager`.

#Project Structure
```text
Assets/
 └── Scripts/
      ├── Data/      # Value types (Structs)
      ├── Systems/   # Pure logic (Movement, Enemy logic)
      ├── Managers/  # Unity bridges (GameManager, ScoreManager)
      └── Events/    # Event-driven communication
