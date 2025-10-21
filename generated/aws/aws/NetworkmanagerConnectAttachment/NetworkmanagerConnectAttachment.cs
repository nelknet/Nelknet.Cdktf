using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerConnectAttachment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment aws_networkmanager_connect_attachment}.</summary>
    [JsiiClass(nativeType: typeof(aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachment), fullyQualifiedName: "aws.networkmanagerConnectAttachment.NetworkmanagerConnectAttachment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.networkmanagerConnectAttachment.NetworkmanagerConnectAttachmentConfig\"}}]")]
    public class NetworkmanagerConnectAttachment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment aws_networkmanager_connect_attachment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkmanagerConnectAttachment(Constructs.Construct scope, string id, aws.NetworkmanagerConnectAttachment.INetworkmanagerConnectAttachmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.NetworkmanagerConnectAttachment.INetworkmanagerConnectAttachmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkmanagerConnectAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkmanagerConnectAttachment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a NetworkmanagerConnectAttachment resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetworkmanagerConnectAttachment to import.</param>
        /// <param name="importFromId">The id of the existing NetworkmanagerConnectAttachment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetworkmanagerConnectAttachment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetworkmanagerConnectAttachment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetworkmanagerConnectAttachment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetworkmanagerConnectAttachment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkmanagerConnectAttachment.NetworkmanagerConnectAttachmentOptions\"}}]")]
        public virtual void PutOptions(aws.NetworkmanagerConnectAttachment.INetworkmanagerConnectAttachmentOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.NetworkmanagerConnectAttachment.INetworkmanagerConnectAttachmentOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkmanagerConnectAttachment.NetworkmanagerConnectAttachmentTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.NetworkmanagerConnectAttachment.INetworkmanagerConnectAttachmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.NetworkmanagerConnectAttachment.INetworkmanagerConnectAttachmentTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachment))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attachmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttachmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attachmentPolicyRuleNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AttachmentPolicyRuleNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "attachmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttachmentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "coreNetworkArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CoreNetworkArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"aws.networkmanagerConnectAttachment.NetworkmanagerConnectAttachmentOptionsOutputReference\"}")]
        public virtual aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachmentOptionsOutputReference Options
        {
            get => GetInstanceProperty<aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachmentOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "ownerAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "segmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SegmentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.networkmanagerConnectAttachment.NetworkmanagerConnectAttachmentTimeoutsOutputReference\"}")]
        public virtual aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.NetworkmanagerConnectAttachment.NetworkmanagerConnectAttachmentTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CoreNetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgeLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EdgeLocationInput
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
        [JsiiProperty(name: "optionsInput", typeJson: "{\"fqn\":\"aws.networkmanagerConnectAttachment.NetworkmanagerConnectAttachmentOptions\"}", isOptional: true)]
        public virtual aws.NetworkmanagerConnectAttachment.INetworkmanagerConnectAttachmentOptions? OptionsInput
        {
            get => GetInstanceProperty<aws.NetworkmanagerConnectAttachment.INetworkmanagerConnectAttachmentOptions?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.networkmanagerConnectAttachment.NetworkmanagerConnectAttachmentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportAttachmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransportAttachmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "coreNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CoreNetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edgeLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeLocation
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

        [JsiiProperty(name: "transportAttachmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransportAttachmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
