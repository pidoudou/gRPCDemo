# gRPCDemo
根据教程编写简单的gRPC实例代码

protoc buffer编译器自动生成服务端和客户端代码命令如下：

protoc.exe -I=. --csharp_out=. --grpc_out=. --plugin=protoc-gen-grpc=grpc_csharp_plugin.exe helloworld.proto

	1、-I=  --csharp_out=   --grpc_out=  ，后面需要添加对应.dll类库的地址（及IDL文件所在的位置）；

	2、--plugin=protoc-gen-grpc= ，调用C#插件；

	3、helloworld.proto，定义的IDL服务文件；

ps：
  
	1、protoc.exe和csharp_plugin.exe工具是在.dll类文件的NuGet中添加Grpc.Tools引用生成的文件包；
	 
	2、 无论是client、service还是.dll类库都需要在NuGet中添加Google.Protobuf和Grpc（其中有命名空间Grpc.Core）引用；
	
	
具体使用详见：https://www.cnblogs.com/linezero/p/grpc.html
	
	
