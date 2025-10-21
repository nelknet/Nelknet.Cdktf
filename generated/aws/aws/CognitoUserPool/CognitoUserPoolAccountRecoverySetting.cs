using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolAccountRecoverySetting")]
    public class CognitoUserPoolAccountRecoverySetting : aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting
    {
        private object? _recoveryMechanism;

        /// <summary>recovery_mechanism block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#recovery_mechanism CognitoUserPool#recovery_mechanism}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryMechanism", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySettingRecoveryMechanism\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RecoveryMechanism
        {
            get => _recoveryMechanism;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _recoveryMechanism = value;
            }
        }
    }
}
