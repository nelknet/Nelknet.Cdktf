using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolAccountRecoverySetting), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolAccountRecoverySetting")]
    public interface ICognitoUserPoolAccountRecoverySetting
    {
        /// <summary>recovery_mechanism block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#recovery_mechanism CognitoUserPool#recovery_mechanism}
        /// </remarks>
        [JsiiProperty(name: "recoveryMechanism", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySettingRecoveryMechanism\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoveryMechanism
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolAccountRecoverySetting), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolAccountRecoverySetting")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>recovery_mechanism block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#recovery_mechanism CognitoUserPool#recovery_mechanism}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryMechanism", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySettingRecoveryMechanism\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecoveryMechanism
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
