using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineConfig), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineConfig")]
    public interface IMssqlVirtualMachineConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#virtual_machine_id MssqlVirtualMachine#virtual_machine_id}.</summary>
        [JsiiProperty(name: "virtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualMachineId
        {
            get;
        }

        /// <summary>assessment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#assessment MssqlVirtualMachine#assessment}
        /// </remarks>
        [JsiiProperty(name: "assessment", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessment\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessment? Assessment
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_backup block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#auto_backup MssqlVirtualMachine#auto_backup}
        /// </remarks>
        [JsiiProperty(name: "autoBackup", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoBackup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoBackup? AutoBackup
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_patching block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#auto_patching MssqlVirtualMachine#auto_patching}
        /// </remarks>
        [JsiiProperty(name: "autoPatching", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoPatching\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoPatching? AutoPatching
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#id MssqlVirtualMachine#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_vault_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#key_vault_credential MssqlVirtualMachine#key_vault_credential}
        /// </remarks>
        [JsiiProperty(name: "keyVaultCredential", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredential\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineKeyVaultCredential? KeyVaultCredential
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#r_services_enabled MssqlVirtualMachine#r_services_enabled}.</summary>
        [JsiiProperty(name: "rServicesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RServicesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_port MssqlVirtualMachine#sql_connectivity_port}.</summary>
        [JsiiProperty(name: "sqlConnectivityPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SqlConnectivityPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_type MssqlVirtualMachine#sql_connectivity_type}.</summary>
        [JsiiProperty(name: "sqlConnectivityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqlConnectivityType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_update_password MssqlVirtualMachine#sql_connectivity_update_password}.</summary>
        [JsiiProperty(name: "sqlConnectivityUpdatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqlConnectivityUpdatePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_update_username MssqlVirtualMachine#sql_connectivity_update_username}.</summary>
        [JsiiProperty(name: "sqlConnectivityUpdateUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqlConnectivityUpdateUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>sql_instance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_instance MssqlVirtualMachine#sql_instance}
        /// </remarks>
        [JsiiProperty(name: "sqlInstance", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineSqlInstance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineSqlInstance? SqlInstance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_license_type MssqlVirtualMachine#sql_license_type}.</summary>
        [JsiiProperty(name: "sqlLicenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqlLicenseType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_virtual_machine_group_id MssqlVirtualMachine#sql_virtual_machine_group_id}.</summary>
        [JsiiProperty(name: "sqlVirtualMachineGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqlVirtualMachineGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#storage_configuration MssqlVirtualMachine#storage_configuration}
        /// </remarks>
        [JsiiProperty(name: "storageConfiguration", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfiguration? StorageConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#tags MssqlVirtualMachine#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#timeouts MssqlVirtualMachine#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>wsfc_domain_credential block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#wsfc_domain_credential MssqlVirtualMachine#wsfc_domain_credential}
        /// </remarks>
        [JsiiProperty(name: "wsfcDomainCredential", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredential\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineWsfcDomainCredential? WsfcDomainCredential
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineConfig), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#virtual_machine_id MssqlVirtualMachine#virtual_machine_id}.</summary>
            [JsiiProperty(name: "virtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualMachineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>assessment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#assessment MssqlVirtualMachine#assessment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assessment", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessment\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessment? Assessment
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessment?>();
            }

            /// <summary>auto_backup block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#auto_backup MssqlVirtualMachine#auto_backup}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoBackup", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoBackup\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoBackup? AutoBackup
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoBackup?>();
            }

            /// <summary>auto_patching block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#auto_patching MssqlVirtualMachine#auto_patching}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoPatching", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoPatching\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoPatching? AutoPatching
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoPatching?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#id MssqlVirtualMachine#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>key_vault_credential block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#key_vault_credential MssqlVirtualMachine#key_vault_credential}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultCredential", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredential\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineKeyVaultCredential? KeyVaultCredential
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineKeyVaultCredential?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#r_services_enabled MssqlVirtualMachine#r_services_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rServicesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RServicesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_port MssqlVirtualMachine#sql_connectivity_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlConnectivityPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SqlConnectivityPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_type MssqlVirtualMachine#sql_connectivity_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlConnectivityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqlConnectivityType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_update_password MssqlVirtualMachine#sql_connectivity_update_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlConnectivityUpdatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqlConnectivityUpdatePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_update_username MssqlVirtualMachine#sql_connectivity_update_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlConnectivityUpdateUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqlConnectivityUpdateUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>sql_instance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_instance MssqlVirtualMachine#sql_instance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqlInstance", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineSqlInstance\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineSqlInstance? SqlInstance
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineSqlInstance?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_license_type MssqlVirtualMachine#sql_license_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlLicenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqlLicenseType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_virtual_machine_group_id MssqlVirtualMachine#sql_virtual_machine_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlVirtualMachineGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqlVirtualMachineGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storage_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#storage_configuration MssqlVirtualMachine#storage_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageConfiguration", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfiguration\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfiguration? StorageConfiguration
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#tags MssqlVirtualMachine#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#timeouts MssqlVirtualMachine#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineTimeouts\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineTimeouts?>();
            }

            /// <summary>wsfc_domain_credential block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#wsfc_domain_credential MssqlVirtualMachine#wsfc_domain_credential}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wsfcDomainCredential", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredential\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineWsfcDomainCredential? WsfcDomainCredential
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineWsfcDomainCredential?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
