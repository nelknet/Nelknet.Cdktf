using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineWsfcDomainCredential), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredential")]
    public interface IMssqlVirtualMachineWsfcDomainCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#cluster_bootstrap_account_password MssqlVirtualMachine#cluster_bootstrap_account_password}.</summary>
        [JsiiProperty(name: "clusterBootstrapAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterBootstrapAccountPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#cluster_operator_account_password MssqlVirtualMachine#cluster_operator_account_password}.</summary>
        [JsiiProperty(name: "clusterOperatorAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterOperatorAccountPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_service_account_password MssqlVirtualMachine#sql_service_account_password}.</summary>
        [JsiiProperty(name: "sqlServiceAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
        string SqlServiceAccountPassword
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineWsfcDomainCredential), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredential")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineWsfcDomainCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#cluster_bootstrap_account_password MssqlVirtualMachine#cluster_bootstrap_account_password}.</summary>
            [JsiiProperty(name: "clusterBootstrapAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterBootstrapAccountPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#cluster_operator_account_password MssqlVirtualMachine#cluster_operator_account_password}.</summary>
            [JsiiProperty(name: "clusterOperatorAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterOperatorAccountPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_service_account_password MssqlVirtualMachine#sql_service_account_password}.</summary>
            [JsiiProperty(name: "sqlServiceAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlServiceAccountPassword
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
