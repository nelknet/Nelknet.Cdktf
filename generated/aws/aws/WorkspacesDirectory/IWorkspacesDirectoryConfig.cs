using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    [JsiiInterface(nativeType: typeof(IWorkspacesDirectoryConfig), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectoryConfig")]
    public interface IWorkspacesDirectoryConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>active_directory_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#active_directory_config WorkspacesDirectory#active_directory_config}
        /// </remarks>
        [JsiiProperty(name: "activeDirectoryConfig", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryActiveDirectoryConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.WorkspacesDirectory.IWorkspacesDirectoryActiveDirectoryConfig? ActiveDirectoryConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>certificate_based_auth_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#certificate_based_auth_properties WorkspacesDirectory#certificate_based_auth_properties}
        /// </remarks>
        [JsiiProperty(name: "certificateBasedAuthProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryCertificateBasedAuthProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.WorkspacesDirectory.IWorkspacesDirectoryCertificateBasedAuthProperties? CertificateBasedAuthProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#directory_id WorkspacesDirectory#directory_id}.</summary>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#id WorkspacesDirectory#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#ip_group_ids WorkspacesDirectory#ip_group_ids}.</summary>
        [JsiiProperty(name: "ipGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>saml_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#saml_properties WorkspacesDirectory#saml_properties}
        /// </remarks>
        [JsiiProperty(name: "samlProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySamlProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.WorkspacesDirectory.IWorkspacesDirectorySamlProperties? SamlProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>self_service_permissions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#self_service_permissions WorkspacesDirectory#self_service_permissions}
        /// </remarks>
        [JsiiProperty(name: "selfServicePermissions", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySelfServicePermissions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.WorkspacesDirectory.IWorkspacesDirectorySelfServicePermissions? SelfServicePermissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#subnet_ids WorkspacesDirectory#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubnetIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#tags WorkspacesDirectory#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#tags_all WorkspacesDirectory#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#user_identity_type WorkspacesDirectory#user_identity_type}.</summary>
        [JsiiProperty(name: "userIdentityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserIdentityType
        {
            get
            {
                return null;
            }
        }

        /// <summary>workspace_access_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_access_properties WorkspacesDirectory#workspace_access_properties}
        /// </remarks>
        [JsiiProperty(name: "workspaceAccessProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessProperties? WorkspaceAccessProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>workspace_creation_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_creation_properties WorkspacesDirectory#workspace_creation_properties}
        /// </remarks>
        [JsiiProperty(name: "workspaceCreationProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceCreationProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceCreationProperties? WorkspaceCreationProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_directory_description WorkspacesDirectory#workspace_directory_description}.</summary>
        [JsiiProperty(name: "workspaceDirectoryDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkspaceDirectoryDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_directory_name WorkspacesDirectory#workspace_directory_name}.</summary>
        [JsiiProperty(name: "workspaceDirectoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkspaceDirectoryName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_type WorkspacesDirectory#workspace_type}.</summary>
        [JsiiProperty(name: "workspaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkspaceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesDirectoryConfig), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectoryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspacesDirectory.IWorkspacesDirectoryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>active_directory_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#active_directory_config WorkspacesDirectory#active_directory_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeDirectoryConfig", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryActiveDirectoryConfig\"}", isOptional: true)]
            public aws.WorkspacesDirectory.IWorkspacesDirectoryActiveDirectoryConfig? ActiveDirectoryConfig
            {
                get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectoryActiveDirectoryConfig?>();
            }

            /// <summary>certificate_based_auth_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#certificate_based_auth_properties WorkspacesDirectory#certificate_based_auth_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateBasedAuthProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryCertificateBasedAuthProperties\"}", isOptional: true)]
            public aws.WorkspacesDirectory.IWorkspacesDirectoryCertificateBasedAuthProperties? CertificateBasedAuthProperties
            {
                get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectoryCertificateBasedAuthProperties?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#directory_id WorkspacesDirectory#directory_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#id WorkspacesDirectory#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#ip_group_ids WorkspacesDirectory#ip_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>saml_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#saml_properties WorkspacesDirectory#saml_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "samlProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySamlProperties\"}", isOptional: true)]
            public aws.WorkspacesDirectory.IWorkspacesDirectorySamlProperties? SamlProperties
            {
                get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectorySamlProperties?>();
            }

            /// <summary>self_service_permissions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#self_service_permissions WorkspacesDirectory#self_service_permissions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfServicePermissions", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySelfServicePermissions\"}", isOptional: true)]
            public aws.WorkspacesDirectory.IWorkspacesDirectorySelfServicePermissions? SelfServicePermissions
            {
                get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectorySelfServicePermissions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#subnet_ids WorkspacesDirectory#subnet_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubnetIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#tags WorkspacesDirectory#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#tags_all WorkspacesDirectory#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#user_identity_type WorkspacesDirectory#user_identity_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userIdentityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserIdentityType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>workspace_access_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_access_properties WorkspacesDirectory#workspace_access_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workspaceAccessProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessProperties\"}", isOptional: true)]
            public aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessProperties? WorkspaceAccessProperties
            {
                get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessProperties?>();
            }

            /// <summary>workspace_creation_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_creation_properties WorkspacesDirectory#workspace_creation_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workspaceCreationProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceCreationProperties\"}", isOptional: true)]
            public aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceCreationProperties? WorkspaceCreationProperties
            {
                get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceCreationProperties?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_directory_description WorkspacesDirectory#workspace_directory_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workspaceDirectoryDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkspaceDirectoryDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_directory_name WorkspacesDirectory#workspace_directory_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workspaceDirectoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkspaceDirectoryName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_type WorkspacesDirectory#workspace_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workspaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkspaceType
            {
                get => GetInstanceProperty<string?>();
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
