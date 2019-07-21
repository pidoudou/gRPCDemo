﻿using Grpc.Core;
using GRPCDemo;
using System;

namespace gRPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:9007", ChannelCredentials.Insecure);

            var client = new gRPC.gRPCClient(channel);
            var reply = client.SayHello(new HelloRequest { Name = "LineZero" });
            Console.WriteLine("来自：" + reply.Message);
            string user = "VinsonFan";
            var secondReply = client.SayHelloAgain(new HelloRequest { Name = user });
            Console.WriteLine("来自: " + secondReply.Message);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
