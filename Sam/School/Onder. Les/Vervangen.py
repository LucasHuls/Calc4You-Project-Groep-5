#Metaaldraaibank vervangen

werkuren = input("Hoeveel uren heeft hij gewerkt? ")
oud = input("Hoeveel jaren heeft hij gewerkt? ")
storing = input("Hoeveel storingen heeft hij per jaar? ")

vervang = 0

if werkuren > str(10000) :
    vervang = vervang + 1
if oud > str(7) :
    vervang = vervang + 1
if storing > str(25) :
    vervang = vervang + 1

print()
if vervang >= 3 :
    print("Hij moet vervangt worden")
if vervang < 1:
    print("Hij hoeft niet vervangen te worden")


