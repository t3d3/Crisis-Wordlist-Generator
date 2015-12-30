using System;

namespace crisis
{
    public class Tools
    {
        public Tools()
        {
        }
        
        internal void StartblockPattern(string _s)
        {
            for (int i = 0; i < _s.Length; i++)
            {
                Charset.CharsetSelecting[i] = _s[i].ToString();               
            }        
        }
        
        internal void EndPattern(string _e)
        {
            for (int i = 0; i < _e.Length; i++)
            {
                Charset.CharsetSelecting[ (Charset.CharsetSelecting.Count - _e.Length) + i ] = _e[i].ToString();
            } 
        }
        
    }
}

