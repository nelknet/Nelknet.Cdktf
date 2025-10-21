using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlMultiRegionAccessPointPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point_policy aws_s3control_multi_region_access_point_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicy), fullyQualifiedName: "aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyConfig\"}}]")]
    public class S3ControlMultiRegionAccessPointPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point_policy aws_s3control_multi_region_access_point_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3ControlMultiRegionAccessPointPolicy(Constructs.Construct scope, string id, aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlMultiRegionAccessPointPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlMultiRegionAccessPointPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a S3ControlMultiRegionAccessPointPolicy resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the S3ControlMultiRegionAccessPointPolicy to import.</param>
        /// <param name="importFromId">The id of the existing S3ControlMultiRegionAccessPointPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the S3ControlMultiRegionAccessPointPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the S3ControlMultiRegionAccessPointPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_multi_region_access_point_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing S3ControlMultiRegionAccessPointPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the S3ControlMultiRegionAccessPointPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyDetails\"}}]")]
        public virtual void PutDetails(aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
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
        = GetStaticProperty<string>(typeof(aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicy))!;

        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyDetailsOutputReference\"}")]
        public virtual aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyDetailsOutputReference Details
        {
            get => GetInstanceProperty<aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "established", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Established
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proposed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Proposed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyTimeoutsOutputReference\"}")]
        public virtual aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.S3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detailsInput", typeJson: "{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyDetails\"}", isOptional: true)]
        public virtual aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyDetails? DetailsInput
        {
            get => GetInstanceProperty<aws.S3ControlMultiRegionAccessPointPolicy.IS3ControlMultiRegionAccessPointPolicyDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.s3ControlMultiRegionAccessPointPolicy.S3ControlMultiRegionAccessPointPolicyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
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
    }
}
