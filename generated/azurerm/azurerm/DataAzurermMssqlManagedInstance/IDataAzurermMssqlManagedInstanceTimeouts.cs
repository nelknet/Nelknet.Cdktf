using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlManagedInstance
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMssqlManagedInstanceTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstanceTimeouts")]
    public interface IDataAzurermMssqlManagedInstanceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_managed_instance#read DataAzurermMssqlManagedInstance#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMssqlManagedInstanceTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlManagedInstance.DataAzurermMssqlManagedInstanceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMssqlManagedInstance.IDataAzurermMssqlManagedInstanceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_managed_instance#read DataAzurermMssqlManagedInstance#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
