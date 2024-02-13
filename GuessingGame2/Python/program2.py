import random;
number = random.randint(1, 60);
Count = 5;

for i in range(Count):
    guess = int(input("Enter a Number: "))
    
    if guess == number:
        print("Correct Answer! " + str(number))
        break
    elif guess < number:
        print("Enter a Higher number!")
    elif guess > number:
        print("Enter a Lower number!")
        
    if i == Count - 1:
        print("You ran out of tries!\nCorrect Answer: " + str(number))
        break
