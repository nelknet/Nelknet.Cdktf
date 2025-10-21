using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2OrganizationConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_organization_configuration aws_inspector2_organization_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfiguration), fullyQualifiedName: "aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationConfig\"}}]")]
    public class Inspector2OrganizationConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_organization_configuration aws_inspector2_organization_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Inspector2OrganizationConfiguration(Constructs.Construct scope, string id, aws.Inspector2OrganizationConfiguration.IInspector2OrganizationConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Inspector2OrganizationConfiguration.IInspector2OrganizationConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Inspector2OrganizationConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Inspector2OrganizationConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Inspector2OrganizationConfiguration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Inspector2OrganizationConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing Inspector2OrganizationConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Inspector2OrganizationConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Inspector2OrganizationConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_organization_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Inspector2OrganizationConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Inspector2OrganizationConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoEnable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationAutoEnable\"}}]")]
        public virtual void PutAutoEnable(aws.Inspector2OrganizationConfiguration.IInspector2OrganizationConfigurationAutoEnable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Inspector2OrganizationConfiguration.IInspector2OrganizationConfigurationAutoEnable)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Inspector2OrganizationConfiguration.IInspector2OrganizationConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Inspector2OrganizationConfiguration.IInspector2OrganizationConfigurationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfiguration))!;

        [JsiiProperty(name: "autoEnable", typeJson: "{\"fqn\":\"aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationAutoEnableOutputReference\"}")]
        public virtual aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationAutoEnableOutputReference AutoEnable
        {
            get => GetInstanceProperty<aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationAutoEnableOutputReference>()!;
        }

        [JsiiProperty(name: "maxAccountLimitReached", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MaxAccountLimitReached
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationTimeoutsOutputReference\"}")]
        public virtual aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoEnableInput", typeJson: "{\"fqn\":\"aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationAutoEnable\"}", isOptional: true)]
        public virtual aws.Inspector2OrganizationConfiguration.IInspector2OrganizationConfigurationAutoEnable? AutoEnableInput
        {
            get => GetInstanceProperty<aws.Inspector2OrganizationConfiguration.IInspector2OrganizationConfigurationAutoEnable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.inspector2OrganizationConfiguration.Inspector2OrganizationConfigurationTimeouts\"}]}}", isOptional: true)]
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
    }
}
