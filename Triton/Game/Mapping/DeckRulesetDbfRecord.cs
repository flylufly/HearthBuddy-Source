﻿namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckRulesetDbfRecord")]
    public class DeckRulesetDbfRecord : DbfRecord
    {
        public DeckRulesetDbfRecord(IntPtr address) : this(address, "DeckRulesetDbfRecord")
        {
        }

        public DeckRulesetDbfRecord(IntPtr address, string className) : base(address, className)
        {
        }

        public object GetVar(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<object>("GetVar", objArray1);
        }

        public System.Type GetVarType(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<System.Type>("GetVarType", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }
    }
}

