using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent aws_lex_intent}.</summary>
    [JsiiClass(nativeType: typeof(aws.LexIntent.LexIntent), fullyQualifiedName: "aws.lexIntent.LexIntent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentConfig\"}}]")]
    public class LexIntent : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent aws_lex_intent} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LexIntent(Constructs.Construct scope, string id, aws.LexIntent.ILexIntentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LexIntent.ILexIntentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntent(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LexIntent resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LexIntent to import.</param>
        /// <param name="importFromId">The id of the existing LexIntent that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LexIntent to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LexIntent to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LexIntent that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LexIntent to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.LexIntent.LexIntent), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConclusionStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentConclusionStatement\"}}]")]
        public virtual void PutConclusionStatement(aws.LexIntent.ILexIntentConclusionStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentConclusionStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfirmationPrompt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentConfirmationPrompt\"}}]")]
        public virtual void PutConfirmationPrompt(aws.LexIntent.ILexIntentConfirmationPrompt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentConfirmationPrompt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDialogCodeHook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentDialogCodeHook\"}}]")]
        public virtual void PutDialogCodeHook(aws.LexIntent.ILexIntentDialogCodeHook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentDialogCodeHook)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFollowUpPrompt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPrompt\"}}]")]
        public virtual void PutFollowUpPrompt(aws.LexIntent.ILexIntentFollowUpPrompt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentFollowUpPrompt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFulfillmentActivity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivity\"}}]")]
        public virtual void PutFulfillmentActivity(aws.LexIntent.ILexIntentFulfillmentActivity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentFulfillmentActivity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRejectionStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentRejectionStatement\"}}]")]
        public virtual void PutRejectionStatement(aws.LexIntent.ILexIntentRejectionStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentRejectionStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlot", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexIntent.LexIntentSlot\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSlot(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LexIntent.ILexIntentSlot[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LexIntent.ILexIntentSlot).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LexIntent.ILexIntentSlot).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lexIntent.LexIntentTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.LexIntent.ILexIntentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LexIntent.ILexIntentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConclusionStatement")]
        public virtual void ResetConclusionStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfirmationPrompt")]
        public virtual void ResetConfirmationPrompt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateVersion")]
        public virtual void ResetCreateVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDialogCodeHook")]
        public virtual void ResetDialogCodeHook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFollowUpPrompt")]
        public virtual void ResetFollowUpPrompt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParentIntentSignature")]
        public virtual void ResetParentIntentSignature()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRejectionStatement")]
        public virtual void ResetRejectionStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSampleUtterances")]
        public virtual void ResetSampleUtterances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlot")]
        public virtual void ResetSlot()
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
        = GetStaticProperty<string>(typeof(aws.LexIntent.LexIntent))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksum", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Checksum
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conclusionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentConclusionStatementOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentConclusionStatementOutputReference ConclusionStatement
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentConclusionStatementOutputReference>()!;
        }

        [JsiiProperty(name: "confirmationPrompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentConfirmationPromptOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentConfirmationPromptOutputReference ConfirmationPrompt
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentConfirmationPromptOutputReference>()!;
        }

        [JsiiProperty(name: "createdDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dialogCodeHook", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentDialogCodeHookOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentDialogCodeHookOutputReference DialogCodeHook
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentDialogCodeHookOutputReference>()!;
        }

        [JsiiProperty(name: "followUpPrompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentFollowUpPromptOutputReference FollowUpPrompt
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentFollowUpPromptOutputReference>()!;
        }

        [JsiiProperty(name: "fulfillmentActivity", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivityOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentFulfillmentActivityOutputReference FulfillmentActivity
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentFulfillmentActivityOutputReference>()!;
        }

        [JsiiProperty(name: "lastUpdatedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentRejectionStatementOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentRejectionStatementOutputReference RejectionStatement
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentRejectionStatementOutputReference>()!;
        }

        [JsiiProperty(name: "slot", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentSlotList\"}")]
        public virtual aws.LexIntent.LexIntentSlotList Slot
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentSlotList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentTimeoutsOutputReference\"}")]
        public virtual aws.LexIntent.LexIntentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.LexIntent.LexIntentTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conclusionStatementInput", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentConclusionStatement\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentConclusionStatement? ConclusionStatementInput
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentConclusionStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "confirmationPromptInput", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentConfirmationPrompt\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentConfirmationPrompt? ConfirmationPromptInput
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentConfirmationPrompt?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createVersionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CreateVersionInput
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
        [JsiiProperty(name: "dialogCodeHookInput", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentDialogCodeHook\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentDialogCodeHook? DialogCodeHookInput
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentDialogCodeHook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "followUpPromptInput", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPrompt\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentFollowUpPrompt? FollowUpPromptInput
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentFollowUpPrompt?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fulfillmentActivityInput", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivity\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentFulfillmentActivity? FulfillmentActivityInput
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentFulfillmentActivity?>();
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
        [JsiiProperty(name: "parentIntentSignatureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentIntentSignatureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rejectionStatementInput", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentRejectionStatement\"}", isOptional: true)]
        public virtual aws.LexIntent.ILexIntentRejectionStatement? RejectionStatementInput
        {
            get => GetInstanceProperty<aws.LexIntent.ILexIntentRejectionStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sampleUtterancesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SampleUtterancesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slotInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexIntent.LexIntentSlot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SlotInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.lexIntent.LexIntentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "createVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CreateVersion
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
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

        [JsiiProperty(name: "parentIntentSignature", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentIntentSignature
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SampleUtterances
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
