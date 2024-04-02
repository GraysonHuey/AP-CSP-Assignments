from time import sleep
import os

# Input all of the blank spaces
year = input('Input whole number: ')
adjective1 = input('Input adjective: ')
pluralNoun = input('Input plural noun: ')
weight = input('Input number (can have decimals): ')
chestContents = input('Input noun: ')
challengeAmount = input('Input whole number: ')
time = input('Input number (can have decimals): ')
adjective2 = input('Input adjective: ')
adjective3 = input('Input adjective: ')
noun = input('Input noun: ')
advice = input('Input whole number: ')

# Clears the console (to make it look better) and tells the user their mad lib is ready
os.system('clear')
sleep(1)
print('Here is your mad lib...')
sleep(1)
os.system('clear')

# Outputs the mad lib
print(f'In the year {year}, a group of {adjective1} {pluralNoun} embarked on a quest to find the hidden treasure chest containing {weight} pounds of {chestContents}. Along the way, they encountered {challengeAmount} challenges and traveled for {time} days through the {adjective2} wilderness. Their journey led them to a {adjective3} village where they met a wise old {noun} who shared {advice} pieces of valuable advice to use in their future adventures.')
