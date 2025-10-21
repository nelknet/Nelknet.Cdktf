using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotIndexingConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration aws_iot_indexing_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.IotIndexingConfiguration.IotIndexingConfiguration), fullyQualifiedName: "aws.iotIndexingConfiguration.IotIndexingConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationConfig\"}}]")]
    public class IotIndexingConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration aws_iot_indexing_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IotIndexingConfiguration(Constructs.Construct scope, string id, aws.IotIndexingConfiguration.IIotIndexingConfigurationConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.IotIndexingConfiguration.IIotIndexingConfigurationConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIndexingConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIndexingConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a IotIndexingConfiguration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IotIndexingConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing IotIndexingConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IotIndexingConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IotIndexingConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IotIndexingConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IotIndexingConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.IotIndexingConfiguration.IotIndexingConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putThingGroupIndexingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfiguration\"}}]")]
        public virtual void PutThingGroupIndexingConfiguration(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThingIndexingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfiguration\"}}]")]
        public virtual void PutThingIndexingConfiguration(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThingGroupIndexingConfiguration")]
        public virtual void ResetThingGroupIndexingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThingIndexingConfiguration")]
        public virtual void ResetThingIndexingConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.IotIndexingConfiguration.IotIndexingConfiguration))!;

        [JsiiProperty(name: "thingGroupIndexingConfiguration", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationOutputReference\"}")]
        public virtual aws.IotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationOutputReference ThingGroupIndexingConfiguration
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "thingIndexingConfiguration", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationOutputReference\"}")]
        public virtual aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationOutputReference ThingIndexingConfiguration
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thingGroupIndexingConfigurationInput", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfiguration\"}", isOptional: true)]
        public virtual aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfiguration? ThingGroupIndexingConfigurationInput
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thingIndexingConfigurationInput", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfiguration\"}", isOptional: true)]
        public virtual aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfiguration? ThingIndexingConfigurationInput
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfiguration?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
