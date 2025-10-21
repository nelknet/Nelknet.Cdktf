using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    [JsiiInterface(nativeType: typeof(ILexIntentConfig), fullyQualifiedName: "aws.lexIntent.LexIntentConfig")]
    public interface ILexIntentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>fulfillment_activity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#fulfillment_activity LexIntent#fulfillment_activity}
        /// </remarks>
        [JsiiProperty(name: "fulfillmentActivity", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivity\"}")]
        aws.LexIntent.ILexIntentFulfillmentActivity FulfillmentActivity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#name LexIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>conclusion_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#conclusion_statement LexIntent#conclusion_statement}
        /// </remarks>
        [JsiiProperty(name: "conclusionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentConclusionStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LexIntent.ILexIntentConclusionStatement? ConclusionStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>confirmation_prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#confirmation_prompt LexIntent#confirmation_prompt}
        /// </remarks>
        [JsiiProperty(name: "confirmationPrompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentConfirmationPrompt\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LexIntent.ILexIntentConfirmationPrompt? ConfirmationPrompt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#create_version LexIntent#create_version}.</summary>
        [JsiiProperty(name: "createVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreateVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#description LexIntent#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dialog_code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#dialog_code_hook LexIntent#dialog_code_hook}
        /// </remarks>
        [JsiiProperty(name: "dialogCodeHook", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentDialogCodeHook\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LexIntent.ILexIntentDialogCodeHook? DialogCodeHook
        {
            get
            {
                return null;
            }
        }

        /// <summary>follow_up_prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#follow_up_prompt LexIntent#follow_up_prompt}
        /// </remarks>
        [JsiiProperty(name: "followUpPrompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPrompt\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LexIntent.ILexIntentFollowUpPrompt? FollowUpPrompt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#id LexIntent#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#parent_intent_signature LexIntent#parent_intent_signature}.</summary>
        [JsiiProperty(name: "parentIntentSignature", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentIntentSignature
        {
            get
            {
                return null;
            }
        }

        /// <summary>rejection_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#rejection_statement LexIntent#rejection_statement}
        /// </remarks>
        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentRejectionStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LexIntent.ILexIntentRejectionStatement? RejectionStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#sample_utterances LexIntent#sample_utterances}.</summary>
        [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SampleUtterances
        {
            get
            {
                return null;
            }
        }

        /// <summary>slot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot LexIntent#slot}
        /// </remarks>
        [JsiiProperty(name: "slot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexIntent.LexIntentSlot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Slot
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#timeouts LexIntent#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LexIntent.ILexIntentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexIntentConfig), fullyQualifiedName: "aws.lexIntent.LexIntentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LexIntent.ILexIntentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>fulfillment_activity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#fulfillment_activity LexIntent#fulfillment_activity}
            /// </remarks>
            [JsiiProperty(name: "fulfillmentActivity", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivity\"}")]
            public aws.LexIntent.ILexIntentFulfillmentActivity FulfillmentActivity
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentFulfillmentActivity>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#name LexIntent#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>conclusion_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#conclusion_statement LexIntent#conclusion_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conclusionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentConclusionStatement\"}", isOptional: true)]
            public aws.LexIntent.ILexIntentConclusionStatement? ConclusionStatement
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentConclusionStatement?>();
            }

            /// <summary>confirmation_prompt block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#confirmation_prompt LexIntent#confirmation_prompt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "confirmationPrompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentConfirmationPrompt\"}", isOptional: true)]
            public aws.LexIntent.ILexIntentConfirmationPrompt? ConfirmationPrompt
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentConfirmationPrompt?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#create_version LexIntent#create_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CreateVersion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#description LexIntent#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dialog_code_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#dialog_code_hook LexIntent#dialog_code_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dialogCodeHook", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentDialogCodeHook\"}", isOptional: true)]
            public aws.LexIntent.ILexIntentDialogCodeHook? DialogCodeHook
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentDialogCodeHook?>();
            }

            /// <summary>follow_up_prompt block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#follow_up_prompt LexIntent#follow_up_prompt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "followUpPrompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPrompt\"}", isOptional: true)]
            public aws.LexIntent.ILexIntentFollowUpPrompt? FollowUpPrompt
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentFollowUpPrompt?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#id LexIntent#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#parent_intent_signature LexIntent#parent_intent_signature}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parentIntentSignature", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentIntentSignature
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rejection_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#rejection_statement LexIntent#rejection_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentRejectionStatement\"}", isOptional: true)]
            public aws.LexIntent.ILexIntentRejectionStatement? RejectionStatement
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentRejectionStatement?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#sample_utterances LexIntent#sample_utterances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SampleUtterances
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>slot block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot LexIntent#slot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexIntent.LexIntentSlot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Slot
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#timeouts LexIntent#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentTimeouts\"}", isOptional: true)]
            public aws.LexIntent.ILexIntentTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
