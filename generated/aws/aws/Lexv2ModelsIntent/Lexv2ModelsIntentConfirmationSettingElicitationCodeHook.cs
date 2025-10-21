using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingElicitationCodeHook")]
    public class Lexv2ModelsIntentConfirmationSettingElicitationCodeHook : aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingElicitationCodeHook
    {
        private object? _enableCodeHookInvocation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#enable_code_hook_invocation Lexv2ModelsIntent#enable_code_hook_invocation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableCodeHookInvocation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableCodeHookInvocation
        {
            get => _enableCodeHookInvocation;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableCodeHookInvocation = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#invocation_label Lexv2ModelsIntent#invocation_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "invocationLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InvocationLabel
        {
            get;
            set;
        }
    }
}
