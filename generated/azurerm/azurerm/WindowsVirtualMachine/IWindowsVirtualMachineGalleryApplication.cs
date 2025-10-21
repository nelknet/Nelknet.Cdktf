using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineGalleryApplication), fullyQualifiedName: "azurerm.windowsVirtualMachine.WindowsVirtualMachineGalleryApplication")]
    public interface IWindowsVirtualMachineGalleryApplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#version_id WindowsVirtualMachine#version_id}.</summary>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        string VersionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#automatic_upgrade_enabled WindowsVirtualMachine#automatic_upgrade_enabled}.</summary>
        [JsiiProperty(name: "automaticUpgradeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutomaticUpgradeEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#configuration_blob_uri WindowsVirtualMachine#configuration_blob_uri}.</summary>
        [JsiiProperty(name: "configurationBlobUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigurationBlobUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#order WindowsVirtualMachine#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Order
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#tag WindowsVirtualMachine#tag}.</summary>
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#treat_failure_as_deployment_failure_enabled WindowsVirtualMachine#treat_failure_as_deployment_failure_enabled}.</summary>
        [JsiiProperty(name: "treatFailureAsDeploymentFailureEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TreatFailureAsDeploymentFailureEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineGalleryApplication), fullyQualifiedName: "azurerm.windowsVirtualMachine.WindowsVirtualMachineGalleryApplication")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsVirtualMachine.IWindowsVirtualMachineGalleryApplication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#version_id WindowsVirtualMachine#version_id}.</summary>
            [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
            public string VersionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#automatic_upgrade_enabled WindowsVirtualMachine#automatic_upgrade_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticUpgradeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutomaticUpgradeEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#configuration_blob_uri WindowsVirtualMachine#configuration_blob_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configurationBlobUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigurationBlobUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#order WindowsVirtualMachine#order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#tag WindowsVirtualMachine#tag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#treat_failure_as_deployment_failure_enabled WindowsVirtualMachine#treat_failure_as_deployment_failure_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "treatFailureAsDeploymentFailureEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TreatFailureAsDeploymentFailureEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
