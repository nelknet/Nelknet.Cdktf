using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayUsagePlan
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan aws_api_gateway_usage_plan}.</summary>
    [JsiiClass(nativeType: typeof(aws.ApiGatewayUsagePlan.ApiGatewayUsagePlan), fullyQualifiedName: "aws.apiGatewayUsagePlan.ApiGatewayUsagePlan", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanConfig\"}}]")]
    public class ApiGatewayUsagePlan : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan aws_api_gateway_usage_plan} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiGatewayUsagePlan(Constructs.Construct scope, string id, aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayUsagePlan(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayUsagePlan(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ApiGatewayUsagePlan resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApiGatewayUsagePlan to import.</param>
        /// <param name="importFromId">The id of the existing ApiGatewayUsagePlan that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApiGatewayUsagePlan to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApiGatewayUsagePlan to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_usage_plan#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApiGatewayUsagePlan that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApiGatewayUsagePlan to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ApiGatewayUsagePlan.ApiGatewayUsagePlan), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApiStages", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanApiStages\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutApiStages(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanApiStages[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanApiStages).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanApiStages).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQuotaSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanQuotaSettings\"}}]")]
        public virtual void PutQuotaSettings(aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanQuotaSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanQuotaSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThrottleSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettings\"}}]")]
        public virtual void PutThrottleSettings(aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanThrottleSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanThrottleSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiStages")]
        public virtual void ResetApiStages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductCode")]
        public virtual void ResetProductCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuotaSettings")]
        public virtual void ResetQuotaSettings()
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

        [JsiiMethod(name: "resetThrottleSettings")]
        public virtual void ResetThrottleSettings()
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
        = GetStaticProperty<string>(typeof(aws.ApiGatewayUsagePlan.ApiGatewayUsagePlan))!;

        [JsiiProperty(name: "apiStages", typeJson: "{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanApiStagesList\"}")]
        public virtual aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanApiStagesList ApiStages
        {
            get => GetInstanceProperty<aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanApiStagesList>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quotaSettings", typeJson: "{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanQuotaSettingsOutputReference\"}")]
        public virtual aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanQuotaSettingsOutputReference QuotaSettings
        {
            get => GetInstanceProperty<aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanQuotaSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "throttleSettings", typeJson: "{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettingsOutputReference\"}")]
        public virtual aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettingsOutputReference ThrottleSettings
        {
            get => GetInstanceProperty<aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiStagesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanApiStages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ApiStagesInput
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
        [JsiiProperty(name: "productCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quotaSettingsInput", typeJson: "{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanQuotaSettings\"}", isOptional: true)]
        public virtual aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanQuotaSettings? QuotaSettingsInput
        {
            get => GetInstanceProperty<aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanQuotaSettings?>();
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
        [JsiiProperty(name: "throttleSettingsInput", typeJson: "{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettings\"}", isOptional: true)]
        public virtual aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanThrottleSettings? ThrottleSettingsInput
        {
            get => GetInstanceProperty<aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanThrottleSettings?>();
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "productCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductCode
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
