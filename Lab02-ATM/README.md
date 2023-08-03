Summary and Context:
This code is a simple ATM (Automated Teller Machine) program implemented in C#. It allows users to perform three main operations: view balance, withdraw funds, and deposit funds. The program provides a basic user interface through the console, making it easy to interact with the ATM functionalities.

Visuals:
Below are some visuals of how the program looks and works in action:

Welcome Screen:

Copy code
Hello World
Choose an option:
View Balance
Withdraw
Deposit
Exit
View Balance:

Copy code
Choose an option:
View Balance
Withdraw
Deposit
Exit
1
Current Balance: $0.00
Withdraw:

Copy code
Choose an option:
View Balance
Withdraw
Deposit
Exit
2
Enter the amount to withdraw:
50
Deposit:

Copy code
Choose an option:
View Balance
Withdraw
Deposit
Exit
3
Enter the amount to deposit:
100
Exit:

Copy code
Choose an option:
View Balance
Withdraw
Deposit
Exit
4
Thank You!

Step-by-Step Directions (Happy Path Walkthrough):
When you run the program, it will display the welcome message and the available options.

To view your current balance, enter "1" and press Enter. The program will display your balance.

To withdraw funds, enter "2" and press Enter. It will prompt you to enter the amount you want to withdraw. Type the amount and press Enter. The program will process the withdrawal and display the updated balance if successful. If the withdrawal amount exceeds your balance, it will show an error message.

To deposit funds, enter "3" and press Enter. It will prompt you to enter the amount you want to deposit. Type the amount and press Enter. The program will process the deposit and display the updated balance if successful. If you try to deposit a negative amount, it will show an error message.

To exit the program, enter "4" and press Enter. The program will display a farewell message and terminate.