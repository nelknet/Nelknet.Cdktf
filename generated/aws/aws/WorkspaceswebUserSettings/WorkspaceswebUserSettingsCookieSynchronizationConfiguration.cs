using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebUserSettings
{
    [JsiiByValue(fqn: "aws.workspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfiguration")]
    public class WorkspaceswebUserSettingsCookieSynchronizationConfiguration : aws.WorkspaceswebUserSettings.IWorkspaceswebUserSettingsCookieSynchronizationConfiguration
    {
        private object? _allowlist;

        /// <summary>allowlist block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#allowlist WorkspaceswebUserSettings#allowlist}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowlist", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfigurationAllowlistStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Allowlist
        {
            get => _allowlist;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.WorkspaceswebUserSettings.IWorkspaceswebUserSettingsCookieSynchronizationConfigurationAllowlistStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.WorkspaceswebUserSettings.IWorkspaceswebUserSettingsCookieSynchronizationConfigurationAllowlistStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowlist = value;
            }
        }

        private object? _blocklist;

        /// <summary>blocklist block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#blocklist WorkspaceswebUserSettings#blocklist}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blocklist", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfigurationBlocklistStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Blocklist
        {
            get => _blocklist;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.WorkspaceswebUserSettings.IWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlocklistStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.WorkspaceswebUserSettings.IWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlocklistStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _blocklist = value;
            }
        }
    }
}
