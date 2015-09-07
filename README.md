# Crisis-Wordlist-Generator
Test on Debian and Kali Linux.

Crisis peut créer une liste de mots aléatoires ou une liste de charset personnalisées pour crunch wordlist generator sur la base de critères que vous spécifiez.

#Download 
Version for linux.
<pre>
git clone https://github.com/teeknofil/Crisis-Wordlist-Generator.git
</pre>

# Setup in linux 
Test on Debian and Kali Linux
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
   -w, --wordlist     Character of the wordlist, type                         
                      wordlist-help for more info                             


Example:		crisis --charset
			crisis -l 15 -e -w hex-lower -f
			crisis -l 17 -r -w ualpha

</pre>
