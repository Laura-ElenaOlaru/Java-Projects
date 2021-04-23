/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace transformer
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Reservation : TBase
  {
    private int _id;
    private int _agencyUserId;
    private int _tripId;
    private int _nrTickets;
    private string _clientName;
    private string _telephone;

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public int AgencyUserId
    {
      get
      {
        return _agencyUserId;
      }
      set
      {
        __isset.agencyUserId = true;
        this._agencyUserId = value;
      }
    }

    public int TripId
    {
      get
      {
        return _tripId;
      }
      set
      {
        __isset.tripId = true;
        this._tripId = value;
      }
    }

    public int NrTickets
    {
      get
      {
        return _nrTickets;
      }
      set
      {
        __isset.nrTickets = true;
        this._nrTickets = value;
      }
    }

    public string ClientName
    {
      get
      {
        return _clientName;
      }
      set
      {
        __isset.clientName = true;
        this._clientName = value;
      }
    }

    public string Telephone
    {
      get
      {
        return _telephone;
      }
      set
      {
        __isset.telephone = true;
        this._telephone = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool agencyUserId;
      public bool tripId;
      public bool nrTickets;
      public bool clientName;
      public bool telephone;
    }

    public Reservation() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              AgencyUserId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              TripId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              NrTickets = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              ClientName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              Telephone = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Reservation");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (__isset.agencyUserId) {
        field.Name = "agencyUserId";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AgencyUserId);
        oprot.WriteFieldEnd();
      }
      if (__isset.tripId) {
        field.Name = "tripId";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TripId);
        oprot.WriteFieldEnd();
      }
      if (__isset.nrTickets) {
        field.Name = "nrTickets";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(NrTickets);
        oprot.WriteFieldEnd();
      }
      if (ClientName != null && __isset.clientName) {
        field.Name = "clientName";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ClientName);
        oprot.WriteFieldEnd();
      }
      if (Telephone != null && __isset.telephone) {
        field.Name = "telephone";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Telephone);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Reservation(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",AgencyUserId: ");
      sb.Append(AgencyUserId);
      sb.Append(",TripId: ");
      sb.Append(TripId);
      sb.Append(",NrTickets: ");
      sb.Append(NrTickets);
      sb.Append(",ClientName: ");
      sb.Append(ClientName);
      sb.Append(",Telephone: ");
      sb.Append(Telephone);
      sb.Append(")");
      return sb.ToString();
    }

  }

}