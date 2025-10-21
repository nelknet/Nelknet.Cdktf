using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiInterface(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServerVirtualMachineDataDisk), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServerVirtualMachineDataDisk")]
    public interface IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServerVirtualMachineDataDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#names WorkloadsSapThreeTierVirtualInstance#names}.</summary>
        [JsiiProperty(name: "names", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Names
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#volume_name WorkloadsSapThreeTierVirtualInstance#volume_name}.</summary>
        [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServerVirtualMachineDataDisk), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServerVirtualMachineDataDisk")]
        internal sealed class _Proxy : DeputyBase, azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServerVirtualMachineDataDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#names WorkloadsSapThreeTierVirtualInstance#names}.</summary>
            [JsiiProperty(name: "names", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Names
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#volume_name WorkloadsSapThreeTierVirtualInstance#volume_name}.</summary>
            [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
