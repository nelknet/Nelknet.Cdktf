using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesConfigurationSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set aws_ses_configuration_set}.</summary>
    [JsiiClass(nativeType: typeof(aws.SesConfigurationSet.SesConfigurationSet), fullyQualifiedName: "aws.sesConfigurationSet.SesConfigurationSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sesConfigurationSet.SesConfigurationSetConfig\"}}]")]
    public class SesConfigurationSet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set aws_ses_configuration_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SesConfigurationSet(Constructs.Construct scope, string id, aws.SesConfigurationSet.ISesConfigurationSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SesConfigurationSet.ISesConfigurationSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesConfigurationSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesConfigurationSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SesConfigurationSet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SesConfigurationSet to import.</param>
        /// <param name="importFromId">The id of the existing SesConfigurationSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SesConfigurationSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SesConfigurationSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SesConfigurationSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SesConfigurationSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.SesConfigurationSet.SesConfigurationSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDeliveryOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesConfigurationSet.SesConfigurationSetDeliveryOptions\"}}]")]
        public virtual void PutDeliveryOptions(aws.SesConfigurationSet.ISesConfigurationSetDeliveryOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SesConfigurationSet.ISesConfigurationSetDeliveryOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrackingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesConfigurationSet.SesConfigurationSetTrackingOptions\"}}]")]
        public virtual void PutTrackingOptions(aws.SesConfigurationSet.ISesConfigurationSetTrackingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SesConfigurationSet.ISesConfigurationSetTrackingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeliveryOptions")]
        public virtual void ResetDeliveryOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReputationMetricsEnabled")]
        public virtual void ResetReputationMetricsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSendingEnabled")]
        public virtual void ResetSendingEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrackingOptions")]
        public virtual void ResetTrackingOptions()
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
        = GetStaticProperty<string>(typeof(aws.SesConfigurationSet.SesConfigurationSet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deliveryOptions", typeJson: "{\"fqn\":\"aws.sesConfigurationSet.SesConfigurationSetDeliveryOptionsOutputReference\"}")]
        public virtual aws.SesConfigurationSet.SesConfigurationSetDeliveryOptionsOutputReference DeliveryOptions
        {
            get => GetInstanceProperty<aws.SesConfigurationSet.SesConfigurationSetDeliveryOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "lastFreshStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastFreshStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trackingOptions", typeJson: "{\"fqn\":\"aws.sesConfigurationSet.SesConfigurationSetTrackingOptionsOutputReference\"}")]
        public virtual aws.SesConfigurationSet.SesConfigurationSetTrackingOptionsOutputReference TrackingOptions
        {
            get => GetInstanceProperty<aws.SesConfigurationSet.SesConfigurationSetTrackingOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryOptionsInput", typeJson: "{\"fqn\":\"aws.sesConfigurationSet.SesConfigurationSetDeliveryOptions\"}", isOptional: true)]
        public virtual aws.SesConfigurationSet.ISesConfigurationSetDeliveryOptions? DeliveryOptionsInput
        {
            get => GetInstanceProperty<aws.SesConfigurationSet.ISesConfigurationSetDeliveryOptions?>();
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
        [JsiiProperty(name: "reputationMetricsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReputationMetricsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sendingEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SendingEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trackingOptionsInput", typeJson: "{\"fqn\":\"aws.sesConfigurationSet.SesConfigurationSetTrackingOptions\"}", isOptional: true)]
        public virtual aws.SesConfigurationSet.ISesConfigurationSetTrackingOptions? TrackingOptionsInput
        {
            get => GetInstanceProperty<aws.SesConfigurationSet.ISesConfigurationSetTrackingOptions?>();
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

        [JsiiProperty(name: "reputationMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ReputationMetricsEnabled
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

        [JsiiProperty(name: "sendingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SendingEnabled
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
    }
}
