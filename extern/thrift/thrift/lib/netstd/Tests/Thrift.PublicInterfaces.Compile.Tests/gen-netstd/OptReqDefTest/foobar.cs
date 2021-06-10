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

namespace OptReqDefTest
{
public partial class foobar
{
  [ServiceContract(Namespace="")]
  public interface IAsync
  {
    [OperationContract]
    [FaultContract(typeof(global::OptReqDefTest.CrashBoomBangFault))]
    global::System.Threading.Tasks.Task<THashSet<THashSet<THashSet<global::OptReqDefTest.Distance>>>> DoItNowAsync(List<List<List<global::OptReqDefTest.RaceDetails>>> rd, int mitDefault, CancellationToken cancellationToken = default);

  }


  public class Client : TBaseClient, IDisposable, IAsync
  {
    public Client(TProtocol protocol) : this(protocol, protocol)
    {
    }

    public Client(TProtocol inputProtocol, TProtocol outputProtocol) : base(inputProtocol, outputProtocol)    {
    }
    public async global::System.Threading.Tasks.Task<THashSet<THashSet<THashSet<global::OptReqDefTest.Distance>>>> DoItNowAsync(List<List<List<global::OptReqDefTest.RaceDetails>>> rd, int mitDefault, CancellationToken cancellationToken = default)
    {
      await OutputProtocol.WriteMessageBeginAsync(new TMessage("DoItNow", TMessageType.Call, SeqId), cancellationToken);
      
      var args = new InternalStructs.DoItNowArgs() {
        Rd = rd,
        MitDefault = mitDefault,
      };
      
      await args.WriteAsync(OutputProtocol, cancellationToken);
      await OutputProtocol.WriteMessageEndAsync(cancellationToken);
      await OutputProtocol.Transport.FlushAsync(cancellationToken);
      
      var msg = await InputProtocol.ReadMessageBeginAsync(cancellationToken);
      if (msg.Type == TMessageType.Exception)
      {
        var x = await TApplicationException.ReadAsync(InputProtocol, cancellationToken);
        await InputProtocol.ReadMessageEndAsync(cancellationToken);
        throw x;
      }

      var result = new InternalStructs.DoItNowResult();
      await result.ReadAsync(InputProtocol, cancellationToken);
      await InputProtocol.ReadMessageEndAsync(cancellationToken);
      if (result.__isset.success)
      {
        return result.Success;
      }
      if (result.__isset.cbb)
      {
        throw result.Cbb;
      }
      throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "DoItNow failed: unknown result");
    }

  }

  public class AsyncProcessor : ITAsyncProcessor
  {
    private readonly IAsync _iAsync;
    private readonly ILogger<AsyncProcessor> _logger;

    public AsyncProcessor(IAsync iAsync, ILogger<AsyncProcessor> logger = default)
    {
      _iAsync = iAsync ?? throw new ArgumentNullException(nameof(iAsync));
      _logger = logger;
      processMap_["DoItNow"] = DoItNow_ProcessAsync;
    }

    protected delegate global::System.Threading.Tasks.Task ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken);
    protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

    public async Task<bool> ProcessAsync(TProtocol iprot, TProtocol oprot)
    {
      return await ProcessAsync(iprot, oprot, CancellationToken.None);
    }

    public async Task<bool> ProcessAsync(TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken)
    {
      try
      {
        var msg = await iprot.ReadMessageBeginAsync(cancellationToken);

        processMap_.TryGetValue(msg.Name, out ProcessFunction fn);

        if (fn == null)
        {
          await TProtocolUtil.SkipAsync(iprot, TType.Struct, cancellationToken);
          await iprot.ReadMessageEndAsync(cancellationToken);
          var x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
          await oprot.WriteMessageBeginAsync(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID), cancellationToken);
          await x.WriteAsync(oprot, cancellationToken);
          await oprot.WriteMessageEndAsync(cancellationToken);
          await oprot.Transport.FlushAsync(cancellationToken);
          return true;
        }

        await fn(msg.SeqID, iprot, oprot, cancellationToken);

      }
      catch (IOException)
      {
        return false;
      }

