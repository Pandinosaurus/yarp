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

namespace Apache.Cassandra.Test
{

  /// <summary>
  /// Row returned from a CQL query
  /// </summary>
  [DataContract(Namespace="")]
  public partial class CqlRow : TBase
  {

    [DataMember(Order = 0)]
    public byte[] Key { get; set; }

    [DataMember(Order = 0)]
    public List<global::Apache.Cassandra.Test.Column> Columns { get; set; }

    public CqlRow()
    {
    }

    public CqlRow(byte[] key, List<global::Apache.Cassandra.Test.Column> columns) : this()
    {
      this.Key = key;
      this.Columns = columns;
    }

    public CqlRow DeepCopy()
    {
      var tmp123 = new CqlRow();
      if((Key != null))
      {
        tmp123.Key = this.Key.ToArray();
      }
      if((Columns != null))
      {
        tmp123.Columns = this.Columns.DeepCopy();
      }
      return tmp123;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_key = false;
        bool isset_columns = false;
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
              if (field.Type == TType.String)
              {
                Key = await iprot.ReadBinaryAsync(cancellationToken);
                isset_key = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list124 = await iprot.ReadListBeginAsync(cancellationToken);
                  Columns = new List<global::Apache.Cassandra.Test.Column>(_list124.Count);
                  for(int _i125 = 0; _i125 < _list124.Count; ++_i125)
                  {
                    global::Apache.Cassandra.Test.Column _elem126;
                    _elem126 = new global::Apache.Cassandra.Test.Column();
                    await _elem126.ReadAsync(iprot, cancellationToken);
                    Columns.Add(_elem126);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_columns = true;
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
        if (!isset_key)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_columns)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
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
        var struc = new TStruct("CqlRow");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if((Key != null))
        {
          field.Name = "key";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Key, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Columns != null))
        {
          field.Name = "columns";
          field.Type = TType.List;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Columns.Count), cancellationToken);
            foreach (global::Apache.Cassandra.Test.Column _iter127 in Columns)
            {
              await _iter127.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      if (!(that is CqlRow other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return TCollections.Equals(Key, other.Key)
        && TCollections.Equals(Columns, other.Columns);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Key != null))
        {
          hashcode = (hashcode * 397) + Key.GetHashCode();
        }
        if((Columns != null))
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Columns);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("CqlRow(");
      if((Key != null))
      {
        sb.Append(", Key: ");
        Key.ToString(sb);
      }
      if((Columns != null))
      {
        sb.Append(", Columns: ");
        Columns.ToString(sb);
      }
      sb.Append(')');
      return sb.ToString();
    }
  }

}
