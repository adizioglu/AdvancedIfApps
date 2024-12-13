#include <iostream>
#include <string>
#include <algorithm>

int main()
{
    std::cout << "What is your first name: ";
    std::string firstName;
    std::getline(std::cin, firstName);

    std::cout << "What is your last name: ";
    std::string lastName;
    std::getline(std::cin, lastName);

    // Convert to lowercase
    std::transform(firstName.begin(), firstName.end(), firstName.begin(), ::tolower);
    std::transform(lastName.begin(), lastName.end(), lastName.begin(), ::tolower);

    if (firstName == "tim" && lastName == "corey")
    {
        std::cout << "Hello Professor Corey" << std::endl;
    }
    else if (firstName == "tim" || lastName == "corey")
    {
        std::cout << "You have a great part in your name." << std::endl;
    }
    else
    {
        std::cout << "Hello Student" << std::endl;
    }

    int age = 73;

    if ((age >= 40 && age < 50) || (age >= 70 && age < 80))
    {
        std::cout << "You are in your 40's or 70's" << std::endl;
    }

    return 0;
}
