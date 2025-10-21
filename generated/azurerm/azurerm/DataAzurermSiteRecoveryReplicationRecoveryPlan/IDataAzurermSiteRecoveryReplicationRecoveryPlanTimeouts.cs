using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSiteRecoveryReplicationRecoveryPlan
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSiteRecoveryReplicationRecoveryPlanTimeouts), fullyQualifiedName: "azurerm.dataAzurermSiteRecoveryReplicationRecoveryPlan.DataAzurermSiteRecoveryReplicationRecoveryPlanTimeouts")]
    public interface IDataAzurermSiteRecoveryReplicationRecoveryPlanTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_recovery_plan#read DataAzurermSiteRecoveryReplicationRecoveryPlan#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSiteRecoveryReplicationRecoveryPlanTimeouts), fullyQualifiedName: "azurerm.dataAzurermSiteRecoveryReplicationRecoveryPlan.DataAzurermSiteRecoveryReplicationRecoveryPlanTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSiteRecoveryReplicationRecoveryPlan.IDataAzurermSiteRecoveryReplicationRecoveryPlanTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_recovery_plan#read DataAzurermSiteRecoveryReplicationRecoveryPlan#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
