using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTokenPassword
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryTokenPasswordConfig), fullyQualifiedName: "azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordConfig")]
    public interface IContainerRegistryTokenPasswordConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#container_registry_token_id ContainerRegistryTokenPassword#container_registry_token_id}.</summary>
        [JsiiProperty(name: "containerRegistryTokenId", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerRegistryTokenId
        {
            get;
        }

        /// <summary>password1 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#password1 ContainerRegistryTokenPassword#password1}
        /// </remarks>
        [JsiiProperty(name: "password1", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword1\"}")]
        azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword1 Password1
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#id ContainerRegistryTokenPassword#id}.</summary>
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

        /// <summary>password2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#password2 ContainerRegistryTokenPassword#password2}
        /// </remarks>
        [JsiiProperty(name: "password2", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2? Password2
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#timeouts ContainerRegistryTokenPassword#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryTokenPasswordConfig), fullyQualifiedName: "azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#container_registry_token_id ContainerRegistryTokenPassword#container_registry_token_id}.</summary>
            [JsiiProperty(name: "containerRegistryTokenId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerRegistryTokenId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>password1 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#password1 ContainerRegistryTokenPassword#password1}
            /// </remarks>
            [JsiiProperty(name: "password1", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword1\"}")]
            public azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword1 Password1
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword1>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#id ContainerRegistryTokenPassword#id}.</summary>
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

            /// <summary>password2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#password2 ContainerRegistryTokenPassword#password2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password2", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2\"}", isOptional: true)]
            public azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2? Password2
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#timeouts ContainerRegistryTokenPassword#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordTimeouts\"}", isOptional: true)]
            public azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordTimeouts?>();
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
