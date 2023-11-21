// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NumberGenerator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Server {

  /// <summary>Holder for reflection information generated from NumberGenerator.proto</summary>
  public static partial class NumberGeneratorReflection {

    #region Descriptor
    /// <summary>File descriptor for NumberGenerator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NumberGeneratorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVOdW1iZXJHZW5lcmF0b3IucHJvdG8SD051bWJlckdlbmVyYXRvciI4ChFH",
            "ZW5lcmF0aW9uT3B0aW9ucxINCgVzdGFydBgBIAEoBRIUCgxkZWxheVNlY29u",
            "ZHMYAiABKAUiOwoPR2VuZXJhdGVkTnVtYmVyEg4KBm51bWJlchgBIAEoBRIY",
            "ChBnZW5lcmF0ZWRBdFRpY2tzGAIgASgDMmUKD051bWJlckdlbmVyYXRvchJS",
            "CghHZW5lcmF0ZRIiLk51bWJlckdlbmVyYXRvci5HZW5lcmF0aW9uT3B0aW9u",
            "cxogLk51bWJlckdlbmVyYXRvci5HZW5lcmF0ZWROdW1iZXIwAUIJqgIGU2Vy",
            "dmVyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Server.GenerationOptions), global::Server.GenerationOptions.Parser, new[]{ "Start", "DelaySeconds" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Server.GeneratedNumber), global::Server.GeneratedNumber.Parser, new[]{ "Number", "GeneratedAtTicks" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GenerationOptions : pb::IMessage<GenerationOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GenerationOptions> _parser = new pb::MessageParser<GenerationOptions>(() => new GenerationOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GenerationOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Server.NumberGeneratorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenerationOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenerationOptions(GenerationOptions other) : this() {
      start_ = other.start_;
      delaySeconds_ = other.delaySeconds_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenerationOptions Clone() {
      return new GenerationOptions(this);
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 1;
    private int start_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "delaySeconds" field.</summary>
    public const int DelaySecondsFieldNumber = 2;
    private int delaySeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int DelaySeconds {
      get { return delaySeconds_; }
      set {
        delaySeconds_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GenerationOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GenerationOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Start != other.Start) return false;
      if (DelaySeconds != other.DelaySeconds) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Start != 0) hash ^= Start.GetHashCode();
      if (DelaySeconds != 0) hash ^= DelaySeconds.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Start != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Start);
      }
      if (DelaySeconds != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(DelaySeconds);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Start != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Start);
      }
      if (DelaySeconds != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(DelaySeconds);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Start != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Start);
      }
      if (DelaySeconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DelaySeconds);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GenerationOptions other) {
      if (other == null) {
        return;
      }
      if (other.Start != 0) {
        Start = other.Start;
      }
      if (other.DelaySeconds != 0) {
        DelaySeconds = other.DelaySeconds;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Start = input.ReadInt32();
            break;
          }
          case 16: {
            DelaySeconds = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Start = input.ReadInt32();
            break;
          }
          case 16: {
            DelaySeconds = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GeneratedNumber : pb::IMessage<GeneratedNumber>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GeneratedNumber> _parser = new pb::MessageParser<GeneratedNumber>(() => new GeneratedNumber());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GeneratedNumber> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Server.NumberGeneratorReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GeneratedNumber() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GeneratedNumber(GeneratedNumber other) : this() {
      number_ = other.number_;
      generatedAtTicks_ = other.generatedAtTicks_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GeneratedNumber Clone() {
      return new GeneratedNumber(this);
    }

    /// <summary>Field number for the "number" field.</summary>
    public const int NumberFieldNumber = 1;
    private int number_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Number {
      get { return number_; }
      set {
        number_ = value;
      }
    }

    /// <summary>Field number for the "generatedAtTicks" field.</summary>
    public const int GeneratedAtTicksFieldNumber = 2;
    private long generatedAtTicks_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long GeneratedAtTicks {
      get { return generatedAtTicks_; }
      set {
        generatedAtTicks_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GeneratedNumber);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GeneratedNumber other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Number != other.Number) return false;
      if (GeneratedAtTicks != other.GeneratedAtTicks) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Number != 0) hash ^= Number.GetHashCode();
      if (GeneratedAtTicks != 0L) hash ^= GeneratedAtTicks.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Number != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Number);
      }
      if (GeneratedAtTicks != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(GeneratedAtTicks);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Number != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Number);
      }
      if (GeneratedAtTicks != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(GeneratedAtTicks);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Number != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Number);
      }
      if (GeneratedAtTicks != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(GeneratedAtTicks);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GeneratedNumber other) {
      if (other == null) {
        return;
      }
      if (other.Number != 0) {
        Number = other.Number;
      }
      if (other.GeneratedAtTicks != 0L) {
        GeneratedAtTicks = other.GeneratedAtTicks;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Number = input.ReadInt32();
            break;
          }
          case 16: {
            GeneratedAtTicks = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Number = input.ReadInt32();
            break;
          }
          case 16: {
            GeneratedAtTicks = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
