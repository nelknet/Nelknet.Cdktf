using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicationRecoveryPlan
{
    [JsiiByValue(fqn: "azurerm.siteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanAzureToAzureSettings")]
    public class SiteRecoveryReplicationRecoveryPlanAzureToAzureSettings : azurerm.SiteRecoveryReplicationRecoveryPlan.ISiteRecoveryReplicationRecoveryPlanAzureToAzureSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#primary_edge_zone SiteRecoveryReplicationRecoveryPlan#primary_edge_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryEdgeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryEdgeZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#primary_zone SiteRecoveryReplicationRecoveryPlan#primary_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#recovery_edge_zone SiteRecoveryReplicationRecoveryPlan#recovery_edge_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryEdgeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecoveryEdgeZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#recovery_zone SiteRecoveryReplicationRecoveryPlan#recovery_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecoveryZone
        {
            get;
            set;
        }
    }
}
