using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetRollingUpgradePolicy), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy")]
    public interface IVirtualMachineScaleSetRollingUpgradePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#max_batch_instance_percent VirtualMachineScaleSet#max_batch_instance_percent}.</summary>
        [JsiiProperty(name: "maxBatchInstancePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxBatchInstancePercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#max_unhealthy_instance_percent VirtualMachineScaleSet#max_unhealthy_instance_percent}.</summary>
        [JsiiProperty(name: "maxUnhealthyInstancePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnhealthyInstancePercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#max_unhealthy_upgraded_instance_percent VirtualMachineScaleSet#max_unhealthy_upgraded_instance_percent}.</summary>
        [JsiiProperty(name: "maxUnhealthyUpgradedInstancePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnhealthyUpgradedInstancePercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#pause_time_between_batches VirtualMachineScaleSet#pause_time_between_batches}.</summary>
        [JsiiProperty(name: "pauseTimeBetweenBatches", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PauseTimeBetweenBatches
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetRollingUpgradePolicy), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#max_batch_instance_percent VirtualMachineScaleSet#max_batch_instance_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxBatchInstancePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxBatchInstancePercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#max_unhealthy_instance_percent VirtualMachineScaleSet#max_unhealthy_instance_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnhealthyInstancePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnhealthyInstancePercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#max_unhealthy_upgraded_instance_percent VirtualMachineScaleSet#max_unhealthy_upgraded_instance_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnhealthyUpgradedInstancePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnhealthyUpgradedInstancePercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#pause_time_between_batches VirtualMachineScaleSet#pause_time_between_batches}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pauseTimeBetweenBatches", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PauseTimeBetweenBatches
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
