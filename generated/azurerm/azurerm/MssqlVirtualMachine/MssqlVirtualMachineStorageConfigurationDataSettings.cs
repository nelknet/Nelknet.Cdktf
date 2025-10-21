using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationDataSettings")]
    public class MssqlVirtualMachineStorageConfigurationDataSettings : azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationDataSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#default_file_path MssqlVirtualMachine#default_file_path}.</summary>
        [JsiiProperty(name: "defaultFilePath", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultFilePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#luns MssqlVirtualMachine#luns}.</summary>
        [JsiiProperty(name: "luns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] Luns
        {
            get;
            set;
        }
    }
}
