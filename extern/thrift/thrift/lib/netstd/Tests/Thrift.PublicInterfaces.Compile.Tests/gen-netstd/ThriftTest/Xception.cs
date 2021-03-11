/**
 * Autogenerated by Thrift Compiler (0.14.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using System.ServiceModel;
using System.Runtime.Serialization;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling

namespace ThriftTest
{

public partial class Xception : TException, TBase
{
  private int _errorCode;
  private string _message;

  [DataMember(Order = 0)]
  public int ErrorCode
  {
    get
    {
      return _errorCode;
    }
    set
    {
      __isset.errorCode = true;
      this._errorCode = value;
    }
  }

  [DataMember(Order = 0)]
  public string Message
  {
    get
    {
      return _message;
    }
    set
    {
      __isset.message = true;
      this._message = value;
    }
  }


  [DataMember(Order = 1)]
  public Isset __isset;
  [DataContract]
  public struct Isset
  {
    [DataMember]
    public bool errorCode;
    [DataMember]
    public bool message;
  }

  #region XmlSerializer support

  public bool ShouldSerializeErrorCode()
  {
    return __isset.errorCode;
  }

  public bool ShouldSerializeMessage()
  {
    return __isset.message;
  }

  #endregion XmlSerializer support

  public Xception()
  {
  }

  public Xception DeepCopy()
  {
    var tmp63 = new Xception();
    if(__isset.errorCode)
    {
      tmp63.ErrorCode = this.ErrorCode;
    }
    tmp63.__isset.errorCode = this.__isset.errorCode;
    if((Message != null) && __isset.message)
    {
      tmp63.Message = this.Message;
    }
    tmp63.__isset.message = this.__isset.message;
    return tmp63;
  }

  public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      TField field;
      await iprot.ReadStructBeginAsync(cancellationToken);
      while (true)
      {
        field = await iprot.ReadFieldBeginAsync(cancellationToken);
        if (field.Type == TType.Stop)
        {
          break;
        }

        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32)
            {
              ErrorCode = await iprot.ReadI32Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.String)
            {
              Message = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          default: 
            await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            break;
        }

        await iprot.ReadFieldEndAsync(cancellationToken);
      }

      await iprot.ReadStructEndAsync(cancellationToken);
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
  {
    oprot.IncrementRecursionDepth();
    try
    {
      var struc = new TStruct("Xception");
      await oprot.WriteStructBeginAsync(struc, cancellationToken);
      var field = new TField();
      if(__isset.errorCode)
      {
        field.Name = "errorCode";
        field.Type = TType.I32;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(ErrorCode, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if((Message != null) && __isset.message)
      {
        field.Name = "message";
        field.Type = TType.String;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(Message, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      await oprot.WriteFieldStopAsync(cancellationToken);
      await oprot.WriteStructEndAsync(cancellationToken);
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override bool Equals(object that)
  {
    if (!(that is Xception other)) return false;
    if (ReferenceEquals(this, other)) return true;
    return ((__isset.errorCode == other.__isset.errorCode) && ((!__isset.errorCode) || (System.Object.Equals(ErrorCode, other.ErrorCode))))
      && ((__isset.message == other.__isset.message) && ((!__isset.message) || (System.Object.Equals(Message, other.Message))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      if(__isset.errorCode)
      {
        hashcode = (hashcode * 397) + ErrorCode.GetHashCode();
      }
      if((Message != null) && __isset.message)
      {
        hashcode = (hashcode * 397) + Message.GetHashCode();
      }
    }
    return hashcode;
  }

  public override string ToString()
  {
    var sb = new StringBuilder("Xception(");
    int tmp64 = 0;
    if(__isset.errorCode)
    {
      if(0 < tmp64++) { sb.Append(", "); }
      sb.Append("ErrorCode: ");
      ErrorCode.ToString(sb);
    }
    if((Message != null) && __isset.message)
    {
      if(0 < tmp64++) { sb.Append(", "); }
      sb.Append("Message: ");
      Message.ToString(sb);
    }
    sb.Append(')');
    return sb.ToString();
  }
}


[DataContract]
public partial class XceptionFault
{
  private int _errorCode;
  private string _message;

  [DataMember(Order = 0)]
  public int ErrorCode
  {
    get
    {
      return _errorCode;
    }
    set
    {
      this._errorCode = value;
    }
  }

  [DataMember(Order = 0)]
  public string Message
  {
    get
    {
      return _message;
    }
    set
    {
      this._message = value;
    }
  }

}

}
