using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachineGroup
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineGroupWsfcDomainProfile), fullyQualifiedName: "azurerm.mssqlVirtualMachineGroup.MssqlVirtualMachineGroupWsfcDomainProfile")]
    public interface IMssqlVirtualMachineGroupWsfcDomainProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#cluster_subnet_type MssqlVirtualMachineGroup#cluster_subnet_type}.</summary>
        [JsiiProperty(name: "clusterSubnetType", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterSubnetType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#fqdn MssqlVirtualMachineGroup#fqdn}.</summary>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        string Fqdn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#cluster_bootstrap_account_name MssqlVirtualMachineGroup#cluster_bootstrap_account_name}.</summary>
        [JsiiProperty(name: "clusterBootstrapAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterBootstrapAccountName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#cluster_operator_account_name MssqlVirtualMachineGroup#cluster_operator_account_name}.</summary>
        [JsiiProperty(name: "clusterOperatorAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterOperatorAccountName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#organizational_unit_path MssqlVirtualMachineGroup#organizational_unit_path}.</summary>
        [JsiiProperty(name: "organizationalUnitPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationalUnitPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#sql_service_account_name MssqlVirtualMachineGroup#sql_service_account_name}.</summary>
        [JsiiProperty(name: "sqlServiceAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqlServiceAccountName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#storage_account_primary_key MssqlVirtualMachineGroup#storage_account_primary_key}.</summary>
        [JsiiProperty(name: "storageAccountPrimaryKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountPrimaryKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#storage_account_url MssqlVirtualMachineGroup#storage_account_url}.</summary>
        [JsiiProperty(name: "storageAccountUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineGroupWsfcDomainProfile), fullyQualifiedName: "azurerm.mssqlVirtualMachineGroup.MssqlVirtualMachineGroupWsfcDomainProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachineGroup.IMssqlVirtualMachineGroupWsfcDomainProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#cluster_subnet_type MssqlVirtualMachineGroup#cluster_subnet_type}.</summary>
            [JsiiProperty(name: "clusterSubnetType", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterSubnetType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#fqdn MssqlVirtualMachineGroup#fqdn}.</summary>
            [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
            public string Fqdn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#cluster_bootstrap_account_name MssqlVirtualMachineGroup#cluster_bootstrap_account_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterBootstrapAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterBootstrapAccountName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#cluster_operator_account_name MssqlVirtualMachineGroup#cluster_operator_account_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterOperatorAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterOperatorAccountName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#organizational_unit_path MssqlVirtualMachineGroup#organizational_unit_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "organizationalUnitPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationalUnitPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#sql_service_account_name MssqlVirtualMachineGroup#sql_service_account_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlServiceAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqlServiceAccountName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#storage_account_primary_key MssqlVirtualMachineGroup#storage_account_primary_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountPrimaryKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountPrimaryKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#storage_account_url MssqlVirtualMachineGroup#storage_account_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
