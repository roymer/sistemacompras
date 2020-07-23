﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemacompra.modelo
{  
    public class Singleton
    {
        private static Singleton instance = null;
        public Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    }
    

    
}
