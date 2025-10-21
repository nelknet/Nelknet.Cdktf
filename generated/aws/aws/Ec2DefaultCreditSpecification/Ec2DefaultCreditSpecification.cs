using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2DefaultCreditSpecification
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_default_credit_specification aws_ec2_default_credit_specification}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecification), fullyQualifiedName: "aws.ec2DefaultCreditSpecification.Ec2DefaultCreditSpecification", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2DefaultCreditSpecification.Ec2DefaultCreditSpecificationConfig\"}}]")]
    public class Ec2DefaultCreditSpecification : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_default_credit_specification aws_ec2_default_credit_specification} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Ec2DefaultCreditSpecification(Constructs.Construct scope, string id, aws.Ec2DefaultCreditSpecification.IEc2DefaultCreditSpecificationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Ec2DefaultCreditSpecification.IEc2DefaultCreditSpecificationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2DefaultCreditSpecification(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2DefaultCreditSpecification(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Ec2DefaultCreditSpecification resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Ec2DefaultCreditSpecification to import.</param>
        /// <param name="importFromId">The id of the existing Ec2DefaultCreditSpecification that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Ec2DefaultCreditSpecification to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Ec2DefaultCreditSpecification to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_default_credit_specification#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Ec2DefaultCreditSpecification that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Ec2DefaultCreditSpecification to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecification), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2DefaultCreditSpecification.Ec2DefaultCreditSpecificationTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ec2DefaultCreditSpecification.IEc2DefaultCreditSpecificationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2DefaultCreditSpecification.IEc2DefaultCreditSpecificationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecification))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2DefaultCreditSpecification.Ec2DefaultCreditSpecificationTimeoutsOutputReference\"}")]
        public virtual aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecificationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ec2DefaultCreditSpecification.Ec2DefaultCreditSpecificationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuCreditsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuCreditsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceFamilyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceFamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ec2DefaultCreditSpecification.Ec2DefaultCreditSpecificationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuCredits
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceFamily
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
