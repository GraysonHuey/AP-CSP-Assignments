import os

# Removes the vowels of a given string
def remVowels(str):
    vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']
    result = ''
    for char in str:
        if char not in vowels:
            result += char
    return result

def capEveryOther(list):
    result = []
    for i in range(len(list)):
        if i % 2 == 0:
            result.append(list[i].upper())
        else:
            result.append(list[i].lower())
    return result

def main():
    os.system('clear')
    site = input('Input site name: ')
    siteLength = len(site)

    # Gets the first two characters of the site name
    abbrSite = site[0] + site[1]

    # Capitalizes the abbreviated site name
    abbrSite = abbrSite.upper()

    usage = input(
        'Input site usage (Read books, watch videos, talk to friends, etc.): ')
    usageList = usage.lower().split()
    usageDict = []
    try:
        for word in usageList:
            # Remove filler words
            if word != 'to' and word != 'the' and word != 'a' and word != 'an' and word != 'and' and word != 'the':
                usageDict.append(word)
        abbrUsage = usageDict[0]
        abbrSubject = remVowels(usageDict[1].upper())
    except IndexError:
        print('Index error. Please try again.')
        exit()

    password = f'{abbrSite} {siteLength} {abbrUsage} {abbrSubject} '

    # Adds ? in between each password element if it is less than 14 characters in length
    # Otherwise, adds # in between each password element if it is greater than 14 characters in length
    if len(password.replace(' ', '')) < 14:
        finalPassword = password.replace(' ', '?')
    elif len(password.replace(' ', '')) >= 14:
        finalPassword = password.replace(' ', '#')

    # Puts all of the password elements together
    print('\n-------------------------------\n')
    print(f'Your password for {site} is: \"{finalPassword}\"')
    print(f'Password length: {len(finalPassword)}\n\n\n')

main()
