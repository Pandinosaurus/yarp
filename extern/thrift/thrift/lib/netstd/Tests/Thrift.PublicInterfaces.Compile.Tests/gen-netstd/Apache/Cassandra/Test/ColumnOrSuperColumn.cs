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
  /// Methods for fetching rows/records from Cassandra will return either a single instance of ColumnOrSuperColumn or a list
  /// of ColumnOrSuperColumns (get_slice()). If you're looking up a SuperColumn (or list of SuperColumns) then the resulting
  /// instances of ColumnOrSuperColumn will have the requested SuperColumn in the attribute super_column. For queries resulting
  /// in Columns, those values will be in the attribute column. This change was made between 0.3 and 0.4 to standardize on
  /// single query methods that may return either a SuperColumn or Column.
  /// 
  /// If the query was on a counter column family, you will either get a counter_column (instead of a column) or a
  /// counter_super_column (instead of a super_column)
  /// 
  /// @param column. The Column returned by get() or get_slice().
  /// @param super_column. The SuperColumn returned by get() or get_slice().
  /// @param counter_column. The Counterolumn returned by get() or get_slice().
  /// @param counter_super_column. The CounterSuperColumn returned by get() or get_slice().
  /// </summary>
  [DataContract(Namespace="")]
  public partial class ColumnOrSuperColumn : TBase
  {
    private global::Apache.Cassandra.Test.Column _column;
    private global::Apache.Cassandra.Test.SuperColumn _super_column;
    private global::Apache.Cassandra.Test.CounterColumn _counter_column;
    private global::Apache.Cassandra.Test.CounterSuperColumn _counter_super_column;

    [DataMember(Order = 0)]
    public global::Apache.Cassandra.Test.Column Column
    {
      get
      {
        return _column;
      }
      set
      {
        __isset.column = true;
        this._column = value;
      }
    }

    [DataMember(Order = 0)]
    public global::Apache.Cassandra.Test.SuperColumn Super_column
    {
      get
      {
        return _super_column;
      }
      set
      {
        __isset.super_column = true;
        this._super_column = value;
      }
    }

    [DataMember(Order = 0)]
    public global::Apache.Cassandra.Test.CounterColumn Counter_column
    {
      get
      {
        return _counter_column;
      }
      set
      {
        __isset.counter_column = true;
        this._counter_column = value;
      }
    }

    [DataMember(Order = 0)]
    public global::Apache.Cassandra.Test.CounterSuperColumn Counter_super_column
    {
      get
      {
        return _counter_super_column;
      }
      set
      {
        __isset.counter_super_column = true;
        this._counter_super_column = value;
      }
    }


    [DataMember(Order = 1)]
    public Isset __isset;
    [DataContract]
    public struct Isset
    {
      [DataMember]
      public bool column;
      [DataMember]
      public bool super_column;
      [DataMember]
      public bool counter_column;
      [DataMember]
      public bool counter_super_column;
    }

    #region XmlSerializer support

    public bool ShouldSerializeColumn()
    {
      return __isset.column;
    }

    public bool ShouldSerializeSuper_column()
    {
      return __isset.super_column;
    }

    public bool ShouldSerializeCounter_column()
    {
      return __isset.counter_column;
    }

    public bool ShouldSerializeCounter_super_column()
    {
      return __isset.counter_super_column;
    }

    #endregion XmlSerializer support

    public ColumnOrSuperColumn()
    {
    }

    public ColumnOrSuperColumn DeepCopy()
    {
      var tmp16 = new ColumnOrSuperColumn();
      if((Column != null) && __isset.column)
      {
        tmp16.Column = (global::Apache.Cassandra.Test.Column)this.Column.DeepCopy();
      }
      tmp16.__isset.column = this.__isset.column;
      if((Super_column != null) && __isset.super_column)
      {
        tmp16.Super_column = (global::Apache.Cassandra.Test.SuperColumn)this.Super_column.DeepCopy();
      }
      tmp16.__isset.super_column = this.__isset.super_column;
      if((Counter_column != null) && __isset.counter_column)
      {
        tmp16.Counter_column = (global::Apache.Cassandra.Test.CounterColumn)this.Counter_column.DeepCopy();
      }
      tmp16.__isset.counter_column = this.__isset.counter_column;
      if((Counter_super_column != null) && __isset.counter_super_column)
      {
        tmp16.Counter_super_column = (global::Apache.Cassandra.Test.CounterSuperColumn)this.Counter_super_column.DeepCopy();
      }
      tmp16.__isset.counter_super_column = this.__isset.counter_super_column;
      return tmp16;
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
              if (field.Type == TType.Struct)
              {
                Column = new global::Apache.Cassandra.Test.Column();
                await Column.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Super_column = new global::Apache.Cassandra.Test.SuperColumn();
                await Super_column.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                Counter_column = new global::Apache.Cassandra.Test.CounterColumn();
                await Counter_column.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Struct)
              {
                Counter_super_column = new global::Apache.Cassandra.Test.CounterSuperColumn();
                await Counter_super_column.ReadAsync(iprot, cancellationToken);
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
        var struc = new TStruct("ColumnOrSuperColumn");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if((Column != null) && __isset.column)
        {
          field.Name = "column";
          field.Type = TType.Struct;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Column.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Super_column != null) && __isset.super_column)
        {
          field.Name = "super_column";
          field.Type = TType.Struct;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Super_column.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Counter_column != null) && __isset.counter_column)
        {
          field.Name = "counter_column";
          field.Type = TType.Struct;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Counter_column.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Counter_super_column != null) && __isset.counter_super_column)
        {
          field.Name = "counter_super_column";
          field.Type = TType.Struct;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Counter_super_column.WriteAsync(oprot, cancellationToken);
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
      if (!(that is ColumnOrSuperColumn other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.column == other.__isset.column) && ((!__isset.column) || (System.Object.Equals(Column, other.Column))))
        && ((__isset.super_column == other.__isset.super_column) && ((!__isset.super_column) || (System.Object.Equals(Super_column, other.Super_column))))
        && ((__isset.counter_column == other.__isset.counter_column) && ((!__isset.counter_column) || (System.Object.Equals(Counter_column, other.Counter_column))))
        && ((__isset.counter_super_column == other.__isset.counter_super_column) && ((!__isset.counter_super_column) || (System.Object.Equals(Counter_super_column, other.Counter_super_column))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Column != null) && __isset.column)
        {
          hashcode = (hashcode * 397) + Column.GetHashCode();
        }
        if((Super_column != null) && __isset.super_column)
        {
          hashcode = (hashcode * 397) + Super_column.GetHashCode();
        }
        if((Counter_column != null) && __isset.counter_column)
        {
          hashcode = (hashcode * 397) + Counter_column.GetHashCode();
        }
        if((Counter_super_column != null) && __isset.counter_super_column)
        {
          hashcode = (hashcode * 397) + Counter_super_column.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("ColumnOrSuperColumn(");
      int tmp17 = 0;
      if((Column != null) && __isset.column)
      {
        if(0 < tmp17++) { sb.Append(", "); }
        sb.Append("Column: ");
        Column.ToString(sb);
      }
      if((Super_column != null) && __isset.super_column)
      {
        if(0 < tmp17++) { sb.Append(", "); }
        sb.Append("Super_column: ");
        Super_column.ToString(sb);
      }
      if((Counter_column != null) && __isset.counter_column)
      {
        if(0 < tmp17++) { sb.Append(", "); }
        sb.Append("Counter_column: ");
        Counter_column.ToString(sb);
      }
      if((Counter_super_column != null) && __isset.counter_super_column)
      {
        if(0 < tmp17++) { sb.Append(", "); }
        sb.Append("Counter_super_column: ");
        Counter_super_column.ToString(sb);
      }
      sb.Append(')');
      return sb.ToString();
    }
  }

}
