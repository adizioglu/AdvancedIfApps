first_name = input("What is your first name: ").lower()
last_name = input("What is your last name: ").lower()

if first_name == "tim" and last_name == "corey":
    print("Hello Professor Corey")
elif first_name == "tim" or last_name == "corey":
    print("You have a great part in your name.")
else:
    print("Hello Student")

age = 73

if (40 <= age < 50) or (70 <= age < 80):
    print("You are in your 40's or 70's")

