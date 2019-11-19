Gebruiker aanmaken (zonder dit werkt de push enzo niet)
git config --global user.name "Naam + Achternaam"
git config --global user.email mail@example.com

Online git repository toevoegen aan een map (kies een map uit met de cd cmd)
git clone (link naar repository)

Verander locatie in git bash
cd documents/map1/map2

Bestandsaanpassingen doorgeven aan github
git add (.) of (file.txt)
git commit -m "Bericht of aanpassingen"
git push (kan alleen als je alle bovenstaande cmds zijn uitgevoerd)

Bestanden verwijderen
git rm file.txt

Status bekijken (Dit cmd vergelijkt je local repo met de online repo en geeft alle verschillen weer)
git status

Bestandsaanpassingen ontvangen van github
git pull