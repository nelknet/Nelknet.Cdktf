using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryHypervReplicationPolicyAssociation
{
    [JsiiByValue(fqn: "azurerm.siteRecoveryHypervReplicationPolicyAssociation.SiteRecoveryHypervReplicationPolicyAssociationTimeouts")]
    public class SiteRecoveryHypervReplicationPolicyAssociationTimeouts : azurerm.SiteRecoveryHypervReplicationPolicyAssociation.ISiteRecoveryHypervReplicationPolicyAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy_association#create SiteRecoveryHypervReplicationPolicyAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy_association#delete SiteRecoveryHypervReplicationPolicyAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy_association#read SiteRecoveryHypervReplicationPolicyAssociation#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
