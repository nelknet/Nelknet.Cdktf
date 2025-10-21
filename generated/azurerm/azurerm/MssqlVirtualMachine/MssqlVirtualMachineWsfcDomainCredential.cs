using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredential")]
    public class MssqlVirtualMachineWsfcDomainCredential : azurerm.MssqlVirtualMachine.IMssqlVirtualMachineWsfcDomainCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#cluster_bootstrap_account_password MssqlVirtualMachine#cluster_bootstrap_account_password}.</summary>
        [JsiiProperty(name: "clusterBootstrapAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterBootstrapAccountPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#cluster_operator_account_password MssqlVirtualMachine#cluster_operator_account_password}.</summary>
        [JsiiProperty(name: "clusterOperatorAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterOperatorAccountPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_service_account_password MssqlVirtualMachine#sql_service_account_password}.</summary>
        [JsiiProperty(name: "sqlServiceAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string SqlServiceAccountPassword
        {
            get;
            set;
        }
    }
}
