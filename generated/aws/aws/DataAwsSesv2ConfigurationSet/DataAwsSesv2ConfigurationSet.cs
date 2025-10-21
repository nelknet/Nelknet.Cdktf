using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSesv2ConfigurationSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_configuration_set aws_sesv2_configuration_set}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSet), fullyQualifiedName: "aws.dataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetConfig\"}}]")]
    public class DataAwsSesv2ConfigurationSet : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_configuration_set aws_sesv2_configuration_set} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsSesv2ConfigurationSet(Constructs.Construct scope, string id, aws.DataAwsSesv2ConfigurationSet.IDataAwsSesv2ConfigurationSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsSesv2ConfigurationSet.IDataAwsSesv2ConfigurationSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSesv2ConfigurationSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSesv2ConfigurationSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsSesv2ConfigurationSet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsSesv2ConfigurationSet to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsSesv2ConfigurationSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsSesv2ConfigurationSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsSesv2ConfigurationSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_configuration_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsSesv2ConfigurationSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsSesv2ConfigurationSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deliveryOptions", typeJson: "{\"fqn\":\"aws.dataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetDeliveryOptionsList\"}")]
        public virtual aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetDeliveryOptionsList DeliveryOptions
        {
            get => GetInstanceProperty<aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetDeliveryOptionsList>()!;
        }

        [JsiiProperty(name: "reputationOptions", typeJson: "{\"fqn\":\"aws.dataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetReputationOptionsList\"}")]
        public virtual aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetReputationOptionsList ReputationOptions
        {
            get => GetInstanceProperty<aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetReputationOptionsList>()!;
        }

        [JsiiProperty(name: "sendingOptions", typeJson: "{\"fqn\":\"aws.dataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetSendingOptionsList\"}")]
        public virtual aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetSendingOptionsList SendingOptions
        {
            get => GetInstanceProperty<aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetSendingOptionsList>()!;
        }

        [JsiiProperty(name: "suppressionOptions", typeJson: "{\"fqn\":\"aws.dataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetSuppressionOptionsList\"}")]
        public virtual aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetSuppressionOptionsList SuppressionOptions
        {
            get => GetInstanceProperty<aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetSuppressionOptionsList>()!;
        }

        [JsiiProperty(name: "trackingOptions", typeJson: "{\"fqn\":\"aws.dataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetTrackingOptionsList\"}")]
        public virtual aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetTrackingOptionsList TrackingOptions
        {
            get => GetInstanceProperty<aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetTrackingOptionsList>()!;
        }

        [JsiiProperty(name: "vdmOptions", typeJson: "{\"fqn\":\"aws.dataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetVdmOptionsList\"}")]
        public virtual aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetVdmOptionsList VdmOptions
        {
            get => GetInstanceProperty<aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetVdmOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationSetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationSetNameInput
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
    }
}
