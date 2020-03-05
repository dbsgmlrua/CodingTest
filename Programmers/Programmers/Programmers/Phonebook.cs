using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Phonebook
    {
        private static Phonebook m_instance;
        public static Phonebook Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Phonebook();
                }
                return m_instance;
            }
        }
        public bool solution(string[] phone_book)
        {
            Array.Sort(phone_book);
            for(int i=0;i< phone_book.Length - 1; i++)
            {
                if (phone_book[i+1].StartsWith(phone_book[i]))
                    return false;
            }
            return true;
        }
    }
}
