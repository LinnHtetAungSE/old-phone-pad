# Mobile Keypad Text Decoder with Overflow and Backspace Support

## Overview
This C# program simulates the functionality of old mobile phone keypads, where pressing a key multiple times cycles through different letters. The program also includes features such as backspace (to delete previous characters) and handles cases where the key press exceeds the expected length (overflow). The main function, `OldPhonePad`, decodes a sequence of keypad inputs into a human-readable text string.

## Features
- Simulates the multi-tap functionality of old mobile phone keypads.
- Supports the backspace key (`*`) to remove the last character entered.
- Ends input with the hash key (`#`), marking the end of input.
- Handles overflow situations where a key is pressed more than its maximum number of characters.
- Handles spaces in the input sequence.

## Functionality
Each number key on the mobile keypad corresponds to a series of letters, as shown in the table below:

| Key | Letters |
| --- | ------- |
| 2   | A, B, C |
| 3   | D, E, F |
| 4   | G, H, I |
| 5   | J, K, L |
| 6   | M, N, O |
| 7   | P, Q, R, S |
| 8   | T, U, V |
| 9   | W, X, Y, Z |
| 0   | (Space) |

Repeated presses of a key will cycle through the characters assigned to that key. If the input exceeds the maximum number of characters for a key (e.g., pressing `6` four times), the program will handle this overflow and return the correct corresponding letter. For example, pressing `6666#` will return `"M"`, cycling through `M`, `N`, `O`.

The backspace key (`*`) removes the last character entered, and the hash key (`#`) signifies the end of the input.

## Installation
1. Clone this repository:
    ```bash
    git clone https://github.com/yourusername/OldPhonePadCodeChallange.git
    ```
2. Open the project in your preferred C# development environment.
3. Compile and run the program.

## Usage
You can test the program by providing a sequence of keypresses as input. Example:

```csharp
string result = Program.OldPhonePad("4427 7999#");
Console.WriteLine(result);
```

## Output

```csharp
HAPPY
```

### Created by **_Linn Htet Aung_**  
[Visit author GitHub profile](https://github.com/LinnHtetAungSE)
