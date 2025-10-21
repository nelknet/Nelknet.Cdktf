using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimeVoiceConnectorStreaming
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming aws_chime_voice_connector_streaming}.</summary>
    [JsiiClass(nativeType: typeof(aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreaming), fullyQualifiedName: "aws.chimeVoiceConnectorStreaming.ChimeVoiceConnectorStreaming", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.chimeVoiceConnectorStreaming.ChimeVoiceConnectorStreamingConfig\"}}]")]
    public class ChimeVoiceConnectorStreaming : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming aws_chime_voice_connector_streaming} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ChimeVoiceConnectorStreaming(Constructs.Construct scope, string id, aws.ChimeVoiceConnectorStreaming.IChimeVoiceConnectorStreamingConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ChimeVoiceConnectorStreaming.IChimeVoiceConnectorStreamingConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChimeVoiceConnectorStreaming(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChimeVoiceConnectorStreaming(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ChimeVoiceConnectorStreaming resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ChimeVoiceConnectorStreaming to import.</param>
        /// <param name="importFromId">The id of the existing ChimeVoiceConnectorStreaming that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ChimeVoiceConnectorStreaming to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ChimeVoiceConnectorStreaming to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_streaming#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ChimeVoiceConnectorStreaming that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ChimeVoiceConnectorStreaming to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreaming), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMediaInsightsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.chimeVoiceConnectorStreaming.ChimeVoiceConnectorStreamingMediaInsightsConfiguration\"}}]")]
        public virtual void PutMediaInsightsConfiguration(aws.ChimeVoiceConnectorStreaming.IChimeVoiceConnectorStreamingMediaInsightsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ChimeVoiceConnectorStreaming.IChimeVoiceConnectorStreamingMediaInsightsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisabled")]
        public virtual void ResetDisabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMediaInsightsConfiguration")]
        public virtual void ResetMediaInsightsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamingNotificationTargets")]
        public virtual void ResetStreamingNotificationTargets()
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
        = GetStaticProperty<string>(typeof(aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreaming))!;

        [JsiiProperty(name: "mediaInsightsConfiguration", typeJson: "{\"fqn\":\"aws.chimeVoiceConnectorStreaming.ChimeVoiceConnectorStreamingMediaInsightsConfigurationOutputReference\"}")]
        public virtual aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreamingMediaInsightsConfigurationOutputReference MediaInsightsConfiguration
        {
            get => GetInstanceProperty<aws.ChimeVoiceConnectorStreaming.ChimeVoiceConnectorStreamingMediaInsightsConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataRetentionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataRetentionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediaInsightsConfigurationInput", typeJson: "{\"fqn\":\"aws.chimeVoiceConnectorStreaming.ChimeVoiceConnectorStreamingMediaInsightsConfiguration\"}", isOptional: true)]
        public virtual aws.ChimeVoiceConnectorStreaming.IChimeVoiceConnectorStreamingMediaInsightsConfiguration? MediaInsightsConfigurationInput
        {
            get => GetInstanceProperty<aws.ChimeVoiceConnectorStreaming.IChimeVoiceConnectorStreamingMediaInsightsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamingNotificationTargetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? StreamingNotificationTargetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "voiceConnectorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VoiceConnectorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataRetention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataRetention
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Disabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamingNotificationTargets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StreamingNotificationTargets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "voiceConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VoiceConnectorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
