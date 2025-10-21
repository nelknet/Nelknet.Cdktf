using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigurationAggregator
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator aws_config_configuration_aggregator}.</summary>
    [JsiiClass(nativeType: typeof(aws.ConfigConfigurationAggregator.ConfigConfigurationAggregator), fullyQualifiedName: "aws.configConfigurationAggregator.ConfigConfigurationAggregator", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.configConfigurationAggregator.ConfigConfigurationAggregatorConfig\"}}]")]
    public class ConfigConfigurationAggregator : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator aws_config_configuration_aggregator} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConfigConfigurationAggregator(Constructs.Construct scope, string id, aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationAggregator(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationAggregator(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ConfigConfigurationAggregator resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ConfigConfigurationAggregator to import.</param>
        /// <param name="importFromId">The id of the existing ConfigConfigurationAggregator that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ConfigConfigurationAggregator to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ConfigConfigurationAggregator to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_aggregator#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ConfigConfigurationAggregator that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ConfigConfigurationAggregator to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ConfigConfigurationAggregator.ConfigConfigurationAggregator), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAccountAggregationSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.configConfigurationAggregator.ConfigConfigurationAggregatorAccountAggregationSource\"}}]")]
        public virtual void PutAccountAggregationSource(aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorAccountAggregationSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorAccountAggregationSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrganizationAggregationSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.configConfigurationAggregator.ConfigConfigurationAggregatorOrganizationAggregationSource\"}}]")]
        public virtual void PutOrganizationAggregationSource(aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorOrganizationAggregationSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorOrganizationAggregationSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountAggregationSource")]
        public virtual void ResetAccountAggregationSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrganizationAggregationSource")]
        public virtual void ResetOrganizationAggregationSource()
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
        = GetStaticProperty<string>(typeof(aws.ConfigConfigurationAggregator.ConfigConfigurationAggregator))!;

        [JsiiProperty(name: "accountAggregationSource", typeJson: "{\"fqn\":\"aws.configConfigurationAggregator.ConfigConfigurationAggregatorAccountAggregationSourceOutputReference\"}")]
        public virtual aws.ConfigConfigurationAggregator.ConfigConfigurationAggregatorAccountAggregationSourceOutputReference AccountAggregationSource
        {
            get => GetInstanceProperty<aws.ConfigConfigurationAggregator.ConfigConfigurationAggregatorAccountAggregationSourceOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationAggregationSource", typeJson: "{\"fqn\":\"aws.configConfigurationAggregator.ConfigConfigurationAggregatorOrganizationAggregationSourceOutputReference\"}")]
        public virtual aws.ConfigConfigurationAggregator.ConfigConfigurationAggregatorOrganizationAggregationSourceOutputReference OrganizationAggregationSource
        {
            get => GetInstanceProperty<aws.ConfigConfigurationAggregator.ConfigConfigurationAggregatorOrganizationAggregationSourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountAggregationSourceInput", typeJson: "{\"fqn\":\"aws.configConfigurationAggregator.ConfigConfigurationAggregatorAccountAggregationSource\"}", isOptional: true)]
        public virtual aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorAccountAggregationSource? AccountAggregationSourceInput
        {
            get => GetInstanceProperty<aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorAccountAggregationSource?>();
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
        [JsiiProperty(name: "organizationAggregationSourceInput", typeJson: "{\"fqn\":\"aws.configConfigurationAggregator.ConfigConfigurationAggregatorOrganizationAggregationSource\"}", isOptional: true)]
        public virtual aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorOrganizationAggregationSource? OrganizationAggregationSourceInput
        {
            get => GetInstanceProperty<aws.ConfigConfigurationAggregator.IConfigConfigurationAggregatorOrganizationAggregationSource?>();
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
