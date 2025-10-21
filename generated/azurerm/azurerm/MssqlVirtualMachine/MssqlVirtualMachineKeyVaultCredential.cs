using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredential")]
    public class MssqlVirtualMachineKeyVaultCredential : azurerm.MssqlVirtualMachine.IMssqlVirtualMachineKeyVaultCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#key_vault_url MssqlVirtualMachine#key_vault_url}.</summary>
        [JsiiProperty(name: "keyVaultUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#name MssqlVirtualMachine#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#service_principal_name MssqlVirtualMachine#service_principal_name}.</summary>
        [JsiiProperty(name: "servicePrincipalName", typeJson: "{\"primitive\":\"string\"}")]
        public string ServicePrincipalName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#service_principal_secret MssqlVirtualMachine#service_principal_secret}.</summary>
        [JsiiProperty(name: "servicePrincipalSecret", typeJson: "{\"primitive\":\"string\"}")]
        public string ServicePrincipalSecret
        {
            get;
            set;
        }
    }
}
