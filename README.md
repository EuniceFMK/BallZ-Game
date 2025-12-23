# BallZ Game

**BallZ Game** is a small game developed in **C#** using **Visual Studio**, featuring **Modal** and **Modeless Dialogs** to control the game and display information.  
This project was created to practice object-oriented programming, game logic, and GDI-based graphics rendering.

---

## Game Overview

- When the game opens, a **modal dialog** prompts the user to **show the score** or adjust the **animation speed**.  
- Clicking **Play** opens the main interface (**GDI Drawer**) with the balls displayed.  
- You can click on a ball to **remove adjacent balls of the same color**, and balls above will fall down.  
- The **score updates automatically** with each action.  
- The **animation speed** can be adjusted in real-time using a **modeless dialog** with a scrollbar.

![Game Screenshot](Screenshots/gamecapture.png)

## Key Features

- Handling of **modal and modeless dialogs**  
- Graphical interface using **GDI Drawer**  
- Removal of groups of balls with the same color  
- Dynamic **score updating**  
- Real-time control of **animation speed** via scrollbar  

## Prerequisites

- **Visual Studio 2022** or later  
- **.NET Framework** compatible with the project  

## How to Run

1. Clone the repo:  
   ```bash
   git clone https://github.com/EuniceFMK/BallZ-Game.git
2. Open the solution in visual Studio
3. Press F5 or click Start in Visual Studio to launch the game.  
