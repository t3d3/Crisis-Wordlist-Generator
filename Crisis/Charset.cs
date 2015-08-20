using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace crisis
{
    public class Charset 
    {
        private List<string> charsetSelecting = new List<string>();
        

        public List<string> CharsetSelecting
        {
            get { return charsetSelecting; }
            set { charsetSelecting = value; }
        }

        private List<string> space       = new List <string> () {" "};
        private List<string> numeric     = new List <string> () {"0","1","2","3","4","5","6","7","8","9"};
        private List<string> hex_lower   = new List <string> () {"a","b","c","d","e","f"};
        private List<string> hex_upper   = new List <string> () {"A","B","C","D","E","F"};
        private List<string> symbols14   = new List <string> () {"!","@","#","$","%","^","&","*","(",")","-","_","="};
        private List<string> symbols_all = new List <string> () {"~", "`", "[", "]", "{", "}", "|", "\\", ":", ";", "\"", "<", ">", ",", ".", "?", "/"};
        private List<string> ualpha      = new List <string> () {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        private List<string> lalpha      = new List <string> () {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};       
        private List<string> ualpha_sv   = new List <string> () {"Å", "Ä", "Ö"};
        private List<string> lalpha_sv   = new List <string> () {"å","ä","ö"};        


        private string charsetName;

        public string CharsetName
        {
            get
            {
                return charsetName;
            }
            set
            {
                charsetName = value;
            }
        }

        private bool booleanType = true;

        public bool BooleanType
        {
            get
            {
                return booleanType;
            }
            set
            {
                booleanType = value;
            }
        }

        internal Regex noLetters = new Regex("^[a-zA-Z]$");

        public Charset()
        {

        }

        public List <string> Hexa()
        {            
            if (charsetName == "hex-lower")
            {
                //hex-lower
                charsetSelecting = numeric.Concat(hex_lower).ToList();
                booleanType = false;
            }
            else if (charsetName  == "hex-upper" )
            {
                //hex-upper 
                charsetSelecting = numeric.Concat(hex_upper).ToList();                    
                booleanType = false;
            }

                return charsetSelecting;
        }
        
        public List<string> Numeric()
        {
            if (charsetName == "numeric")
            {
                //numeric
                charsetSelecting = numeric;                    
                booleanType = false;
            }
            else if (charsetName == "numeric-space")
            {
                //numeric-space
                CharsetSelecting = numeric.Concat(space).ToList();                    
                booleanType = false;
            }           

            return charsetSelecting;
        }

        public List<string> Symbols()
        {

            if (charsetName == "symbols14")
                {
                    //symbols14  
                    charsetSelecting = symbols14;                    
                    booleanType = false;

                }
                else if (charsetName == "symbols14-space")
                {
                    //symbols14-space
                    charsetSelecting = symbols14.Concat(space).ToList();                    
                    booleanType = false;
                }
                else if (charsetName == "symbols-all")
                {
                    //symbols-all
                    charsetSelecting = symbols14.Concat(symbols_all).ToList();                    
                    booleanType = false;
                }
                else if (charsetName == "symbols-all-space")
                {
                    //symbols-all-space
                    charsetSelecting = symbols14.Concat(symbols_all).Concat(space).ToList();                    
                    booleanType = false;
                }

            return charsetSelecting;
        }

        public List<string> Ualpha()
        {
            if (charsetName == "ualpha")
            {
                //ualpha
                charsetSelecting = ualpha;                    
                booleanType = false;
            }
            else if (charsetName == "ualpha-space" )
            {
                //ualpha-space
                charsetSelecting = ualpha.Concat(space).ToList();                    
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric")
            {
                //ualpha-numeric
                charsetSelecting = ualpha.Concat(numeric).ToList();                    
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric-space")
            {
                //ualpha_numeric_space
                charsetSelecting = ualpha.Concat(numeric).Concat(space).ToList(); 
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric-symbol14")
            {
                // ualpha_numeric_symbol14
                charsetSelecting = ualpha.Concat(numeric).Concat(symbols14).ToList();
                booleanType = false;
            }
            else if (charsetName == "ualpha_numeric-symbol14-space")
            {
                //ualpha_numeric-symbol14-space
                charsetSelecting = ualpha.Concat(numeric).Concat(symbols14).Concat(space).ToList(); 
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric-all")
            {
                //ualpha-numeric-all
                charsetSelecting = ualpha.Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "ualpha-numeric-all-space" )
            {
                //ualpha-numeric-all-space
                charsetSelecting = ualpha.Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList(); 
                booleanType = false;
            }

            return charsetSelecting;
        }

        public List<string> Lalpha()
        {
            if (charsetName == "lalpha")
            {
                //lalpha
                charsetSelecting = lalpha;
                booleanType = false;
            }
            else if (charsetName == "lalpha-space")
            {
                // lalpha_space
                charsetSelecting = lalpha.Concat(space).ToList(); 
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric")
            {
                // lalpha-numeric
                charsetSelecting = lalpha.Concat(numeric).ToList();                    
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-space")
            {
                // lalpha-numeric-space
                charsetSelecting = lalpha.Concat(numeric).Concat(space).ToList();                    
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-symbol14")
            {
                //lalpha-numeric-symbol14
                charsetSelecting = lalpha.Concat(numeric).Concat(symbols14).ToList(); 
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-symbol14-space")
            {
                // lalpha-numeric-symbol14-space
                charsetSelecting = lalpha.Concat(numeric).Concat(symbols14).Concat(space).ToList();                     
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-all")
            {
                //lalpha-numeric-all
                charsetSelecting = lalpha.Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                booleanType = false;
            }
            else if (charsetName == "lalpha-numeric-all-space")
            {
                //lalpha-numeric-all-space
                charsetSelecting = lalpha.Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();                    
                booleanType = false;
            }

            return charsetSelecting;
        }

        public List<string> MixAlpha()
        {


            if (charsetName == "mixalpha")
                {
                    //mixalpha
                    charsetSelecting = lalpha.Concat(ualpha).ToList();
                    booleanType = false;
                }
                else if (charsetName == "mixalpha-space")
                {
                    //mixalpha-space
                    charsetSelecting = lalpha.Concat(ualpha).Concat(space).ToList();
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric")
                {
                    //mixalpha-numeric
                    charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).ToList();
                    booleanType = false;

                }
                else if (charsetName == "mixalpha_numeric_space")
                {
                    //mixalpha-numeric-space
                    charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(space).ToList();
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric-symbol14")
                {
                    //mixalpha-numeric-symbol14
                    charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(symbols14).ToList();
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric-symbol14-space")
                {
                    //mixalpha-numeric-symbol14-space
                    charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric-all")
                {
                    // mixalpha-numeric-all
                    charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();                    
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric-all-space")
                {
                    // mixalpha-numeric-all-space
                    charsetSelecting = lalpha.Concat(ualpha).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                    booleanType = false;

                }


            return charsetSelecting;
        }

        public List<string> Ualpha_sv()
        {
           
            if (charsetName == "ualpha-sv")
                {
                    //ualpha-sv
                    charsetSelecting = ualpha.Concat(ualpha_sv).ToList();
                    booleanType = false;
                }
                else if (charsetName == "ualpha-space-sv")
                {
                    //ualpha-space-sv
                    charsetSelecting = ualpha.Concat(ualpha_sv).Concat(space).ToList();
                    booleanType = false;

                }
                else if (charsetName == "ualpha-numeric-sv")
                {
                    //ualpha-numeric-sv
                    charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).ToList();
                    booleanType = false;

                }
                else if (charsetName == "ualpha-numeric-space-sv")
                {
                    //ualpha-numeric-space-sv
                    charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(space).ToList();
                    booleanType = false;

                }
                else if (charsetName == "ualpha-numeric-symbol14-sv")
                {
                    //ualpha-numeric-symbol14-sv
                    charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(symbols14).ToList();
                    booleanType = false;

                }
                else if (charsetName == "ualpha-numeric-symbol14-space-sv")
                {
                    //ualpha-numeric-symbol14-space-sv
                    charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(space).ToList();                    
                    booleanType = false;

                }
                else if (charsetName == "ualpha-numeric-all-sv")
                {
                    //ualpha-numeric-all-sv
                    charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                    booleanType = false;

                }
                else if (charsetName == "ualpha-numeric-all-space-sv")
                {
                    //ualpha-numeric-all-space-sv
                    charsetSelecting = ualpha.Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                    booleanType = false;

                }
            return charsetSelecting;
        }

        public List<string> Lalpha_sv()
        {

            if (charsetName == "lalpha-sv")
                {
                    //lalpha-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).ToList();                    
                    booleanType = false;

                }
                else if (charsetName == "lalpha-space-sv")
                {
                    //lalpha-space-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(space).ToList();
                    booleanType = false;
                }
                else if (charsetName == "lalpha-numeric-své")
                {
                    //lalpha-numeric-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).ToList();
                    booleanType = false;

                }
                else if (charsetName == "lalpha-numeric-space-sv")
                {
                    //lalpha-numeric-space-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(space).ToList();
                    booleanType = false;

                }
                else if (charsetName == "lalpha-numeric-symbol14")
                {

                    //lalpha-numeric-symbol14
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(symbols14).ToList();
                    booleanType = false;

                }
                else if (charsetName == "lalpha-numeric-symbol14-space-sv")
                {

                    // lalpha-numeric-symbol14-space-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                    booleanType = false;

                }
                else if (charsetName == "lalpha-numeric-all-sv")
                {
                    // lalpha-numeric-all-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                    booleanType = false;

                }
                else if (charsetName == "lalpha-numeric-all-space-sv")
                {
                    //lalpha-numeric-all-space-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();                    //charsetSelecting.Add("a"); charsetSelecting.Add("b"); charsetSelecting.Add("c"); charsetSelecting.Add("d"); charsetSelecting.Add("e"); charsetSelecting.Add("f"); charsetSelecting.Add("g"); charsetSelecting.Add("h"); charsetSelecting.Add("i"); charsetSelecting.Add("j"); charsetSelecting.Add("k"); charsetSelecting.Add("l"); charsetSelecting.Add("m"); charsetSelecting.Add("n"); charsetSelecting.Add("o"); charsetSelecting.Add("p"); charsetSelecting.Add("q"); charsetSelecting.Add("r"); charsetSelecting.Add("s"); charsetSelecting.Add("t"); charsetSelecting.Add("u"); charsetSelecting.Add("v"); charsetSelecting.Add("w"); charsetSelecting.Add("x"); charsetSelecting.Add("y"); charsetSelecting.Add("z"); charsetSelecting.Add("å"); charsetSelecting.Add("ä"); charsetSelecting.Add("ö"); charsetSelecting.Add("0"); charsetSelecting.Add("1"); charsetSelecting.Add("2"); charsetSelecting.Add("3"); charsetSelecting.Add("4"); charsetSelecting.Add("5"); charsetSelecting.Add("6"); charsetSelecting.Add("7"); charsetSelecting.Add("8"); charsetSelecting.Add("9"); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("!"); charsetSelecting.Add("@"); charsetSelecting.Add("#"); charsetSelecting.Add("$"); charsetSelecting.Add("%"); charsetSelecting.Add("^"); charsetSelecting.Add("&"); charsetSelecting.Add("*"); charsetSelecting.Add("("); charsetSelecting.Add(")"); charsetSelecting.Add("-"); charsetSelecting.Add("_"); charsetSelecting.Add("+"); charsetSelecting.Add("="); charsetSelecting.Add("~"); charsetSelecting.Add("`"); charsetSelecting.Add("["); charsetSelecting.Add("]"); charsetSelecting.Add("{"); charsetSelecting.Add("}"); charsetSelecting.Add("|"); charsetSelecting.Add("\\"); charsetSelecting.Add(":"); charsetSelecting.Add(";"); charsetSelecting.Add("\""); charsetSelecting.Add("'"); charsetSelecting.Add("<"); charsetSelecting.Add(">"); charsetSelecting.Add(","); charsetSelecting.Add("."); charsetSelecting.Add("?"); charsetSelecting.Add("/"); charsetSelecting.Add(" ");
                    booleanType = false;

                }

            return charsetSelecting;
        }

        public List<string> MixAlpha_sv()
        {

           if (charsetName == "mixalpha-sv")
                {
                    //mixalpha-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).ToList();                    
                    booleanType = false;
                }
                else if (charsetName == "mixalpha-space-sv")
                {
                    //mixalpha-space-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(space).ToList();
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric-sv")
                {
                    // mixalpha-numeric-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).ToList();                    
                    booleanType = false;
                }
                else if (charsetName == "mixalpha-numeric-space_sv")
                {
                    //mixalpha-numeric-space_sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(space).ToList();                    
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric-symbol14-sv")
                {
                    //mixalpha-numeric-symbol14-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(symbols14).ToList();                    
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric-symbol14-space-sv")
                {
                    //mixalpha-numeric-symbol14-space-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(space).ToList();
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric-all-sv")
                {
                    //mixalpha-numeric-all-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).ToList();
                    booleanType = false;

                }
                else if (charsetName == "mixalpha-numeric-all-space-sv")
                {
                    //mixalpha-numeric-all-space-sv
                    charsetSelecting = lalpha.Concat(lalpha_sv).Concat(ualpha).Concat(ualpha_sv).Concat(numeric).Concat(symbols14).Concat(symbols_all).Concat(space).ToList();
                    booleanType = false;

                }
            return charsetSelecting;

        }    


    } // End Class
} // End name space

