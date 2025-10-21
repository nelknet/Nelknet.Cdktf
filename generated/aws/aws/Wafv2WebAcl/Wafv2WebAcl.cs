using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl aws_wafv2_web_acl}.</summary>
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAcl.Wafv2WebAcl), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAcl", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclConfig\"}}]")]
    public class Wafv2WebAcl : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl aws_wafv2_web_acl} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Wafv2WebAcl(Constructs.Construct scope, string id, aws.Wafv2WebAcl.IWafv2WebAclConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Wafv2WebAcl.IWafv2WebAclConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAcl(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAcl(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Wafv2WebAcl resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Wafv2WebAcl to import.</param>
        /// <param name="importFromId">The id of the existing Wafv2WebAcl that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Wafv2WebAcl to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Wafv2WebAcl to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Wafv2WebAcl that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Wafv2WebAcl to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Wafv2WebAcl.Wafv2WebAcl), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAssociationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfig\"}}]")]
        public virtual void PutAssociationConfig(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCaptchaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclCaptchaConfig\"}}]")]
        public virtual void PutCaptchaConfig(aws.Wafv2WebAcl.IWafv2WebAclCaptchaConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclCaptchaConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putChallengeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclChallengeConfig\"}}]")]
        public virtual void PutChallengeConfig(aws.Wafv2WebAcl.IWafv2WebAclChallengeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclChallengeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomResponseBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclCustomResponseBody\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomResponseBody(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAcl.IWafv2WebAclCustomResponseBody[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclCustomResponseBody).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclCustomResponseBody).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataProtectionConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfig\"}}]")]
        public virtual void PutDataProtectionConfig(aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultAction\"}}]")]
        public virtual void PutDefaultAction(aws.Wafv2WebAcl.IWafv2WebAclDefaultAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclDefaultAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2WebAcl.IWafv2WebAclRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVisibilityConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclVisibilityConfig\"}}]")]
        public virtual void PutVisibilityConfig(aws.Wafv2WebAcl.IWafv2WebAclVisibilityConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclVisibilityConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssociationConfig")]
        public virtual void ResetAssociationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaptchaConfig")]
        public virtual void ResetCaptchaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChallengeConfig")]
        public virtual void ResetChallengeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomResponseBody")]
        public virtual void ResetCustomResponseBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataProtectionConfig")]
        public virtual void ResetDataProtectionConfig()
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

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRule")]
        public virtual void ResetRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuleJson")]
        public virtual void ResetRuleJson()
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

        [JsiiMethod(name: "resetTokenDomains")]
        public virtual void ResetTokenDomains()
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
        = GetStaticProperty<string>(typeof(aws.Wafv2WebAcl.Wafv2WebAcl))!;

        [JsiiProperty(name: "applicationIntegrationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationIntegrationUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associationConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigOutputReference AssociationConfig
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclAssociationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Capacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "captchaConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclCaptchaConfigOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclCaptchaConfigOutputReference CaptchaConfig
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclCaptchaConfigOutputReference>()!;
        }

        [JsiiProperty(name: "challengeConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclChallengeConfigOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclChallengeConfigOutputReference ChallengeConfig
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclChallengeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "customResponseBody", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclCustomResponseBodyList\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclCustomResponseBodyList CustomResponseBody
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclCustomResponseBodyList>()!;
        }

        [JsiiProperty(name: "dataProtectionConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclDataProtectionConfigOutputReference DataProtectionConfig
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclDataProtectionConfigOutputReference>()!;
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclDefaultActionOutputReference DefaultAction
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclDefaultActionOutputReference>()!;
        }

        [JsiiProperty(name: "lockToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LockToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleList\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleList Rule
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleList>()!;
        }

        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclVisibilityConfigOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclVisibilityConfigOutputReference VisibilityConfig
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclVisibilityConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associationConfigInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclAssociationConfig? AssociationConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captchaConfigInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclCaptchaConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclCaptchaConfig? CaptchaConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclCaptchaConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "challengeConfigInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclChallengeConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclChallengeConfig? ChallengeConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclChallengeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customResponseBodyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclCustomResponseBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomResponseBodyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionConfigInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfig? DataProtectionConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultAction\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclDefaultAction? DefaultActionInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclDefaultAction?>();
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
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleJsonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleJsonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "tokenDomainsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TokenDomainsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "visibilityConfigInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclVisibilityConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclVisibilityConfig? VisibilityConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclVisibilityConfig?>();
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

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleJson
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
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

        [JsiiProperty(name: "tokenDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TokenDomains
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
