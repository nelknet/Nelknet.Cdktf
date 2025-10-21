using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineKeyVaultCredential), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredential")]
    public interface IMssqlVirtualMachineKeyVaultCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#key_vault_url MssqlVirtualMachine#key_vault_url}.</summary>
        [JsiiProperty(name: "keyVaultUrl", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#name MssqlVirtualMachine#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#service_principal_name MssqlVirtualMachine#service_principal_name}.</summary>
        [JsiiProperty(name: "servicePrincipalName", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePrincipalName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#service_principal_secret MssqlVirtualMachine#service_principal_secret}.</summary>
        [JsiiProperty(name: "servicePrincipalSecret", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePrincipalSecret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineKeyVaultCredential), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredential")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineKeyVaultCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#key_vault_url MssqlVirtualMachine#key_vault_url}.</summary>
            [JsiiProperty(name: "keyVaultUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#name MssqlVirtualMachine#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#service_principal_name MssqlVirtualMachine#service_principal_name}.</summary>
            [JsiiProperty(name: "servicePrincipalName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePrincipalName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#service_principal_secret MssqlVirtualMachine#service_principal_secret}.</summary>
            [JsiiProperty(name: "servicePrincipalSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePrincipalSecret
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
