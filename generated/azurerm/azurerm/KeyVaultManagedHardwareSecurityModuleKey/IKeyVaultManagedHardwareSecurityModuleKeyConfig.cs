using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultManagedHardwareSecurityModuleKey
{
    [JsiiInterface(nativeType: typeof(IKeyVaultManagedHardwareSecurityModuleKeyConfig), fullyQualifiedName: "azurerm.keyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKeyConfig")]
    public interface IKeyVaultManagedHardwareSecurityModuleKeyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#key_opts KeyVaultManagedHardwareSecurityModuleKey#key_opts}.</summary>
        [JsiiProperty(name: "keyOpts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] KeyOpts
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#key_type KeyVaultManagedHardwareSecurityModuleKey#key_type}.</summary>
        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        string KeyType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#managed_hsm_id KeyVaultManagedHardwareSecurityModuleKey#managed_hsm_id}.</summary>
        [JsiiProperty(name: "managedHsmId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedHsmId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#name KeyVaultManagedHardwareSecurityModuleKey#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#curve KeyVaultManagedHardwareSecurityModuleKey#curve}.</summary>
        [JsiiProperty(name: "curve", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Curve
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#expiration_date KeyVaultManagedHardwareSecurityModuleKey#expiration_date}.</summary>
        [JsiiProperty(name: "expirationDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpirationDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#id KeyVaultManagedHardwareSecurityModuleKey#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#key_size KeyVaultManagedHardwareSecurityModuleKey#key_size}.</summary>
        [JsiiProperty(name: "keySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeySize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#not_before_date KeyVaultManagedHardwareSecurityModuleKey#not_before_date}.</summary>
        [JsiiProperty(name: "notBeforeDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotBeforeDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#tags KeyVaultManagedHardwareSecurityModuleKey#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#timeouts KeyVaultManagedHardwareSecurityModuleKey#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.keyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKeyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KeyVaultManagedHardwareSecurityModuleKey.IKeyVaultManagedHardwareSecurityModuleKeyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultManagedHardwareSecurityModuleKeyConfig), fullyQualifiedName: "azurerm.keyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKeyConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultManagedHardwareSecurityModuleKey.IKeyVaultManagedHardwareSecurityModuleKeyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#key_opts KeyVaultManagedHardwareSecurityModuleKey#key_opts}.</summary>
            [JsiiProperty(name: "keyOpts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] KeyOpts
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#key_type KeyVaultManagedHardwareSecurityModuleKey#key_type}.</summary>
            [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#managed_hsm_id KeyVaultManagedHardwareSecurityModuleKey#managed_hsm_id}.</summary>
            [JsiiProperty(name: "managedHsmId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedHsmId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#name KeyVaultManagedHardwareSecurityModuleKey#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#curve KeyVaultManagedHardwareSecurityModuleKey#curve}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "curve", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Curve
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#expiration_date KeyVaultManagedHardwareSecurityModuleKey#expiration_date}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expirationDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpirationDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#id KeyVaultManagedHardwareSecurityModuleKey#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#key_size KeyVaultManagedHardwareSecurityModuleKey#key_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeySize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#not_before_date KeyVaultManagedHardwareSecurityModuleKey#not_before_date}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notBeforeDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotBeforeDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#tags KeyVaultManagedHardwareSecurityModuleKey#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#timeouts KeyVaultManagedHardwareSecurityModuleKey#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.keyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKeyTimeouts\"}", isOptional: true)]
            public azurerm.KeyVaultManagedHardwareSecurityModuleKey.IKeyVaultManagedHardwareSecurityModuleKeyTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.KeyVaultManagedHardwareSecurityModuleKey.IKeyVaultManagedHardwareSecurityModuleKeyTimeouts?>();
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
