using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontRealtimeLogConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config aws_cloudfront_realtime_log_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfig), fullyQualifiedName: "aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigConfig\"}}]")]
    public class CloudfrontRealtimeLogConfig : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config aws_cloudfront_realtime_log_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudfrontRealtimeLogConfig(Constructs.Construct scope, string id, aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontRealtimeLogConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontRealtimeLogConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CloudfrontRealtimeLogConfig resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudfrontRealtimeLogConfig to import.</param>
        /// <param name="importFromId">The id of the existing CloudfrontRealtimeLogConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudfrontRealtimeLogConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudfrontRealtimeLogConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudfrontRealtimeLogConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudfrontRealtimeLogConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpoint\"}}]")]
        public virtual void PutEndpoint(aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpoint)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfig))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointOutputReference\"}")]
        public virtual aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointOutputReference Endpoint
        {
            get => GetInstanceProperty<aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointInput", typeJson: "{\"fqn\":\"aws.cloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpoint\"}", isOptional: true)]
        public virtual aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpoint? EndpointInput
        {
            get => GetInstanceProperty<aws.CloudfrontRealtimeLogConfig.ICloudfrontRealtimeLogConfigEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? FieldsInput
        {
            get => GetInstanceProperty<string[]?>();
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
        [JsiiProperty(name: "samplingRateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SamplingRateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "fields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Fields
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "samplingRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SamplingRate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
