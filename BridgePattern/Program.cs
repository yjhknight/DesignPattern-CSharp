﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    /**
     概述:
        在软件系统中，某些类型由于自身的逻辑，它具有两个或多个维度的变化，那么如何应对这种“多维度的变化”？
        如何利用面向对象的技术来使得该类型能够轻松的沿着多个方向进行变化，而又不引入额外的复杂度？这就要使用Bridge模式。
    意图:
　　　  将抽象部分与实现部分分离，使它们都可以独立的变化。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            ab.SetImplementor(new ConcreteImplementorA());
            ab.Operation();

            ab.SetImplementor(new ConcreteImplementorB());
            ab.Operation();

            Console.ReadKey();
        }
    }
}
