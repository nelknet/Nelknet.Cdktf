using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControlSlot
{
    [JsiiInterface(nativeType: typeof(IAppServiceSourceControlSlotConfig), fullyQualifiedName: "azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotConfig")]
    public interface IAppServiceSourceControlSlotConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>The ID of the Linux or Windows Web App Slot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#slot_id AppServiceSourceControlSlot#slot_id}
        /// </remarks>
        [JsiiProperty(name: "slotId", typeJson: "{\"primitive\":\"string\"}")]
        string SlotId
        {
            get;
        }

        /// <summary>The URL for the repository.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#branch AppServiceSourceControlSlot#branch}
        /// </remarks>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Branch
        {
            get
            {
                return null;
            }
        }

        /// <summary>github_action_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#github_action_configuration AppServiceSourceControlSlot#github_action_configuration}
        /// </remarks>
        [JsiiProperty(name: "githubActionConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfiguration? GithubActionConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#id AppServiceSourceControlSlot#id}.</summary>
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

        /// <summary>The branch name to use for deployments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#repo_url AppServiceSourceControlSlot#repo_url}
        /// </remarks>
        [JsiiProperty(name: "repoUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepoUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the Deployment Rollback be enabled? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#rollback_enabled AppServiceSourceControlSlot#rollback_enabled}
        /// </remarks>
        [JsiiProperty(name: "rollbackEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RollbackEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#timeouts AppServiceSourceControlSlot#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the Slot use local Git configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_local_git AppServiceSourceControlSlot#use_local_git}
        /// </remarks>
        [JsiiProperty(name: "useLocalGit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseLocalGit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should code be deployed manually.</summary>
        /// <remarks>
        /// Set to <c>true</c> to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to <c>false</c>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_manual_integration AppServiceSourceControlSlot#use_manual_integration}
        /// </remarks>
        [JsiiProperty(name: "useManualIntegration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseManualIntegration
        {
            get
            {
                return null;
            }
        }

        /// <summary>The repository specified is Mercurial. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_mercurial AppServiceSourceControlSlot#use_mercurial}
        /// </remarks>
        [JsiiProperty(name: "useMercurial", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseMercurial
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSourceControlSlotConfig), fullyQualifiedName: "azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the Linux or Windows Web App Slot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#slot_id AppServiceSourceControlSlot#slot_id}
            /// </remarks>
            [JsiiProperty(name: "slotId", typeJson: "{\"primitive\":\"string\"}")]
            public string SlotId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The URL for the repository.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#branch AppServiceSourceControlSlot#branch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Branch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>github_action_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#github_action_configuration AppServiceSourceControlSlot#github_action_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "githubActionConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfiguration\"}", isOptional: true)]
            public azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfiguration? GithubActionConfiguration
            {
                get => GetInstanceProperty<azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#id AppServiceSourceControlSlot#id}.</summary>
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

            /// <summary>The branch name to use for deployments.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#repo_url AppServiceSourceControlSlot#repo_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repoUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepoUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should the Deployment Rollback be enabled? Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#rollback_enabled AppServiceSourceControlSlot#rollback_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollbackEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RollbackEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#timeouts AppServiceSourceControlSlot#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotTimeouts\"}", isOptional: true)]
            public azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotTimeouts?>();
            }

            /// <summary>Should the Slot use local Git configuration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_local_git AppServiceSourceControlSlot#use_local_git}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useLocalGit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseLocalGit
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Should code be deployed manually.</summary>
            /// <remarks>
            /// Set to <c>true</c> to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to <c>false</c>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_manual_integration AppServiceSourceControlSlot#use_manual_integration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useManualIntegration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseManualIntegration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The repository specified is Mercurial. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_mercurial AppServiceSourceControlSlot#use_mercurial}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useMercurial", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseMercurial
            {
                get => GetInstanceProperty<object?>();
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
