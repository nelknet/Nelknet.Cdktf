using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineStorageConfigurationLogSettings), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationLogSettings")]
    public interface IMssqlVirtualMachineStorageConfigurationLogSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#default_file_path MssqlVirtualMachine#default_file_path}.</summary>
        [JsiiProperty(name: "defaultFilePath", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultFilePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#luns MssqlVirtualMachine#luns}.</summary>
        [JsiiProperty(name: "luns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] Luns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineStorageConfigurationLogSettings), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationLogSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationLogSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#default_file_path MssqlVirtualMachine#default_file_path}.</summary>
            [JsiiProperty(name: "defaultFilePath", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultFilePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#luns MssqlVirtualMachine#luns}.</summary>
            [JsiiProperty(name: "luns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] Luns
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
