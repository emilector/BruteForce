using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForce
{
    public class Logic
    {
        public Logic(string pass, bool numbersOnly)
        {
            m_pass = pass;

            if (numbersOnly)
                m_hackedPassword = hackNumbersOnly();
            else
                m_hackedPassword = hackBoth();
        }

        List<char> m_alphabet = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ä', 'ö', 'ü' };
        List<char> m_chars = new List<char> { '0', '0', '0', '0', '0' };

        public int m_counter = 0;
        public string m_hackedPassword = "ERROR";
        string m_pass;
        int m_charCounter = 0;
        string m_currentPassword = "";

        // Numbers only

        string hackNumbersOnly()
        {
            string currentPassword = "";
            int number = 0;

            while (!isCorrect(currentPassword))
            {
                currentPassword = number.ToString();
                number++;
            }

            m_counter = number;
            return currentPassword;
        }

        // Numbers + Letters

        private string hackBoth()
        {
            recurse();

            return m_currentPassword;
        }

        void recurse()
        {
            for (int i = 0; i < 39; i++)
            {
                m_chars[m_charCounter] = m_alphabet[i];

                m_currentPassword += m_chars[m_charCounter];

                m_counter++;

                // Break if correct

                if (isCorrect(m_currentPassword))
                    break;

                // Else next char or reset

                else
                {
                    m_charCounter++;

                    if(m_charCounter < 5)
                        recurse();
                    else
                    {
                        m_currentPassword = "";
                        m_charCounter = 0;
                    }
                }
            }
        }
        
        // Check password

        bool isCorrect(string input)
        {
            if (input == m_pass)
                return true;
            else
                return false;
        }
    }
}
