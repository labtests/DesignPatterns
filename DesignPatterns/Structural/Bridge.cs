﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural
{
    #region The Implementation
    //helps in providing truely decoupled architecture
    public interface IBridge
    {
        void Function1();
        void Function2();
    }

    public class Bridge: IBridge
    {
        public void Function1()
        {
            throw new NotImplementedException();
        }

        public void Function2()
        {
            throw new NotImplementedException();
        }
    }

    public class Bridge2 : IBridge
    {
        public void Function1()
        {
            throw new NotImplementedException();
        }

        public void Function2()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
        
    #region Abstraction
    public interface IAbstractionBridge
    {
        void CallMethod1();
        void CallMethod2();
    }

    public class AbstractBridge : IAbstractionBridge
    {
        public IBridge bridge;

        public AbstractBridge(IBridge bridge)
        {
            this.bridge = bridge;
        }

        public void CallMethod1()
        {
            this.bridge.Function1();
        }

        public void CallMethod2()
        {
            this.bridge.Function2();
        }
    }
    #endregion
}
