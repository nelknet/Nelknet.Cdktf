using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentClosingSettingNextStep), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingNextStep")]
    public interface ILexv2ModelsIntentClosingSettingNextStep
    {
        /// <summary>dialog_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#dialog_action Lexv2ModelsIntent#dialog_action}
        /// </remarks>
        [JsiiProperty(name: "dialogAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingNextStepDialogAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DialogAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>intent block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#intent Lexv2ModelsIntent#intent}
        /// </remarks>
        [JsiiProperty(name: "intent", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingNextStepIntent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Intent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#session_attributes Lexv2ModelsIntent#session_attributes}.</summary>
        [JsiiProperty(name: "sessionAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SessionAttributes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentClosingSettingNextStep), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingNextStep")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentClosingSettingNextStep
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dialog_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#dialog_action Lexv2ModelsIntent#dialog_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dialogAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingNextStepDialogAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DialogAction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>intent block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#intent Lexv2ModelsIntent#intent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intent", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingNextStepIntent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Intent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#session_attributes Lexv2ModelsIntent#session_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sessionAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SessionAttributes
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
