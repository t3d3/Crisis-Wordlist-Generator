using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crisis.Charset
{
    class Alpha_sv : Default
    {
        private static List<string> charsetSelecting;

        public List<string> Lalpha_svList(string charsetName)
        {

            if (charsetName == "sv-lalpha")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).ToList();               
            }
            else if (charsetName == "sv-lalpha-space")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Space).ToList();                
            }
            else if (charsetName == "sv-lalpha-numeric")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).ToList();                

            }
            else if (charsetName == "sv-lalpha-numeric-space")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Space).ToList();
                
            }
            else if (charsetName == "sv-lalpha-numeric-symbol14")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Symbols14).ToList();
                
            }
            else if (charsetName == "sv-lalpha-numeric-symbol14-space")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();
                
            }
            else if (charsetName == "sv-lalpha-numeric-all")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();
                
            }
            else if (charsetName == "sv-lalpha-numeric-all-space")
            {
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();                    
               
            }
            
            return charsetSelecting;
        }

        public  List<string> Ualpha_svList(string charsetName)
        {

            if (charsetName == "sv-ualpha")
            {
                //ualpha-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).ToList();
                           }
            else if (charsetName == "sv-ualpha-space")
            {
                //ualpha-space-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Space).ToList();
                
            }
            else if (charsetName == "sv-ualpha-numeric")
            {
                //ualpha-numeric-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-space")
            {
                //ualpha-numeric-space-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Space).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-symbol14")
            {
                //ualpha-numeric-symbol14-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-symbol14-space")
            {
                //ualpha-numeric-symbol14-space-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-all")
            {
                //ualpha-numeric-all-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();

            }
            else if (charsetName == "sv-ualpha-numeric-all-space")
            {
                //ualpha-numeric-all-space-sv
                charsetSelecting = Ualpha.Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();

            }
           
            return charsetSelecting;
        }



        public List<string> MixAlpha_svList(string charsetName)
        {

            if (charsetName == "sv-mixalpha")
            {
                //mixalpha-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).ToList();

            }
            else if (charsetName == "sv-mixalpha-space")
            {
                //mixalpha-space-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Space).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric")
            {
                // mixalpha-numeric-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).ToList();
            }
            else if (charsetName == "sv-mixalpha-numeric-space")
            {
                //mixalpha-numeric-space_sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Space).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric-symbol14")
            {
                //mixalpha-numeric-symbol14-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric-symbol14-space")
            {
                //mixalpha-numeric-symbol14-space-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Space).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric-all")
            {
                //mixalpha-numeric-all-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).ToList();

            }
            else if (charsetName == "sv-mixalpha-numeric-all-space")
            {
                //mixalpha-numeric-all-space-sv
                charsetSelecting = Lalpha.Concat(Lalpha_sv).Concat(Ualpha).Concat(Ualpha_sv).Concat(Numeric).Concat(Symbols14).Concat(Symbols_all).Concat(Space).ToList();

            }
            
            return charsetSelecting;

        }
    }
}
