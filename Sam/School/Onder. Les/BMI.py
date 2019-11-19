#BMI Uitrekenen

print("Bereken jouw BMI")
print()
geslacht = input("Wat is je geslacht? (M/V)")
lengte = float(input("Wat is je lengte? (in m)"))
gewicht = float(input("Wat is je gewicht? (in kg)"))
    
if geslacht == "V":
    lengte = lengte - 0.06
elif geslacht == "v":
    lengte = lengte - 0.06

print()
print("Je BMI is ", round(gewicht / (lengte * lengte), 2))


if round(gewicht / (lengte * lengte), 2) < 18 :
    print("Je hebt ondergewicht :(")
elif round(gewicht / (lengte * lengte), 2) > 25 :
    print("Je hebt overgewicht :(")
elif round(gewicht / (lengte * lengte), 2) >= 18 :
    print("Je hebt een gezond gewicht :)")


