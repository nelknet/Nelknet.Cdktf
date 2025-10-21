using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory aws_workspaces_directory}.</summary>
    [JsiiClass(nativeType: typeof(aws.WorkspacesDirectory.WorkspacesDirectory), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectory", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryConfig\"}}]")]
    public class WorkspacesDirectory : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory aws_workspaces_directory} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WorkspacesDirectory(Constructs.Construct scope, string id, aws.WorkspacesDirectory.IWorkspacesDirectoryConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.WorkspacesDirectory.IWorkspacesDirectoryConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesDirectory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesDirectory(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a WorkspacesDirectory resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WorkspacesDirectory to import.</param>
        /// <param name="importFromId">The id of the existing WorkspacesDirectory that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WorkspacesDirectory to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WorkspacesDirectory to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WorkspacesDirectory that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WorkspacesDirectory to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.WorkspacesDirectory.WorkspacesDirectory), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putActiveDirectoryConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryActiveDirectoryConfig\"}}]")]
        public virtual void PutActiveDirectoryConfig(aws.WorkspacesDirectory.IWorkspacesDirectoryActiveDirectoryConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WorkspacesDirectory.IWorkspacesDirectoryActiveDirectoryConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificateBasedAuthProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryCertificateBasedAuthProperties\"}}]")]
        public virtual void PutCertificateBasedAuthProperties(aws.WorkspacesDirectory.IWorkspacesDirectoryCertificateBasedAuthProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WorkspacesDirectory.IWorkspacesDirectoryCertificateBasedAuthProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSamlProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySamlProperties\"}}]")]
        public virtual void PutSamlProperties(aws.WorkspacesDirectory.IWorkspacesDirectorySamlProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WorkspacesDirectory.IWorkspacesDirectorySamlProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSelfServicePermissions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySelfServicePermissions\"}}]")]
        public virtual void PutSelfServicePermissions(aws.WorkspacesDirectory.IWorkspacesDirectorySelfServicePermissions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WorkspacesDirectory.IWorkspacesDirectorySelfServicePermissions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkspaceAccessProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessProperties\"}}]")]
        public virtual void PutWorkspaceAccessProperties(aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkspaceCreationProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceCreationProperties\"}}]")]
        public virtual void PutWorkspaceCreationProperties(aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceCreationProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceCreationProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveDirectoryConfig")]
        public virtual void ResetActiveDirectoryConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateBasedAuthProperties")]
        public virtual void ResetCertificateBasedAuthProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDirectoryId")]
        public virtual void ResetDirectoryId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpGroupIds")]
        public virtual void ResetIpGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSamlProperties")]
        public virtual void ResetSamlProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSelfServicePermissions")]
        public virtual void ResetSelfServicePermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetIds")]
        public virtual void ResetSubnetIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserIdentityType")]
        public virtual void ResetUserIdentityType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkspaceAccessProperties")]
        public virtual void ResetWorkspaceAccessProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkspaceCreationProperties")]
        public virtual void ResetWorkspaceCreationProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkspaceDirectoryDescription")]
        public virtual void ResetWorkspaceDirectoryDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkspaceDirectoryName")]
        public virtual void ResetWorkspaceDirectoryName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkspaceType")]
        public virtual void ResetWorkspaceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.WorkspacesDirectory.WorkspacesDirectory))!;

        [JsiiProperty(name: "activeDirectoryConfig", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryActiveDirectoryConfigOutputReference\"}")]
        public virtual aws.WorkspacesDirectory.WorkspacesDirectoryActiveDirectoryConfigOutputReference ActiveDirectoryConfig
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.WorkspacesDirectoryActiveDirectoryConfigOutputReference>()!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateBasedAuthProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryCertificateBasedAuthPropertiesOutputReference\"}")]
        public virtual aws.WorkspacesDirectory.WorkspacesDirectoryCertificateBasedAuthPropertiesOutputReference CertificateBasedAuthProperties
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.WorkspacesDirectoryCertificateBasedAuthPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "customerUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "iamRoleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRoleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registrationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "samlProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySamlPropertiesOutputReference\"}")]
        public virtual aws.WorkspacesDirectory.WorkspacesDirectorySamlPropertiesOutputReference SamlProperties
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.WorkspacesDirectorySamlPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "selfServicePermissions", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySelfServicePermissionsOutputReference\"}")]
        public virtual aws.WorkspacesDirectory.WorkspacesDirectorySelfServicePermissionsOutputReference SelfServicePermissions
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.WorkspacesDirectorySelfServicePermissionsOutputReference>()!;
        }

        [JsiiProperty(name: "workspaceAccessProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesOutputReference\"}")]
        public virtual aws.WorkspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesOutputReference WorkspaceAccessProperties
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "workspaceCreationProperties", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceCreationPropertiesOutputReference\"}")]
        public virtual aws.WorkspacesDirectory.WorkspacesDirectoryWorkspaceCreationPropertiesOutputReference WorkspaceCreationProperties
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.WorkspacesDirectoryWorkspaceCreationPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "workspaceSecurityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceSecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryConfigInput", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryActiveDirectoryConfig\"}", isOptional: true)]
        public virtual aws.WorkspacesDirectory.IWorkspacesDirectoryActiveDirectoryConfig? ActiveDirectoryConfigInput
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectoryActiveDirectoryConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateBasedAuthPropertiesInput", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryCertificateBasedAuthProperties\"}", isOptional: true)]
        public virtual aws.WorkspacesDirectory.IWorkspacesDirectoryCertificateBasedAuthProperties? CertificateBasedAuthPropertiesInput
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectoryCertificateBasedAuthProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IpGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlPropertiesInput", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySamlProperties\"}", isOptional: true)]
        public virtual aws.WorkspacesDirectory.IWorkspacesDirectorySamlProperties? SamlPropertiesInput
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectorySamlProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selfServicePermissionsInput", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectorySelfServicePermissions\"}", isOptional: true)]
        public virtual aws.WorkspacesDirectory.IWorkspacesDirectorySelfServicePermissions? SelfServicePermissionsInput
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectorySelfServicePermissions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userIdentityTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserIdentityTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceAccessPropertiesInput", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessProperties\"}", isOptional: true)]
        public virtual aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessProperties? WorkspaceAccessPropertiesInput
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceCreationPropertiesInput", typeJson: "{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceCreationProperties\"}", isOptional: true)]
        public virtual aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceCreationProperties? WorkspaceCreationPropertiesInput
        {
            get => GetInstanceProperty<aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceCreationProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceDirectoryDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceDirectoryDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceDirectoryNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceDirectoryNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userIdentityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserIdentityType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceDirectoryDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceDirectoryDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceDirectoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceDirectoryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
