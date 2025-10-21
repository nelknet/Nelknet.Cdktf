using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebUserSettings
{
    [JsiiInterface(nativeType: typeof(IWorkspaceswebUserSettingsCookieSynchronizationConfiguration), fullyQualifiedName: "aws.workspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfiguration")]
    public interface IWorkspaceswebUserSettingsCookieSynchronizationConfiguration
    {
        /// <summary>allowlist block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#allowlist WorkspaceswebUserSettings#allowlist}
        /// </remarks>
        [JsiiProperty(name: "allowlist", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfigurationAllowlistStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Allowlist
        {
            get
            {
                return null;
            }
        }

        /// <summary>blocklist block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#blocklist WorkspaceswebUserSettings#blocklist}
        /// </remarks>
        [JsiiProperty(name: "blocklist", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfigurationBlocklistStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Blocklist
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspaceswebUserSettingsCookieSynchronizationConfiguration), fullyQualifiedName: "aws.workspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspaceswebUserSettings.IWorkspaceswebUserSettingsCookieSynchronizationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allowlist block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#allowlist WorkspaceswebUserSettings#allowlist}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowlist", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfigurationAllowlistStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Allowlist
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>blocklist block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#blocklist WorkspaceswebUserSettings#blocklist}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blocklist", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfigurationBlocklistStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Blocklist
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
