using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class DiskController
    {
        private static Competition m_instance;
        public static Competition Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Competition();
                }
                return m_instance;
            }
        }

    }
    public class DiskJobs
    {

    }
}
