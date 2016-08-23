﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Policy
{
    public sealed partial class UrlMembershipCondition : System.Security.ISecurityEncodable, System.Security.Policy.IMembershipCondition //System.Security.ISecurityPolicyEncodable
    {
        public UrlMembershipCondition(string url) { }
        public string Url { get; set; }
        public bool Check(System.Security.Policy.Evidence evidence) { return false; }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object obj) => base.Equals(obj);
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => base.ToString();
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
}
