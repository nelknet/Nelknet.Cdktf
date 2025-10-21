using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsWorkspacesDirectory
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_directory aws_workspaces_directory}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectory), fullyQualifiedName: "aws.dataAwsWorkspacesDirectory.DataAwsWorkspacesDirectory", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryConfig\"}}]")]
    public class DataAwsWorkspacesDirectory : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_directory aws_workspaces_directory} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsWorkspacesDirectory(Constructs.Construct scope, string id, aws.DataAwsWorkspacesDirectory.IDataAwsWorkspacesDirectoryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsWorkspacesDirectory.IDataAwsWorkspacesDirectoryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectory(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsWorkspacesDirectory resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsWorkspacesDirectory to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsWorkspacesDirectory that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsWorkspacesDirectory to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsWorkspacesDirectory to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_directory#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsWorkspacesDirectory that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsWorkspacesDirectory to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectory), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectory))!;

        [JsiiProperty(name: "activeDirectoryConfig", typeJson: "{\"fqn\":\"aws.dataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryActiveDirectoryConfigList\"}")]
        public virtual aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryActiveDirectoryConfigList ActiveDirectoryConfig
        {
            get => GetInstanceProperty<aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryActiveDirectoryConfigList>()!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateBasedAuthProperties", typeJson: "{\"fqn\":\"aws.dataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryCertificateBasedAuthPropertiesList\"}")]
        public virtual aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryCertificateBasedAuthPropertiesList CertificateBasedAuthProperties
        {
            get => GetInstanceProperty<aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryCertificateBasedAuthPropertiesList>()!;
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

        [JsiiProperty(name: "ipGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "registrationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "samlProperties", typeJson: "{\"fqn\":\"aws.dataAwsWorkspacesDirectory.DataAwsWorkspacesDirectorySamlPropertiesList\"}")]
        public virtual aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectorySamlPropertiesList SamlProperties
        {
            get => GetInstanceProperty<aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectorySamlPropertiesList>()!;
        }

        [JsiiProperty(name: "selfServicePermissions", typeJson: "{\"fqn\":\"aws.dataAwsWorkspacesDirectory.DataAwsWorkspacesDirectorySelfServicePermissionsList\"}")]
        public virtual aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectorySelfServicePermissionsList SelfServicePermissions
        {
            get => GetInstanceProperty<aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectorySelfServicePermissionsList>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "userIdentityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserIdentityType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workspaceAccessProperties", typeJson: "{\"fqn\":\"aws.dataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryWorkspaceAccessPropertiesList\"}")]
        public virtual aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryWorkspaceAccessPropertiesList WorkspaceAccessProperties
        {
            get => GetInstanceProperty<aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryWorkspaceAccessPropertiesList>()!;
        }

        [JsiiProperty(name: "workspaceCreationProperties", typeJson: "{\"fqn\":\"aws.dataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryWorkspaceCreationPropertiesList\"}")]
        public virtual aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryWorkspaceCreationPropertiesList WorkspaceCreationProperties
        {
            get => GetInstanceProperty<aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryWorkspaceCreationPropertiesList>()!;
        }

        [JsiiProperty(name: "workspaceDirectoryDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceDirectoryDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workspaceDirectoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceDirectoryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workspaceSecurityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceSecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workspaceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceType
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
