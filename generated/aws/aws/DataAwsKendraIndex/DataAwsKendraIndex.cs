using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsKendraIndex
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_index aws_kendra_index}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsKendraIndex.DataAwsKendraIndex), fullyQualifiedName: "aws.dataAwsKendraIndex.DataAwsKendraIndex", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsKendraIndex.DataAwsKendraIndexConfig\"}}]")]
    public class DataAwsKendraIndex : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_index aws_kendra_index} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsKendraIndex(Constructs.Construct scope, string id, aws.DataAwsKendraIndex.IDataAwsKendraIndexConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsKendraIndex.IDataAwsKendraIndexConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKendraIndex(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKendraIndex(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsKendraIndex resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsKendraIndex to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsKendraIndex that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsKendraIndex to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsKendraIndex to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_index#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsKendraIndex that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsKendraIndex to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsKendraIndex.DataAwsKendraIndex), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsKendraIndex.DataAwsKendraIndex))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityUnits", typeJson: "{\"fqn\":\"aws.dataAwsKendraIndex.DataAwsKendraIndexCapacityUnitsList\"}")]
        public virtual aws.DataAwsKendraIndex.DataAwsKendraIndexCapacityUnitsList CapacityUnits
        {
            get => GetInstanceProperty<aws.DataAwsKendraIndex.DataAwsKendraIndexCapacityUnitsList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "documentMetadataConfigurationUpdates", typeJson: "{\"fqn\":\"aws.dataAwsKendraIndex.DataAwsKendraIndexDocumentMetadataConfigurationUpdatesList\"}")]
        public virtual aws.DataAwsKendraIndex.DataAwsKendraIndexDocumentMetadataConfigurationUpdatesList DocumentMetadataConfigurationUpdates
        {
            get => GetInstanceProperty<aws.DataAwsKendraIndex.DataAwsKendraIndexDocumentMetadataConfigurationUpdatesList>()!;
        }

        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Edition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "indexStatistics", typeJson: "{\"fqn\":\"aws.dataAwsKendraIndex.DataAwsKendraIndexIndexStatisticsList\"}")]
        public virtual aws.DataAwsKendraIndex.DataAwsKendraIndexIndexStatisticsList IndexStatistics
        {
            get => GetInstanceProperty<aws.DataAwsKendraIndex.DataAwsKendraIndexIndexStatisticsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsKendraIndex.DataAwsKendraIndexServerSideEncryptionConfigurationList\"}")]
        public virtual aws.DataAwsKendraIndex.DataAwsKendraIndexServerSideEncryptionConfigurationList ServerSideEncryptionConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsKendraIndex.DataAwsKendraIndexServerSideEncryptionConfigurationList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userContextPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserContextPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userGroupResolutionConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsKendraIndex.DataAwsKendraIndexUserGroupResolutionConfigurationList\"}")]
        public virtual aws.DataAwsKendraIndex.DataAwsKendraIndexUserGroupResolutionConfigurationList UserGroupResolutionConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsKendraIndex.DataAwsKendraIndexUserGroupResolutionConfigurationList>()!;
        }

        [JsiiProperty(name: "userTokenConfigurations", typeJson: "{\"fqn\":\"aws.dataAwsKendraIndex.DataAwsKendraIndexUserTokenConfigurationsList\"}")]
        public virtual aws.DataAwsKendraIndex.DataAwsKendraIndexUserTokenConfigurationsList UserTokenConfigurations
        {
            get => GetInstanceProperty<aws.DataAwsKendraIndex.DataAwsKendraIndexUserTokenConfigurationsList>()!;
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
