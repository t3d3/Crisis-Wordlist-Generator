# Crisis Wordlist Generator
Test on Debian and Kali Linux.

Crisis peut créer une liste de mots aléatoires ou une liste de charset personnalisées pour crunch wordlist generator sur la base de critères que vous spécifiez.

#Download 
Version for linux.
<pre>
git clone https://github.com/teeknofil/Crisis-Wordlist-Generator.git
</pre>

# Setup in linux 

<pre>
apt-get install mono-runtime
./configure
make
make install
</pre>

# Run
<pre>
crisis
</pre>
# Run without setup
<pre>
apt-get install mono-runtime
cd Crisis-Wordlist-Generator/Crisis/bin/Release/
chmod +x crisis.exe
./crisis.exe
</pre>

# Manual

<pre>

crisis -h
Crisis Wordlist Generator, by Teeknofil  version : 1.0.4
Thanks WarLocG for the debugging et fix bug
Trouble : http://www.kali-linux.fr/forum/index.php

Combination:                                                                  
   -e,                                                                        
   --enumeration      generates a character list without repetition           
   -r, --random       generate random character                               

Help:                                                                         
   -c, --charset      Displays the list of wordlist                           
   -h, --help         Shows this help text                                    

Options:                                                                      
   -f, --file         Specify the save file in the                            
                      output-dico folder on the desktop                       
   -i,                Interactive command in the                              
   --interactive      terminal with question and answer                       

Parameter:                                                                    
   -l, --lenght       Number of character or character group                  
   -w, --wordlist     Character of the wordlist,                              


Example:		
			crisis --charset
			crisis -l 15 -e -w hex-lower -f
			crisis -l 17 -r -w ualpha

</pre>

#Usage

<pre>
./crisis.exe -l 20 -r -w lalpha-numeric | aircrack-ng -w- -e SFR_XXXX output-01.cap 
Opening output-01.cap
Opening output-01.cap
Reading packets, please wait...

                                 Aircrack-ng 1.2 rc2


                   [00:11:20] 1268865 keys tested (1870.62 k/s)


                       Current passphrase: 3e4u74mem30uf1sso47p       


      Master Key     : DF 02 B4 54 4A A5 43 FE BC 5E 09 AB 3C B6 33 70 
                       7E 4A 78 50 4E AA B2 4B C2 C8 3A 1F 31 FC A6 5A 

      Transient Key  : EF AD 2F 48 64 03 60 73 3A 34 03 D9 D3 1D DD B5 
                       F3 F0 1C EF 7C 36 15 6B 57 4C 43 3B 64 40 30 F5 
                       9F 35 70 36 C8 6F E7 E7 71 BE 01 42 96 A0 90 33 
                       2B B9 CF 3B 1B B5 27 AA 75 14 D1 4E 09 70 EF F4 

      EAPOL HMAC     : A1 F8 50 CD C8 32 F6 6B C2 86 0B 58 40 B7 3D 24
</pre>
