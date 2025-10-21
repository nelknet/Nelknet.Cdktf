using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationNfs
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs aws_datasync_location_nfs}.</summary>
    [JsiiClass(nativeType: typeof(aws.DatasyncLocationNfs.DatasyncLocationNfs), fullyQualifiedName: "aws.datasyncLocationNfs.DatasyncLocationNfs", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.datasyncLocationNfs.DatasyncLocationNfsConfig\"}}]")]
    public class DatasyncLocationNfs : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs aws_datasync_location_nfs} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatasyncLocationNfs(Constructs.Construct scope, string id, aws.DatasyncLocationNfs.IDatasyncLocationNfsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DatasyncLocationNfs.IDatasyncLocationNfsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationNfs(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationNfs(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DatasyncLocationNfs resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatasyncLocationNfs to import.</param>
        /// <param name="importFromId">The id of the existing DatasyncLocationNfs that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatasyncLocationNfs to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatasyncLocationNfs to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatasyncLocationNfs that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatasyncLocationNfs to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DatasyncLocationNfs.DatasyncLocationNfs), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMountOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncLocationNfs.DatasyncLocationNfsMountOptions\"}}]")]
        public virtual void PutMountOptions(aws.DatasyncLocationNfs.IDatasyncLocationNfsMountOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncLocationNfs.IDatasyncLocationNfsMountOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnPremConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncLocationNfs.DatasyncLocationNfsOnPremConfig\"}}]")]
        public virtual void PutOnPremConfig(aws.DatasyncLocationNfs.IDatasyncLocationNfsOnPremConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncLocationNfs.IDatasyncLocationNfsOnPremConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMountOptions")]
        public virtual void ResetMountOptions()
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
        = GetStaticProperty<string>(typeof(aws.DatasyncLocationNfs.DatasyncLocationNfs))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mountOptions", typeJson: "{\"fqn\":\"aws.datasyncLocationNfs.DatasyncLocationNfsMountOptionsOutputReference\"}")]
        public virtual aws.DatasyncLocationNfs.DatasyncLocationNfsMountOptionsOutputReference MountOptions
        {
            get => GetInstanceProperty<aws.DatasyncLocationNfs.DatasyncLocationNfsMountOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "onPremConfig", typeJson: "{\"fqn\":\"aws.datasyncLocationNfs.DatasyncLocationNfsOnPremConfigOutputReference\"}")]
        public virtual aws.DatasyncLocationNfs.DatasyncLocationNfsOnPremConfigOutputReference OnPremConfig
        {
            get => GetInstanceProperty<aws.DatasyncLocationNfs.DatasyncLocationNfsOnPremConfigOutputReference>()!;
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountOptionsInput", typeJson: "{\"fqn\":\"aws.datasyncLocationNfs.DatasyncLocationNfsMountOptions\"}", isOptional: true)]
        public virtual aws.DatasyncLocationNfs.IDatasyncLocationNfsMountOptions? MountOptionsInput
        {
            get => GetInstanceProperty<aws.DatasyncLocationNfs.IDatasyncLocationNfsMountOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onPremConfigInput", typeJson: "{\"fqn\":\"aws.datasyncLocationNfs.DatasyncLocationNfsOnPremConfig\"}", isOptional: true)]
        public virtual aws.DatasyncLocationNfs.IDatasyncLocationNfsOnPremConfig? OnPremConfigInput
        {
            get => GetInstanceProperty<aws.DatasyncLocationNfs.IDatasyncLocationNfsOnPremConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverHostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerHostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subdirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubdirectoryInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerHostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subdirectory
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
