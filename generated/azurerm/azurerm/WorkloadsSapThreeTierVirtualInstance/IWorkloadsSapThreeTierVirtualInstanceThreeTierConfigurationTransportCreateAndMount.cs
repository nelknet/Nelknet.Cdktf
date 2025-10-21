using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiInterface(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount")]
    public interface IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#resource_group_id WorkloadsSapThreeTierVirtualInstance#resource_group_id}.</summary>
        [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#storage_account_name WorkloadsSapThreeTierVirtualInstance#storage_account_name}.</summary>
        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount")]
        internal sealed class _Proxy : DeputyBase, azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#resource_group_id WorkloadsSapThreeTierVirtualInstance#resource_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#storage_account_name WorkloadsSapThreeTierVirtualInstance#storage_account_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
