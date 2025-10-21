using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group aws_identitystore_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroup), fullyQualifiedName: "aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupConfig\"}}]")]
    public class DataAwsIdentitystoreGroup : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group aws_identitystore_group} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsIdentitystoreGroup(Constructs.Construct scope, string id, aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsIdentitystoreGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsIdentitystoreGroup to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsIdentitystoreGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsIdentitystoreGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsIdentitystoreGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsIdentitystoreGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsIdentitystoreGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAlternateIdentifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifier\"}}]")]
        public virtual void PutAlternateIdentifier(aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupFilter\"}}]")]
        public virtual void PutFilter(aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlternateIdentifier")]
        public virtual void ResetAlternateIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupId")]
        public virtual void ResetGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroup))!;

        [JsiiProperty(name: "alternateIdentifier", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierOutputReference\"}")]
        public virtual aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierOutputReference AlternateIdentifier
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierOutputReference>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalIds", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupExternalIdsList\"}")]
        public virtual aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupExternalIdsList ExternalIds
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupExternalIdsList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupFilterOutputReference\"}")]
        public virtual aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupFilterOutputReference Filter
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupFilterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alternateIdentifierInput", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifier\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifier? AlternateIdentifierInput
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifier?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupFilter\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupFilter? FilterInput
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityStoreIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityStoreIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupId
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

        [JsiiProperty(name: "identityStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityStoreId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
