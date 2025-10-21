using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsBotLocale
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale aws_lexv2models_bot_locale}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocale), fullyQualifiedName: "aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocale", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleConfig\"}}]")]
    public class Lexv2ModelsBotLocale : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale aws_lexv2models_bot_locale} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Lexv2ModelsBotLocale(Constructs.Construct scope, string id, aws.Lexv2ModelsBotLocale.ILexv2ModelsBotLocaleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Lexv2ModelsBotLocale.ILexv2ModelsBotLocaleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Lexv2ModelsBotLocale(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Lexv2ModelsBotLocale(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Lexv2ModelsBotLocale resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Lexv2ModelsBotLocale to import.</param>
        /// <param name="importFromId">The id of the existing Lexv2ModelsBotLocale that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Lexv2ModelsBotLocale to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Lexv2ModelsBotLocale to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Lexv2ModelsBotLocale that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Lexv2ModelsBotLocale to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocale), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Lexv2ModelsBotLocale.ILexv2ModelsBotLocaleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lexv2ModelsBotLocale.ILexv2ModelsBotLocaleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVoiceSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleVoiceSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVoiceSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Lexv2ModelsBotLocale.ILexv2ModelsBotLocaleVoiceSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsBotLocale.ILexv2ModelsBotLocaleVoiceSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsBotLocale.ILexv2ModelsBotLocaleVoiceSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVoiceSettings")]
        public virtual void ResetVoiceSettings()
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
        = GetStaticProperty<string>(typeof(aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocale))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleTimeoutsOutputReference\"}")]
        public virtual aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocaleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocaleTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "voiceSettings", typeJson: "{\"fqn\":\"aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleVoiceSettingsList\"}")]
        public virtual aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocaleVoiceSettingsList VoiceSettings
        {
            get => GetInstanceProperty<aws.Lexv2ModelsBotLocale.Lexv2ModelsBotLocaleVoiceSettingsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "botIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BotIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "botVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BotVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocaleIdInput
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
        [JsiiProperty(name: "nLuIntentConfidenceThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NLuIntentConfidenceThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "voiceSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleVoiceSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VoiceSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "botId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BotId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "botVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BotVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocaleId
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

        [JsiiProperty(name: "nLuIntentConfidenceThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NLuIntentConfidenceThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
