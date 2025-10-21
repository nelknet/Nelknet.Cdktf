using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space aws_sagemaker_space}.</summary>
    [JsiiClass(nativeType: typeof(aws.SagemakerSpace.SagemakerSpace), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpace", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceConfig\"}}]")]
    public class SagemakerSpace : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space aws_sagemaker_space} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerSpace(Constructs.Construct scope, string id, aws.SagemakerSpace.ISagemakerSpaceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SagemakerSpace.ISagemakerSpaceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerSpace(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerSpace(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SagemakerSpace resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SagemakerSpace to import.</param>
        /// <param name="importFromId">The id of the existing SagemakerSpace that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SagemakerSpace to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SagemakerSpace to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SagemakerSpace that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SagemakerSpace to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.SagemakerSpace.SagemakerSpace), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putOwnershipSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceOwnershipSettings\"}}]")]
        public virtual void PutOwnershipSettings(aws.SagemakerSpace.ISagemakerSpaceOwnershipSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceOwnershipSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpaceSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettings\"}}]")]
        public virtual void PutSpaceSettings(aws.SagemakerSpace.ISagemakerSpaceSpaceSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpaceSharingSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSharingSettings\"}}]")]
        public virtual void PutSpaceSharingSettings(aws.SagemakerSpace.ISagemakerSpaceSpaceSharingSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSharingSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwnershipSettings")]
        public virtual void ResetOwnershipSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpaceDisplayName")]
        public virtual void ResetSpaceDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpaceSettings")]
        public virtual void ResetSpaceSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpaceSharingSettings")]
        public virtual void ResetSpaceSharingSettings()
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
        = GetStaticProperty<string>(typeof(aws.SagemakerSpace.SagemakerSpace))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "homeEfsFileSystemUid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomeEfsFileSystemUid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownershipSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceOwnershipSettingsOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceOwnershipSettingsOutputReference OwnershipSettings
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceOwnershipSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "spaceSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSettingsOutputReference SpaceSettings
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "spaceSharingSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSharingSettingsOutputReference\"}")]
        public virtual aws.SagemakerSpace.SagemakerSpaceSpaceSharingSettingsOutputReference SpaceSharingSettings
        {
            get => GetInstanceProperty<aws.SagemakerSpace.SagemakerSpaceSpaceSharingSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainIdInput
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
        [JsiiProperty(name: "ownershipSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceOwnershipSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceOwnershipSettings? OwnershipSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceOwnershipSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceDisplayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpaceDisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpaceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSettings? SpaceSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceSharingSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSharingSettings\"}", isOptional: true)]
        public virtual aws.SagemakerSpace.ISagemakerSpaceSpaceSharingSettings? SpaceSharingSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSharingSettings?>();
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

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
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

        [JsiiProperty(name: "spaceDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpaceDisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spaceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpaceName
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
