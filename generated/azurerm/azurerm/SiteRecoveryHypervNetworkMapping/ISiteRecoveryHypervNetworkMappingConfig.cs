using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryHypervNetworkMapping
{
    [JsiiInterface(nativeType: typeof(ISiteRecoveryHypervNetworkMappingConfig), fullyQualifiedName: "azurerm.siteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMappingConfig")]
    public interface ISiteRecoveryHypervNetworkMappingConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#name SiteRecoveryHypervNetworkMapping#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#recovery_vault_id SiteRecoveryHypervNetworkMapping#recovery_vault_id}.</summary>
        [JsiiProperty(name: "recoveryVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string RecoveryVaultId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#source_network_name SiteRecoveryHypervNetworkMapping#source_network_name}.</summary>
        [JsiiProperty(name: "sourceNetworkName", typeJson: "{\"primitive\":\"string\"}")]
        string SourceNetworkName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#source_system_center_virtual_machine_manager_name SiteRecoveryHypervNetworkMapping#source_system_center_virtual_machine_manager_name}.</summary>
        [JsiiProperty(name: "sourceSystemCenterVirtualMachineManagerName", typeJson: "{\"primitive\":\"string\"}")]
        string SourceSystemCenterVirtualMachineManagerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#target_network_id SiteRecoveryHypervNetworkMapping#target_network_id}.</summary>
        [JsiiProperty(name: "targetNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetNetworkId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#id SiteRecoveryHypervNetworkMapping#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#timeouts SiteRecoveryHypervNetworkMapping#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.siteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMappingTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SiteRecoveryHypervNetworkMapping.ISiteRecoveryHypervNetworkMappingTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISiteRecoveryHypervNetworkMappingConfig), fullyQualifiedName: "azurerm.siteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMappingConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SiteRecoveryHypervNetworkMapping.ISiteRecoveryHypervNetworkMappingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#name SiteRecoveryHypervNetworkMapping#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#recovery_vault_id SiteRecoveryHypervNetworkMapping#recovery_vault_id}.</summary>
            [JsiiProperty(name: "recoveryVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string RecoveryVaultId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#source_network_name SiteRecoveryHypervNetworkMapping#source_network_name}.</summary>
            [JsiiProperty(name: "sourceNetworkName", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceNetworkName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#source_system_center_virtual_machine_manager_name SiteRecoveryHypervNetworkMapping#source_system_center_virtual_machine_manager_name}.</summary>
            [JsiiProperty(name: "sourceSystemCenterVirtualMachineManagerName", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceSystemCenterVirtualMachineManagerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#target_network_id SiteRecoveryHypervNetworkMapping#target_network_id}.</summary>
            [JsiiProperty(name: "targetNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#id SiteRecoveryHypervNetworkMapping#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#timeouts SiteRecoveryHypervNetworkMapping#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.siteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMappingTimeouts\"}", isOptional: true)]
            public azurerm.SiteRecoveryHypervNetworkMapping.ISiteRecoveryHypervNetworkMappingTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SiteRecoveryHypervNetworkMapping.ISiteRecoveryHypervNetworkMappingTimeouts?>();
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
