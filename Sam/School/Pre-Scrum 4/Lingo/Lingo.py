#Lingo in Python
import time
from random import randint

leegwoord = "" #Leeg woord _ _ _ _ _ om te raden
pogingen = 4 #Aantal pogingen tot je verliest
numwords = 0 


with open('names.txt', 'r') as f:
    woorden = [line.strip() for line in f] #Convert de txt file met woorden onder elkaar naar een list
        
numwords = len(woorden) #tel het aantal woorden in de file

stage = 0 #Zorgt ervoor dat de speler opnieuw kan spelen zonder af te sluiten

#Kleuren
import os
os.system("cls")
class Kleuren:
    wit ="\033[0m"
    vet ="\033[1m"
    rood ="\033[91m"
    groen ="\033[32m"
    geel ="\033[33m"
    blauw ="\033[34m"
    violet ="\033[35m"
    lichtblauw ="\033[36m"
Kleur = Kleuren()

while stage == 0 :
    #Gek logo
    print(Kleur.geel)
    print("  _       _                         ")
    print(" | |     (_)  _ __     __ _    ___  ")
    print(" | |     | | | '_ \   / _` |  / _ \ ")
    print(" | |___  | | | | | | | (_| | | (_) |")
    print(" |_____| |_| |_| |_|  \__, |  \___/ ")
    print("                      |___/         ")
    print()

    #Welkom
    print(Kleur.groen + "Welkom bij Lingo!")
    print()
    print( "Er zijn " + str(numwords) + " woorden beschikbaar voor jou om te raden")

    #Naam vragen / Checken op lengte
    naam_check = True
    while naam_check == True :
        naam = input(Kleur.lichtblauw + "Wat is jouw naam? ")
        if len(naam) <= 2 :
            print(Kleur.rood + "Sorry, je naam moet langer zijn!" + Kleur.lichtblauw)
        elif len(naam) >= 15 :
            print(Kleur.rood + "Sorry, je naam mag niet langer dan 15 tekens zijn!" + Kleur.lichtblauw)
        else :
            print("Hallo", naam)
            naam_check = False
    print()

    #Uitleg
    Uitleg_check = 0
    while Uitleg_check == 0 :
        Uitleg_horen = input(Kleur.geel + "Wil je de uitleg horen? (Ja of Nee) ")
        if Uitleg_horen == 'Ja' or  Uitleg_horen == 'ja' :
            print(Kleur.groen + "In Lingo is het de bedoeling dat je woorden raadt!")
            time.sleep(1)
            print("Elk woord bestaat uit 5 letters")
            time.sleep(1)
            print("De eerste letter van het woord krijg je te zien")
            time.sleep(1)
            print()
            print("Nadat je hebt geraden krijg je te zien of een letter in het woord zit.")
            time.sleep(1)
            print("Ook krijg je te zien waar de letter in het woord zit.")
            print()
            time.sleep(1)
            print("Dan begint nu het spel!")
            Uitleg_check = 1
        elif Uitleg_horen == "Nee" or Uitleg_horen == "nee" :
            print("Oke, dan begint nu het spel!")
            Uitleg_check = 1
        else :
            print("Dat woord ken ik niet!")

    #Spel start
    kies_woord = randint(0, numwords) #Pakt een woord uit de 1279 woorden uit names.txt
    letterlijst = list(woorden[kies_woord]) #Zet letters in een lijst voor later gebruik
    print(Kleur.geel + "De eerste letter van het woord is:")
    print(Kleur.rood + woorden[kies_woord][0] + Kleur.geel)

    opnieuw = 0
    while not opnieuw == 4 :
        gok = input("Wat denk je dat het woord is? ")
        pogingen -= 1 #De gebruiker heeft een woord gegokt
        opnieuw += 1 #Uit de lus
        lettercheck = list(gok) #Zet letters in een lijst voor later gebruik

        if gok == woorden[kies_woord] :
            print("Je hebt het woord geraden!")
            print()
            niet_geraden = False
            goed_gok = True
            for char in woorden[kies_woord]:
                print(Kleur.rood + char, end='\n' + Kleur.geel)
                time.sleep(0.50)
            opnieuw = 4
        else :
            niet_geraden = True
            goed_gok = False
    

        if goed_gok == False :
            vergelijking = set(lettercheck) & set(letterlijst) #Haalt de correcte letters uit het gegokte woord
            letterserbij = ' '.join(vergelijking)
            print(gok,"was niet het juiste woord, maar de letters", letterserbij.strip('{\'}'), "kloppen wel. - Je mag nog",pogingen,"keer raden.")

            for letterserbij in woorden[kies_woord]:
                if letterserbij in vergelijking:
                    leegwoord += letterserbij
                else: leegwoord += " _ "
            print(leegwoord)
            stap1 = list(leegwoord)
            leegwoord = ""

            print()
            print(Kleur.groen + "Je hebt het woord niet geraden!" + Kleur.geel)
            print()

    print()
    
    stage_check = True
    while stage_check == True :
        stage = input("Wil je nog een keer spelen?")
        if stage == "ja" or stage == "ja" :
            stage = 0
            pogingen += 4
            stage_check = False
        elif stage == "Nee" or stage == "nee" :
            print("Dan stoppen we ermee!")
            stage = 1
            stage_check = False
            time.sleep(1)
            quit()
        else :
            print("Dat woord ken ik niet!")



input()