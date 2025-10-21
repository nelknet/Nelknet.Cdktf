using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachineGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachineGroup.MssqlVirtualMachineGroupWsfcDomainProfile")]
    public class MssqlVirtualMachineGroupWsfcDomainProfile : azurerm.MssqlVirtualMachineGroup.IMssqlVirtualMachineGroupWsfcDomainProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#cluster_subnet_type MssqlVirtualMachineGroup#cluster_subnet_type}.</summary>
        [JsiiProperty(name: "clusterSubnetType", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterSubnetType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#fqdn MssqlVirtualMachineGroup#fqdn}.</summary>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public string Fqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#cluster_bootstrap_account_name MssqlVirtualMachineGroup#cluster_bootstrap_account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterBootstrapAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterBootstrapAccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#cluster_operator_account_name MssqlVirtualMachineGroup#cluster_operator_account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterOperatorAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterOperatorAccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#organizational_unit_path MssqlVirtualMachineGroup#organizational_unit_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnitPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationalUnitPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#sql_service_account_name MssqlVirtualMachineGroup#sql_service_account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlServiceAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SqlServiceAccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#storage_account_primary_key MssqlVirtualMachineGroup#storage_account_primary_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountPrimaryKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountPrimaryKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#storage_account_url MssqlVirtualMachineGroup#storage_account_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountUrl
        {
            get;
            set;
        }
    }
}
