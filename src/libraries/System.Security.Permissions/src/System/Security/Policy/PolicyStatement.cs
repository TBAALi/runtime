﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Policy
{
    public sealed partial class PolicyStatement : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable
    {
        public PolicyStatement(System.Security.PermissionSet permSet) { }
        public PolicyStatement(System.Security.PermissionSet permSet, System.Security.Policy.PolicyStatementAttribute attributes) { }
        public System.Security.Policy.PolicyStatementAttribute Attributes { get; set; }
        public string AttributeString { get { return null; } }
        public System.Security.PermissionSet PermissionSet { get; set; }
        public System.Security.Policy.PolicyStatement Copy() { return this; }
        public override bool Equals(object o) => base.Equals(o);
        public void FromXml(System.Security.SecurityElement et) { }
        public void FromXml(System.Security.SecurityElement et, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() => base.GetHashCode();
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
}
