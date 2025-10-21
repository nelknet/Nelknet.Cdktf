using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeTargetGroupAttachment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment aws_vpclattice_target_group_attachment}.</summary>
    [JsiiClass(nativeType: typeof(aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachment), fullyQualifiedName: "aws.vpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentConfig\"}}]")]
    public class VpclatticeTargetGroupAttachment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment aws_vpclattice_target_group_attachment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpclatticeTargetGroupAttachment(Constructs.Construct scope, string id, aws.VpclatticeTargetGroupAttachment.IVpclatticeTargetGroupAttachmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.VpclatticeTargetGroupAttachment.IVpclatticeTargetGroupAttachmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpclatticeTargetGroupAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpclatticeTargetGroupAttachment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VpclatticeTargetGroupAttachment resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VpclatticeTargetGroupAttachment to import.</param>
        /// <param name="importFromId">The id of the existing VpclatticeTargetGroupAttachment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VpclatticeTargetGroupAttachment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VpclatticeTargetGroupAttachment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VpclatticeTargetGroupAttachment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VpclatticeTargetGroupAttachment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTarget\"}}]")]
        public virtual void PutTarget(aws.VpclatticeTargetGroupAttachment.IVpclatticeTargetGroupAttachmentTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpclatticeTargetGroupAttachment.IVpclatticeTargetGroupAttachmentTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.VpclatticeTargetGroupAttachment.IVpclatticeTargetGroupAttachmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpclatticeTargetGroupAttachment.IVpclatticeTargetGroupAttachmentTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachment))!;

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.vpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTargetOutputReference\"}")]
        public virtual aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTargetOutputReference Target
        {
            get => GetInstanceProperty<aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTargetOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTimeoutsOutputReference\"}")]
        public virtual aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.VpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetGroupIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"fqn\":\"aws.vpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTarget\"}", isOptional: true)]
        public virtual aws.VpclatticeTargetGroupAttachment.IVpclatticeTargetGroupAttachmentTarget? TargetInput
        {
            get => GetInstanceProperty<aws.VpclatticeTargetGroupAttachment.IVpclatticeTargetGroupAttachmentTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.vpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetGroupIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetGroupIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
