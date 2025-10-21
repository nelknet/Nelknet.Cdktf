using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ElasticSanVolume
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume azurerm_elastic_san_volume}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ElasticSanVolume.ElasticSanVolume), fullyQualifiedName: "azurerm.elasticSanVolume.ElasticSanVolume", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.elasticSanVolume.ElasticSanVolumeConfig\"}}]")]
    public class ElasticSanVolume : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume azurerm_elastic_san_volume} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticSanVolume(Constructs.Construct scope, string id, azurerm.ElasticSanVolume.IElasticSanVolumeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ElasticSanVolume.IElasticSanVolumeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticSanVolume(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticSanVolume(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ElasticSanVolume resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ElasticSanVolume to import.</param>
        /// <param name="importFromId">The id of the existing ElasticSanVolume that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ElasticSanVolume to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ElasticSanVolume to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ElasticSanVolume that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ElasticSanVolume to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ElasticSanVolume.ElasticSanVolume), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCreateSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.elasticSanVolume.ElasticSanVolumeCreateSource\"}}]")]
        public virtual void PutCreateSource(azurerm.ElasticSanVolume.IElasticSanVolumeCreateSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ElasticSanVolume.IElasticSanVolumeCreateSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.elasticSanVolume.ElasticSanVolumeTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ElasticSanVolume.IElasticSanVolumeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ElasticSanVolume.IElasticSanVolumeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCreateSource")]
        public virtual void ResetCreateSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.ElasticSanVolume.ElasticSanVolume))!;

        [JsiiProperty(name: "createSource", typeJson: "{\"fqn\":\"azurerm.elasticSanVolume.ElasticSanVolumeCreateSourceOutputReference\"}")]
        public virtual azurerm.ElasticSanVolume.ElasticSanVolumeCreateSourceOutputReference CreateSource
        {
            get => GetInstanceProperty<azurerm.ElasticSanVolume.ElasticSanVolumeCreateSourceOutputReference>()!;
        }

        [JsiiProperty(name: "targetIqn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetIqn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetPortalHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetPortalHostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetPortalPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetPortalPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.elasticSanVolume.ElasticSanVolumeTimeoutsOutputReference\"}")]
        public virtual azurerm.ElasticSanVolume.ElasticSanVolumeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ElasticSanVolume.ElasticSanVolumeTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "createSourceInput", typeJson: "{\"fqn\":\"azurerm.elasticSanVolume.ElasticSanVolumeCreateSource\"}", isOptional: true)]
        public virtual azurerm.ElasticSanVolume.IElasticSanVolumeCreateSource? CreateSourceInput
        {
            get => GetInstanceProperty<azurerm.ElasticSanVolume.IElasticSanVolumeCreateSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeInGibInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SizeInGibInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.elasticSanVolume.ElasticSanVolumeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeInGib
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
