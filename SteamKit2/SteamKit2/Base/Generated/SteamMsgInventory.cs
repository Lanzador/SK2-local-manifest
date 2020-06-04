// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_inventory.steamclient.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_GetInventory_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string etag
        {
            get { return __pbn__etag ?? ""; }
            set { __pbn__etag = value; }
        }
        public bool ShouldSerializeetag() => __pbn__etag != null;
        public void Resetetag() => __pbn__etag = null;
        private string __pbn__etag;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<ulong> removeditemids { get; } = new global::System.Collections.Generic.List<ulong>();

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_json
        {
            get { return __pbn__item_json ?? ""; }
            set { __pbn__item_json = value; }
        }
        public bool ShouldSerializeitem_json() => __pbn__item_json != null;
        public void Resetitem_json() => __pbn__item_json = null;
        private string __pbn__item_json;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string itemdef_json
        {
            get { return __pbn__itemdef_json ?? ""; }
            set { __pbn__itemdef_json = value; }
        }
        public bool ShouldSerializeitemdef_json() => __pbn__itemdef_json != null;
        public void Resetitemdef_json() => __pbn__itemdef_json = null;
        private string __pbn__itemdef_json;

        [global::ProtoBuf.ProtoMember(5)]
        public byte[] ticket
        {
            get { return __pbn__ticket; }
            set { __pbn__ticket = value; }
        }
        public bool ShouldSerializeticket() => __pbn__ticket != null;
        public void Resetticket() => __pbn__ticket = null;
        private byte[] __pbn__ticket;

        [global::ProtoBuf.ProtoMember(6)]
        public bool replayed
        {
            get { return __pbn__replayed.GetValueOrDefault(); }
            set { __pbn__replayed = value; }
        }
        public bool ShouldSerializereplayed() => __pbn__replayed != null;
        public void Resetreplayed() => __pbn__replayed = null;
        private bool? __pbn__replayed;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_ExchangeItem_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<ulong> materialsitemid { get; } = new global::System.Collections.Generic.List<ulong>();

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<uint> materialsquantity { get; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(5)]
        public ulong outputitemdefid
        {
            get { return __pbn__outputitemdefid.GetValueOrDefault(); }
            set { __pbn__outputitemdefid = value; }
        }
        public bool ShouldSerializeoutputitemdefid() => __pbn__outputitemdefid != null;
        public void Resetoutputitemdefid() => __pbn__outputitemdefid = null;
        private ulong? __pbn__outputitemdefid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_GetEligiblePromoItemDefIDs_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_GetEligiblePromoItemDefIDs_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ulong> itemdefids { get; } = new global::System.Collections.Generic.List<ulong>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_AddItem_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<ulong> itemdefid { get; } = new global::System.Collections.Generic.List<ulong>();

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<string> itempropsjson { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(4)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(5)]
        public bool notify
        {
            get { return __pbn__notify.GetValueOrDefault(); }
            set { __pbn__notify = value; }
        }
        public bool ShouldSerializenotify() => __pbn__notify != null;
        public void Resetnotify() => __pbn__notify = null;
        private bool? __pbn__notify;

        [global::ProtoBuf.ProtoMember(6)]
        public ulong requestid
        {
            get { return __pbn__requestid.GetValueOrDefault(); }
            set { __pbn__requestid = value; }
        }
        public bool ShouldSerializerequestid() => __pbn__requestid != null;
        public void Resetrequestid() => __pbn__requestid = null;
        private ulong? __pbn__requestid;

        [global::ProtoBuf.ProtoMember(7)]
        public bool trade_restriction
        {
            get { return __pbn__trade_restriction.GetValueOrDefault(); }
            set { __pbn__trade_restriction = value; }
        }
        public bool ShouldSerializetrade_restriction() => __pbn__trade_restriction != null;
        public void Resettrade_restriction() => __pbn__trade_restriction = null;
        private bool? __pbn__trade_restriction;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool is_purchase
        {
            get { return __pbn__is_purchase ?? false; }
            set { __pbn__is_purchase = value; }
        }
        public bool ShouldSerializeis_purchase() => __pbn__is_purchase != null;
        public void Resetis_purchase() => __pbn__is_purchase = null;
        private bool? __pbn__is_purchase;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_ModifyItems_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<ItemPropertyUpdate> updates { get; } = new global::System.Collections.Generic.List<ItemPropertyUpdate>();

        [global::ProtoBuf.ProtoMember(4)]
        public uint timestamp
        {
            get { return __pbn__timestamp.GetValueOrDefault(); }
            set { __pbn__timestamp = value; }
        }
        public bool ShouldSerializetimestamp() => __pbn__timestamp != null;
        public void Resettimestamp() => __pbn__timestamp = null;
        private uint? __pbn__timestamp;

        [global::ProtoBuf.ProtoContract()]
        public partial class ItemPropertyUpdate : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public ulong itemid
            {
                get { return __pbn__itemid.GetValueOrDefault(); }
                set { __pbn__itemid = value; }
            }
            public bool ShouldSerializeitemid() => __pbn__itemid != null;
            public void Resetitemid() => __pbn__itemid = null;
            private ulong? __pbn__itemid;

            [global::ProtoBuf.ProtoMember(2)]
            public bool remove_property
            {
                get { return __pbn__remove_property.GetValueOrDefault(); }
                set { __pbn__remove_property = value; }
            }
            public bool ShouldSerializeremove_property() => __pbn__remove_property != null;
            public void Resetremove_property() => __pbn__remove_property = null;
            private bool? __pbn__remove_property;

            [global::ProtoBuf.ProtoMember(3)]
            [global::System.ComponentModel.DefaultValue("")]
            public string property_name
            {
                get { return __pbn__property_name ?? ""; }
                set { __pbn__property_name = value; }
            }
            public bool ShouldSerializeproperty_name() => __pbn__property_name != null;
            public void Resetproperty_name() => __pbn__property_name = null;
            private string __pbn__property_name;

            [global::ProtoBuf.ProtoMember(4)]
            public bool property_value_bool
            {
                get { return __pbn__property_value_bool.GetValueOrDefault(); }
                set { __pbn__property_value_bool = value; }
            }
            public bool ShouldSerializeproperty_value_bool() => __pbn__property_value_bool != null;
            public void Resetproperty_value_bool() => __pbn__property_value_bool = null;
            private bool? __pbn__property_value_bool;

            [global::ProtoBuf.ProtoMember(5)]
            public long property_value_int
            {
                get { return __pbn__property_value_int.GetValueOrDefault(); }
                set { __pbn__property_value_int = value; }
            }
            public bool ShouldSerializeproperty_value_int() => __pbn__property_value_int != null;
            public void Resetproperty_value_int() => __pbn__property_value_int = null;
            private long? __pbn__property_value_int;

            [global::ProtoBuf.ProtoMember(6)]
            [global::System.ComponentModel.DefaultValue("")]
            public string property_value_string
            {
                get { return __pbn__property_value_string ?? ""; }
                set { __pbn__property_value_string = value; }
            }
            public bool ShouldSerializeproperty_value_string() => __pbn__property_value_string != null;
            public void Resetproperty_value_string() => __pbn__property_value_string = null;
            private string __pbn__property_value_string;

            [global::ProtoBuf.ProtoMember(7)]
            public float property_value_float
            {
                get { return __pbn__property_value_float.GetValueOrDefault(); }
                set { __pbn__property_value_float = value; }
            }
            public bool ShouldSerializeproperty_value_float() => __pbn__property_value_float != null;
            public void Resetproperty_value_float() => __pbn__property_value_float = null;
            private float? __pbn__property_value_float;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_ConsumePlaytime_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong itemdefid
        {
            get { return __pbn__itemdefid.GetValueOrDefault(); }
            set { __pbn__itemdefid = value; }
        }
        public bool ShouldSerializeitemdefid() => __pbn__itemdefid != null;
        public void Resetitemdefid() => __pbn__itemdefid = null;
        private ulong? __pbn__itemdefid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_ConsumeItem_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong itemid
        {
            get { return __pbn__itemid.GetValueOrDefault(); }
            set { __pbn__itemid = value; }
        }
        public bool ShouldSerializeitemid() => __pbn__itemid != null;
        public void Resetitemid() => __pbn__itemid = null;
        private ulong? __pbn__itemid;

        [global::ProtoBuf.ProtoMember(3)]
        public uint quantity
        {
            get { return __pbn__quantity.GetValueOrDefault(); }
            set { __pbn__quantity = value; }
        }
        public bool ShouldSerializequantity() => __pbn__quantity != null;
        public void Resetquantity() => __pbn__quantity = null;
        private uint? __pbn__quantity;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string timestamp
        {
            get { return __pbn__timestamp ?? ""; }
            set { __pbn__timestamp = value; }
        }
        public bool ShouldSerializetimestamp() => __pbn__timestamp != null;
        public void Resettimestamp() => __pbn__timestamp = null;
        private string __pbn__timestamp;

        [global::ProtoBuf.ProtoMember(5)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(6)]
        public ulong requestid
        {
            get { return __pbn__requestid.GetValueOrDefault(); }
            set { __pbn__requestid = value; }
        }
        public bool ShouldSerializerequestid() => __pbn__requestid != null;
        public void Resetrequestid() => __pbn__requestid = null;
        private ulong? __pbn__requestid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_DevSetNextDrop_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong itemdefid
        {
            get { return __pbn__itemdefid.GetValueOrDefault(); }
            set { __pbn__itemdefid = value; }
        }
        public bool ShouldSerializeitemdefid() => __pbn__itemdefid != null;
        public void Resetitemdefid() => __pbn__itemdefid = null;
        private ulong? __pbn__itemdefid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string droptime
        {
            get { return __pbn__droptime ?? ""; }
            set { __pbn__droptime = value; }
        }
        public bool ShouldSerializedroptime() => __pbn__droptime != null;
        public void Resetdroptime() => __pbn__droptime = null;
        private string __pbn__droptime;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_SplitItemStack_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong itemid
        {
            get { return __pbn__itemid.GetValueOrDefault(); }
            set { __pbn__itemid = value; }
        }
        public bool ShouldSerializeitemid() => __pbn__itemid != null;
        public void Resetitemid() => __pbn__itemid = null;
        private ulong? __pbn__itemid;

        [global::ProtoBuf.ProtoMember(3)]
        public uint quantity
        {
            get { return __pbn__quantity.GetValueOrDefault(); }
            set { __pbn__quantity = value; }
        }
        public bool ShouldSerializequantity() => __pbn__quantity != null;
        public void Resetquantity() => __pbn__quantity = null;
        private uint? __pbn__quantity;

        [global::ProtoBuf.ProtoMember(5)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_CombineItemStacks_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong fromitemid
        {
            get { return __pbn__fromitemid.GetValueOrDefault(); }
            set { __pbn__fromitemid = value; }
        }
        public bool ShouldSerializefromitemid() => __pbn__fromitemid != null;
        public void Resetfromitemid() => __pbn__fromitemid = null;
        private ulong? __pbn__fromitemid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong destitemid
        {
            get { return __pbn__destitemid.GetValueOrDefault(); }
            set { __pbn__destitemid = value; }
        }
        public bool ShouldSerializedestitemid() => __pbn__destitemid != null;
        public void Resetdestitemid() => __pbn__destitemid = null;
        private ulong? __pbn__destitemid;

        [global::ProtoBuf.ProtoMember(4)]
        public uint quantity
        {
            get { return __pbn__quantity.GetValueOrDefault(); }
            set { __pbn__quantity = value; }
        }
        public bool ShouldSerializequantity() => __pbn__quantity != null;
        public void Resetquantity() => __pbn__quantity = null;
        private uint? __pbn__quantity;

        [global::ProtoBuf.ProtoMember(7, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_GetItemDefMeta_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_GetItemDefMeta_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint modified
        {
            get { return __pbn__modified.GetValueOrDefault(); }
            set { __pbn__modified = value; }
        }
        public bool ShouldSerializemodified() => __pbn__modified != null;
        public void Resetmodified() => __pbn__modified = null;
        private uint? __pbn__modified;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string digest
        {
            get { return __pbn__digest ?? ""; }
            set { __pbn__digest = value; }
        }
        public bool ShouldSerializedigest() => __pbn__digest != null;
        public void Resetdigest() => __pbn__digest = null;
        private string __pbn__digest;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_GetUserPurchaseInfo_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_GetUserPurchaseInfo_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int ecurrency
        {
            get { return __pbn__ecurrency.GetValueOrDefault(); }
            set { __pbn__ecurrency = value; }
        }
        public bool ShouldSerializeecurrency() => __pbn__ecurrency != null;
        public void Resetecurrency() => __pbn__ecurrency = null;
        private int? __pbn__ecurrency;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_PurchaseInit_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public int language
        {
            get { return __pbn__language.GetValueOrDefault(); }
            set { __pbn__language = value; }
        }
        public bool ShouldSerializelanguage() => __pbn__language != null;
        public void Resetlanguage() => __pbn__language = null;
        private int? __pbn__language;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<LineItem> line_items { get; } = new global::System.Collections.Generic.List<LineItem>();

        [global::ProtoBuf.ProtoContract()]
        public partial class LineItem : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public ulong itemdefid
            {
                get { return __pbn__itemdefid.GetValueOrDefault(); }
                set { __pbn__itemdefid = value; }
            }
            public bool ShouldSerializeitemdefid() => __pbn__itemdefid != null;
            public void Resetitemdefid() => __pbn__itemdefid = null;
            private ulong? __pbn__itemdefid;

            [global::ProtoBuf.ProtoMember(2)]
            public uint quantity
            {
                get { return __pbn__quantity.GetValueOrDefault(); }
                set { __pbn__quantity = value; }
            }
            public bool ShouldSerializequantity() => __pbn__quantity != null;
            public void Resetquantity() => __pbn__quantity = null;
            private uint? __pbn__quantity;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_PurchaseInit_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong orderid
        {
            get { return __pbn__orderid.GetValueOrDefault(); }
            set { __pbn__orderid = value; }
        }
        public bool ShouldSerializeorderid() => __pbn__orderid != null;
        public void Resetorderid() => __pbn__orderid = null;
        private ulong? __pbn__orderid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong transid
        {
            get { return __pbn__transid.GetValueOrDefault(); }
            set { __pbn__transid = value; }
        }
        public bool ShouldSerializetransid() => __pbn__transid != null;
        public void Resettransid() => __pbn__transid = null;
        private ulong? __pbn__transid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_PurchaseFinalize_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public int language
        {
            get { return __pbn__language.GetValueOrDefault(); }
            set { __pbn__language = value; }
        }
        public bool ShouldSerializelanguage() => __pbn__language != null;
        public void Resetlanguage() => __pbn__language = null;
        private int? __pbn__language;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong orderid
        {
            get { return __pbn__orderid.GetValueOrDefault(); }
            set { __pbn__orderid = value; }
        }
        public bool ShouldSerializeorderid() => __pbn__orderid != null;
        public void Resetorderid() => __pbn__orderid = null;
        private ulong? __pbn__orderid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventory_InspectItem_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong itemdefid
        {
            get { return __pbn__itemdefid.GetValueOrDefault(); }
            set { __pbn__itemdefid = value; }
        }
        public bool ShouldSerializeitemdefid() => __pbn__itemdefid != null;
        public void Resetitemdefid() => __pbn__itemdefid = null;
        private ulong? __pbn__itemdefid;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong itemid
        {
            get { return __pbn__itemid.GetValueOrDefault(); }
            set { __pbn__itemid = value; }
        }
        public bool ShouldSerializeitemid() => __pbn__itemid != null;
        public void Resetitemid() => __pbn__itemid = null;
        private ulong? __pbn__itemid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string tags
        {
            get { return __pbn__tags ?? ""; }
            set { __pbn__tags = value; }
        }
        public bool ShouldSerializetags() => __pbn__tags != null;
        public void Resettags() => __pbn__tags = null;
        private string __pbn__tags;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CInventoryClient_NewItems_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public CInventory_Response inventory_response { get; set; }

    }

    public interface IInventory
    {
        CInventory_Response GetInventory(CInventory_GetInventory_Request request);
        CInventory_Response ExchangeItem(CInventory_ExchangeItem_Request request);
        CInventory_GetEligiblePromoItemDefIDs_Response GetEligiblePromoItemDefIDs(CInventory_GetEligiblePromoItemDefIDs_Request request);
        CInventory_Response AddPromoItem(CInventory_AddItem_Request request);
        CInventory_Response SafeModifyItems(CInventory_ModifyItems_Request request);
        CInventory_Response ConsumePlaytime(CInventory_ConsumePlaytime_Request request);
        CInventory_Response ConsumeItem(CInventory_ConsumeItem_Request request);
        CInventory_Response DevGenerateItem(CInventory_AddItem_Request request);
        CInventory_Response DevSetNextDrop(CInventory_DevSetNextDrop_Request request);
        CInventory_Response SplitItemStack(CInventory_SplitItemStack_Request request);
        CInventory_Response CombineItemStacks(CInventory_CombineItemStacks_Request request);
        CInventory_GetItemDefMeta_Response GetItemDefMeta(CInventory_GetItemDefMeta_Request request);
        CInventory_GetUserPurchaseInfo_Response GetUserPurchaseInfo(CInventory_GetUserPurchaseInfo_Request request);
        CInventory_PurchaseInit_Response PurchaseInit(CInventory_PurchaseInit_Request request);
        CInventory_Response PurchaseFinalize(CInventory_PurchaseFinalize_Request request);
        CInventory_Response InspectItem(CInventory_InspectItem_Request request);
    }

    public interface IInventoryClient
    {
        NoResponse NotifyNewItems(CInventoryClient_NewItems_Notification request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
