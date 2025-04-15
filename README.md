# Car Registration Manager

The **Car Registration Manager** is a Windows Forms application designed to manage car registration plates. It allows users to add, edit, delete, search, and tag registration plates, as well as save and load data from text files. This project demonstrates proficiency in C# programming, Windows Forms development, and implementing common data management features.

---

## Features

- **Add Registration Plates**: Add new registration plates with validation to ensure proper format.
- **Edit Registration Plates**: Modify existing registration plates.
- **Delete Registration Plates**: Remove unwanted registration plates from the list.
- **Search Functionality**: Perform binary or linear searches to locate specific registration plates.
- **Tagging**: Mark registration plates with a `[TAGGED]` label for special identification.
- **Save and Load**: Save the list of registration plates to a file or load them from an existing file.
- **Reset**: Clear all data to start fresh.

---

## Screenshots

### 1. **Main Interface**
![Main Interface](https://i.imgur.com/kFgRDo2.png)

### 2. **Adding a Registration Plate**
![Adding a Registration Plate](https://i.imgur.com/PG80Hbq.png)

### 3. **Editing a Registration Plate**
![Editing a Registration Plate](https://i.imgur.com/zryieg3.png)

### 4. **Deleting a Registration Plate**
![Deleting a Registration Plate](https://i.imgur.com/4yoynan.png)

### 5. **Tagging a Registration Plate**
![Tagging a Registration Plate](https://i.imgur.com/BZsfvlO.png)

### 6. **Binary Search**
![Binary Search](https://i.imgur.com/mavVI4x.png)

### 7. **Linear Search**
![Linear Search](https://i.imgur.com/1rh4IRA.png)

### 8. **Saving Data**
![Saving Data](https://i.imgur.com/1q40o6w.png)

### 9. **Loading Data**
![Loading Data](https://i.imgur.com/H0hancr.png)

### 10. **Resetting the Form**
![Resetting the Form](https://i.imgur.com/oeYy5fJ.png)

---

## Code Overview

### 1. **Main Form (`Form1.cs`)**
The main form handles the user interface and interactions. Key methods include:
- `btnEnter_Click`: Adds a new registration plate.
- `btnEdit_Click`: Loads a selected plate for editing.
- `btnDelete_Click`: Deletes a selected plate.
- `btnBinarySearch_Click` and `btnLinearSearch_Click`: Perform searches using the [`SearchService`](CarRegoApp/Services/SearchService.cs).
- `btnTag_Click`: Toggles the `[TAGGED]` label for a selected plate.
- `btnOpen_Click` and `btnSave_Click`: Use the [`FileService`](CarRegoApp/Services/FileService.cs) to load and save data.

### 2. **Search Service (`SearchService.cs`)**
Implements binary and linear search algorithms for finding registration plates.

### 3. **File Service (`FileService.cs`)**
Handles file operations, including opening and saving registration plate data.

---

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Keanu191/CarRegoApp.git
   ```
2. Open the solution file `CarRegoApp.sln` in Visual Studio.
3. Build and run the project.

---

## Validation Rules

- Registration plates must follow the format: `1ABC-123`.
- Duplicate plates are not allowed.

---

## Technologies Used

- **C#**
- **Windows Forms**
- **.NET 8.0**

---

