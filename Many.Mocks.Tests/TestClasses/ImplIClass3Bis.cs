﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Many.Mocks.Tests.TestClasses
{
    public  class ImplIClass3Bis :IClass3
    {
        public static int ValidMocksInConstructor = 2;
        public static int NotValidMocksInConstructor = 0;
        public ImplIClass3Bis(IClass2 class1, IClass1 class2)
        { 
        }

        public bool Third(SealedClass sealedC)
        {
            throw new NotImplementedException();
        }
    }
}
