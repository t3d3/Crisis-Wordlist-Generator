# Crisis Wordlist Generator
Tested on Windows, Debian and Kali Linux.

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
Crisis Wordlist Generator, by Teeknofil  version : 1.0.5
Thanks WarLocG for the debugging et fix bug
Trouble : http://www.kali-linux.fr/forum/index.php

Combination:                                                                  
   -a, --crunch       charset list customized to crunch wordlist generator
   -e,                                                                        
   --enumeration      generates a character list without repetition           
   -r, --random       generate random character                               

Help:                                                                         
   -c, --wordlist-help      Displays the list of wordlist                           
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

<h2>Pipe with Aircrack-ng</h2>

<pre>
./crisis.exe -l 20 -r -w lalpha-numeric | aircrack-ng -w- -e BOX__XXXX output-01.cap 
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

<h2>Pipe with genpmk</h2>

<pre>
crisis -l 20 -r -w lalpha | genpmk -f- -d wordlistBOX -s BOX_XXXX
genpmk 1.1 - WPA-PSK precomputation attack. <jwright@hasborg.com>
Using STDIN for words.
File wordlistSFR does not exist, creating.
key no. 1000: negdhirvdowoyodenjta
key no. 2000: pggcdhupteltboqnzvac
key no. 3000: sxtpwjrcegzmpskultzy
key no. 4000: gwifxtqfvvsttvuowmii
key no. 5000: xxmvqajwzjoyglotainh
key no. 6000: xefzswiqrzcqsbqncugu
key no. 7000: cmuxxhwtbyskclxzlbdq
key no. 8000: fhmegcamdtbwwbvfvdsj
key no. 9000: yeonrqsrvllbdfyvuuqc
key no. 10000: kgrzzjqshhbangsfqezm
^C
10470 passphrases tested in 26.96 seconds:  388.38 passphrases/second
</pre>

<h2>Pipe with cowpatty</h2>

<pre>
crisis -l 20 -r -w lalpha | cowpatty -f- -r output-01.cap -s BOX_XXXX
cowpatty 4.6 - WPA-PSK dictionary attack. <jwright@hasborg.com>

Collected all necessary data to mount crack against WPA2/PSK passphrase.
Starting dictionary attack.  Please be patient.
Using STDIN for words.
key no. 1000: dcqjjuxfzmugiubenvrw
key no. 2000: dgcuvpaltalrtqqffpum
key no. 3000: uvbjybtoygvezmysffbw
key no. 4000: yeuhlbqjvjkbtfgkeogm
key no. 5000: prubwsjmrhqsmpslcqhp
key no. 6000: pkpracuojhawqpetsuqi
^CUnable to identify the PSK from the dictionary file. Try expanding your
passphrase list, and double-check the SSID.  Sorry it didn't work out.

6739 passphrases tested in 16.27 seconds:  414.29 passphrases/second
</pre>


<h2>Charset list for crunch</h2>

<pre>
crisis -a -w sfr7 > charset.lst
crunch 20 20 -f charset.lst charset1 -i -s abcdefghijklmnopqrs7

</pre>
