open System

printf "What is your first name: "
let firstName = Console.ReadLine().ToLower()

printf "What is your last name: "
let lastName = Console.ReadLine().ToLower()

if firstName = "tim" && lastName = "corey" then
    printfn "Hello Professor Corey"
elif firstName = "tim" || lastName = "corey" then
    printfn "You have a great part in your name."
else
    printfn "Hello Student"

let age = 73

if (age >= 40 && age < 50) || (age >= 70 && age < 80) then
    printfn "You are in your 40's or 70's"
