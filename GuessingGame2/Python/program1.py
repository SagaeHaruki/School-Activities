import random;

number = random.randint(1, 100);
Count = 5;

for i in range(Count):
    guess = int(input("Enter a Number: "))
    if guess < number:
        print("Higher!")
    elif guess > number:
        print("Lower!")
    else:
        print("Correct Answer! " + str(number))
        break
    if i == Count - 1:
        print("You ran out of tries!\nCorrect Answer: " + str(number))
        break
