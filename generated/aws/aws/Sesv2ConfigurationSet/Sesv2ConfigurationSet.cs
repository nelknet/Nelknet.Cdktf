using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set aws_sesv2_configuration_set}.</summary>
    [JsiiClass(nativeType: typeof(aws.Sesv2ConfigurationSet.Sesv2ConfigurationSet), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetConfig\"}}]")]
    public class Sesv2ConfigurationSet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set aws_sesv2_configuration_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Sesv2ConfigurationSet(Constructs.Construct scope, string id, aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Sesv2ConfigurationSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Sesv2ConfigurationSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Sesv2ConfigurationSet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Sesv2ConfigurationSet to import.</param>
        /// <param name="importFromId">The id of the existing Sesv2ConfigurationSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Sesv2ConfigurationSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Sesv2ConfigurationSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Sesv2ConfigurationSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Sesv2ConfigurationSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Sesv2ConfigurationSet.Sesv2ConfigurationSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDeliveryOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetDeliveryOptions\"}}]")]
        public virtual void PutDeliveryOptions(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetDeliveryOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetDeliveryOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReputationOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptions\"}}]")]
        public virtual void PutReputationOptions(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetReputationOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetReputationOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSendingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptions\"}}]")]
        public virtual void PutSendingOptions(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSendingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSendingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSuppressionOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptions\"}}]")]
        public virtual void PutSuppressionOptions(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSuppressionOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSuppressionOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrackingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptions\"}}]")]
        public virtual void PutTrackingOptions(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetTrackingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetTrackingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVdmOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptions\"}}]")]
        public virtual void PutVdmOptions(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions)}, new object[]{@value});
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

        [JsiiMethod(name: "resetReputationOptions")]
        public virtual void ResetReputationOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSendingOptions")]
        public virtual void ResetSendingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuppressionOptions")]
        public virtual void ResetSuppressionOptions()
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

        [JsiiMethod(name: "resetTrackingOptions")]
        public virtual void ResetTrackingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVdmOptions")]
        public virtual void ResetVdmOptions()
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
        = GetStaticProperty<string>(typeof(aws.Sesv2ConfigurationSet.Sesv2ConfigurationSet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deliveryOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetDeliveryOptionsOutputReference\"}")]
        public virtual aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetDeliveryOptionsOutputReference DeliveryOptions
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetDeliveryOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "reputationOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptionsOutputReference\"}")]
        public virtual aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptionsOutputReference ReputationOptions
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "sendingOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptionsOutputReference\"}")]
        public virtual aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptionsOutputReference SendingOptions
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "suppressionOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptionsOutputReference\"}")]
        public virtual aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptionsOutputReference SuppressionOptions
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "trackingOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptionsOutputReference\"}")]
        public virtual aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptionsOutputReference TrackingOptions
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "vdmOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsOutputReference\"}")]
        public virtual aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsOutputReference VdmOptions
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationSetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationSetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryOptionsInput", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetDeliveryOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetDeliveryOptions? DeliveryOptionsInput
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetDeliveryOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reputationOptionsInput", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetReputationOptions? ReputationOptionsInput
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetReputationOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sendingOptionsInput", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSendingOptions? SendingOptionsInput
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSendingOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "suppressionOptionsInput", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSuppressionOptions? SuppressionOptionsInput
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSuppressionOptions?>();
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
        [JsiiProperty(name: "trackingOptionsInput", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetTrackingOptions? TrackingOptionsInput
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetTrackingOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vdmOptionsInput", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptions\"}", isOptional: true)]
        public virtual aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions? VdmOptionsInput
        {
            get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions?>();
        }

        [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationSetName
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
