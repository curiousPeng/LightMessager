﻿using LightMessager.Model;
using System;

namespace ConsumerTest
{
    public class OrderHandler : BaseMessageHandler<OrderMessage>
    {
        // 指明该handler的逻辑处理是否是幂等的（虽然可能很麻烦，但还是强烈建议实现成幂等的）
        public override bool Idempotent { get => true; }

        protected override bool DoHandle(OrderMessage message)
        {
            // 不需要做任何try...catch处理，库外层已经处理过了
            Console.WriteLine("接收到消息: " + message + "，时间：" + DateTime.Now);
            return true;
        }
    }

    public class OrderHandler1 : BaseMessageHandler<OrderMessage>
    {
        // 指明该handler的逻辑处理是否是幂等的（虽然可能很麻烦，但还是强烈建议实现成幂等的）
        public override bool Idempotent { get => true; }

        protected override bool DoHandle(OrderMessage message)
        {
            // 不需要做任何try...catch处理，库外层已经处理过了
            Console.WriteLine("我是sub1, 接收到消息: " + message + "，时间：" + DateTime.Now);
            return true;
        }
    }

    public class OrderHandler2 : BaseMessageHandler<OrderMessage>
    {
        // 指明该handler的逻辑处理是否是幂等的（虽然可能很麻烦，但还是强烈建议实现成幂等的）
        public override bool Idempotent { get => true; }

        protected override bool DoHandle(OrderMessage message)
        {
            // 不需要做任何try...catch处理，库外层已经处理过了
            Console.WriteLine("我是sub2，接收到消息: " + message + "，时间：" + DateTime.Now);
            return true;
        }
    }
}
