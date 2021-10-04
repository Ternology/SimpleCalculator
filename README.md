# SimpleCalculator
C# .Net Windows Form Application Simple Calculator


# Simple Math Operations

```c#
using System;
using System.Windows.Forms;

double X; //First Number
double Y; //Second Number

double Result; // result Output

X = double.Parse( firstNumBOX.Text ); //Parse the String as Double for TextBox1
Y = double.Parse( secondNumBOX.Text ); //Parse the String as Double for TextBox2

Result = X + Y; //Math Operation, change the + to other basic Math Operations.

OutputBox.Text = Result.ToString(); // Print the Output.

/*Example e.g
5 + 5*/

/*OUTPUT
10*/
```
