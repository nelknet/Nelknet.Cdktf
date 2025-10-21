using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSiteRecoveryReplicationPolicy
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSiteRecoveryReplicationPolicy.DataAzurermSiteRecoveryReplicationPolicyTimeouts")]
    public class DataAzurermSiteRecoveryReplicationPolicyTimeouts : azurerm.DataAzurermSiteRecoveryReplicationPolicy.IDataAzurermSiteRecoveryReplicationPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_policy#read DataAzurermSiteRecoveryReplicationPolicy#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
