using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DirectoryServiceRegion
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region aws_directory_service_region}.</summary>
    [JsiiClass(nativeType: typeof(aws.DirectoryServiceRegion.DirectoryServiceRegion), fullyQualifiedName: "aws.directoryServiceRegion.DirectoryServiceRegion", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.directoryServiceRegion.DirectoryServiceRegionConfig\"}}]")]
    public class DirectoryServiceRegion : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region aws_directory_service_region} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DirectoryServiceRegion(Constructs.Construct scope, string id, aws.DirectoryServiceRegion.IDirectoryServiceRegionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DirectoryServiceRegion.IDirectoryServiceRegionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DirectoryServiceRegion(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DirectoryServiceRegion(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DirectoryServiceRegion resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DirectoryServiceRegion to import.</param>
        /// <param name="importFromId">The id of the existing DirectoryServiceRegion that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DirectoryServiceRegion to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DirectoryServiceRegion to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_region#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DirectoryServiceRegion that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DirectoryServiceRegion to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DirectoryServiceRegion.DirectoryServiceRegion), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.directoryServiceRegion.DirectoryServiceRegionTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DirectoryServiceRegion.IDirectoryServiceRegionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DirectoryServiceRegion.IDirectoryServiceRegionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.directoryServiceRegion.DirectoryServiceRegionVpcSettings\"}}]")]
        public virtual void PutVpcSettings(aws.DirectoryServiceRegion.IDirectoryServiceRegionVpcSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DirectoryServiceRegion.IDirectoryServiceRegionVpcSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDesiredNumberOfDomainControllers")]
        public virtual void ResetDesiredNumberOfDomainControllers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.DirectoryServiceRegion.DirectoryServiceRegion))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directoryServiceRegion.DirectoryServiceRegionTimeoutsOutputReference\"}")]
        public virtual aws.DirectoryServiceRegion.DirectoryServiceRegionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DirectoryServiceRegion.DirectoryServiceRegionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcSettings", typeJson: "{\"fqn\":\"aws.directoryServiceRegion.DirectoryServiceRegionVpcSettingsOutputReference\"}")]
        public virtual aws.DirectoryServiceRegion.DirectoryServiceRegionVpcSettingsOutputReference VpcSettings
        {
            get => GetInstanceProperty<aws.DirectoryServiceRegion.DirectoryServiceRegionVpcSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredNumberOfDomainControllersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredNumberOfDomainControllersInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "regionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionNameInput
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

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.directoryServiceRegion.DirectoryServiceRegionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSettingsInput", typeJson: "{\"fqn\":\"aws.directoryServiceRegion.DirectoryServiceRegionVpcSettings\"}", isOptional: true)]
        public virtual aws.DirectoryServiceRegion.IDirectoryServiceRegionVpcSettings? VpcSettingsInput
        {
            get => GetInstanceProperty<aws.DirectoryServiceRegion.IDirectoryServiceRegionVpcSettings?>();
        }

        [JsiiProperty(name: "desiredNumberOfDomainControllers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredNumberOfDomainControllers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionName
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
