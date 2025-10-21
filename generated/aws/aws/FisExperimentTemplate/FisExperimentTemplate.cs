using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template aws_fis_experiment_template}.</summary>
    [JsiiClass(nativeType: typeof(aws.FisExperimentTemplate.FisExperimentTemplate), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateConfig\"}}]")]
    public class FisExperimentTemplate : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template aws_fis_experiment_template} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FisExperimentTemplate(Constructs.Construct scope, string id, aws.FisExperimentTemplate.IFisExperimentTemplateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.FisExperimentTemplate.IFisExperimentTemplateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FisExperimentTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FisExperimentTemplate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a FisExperimentTemplate resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FisExperimentTemplate to import.</param>
        /// <param name="importFromId">The id of the existing FisExperimentTemplate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FisExperimentTemplate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FisExperimentTemplate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FisExperimentTemplate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FisExperimentTemplate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.FisExperimentTemplate.FisExperimentTemplate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.FisExperimentTemplate.IFisExperimentTemplateAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FisExperimentTemplate.IFisExperimentTemplateAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FisExperimentTemplate.IFisExperimentTemplateAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExperimentOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentOptions\"}}]")]
        public virtual void PutExperimentOptions(aws.FisExperimentTemplate.IFisExperimentTemplateExperimentOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FisExperimentTemplate.IFisExperimentTemplateExperimentOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExperimentReportConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfiguration\"}}]")]
        public virtual void PutExperimentReportConfiguration(aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfiguration\"}}]")]
        public virtual void PutLogConfiguration(aws.FisExperimentTemplate.IFisExperimentTemplateLogConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FisExperimentTemplate.IFisExperimentTemplateLogConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStopCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateStopCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStopCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.FisExperimentTemplate.IFisExperimentTemplateStopCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FisExperimentTemplate.IFisExperimentTemplateStopCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FisExperimentTemplate.IFisExperimentTemplateStopCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateTarget\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTarget(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.FisExperimentTemplate.IFisExperimentTemplateTarget[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FisExperimentTemplate.IFisExperimentTemplateTarget).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FisExperimentTemplate.IFisExperimentTemplateTarget).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.FisExperimentTemplate.IFisExperimentTemplateTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FisExperimentTemplate.IFisExperimentTemplateTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExperimentOptions")]
        public virtual void ResetExperimentOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExperimentReportConfiguration")]
        public virtual void ResetExperimentReportConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogConfiguration")]
        public virtual void ResetLogConfiguration()
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

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
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
        = GetStaticProperty<string>(typeof(aws.FisExperimentTemplate.FisExperimentTemplate))!;

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateActionList\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateActionList Action
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateActionList>()!;
        }

        [JsiiProperty(name: "experimentOptions", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentOptionsOutputReference\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateExperimentOptionsOutputReference ExperimentOptions
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateExperimentOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "experimentReportConfiguration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputReference\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputReference ExperimentReportConfiguration
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "logConfiguration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationOutputReference\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateLogConfigurationOutputReference LogConfiguration
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateLogConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "stopCondition", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateStopConditionList\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateStopConditionList StopCondition
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateStopConditionList>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateTargetList\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateTargetList Target
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateTargetList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateTimeoutsOutputReference\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "experimentOptionsInput", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentOptions\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateExperimentOptions? ExperimentOptionsInput
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateExperimentOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "experimentReportConfigurationInput", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfiguration\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfiguration? ExperimentReportConfigurationInput
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logConfigurationInput", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfiguration\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateLogConfiguration? LogConfigurationInput
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateLogConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stopConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateStopCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StopConditionInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "targetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
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
