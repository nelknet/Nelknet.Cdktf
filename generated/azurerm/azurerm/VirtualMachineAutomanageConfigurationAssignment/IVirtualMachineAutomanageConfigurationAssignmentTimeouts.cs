using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineAutomanageConfigurationAssignment
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineAutomanageConfigurationAssignmentTimeouts), fullyQualifiedName: "azurerm.virtualMachineAutomanageConfigurationAssignment.VirtualMachineAutomanageConfigurationAssignmentTimeouts")]
    public interface IVirtualMachineAutomanageConfigurationAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#create VirtualMachineAutomanageConfigurationAssignment#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#delete VirtualMachineAutomanageConfigurationAssignment#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#read VirtualMachineAutomanageConfigurationAssignment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineAutomanageConfigurationAssignmentTimeouts), fullyQualifiedName: "azurerm.virtualMachineAutomanageConfigurationAssignment.VirtualMachineAutomanageConfigurationAssignmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineAutomanageConfigurationAssignment.IVirtualMachineAutomanageConfigurationAssignmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#create VirtualMachineAutomanageConfigurationAssignment#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#delete VirtualMachineAutomanageConfigurationAssignment#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_automanage_configuration_assignment#read VirtualMachineAutomanageConfigurationAssignment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
