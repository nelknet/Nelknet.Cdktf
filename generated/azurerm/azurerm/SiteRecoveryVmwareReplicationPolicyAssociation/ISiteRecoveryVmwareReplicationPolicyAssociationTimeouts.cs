using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryVmwareReplicationPolicyAssociation
{
    [JsiiInterface(nativeType: typeof(ISiteRecoveryVmwareReplicationPolicyAssociationTimeouts), fullyQualifiedName: "azurerm.siteRecoveryVmwareReplicationPolicyAssociation.SiteRecoveryVmwareReplicationPolicyAssociationTimeouts")]
    public interface ISiteRecoveryVmwareReplicationPolicyAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#create SiteRecoveryVmwareReplicationPolicyAssociation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#delete SiteRecoveryVmwareReplicationPolicyAssociation#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#read SiteRecoveryVmwareReplicationPolicyAssociation#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISiteRecoveryVmwareReplicationPolicyAssociationTimeouts), fullyQualifiedName: "azurerm.siteRecoveryVmwareReplicationPolicyAssociation.SiteRecoveryVmwareReplicationPolicyAssociationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.SiteRecoveryVmwareReplicationPolicyAssociation.ISiteRecoveryVmwareReplicationPolicyAssociationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#create SiteRecoveryVmwareReplicationPolicyAssociation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#delete SiteRecoveryVmwareReplicationPolicyAssociation#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#read SiteRecoveryVmwareReplicationPolicyAssociation#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
