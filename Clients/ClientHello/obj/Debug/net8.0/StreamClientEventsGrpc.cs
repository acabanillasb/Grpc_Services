// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StreamClientEvents.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Server {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class StreamClientEvents
  {
    static readonly string __ServiceName = "streamClientEvents.StreamClientEvents";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Server.StreamClientRequest> __Marshaller_streamClientEvents_StreamClientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.StreamClientRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Server.StreamClientResponse> __Marshaller_streamClientEvents_StreamClientResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Server.StreamClientResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Server.StreamClientRequest, global::Server.StreamClientResponse> __Method_MetodoStreamCliente = new grpc::Method<global::Server.StreamClientRequest, global::Server.StreamClientResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "MetodoStreamCliente",
        __Marshaller_streamClientEvents_StreamClientRequest,
        __Marshaller_streamClientEvents_StreamClientResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Server.StreamClientEventsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for StreamClientEvents</summary>
    public partial class StreamClientEventsClient : grpc::ClientBase<StreamClientEventsClient>
    {
      /// <summary>Creates a new client for StreamClientEvents</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public StreamClientEventsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StreamClientEvents that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public StreamClientEventsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected StreamClientEventsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected StreamClientEventsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Server.StreamClientRequest, global::Server.StreamClientResponse> MetodoStreamCliente(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MetodoStreamCliente(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Server.StreamClientRequest, global::Server.StreamClientResponse> MetodoStreamCliente(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_MetodoStreamCliente, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override StreamClientEventsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StreamClientEventsClient(configuration);
      }
    }

  }
}
#endregion