      return true;
    }

    public async global::System.Threading.Tasks.Task DoItNow_ProcessAsync(int seqid, TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken)
    {
      var args = new InternalStructs.DoItNowArgs();
      await args.ReadAsync(iprot, cancellationToken);
      await iprot.ReadMessageEndAsync(cancellationToken);
      var result = new InternalStructs.DoItNowResult();
      try
      {
        try
        {
          result.Success = await _iAsync.DoItNowAsync(args.Rd, args.MitDefault, cancellationToken);
        }
        catch (global::OptReqDefTest.CrashBoomBang cbb)
        {
          result.Cbb = cbb;
        }
        await oprot.WriteMessageBeginAsync(new TMessage("DoItNow", TMessageType.Reply, seqid), cancellationToken); 
        await result.WriteAsync(oprot, cancellationToken);
      }
      catch (TTransportException)
      {
        throw;
      }
      catch (Exception ex)
      {
        var sErr = $"Error occurred in {GetType().FullName}: {ex.Message}";
        if(_logger != null)
          _logger.LogError(ex, sErr);
        else
          Console.Error.WriteLine(sErr);
        var x = new TApplicationException(TApplicationException.ExceptionType.InternalError," Internal error.");
        await oprot.WriteMessageBeginAsync(new TMessage("DoItNow", TMessageType.Exception, seqid), cancellationToken);
        await x.WriteAsync(oprot, cancellationToken);
      }
      await oprot.WriteMessageEndAsync(cancellationToken);
      await oprot.Transport.FlushAsync(cancellationToken);
    }

  }

  public class InternalStructs
  {

    [DataContract(Namespace="")]
    public partial class DoItNowArgs : TBase
    {
      private List<List<List<global::OptReqDefTest.RaceDetails>>> _rd;
      private int _mitDefault;

      [DataMember(Order = 0)]
      public List<List<List<global::OptReqDefTest.RaceDetails>>> Rd
      {
        get
        {
          return _rd;
        }
        set
        {
          __isset.rd = true;
          this._rd = value;
        }
      }

      [DataMember(Order = 0)]
      public int MitDefault
      {
        get
        {
          return _mitDefault;
        }
        set
        {
          __isset.mitDefault = true;
          this._mitDefault = value;
        }
      }


      [DataMember(Order = 1)]
      public Isset __isset;
      [DataContract]
      public struct Isset
      {
        [DataMember]
        public bool rd;
        [DataMember]
        public bool mitDefault;
      }

      #region XmlSerializer support

      public bool ShouldSerializeRd()
      {
        return __isset.rd;
      }

      public bool ShouldSerializeMitDefault()
      {
        return __isset.mitDefault;
      }

      #endregion XmlSerializer support

      public DoItNowArgs()
      {
        this._mitDefault = 42;
        this.__isset.mitDefault = true;
      }

      public DoItNowArgs DeepCopy()
      {
        var tmp180 = new DoItNowArgs();
        if((Rd != null) && __isset.rd)
        {
          tmp180.Rd = this.Rd.DeepCopy();
        }
        tmp180.__isset.rd = this.__isset.rd;
        if(__isset.mitDefault)
        {
          tmp180.MitDefault = this.MitDefault;
        }
        tmp180.__isset.mitDefault = this.__isset.mitDefault;
        return tmp180;
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
                if (field.Type == TType.List)
                {
                  {
                    TList _list181 = await iprot.ReadListBeginAsync(cancellationToken);
                    Rd = new List<List<List<global::OptReqDefTest.RaceDetails>>>(_list181.Count);
                    for(int _i182 = 0; _i182 < _list181.Count; ++_i182)
                    {
                      List<List<global::OptReqDefTest.RaceDetails>> _elem183;
                      {
                        TList _list184 = await iprot.ReadListBeginAsync(cancellationToken);
                        _elem183 = new List<List<global::OptReqDefTest.RaceDetails>>(_list184.Count);
                        for(int _i185 = 0; _i185 < _list184.Count; ++_i185)
                        {
                          List<global::OptReqDefTest.RaceDetails> _elem186;
                          {
                            TList _list187 = await iprot.ReadListBeginAsync(cancellationToken);
                            _elem186 = new List<global::OptReqDefTest.RaceDetails>(_list187.Count);
                            for(int _i188 = 0; _i188 < _list187.Count; ++_i188)
                            {
                              global::OptReqDefTest.RaceDetails _elem189;
                              _elem189 = new global::OptReqDefTest.RaceDetails();
                              await _elem189.ReadAsync(iprot, cancellationToken);
                              _elem186.Add(_elem189);
                            }
                            await iprot.ReadListEndAsync(cancellationToken);
                          }
                          _elem183.Add(_elem186);
                        }
                        await iprot.ReadListEndAsync(cancellationToken);
                      }
                      Rd.Add(_elem183);
                    }
                    await iprot.ReadListEndAsync(cancellationToken);
                  }
                }
                else
                {
                  await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                }
                break;
              case 2:
                if (field.Type == TType.I32)
                {
                  MitDefault = await iprot.ReadI32Async(cancellationToken);
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
          var struc = new TStruct("DoItNow_args");
          await oprot.WriteStructBeginAsync(struc, cancellationToken);
          var field = new TField();
          if((Rd != null) && __isset.rd)
          {
            field.Name = "rd";
            field.Type = TType.List;
            field.ID = 1;
            await oprot.WriteFieldBeginAsync(field, cancellationToken);
            {
              await oprot.WriteListBeginAsync(new TList(TType.List, Rd.Count), cancellationToken);
              foreach (List<List<global::OptReqDefTest.RaceDetails>> _iter190 in Rd)
              {
                {
                  await oprot.WriteListBeginAsync(new TList(TType.List, _iter190.Count), cancellationToken);
                  foreach (List<global::OptReqDefTest.RaceDetails> _iter191 in _iter190)
                  {
                    {
                      await oprot.WriteListBeginAsync(new TList(TType.Struct, _iter191.Count), cancellationToken);
                      foreach (global::OptReqDefTest.RaceDetails _iter192 in _iter191)
                      {
                        await _iter192.WriteAsync(oprot, cancellationToken);
                      }
                      await oprot.WriteListEndAsync(cancellationToken);
                    }
                  }
                  await oprot.WriteListEndAsync(cancellationToken);
                }
              }
              await oprot.WriteListEndAsync(cancellationToken);
            }
            await oprot.WriteFieldEndAsync(cancellationToken);
          }
          if(__isset.mitDefault)
          {
            field.Name = "mitDefault";
            field.Type = TType.I32;
            field.ID = 2;
            await oprot.WriteFieldBeginAsync(field, cancellationToken);
            await oprot.WriteI32Async(MitDefault, cancellationToken);
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
        if (!(that is DoItNowArgs other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return ((__isset.rd == other.__isset.rd) && ((!__isset.rd) || (TCollections.Equals(Rd, other.Rd))))
          && ((__isset.mitDefault == other.__isset.mitDefault) && ((!__isset.mitDefault) || (System.Object.Equals(MitDefault, other.MitDefault))));
      }

      public override int GetHashCode() {
        int hashcode = 157;
        unchecked {
          if((Rd != null) && __isset.rd)
          {
            hashcode = (hashcode * 397) + TCollections.GetHashCode(Rd);
          }
          if(__isset.mitDefault)
          {
            hashcode = (hashcode * 397) + MitDefault.GetHashCode();
          }
        }
        return hashcode;
      }

      public override string ToString()
      {
        var sb = new StringBuilder("DoItNow_args(");
        int tmp193 = 0;
        if((Rd != null) && __isset.rd)
        {
          if(0 < tmp193++) { sb.Append(", "); }
          sb.Append("Rd: ");
          Rd.ToString(sb);
        }
        if(__isset.mitDefault)
        {
          if(0 < tmp193++) { sb.Append(", "); }
          sb.Append("MitDefault: ");
          MitDefault.ToString(sb);
        }
        sb.Append(')');
        return sb.ToString();
      }
    }


    [DataContract(Namespace="")]
    public partial class DoItNowResult : TBase
    {
      private THashSet<THashSet<THashSet<global::OptReqDefTest.Distance>>> _success;
      private global::OptReqDefTest.CrashBoomBang _cbb;

      [DataMember(Order = 0)]
      public THashSet<THashSet<THashSet<global::OptReqDefTest.Distance>>> Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }

      [DataMember(Order = 0)]
      public global::OptReqDefTest.CrashBoomBang Cbb
      {
        get
        {
          return _cbb;
        }
        set
        {
          __isset.cbb = true;
          this._cbb = value;
        }
      }


      [DataMember(Order = 1)]
      public Isset __isset;
      [DataContract]
      public struct Isset
      {
        [DataMember]
        public bool success;
        [DataMember]
        public bool cbb;
      }

      #region XmlSerializer support

      public bool ShouldSerializeSuccess()
      {
        return __isset.success;
      }

      public bool ShouldSerializeCbb()
      {
        return __isset.cbb;
      }

      #endregion XmlSerializer support

      public DoItNowResult()
      {
      }

      public DoItNowResult DeepCopy()
      {
        var tmp194 = new DoItNowResult();
        if((Success != null) && __isset.success)
        {
          tmp194.Success = this.Success.DeepCopy();
        }
        tmp194.__isset.success = this.__isset.success;
        if((Cbb != null) && __isset.cbb)
        {
          tmp194.Cbb = (global::OptReqDefTest.CrashBoomBang)this.Cbb.DeepCopy();
        }
        tmp194.__isset.cbb = this.__isset.cbb;
        return tmp194;
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
              case 0:
                if (field.Type == TType.Set)
                {
                  {
                    TSet _set195 = await iprot.ReadSetBeginAsync(cancellationToken);
                    Success = new THashSet<THashSet<THashSet<global::OptReqDefTest.Distance>>>(_set195.Count);
                    for(int _i196 = 0; _i196 < _set195.Count; ++_i196)
                    {
                      THashSet<THashSet<global::OptReqDefTest.Distance>> _elem197;
                      {
                        TSet _set198 = await iprot.ReadSetBeginAsync(cancellationToken);
                        _elem197 = new THashSet<THashSet<global::OptReqDefTest.Distance>>(_set198.Count);
                        for(int _i199 = 0; _i199 < _set198.Count; ++_i199)
                        {
                          THashSet<global::OptReqDefTest.Distance> _elem200;
                          {
                            TSet _set201 = await iprot.ReadSetBeginAsync(cancellationToken);
                            _elem200 = new THashSet<global::OptReqDefTest.Distance>(_set201.Count);
                            for(int _i202 = 0; _i202 < _set201.Count; ++_i202)
                            {
                              global::OptReqDefTest.Distance _elem203;
                              _elem203 = (global::OptReqDefTest.Distance)await iprot.ReadI32Async(cancellationToken);
                              _elem200.Add(_elem203);
                            }
                            await iprot.ReadSetEndAsync(cancellationToken);
                          }
                          _elem197.Add(_elem200);
                        }
                        await iprot.ReadSetEndAsync(cancellationToken);
                      }
                      Success.Add(_elem197);
                    }
                    await iprot.ReadSetEndAsync(cancellationToken);
                  }
                }
                else
                {
                  await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                }
                break;
              case 1:
                if (field.Type == TType.Struct)
                {
                  Cbb = new global::OptReqDefTest.CrashBoomBang();
                  await Cbb.ReadAsync(iprot, cancellationToken);
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
          var struc = new TStruct("DoItNow_result");
          await oprot.WriteStructBeginAsync(struc, cancellationToken);
          var field = new TField();

          if(this.__isset.success)
          {
            if (Success != null)
            {
              field.Name = "Success";
              field.Type = TType.Set;
              field.ID = 0;
              await oprot.WriteFieldBeginAsync(field, cancellationToken);
              {
                await oprot.WriteSetBeginAsync(new TSet(TType.Set, Success.Count), cancellationToken);
                foreach (THashSet<THashSet<global::OptReqDefTest.Distance>> _iter204 in Success)
                {
                  {
                    await oprot.WriteSetBeginAsync(new TSet(TType.Set, _iter204.Count), cancellationToken);
                    foreach (THashSet<global::OptReqDefTest.Distance> _iter205 in _iter204)
                    {
                      {
                        await oprot.WriteSetBeginAsync(new TSet(TType.I32, _iter205.Count), cancellationToken);
                        foreach (global::OptReqDefTest.Distance _iter206 in _iter205)
                        {
                          await oprot.WriteI32Async((int)_iter206, cancellationToken);
                        }
                        await oprot.WriteSetEndAsync(cancellationToken);
                      }
                    }
                    await oprot.WriteSetEndAsync(cancellationToken);
                  }
                }
                await oprot.WriteSetEndAsync(cancellationToken);
              }
              await oprot.WriteFieldEndAsync(cancellationToken);
            }
          }
          else if(this.__isset.cbb)
          {
            if (Cbb != null)
            {
              field.Name = "Cbb";
              field.Type = TType.Struct;
              field.ID = 1;
              await oprot.WriteFieldBeginAsync(field, cancellationToken);
              await Cbb.WriteAsync(oprot, cancellationToken);
              await oprot.WriteFieldEndAsync(cancellationToken);
            }
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
        if (!(that is DoItNowResult other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return ((__isset.success == other.__isset.success) && ((!__isset.success) || (TCollections.Equals(Success, other.Success))))
          && ((__isset.cbb == other.__isset.cbb) && ((!__isset.cbb) || (System.Object.Equals(Cbb, other.Cbb))));
      }

      public override int GetHashCode() {
        int hashcode = 157;
        unchecked {
          if((Success != null) && __isset.success)
          {
            hashcode = (hashcode * 397) + TCollections.GetHashCode(Success);
          }
          if((Cbb != null) && __isset.cbb)
          {
            hashcode = (hashcode * 397) + Cbb.GetHashCode();
          }
        }
        return hashcode;
      }

      public override string ToString()
      {
        var sb = new StringBuilder("DoItNow_result(");
        int tmp207 = 0;
        if((Success != null) && __isset.success)
        {
          if(0 < tmp207++) { sb.Append(", "); }
          sb.Append("Success: ");
          Success.ToString(sb);
        }
        if((Cbb != null) && __isset.cbb)
        {
          if(0 < tmp207++) { sb.Append(", "); }
          sb.Append("Cbb: ");
          Cbb.ToString(sb);
        }
        sb.Append(')');
        return sb.ToString();
      }
    }

  }

}
}