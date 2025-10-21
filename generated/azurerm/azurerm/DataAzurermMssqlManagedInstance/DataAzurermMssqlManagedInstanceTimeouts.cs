using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlManagedInstance
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstanceTimeouts")]
    public class DataAzurermMssqlManagedInstanceTimeouts : azurerm.DataAzurermMssqlManagedInstance.IDataAzurermMssqlManagedInstanceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_managed_instance#read DataAzurermMssqlManagedInstance#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
