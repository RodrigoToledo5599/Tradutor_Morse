using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tradutor_Morse
{
    public class CodificadorMorse
    {

        private Dictionary<char, string> TextToMorse = new Dictionary<char, string>
        {
            //Todas as opções de caracteres possíveis ================================================================================= 
            {' ',@"/ "},{',',"--..-- " },
            {'1',".---- "},{'2',"..--- "},{'3',"...-- "},{'4',"....- "},{'5',"..... "},{'6',"-.... "},{'7',"--... "},{'8',".---.. "},{'9',"----. "},{'0',"----- "},
            {'a',".- "},{'A',".- "},
            {'b',"-... "},{'B',"-... "},
            {'c',"-.-. "},{'C',"-.-. "},
            {'d',"-.. "},{'D',"-.. "},
            {'e',". "},{'E',". "},
            {'f',"..-. "},{'F',"..-. "},
            {'g',"--. "},{'G',"--. "},
            {'h',".... "},{'H',".... "},
            {'i',".. "},{'I',".. "},
            {'j',".--- "},{'J',".--- "},
            {'k',"-.- "},{'K',"-.- "},
            {'l',".-.. "},{'L',".-.. "},
            {'m',"-- "},{'M',"-- "},
            {'n',"-. "},{'N',"-. "},
            {'o',"--- "},{'O',"--- "},
            {'p',".--. "},{'P',".--. "},
            {'q',"--.- "},{'Q',"--.- "},
            {'r',".-. "},{'R',".-. "},
            {'s',"... "},{'S',"... "},
            {'t',"- "},{'T',"- "},
            {'u',"..- "},{'U',"..- "},
            {'v',"...- "},{'V',"...- "},
            {'w',".-- "},{'W',".-- "},
            {'x',"-..- "},{'X',"-..- "},
            {'y',"-.-- "},{'Y',"-.-- "},
            {'z',"--.. "},{'Z',"--.. "}
                //==================================================================================================
        };
        /*
        // NOT IMPLEMENTED YET
        private Dictionary<string, char> MorseToText = new Dictionary<string, char>
        {
            {@"/ ",' '},{"--..-- " , ',' },
            {".---- " , '1'},{"..--- " , '2'},{"...-- " , '3'},{"....- " , '4'},{"..... " , '5'},{"-.... " , '6'},{"--... " , '7'},{".---.. " , '8'},{"----. " , '9'},{"----- " , '0'},
            {".- " , 'a'},{".- " , 'A'},
            {"-... " , 'b'},{"-... " , 'B'},
            {"-.-. " , 'c'},{"-.-. " , 'C'},
            {"-.. " , 'd'},{"-.. " , 'D'},
            {". " , 'e'},{". " , 'E'},
            {"..-. " , 'f'},{"..-. " , 'F'},
            {"--. " , 'g'},{"--. " , 'G'},
            {".... " , 'h'},{".... " , 'H'},
            {".. " , 'i'},{".. " , 'I'},
            {".--- " , 'j'},{".--- " , 'J'},
            {"-.- " , 'k'},{"-.- " , 'K'},
            {".-.. " , 'l'},{".-.. " , 'L'},
            {"-- " , 'm'},{"-- " , 'M'},
            {"-. " , 'n'},{"-. " , 'N'},
            {"--- " , 'o'},{"--- " , 'O'},
            {".--. " , 'p'},{".--. " , 'P'},
            {"--.- " , 'q'},{"--.- " , 'Q'},
            {".-. " , 'r'},{".-. " , 'R'},
            {"... " , 's'},{"... " , 'S'},
            {"- " , 't'},{"- " , 'T'},
            {"..- " , 'u'},{"..- " , 'U'},
            {"...- " , 'v'},{"...- " , 'V'},
            {".-- " , 'w'},{".-- " , 'W'},
            {"-..- " , 'x'},{"-..- " , 'X'},
            {"-.-- " , 'y'},{"-.-- " , 'Y'},
            {"--.. " , 'z'},{"--.. " , 'Z'}
        };
        */
        public void textoParaMorse(string SuaFrase)
        { 
            int startingPoint=0;                                                                               
            int position;
            // Debugando o código para a possibilidade de caracteres que não estão dentre os listados no dicionario
            while(true)
            {
                for(position = startingPoint; position <= SuaFrase.Length - 1; position++)
                {
                    try 
                    {
                        Console.Write(TextToMorse[SuaFrase[position]]);
                    }
                    catch (System.Collections.Generic.KeyNotFoundException){}
                }

                startingPoint = position;

                if(startingPoint == SuaFrase.Length)
                {
                    break;
                }
            }  
        }

        // NOT IMPLEMENTED YET ()
        /*
        public void MorseParaText(string SuaFraseEmMorse)
        {
            int startingPoint = 0;
            int position;
            // Debugando o código para a possibilidade de caracteres que não estão dentre os listados no dicionario
            {
                while (true)
                {
                    for (position = startingPoint; position <= SuaFraseEmMorse.Length - 1; position++)
                    {
                        try
                        {
                            Console.Write(MorseToText[SuaFraseEmMorse[position]]);
                        }
                        catch (System.Collections.Generic.KeyNotFoundException) { }
                    }

                    startingPoint = position;

                    if (startingPoint == SuaFraseEmMorse.Length)
                    {
                        break;
                    }
                }  
            }
        }*/





    }
}