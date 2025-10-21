using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolUserPoolAddOns), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolUserPoolAddOns")]
    public interface ICognitoUserPoolUserPoolAddOns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#advanced_security_mode CognitoUserPool#advanced_security_mode}.</summary>
        [JsiiProperty(name: "advancedSecurityMode", typeJson: "{\"primitive\":\"string\"}")]
        string AdvancedSecurityMode
        {
            get;
        }

        /// <summary>advanced_security_additional_flows block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#advanced_security_additional_flows CognitoUserPool#advanced_security_additional_flows}
        /// </remarks>
        [JsiiProperty(name: "advancedSecurityAdditionalFlows", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows? AdvancedSecurityAdditionalFlows
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolUserPoolAddOns), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolUserPoolAddOns")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#advanced_security_mode CognitoUserPool#advanced_security_mode}.</summary>
            [JsiiProperty(name: "advancedSecurityMode", typeJson: "{\"primitive\":\"string\"}")]
            public string AdvancedSecurityMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>advanced_security_additional_flows block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#advanced_security_additional_flows CognitoUserPool#advanced_security_additional_flows}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "advancedSecurityAdditionalFlows", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows? AdvancedSecurityAdditionalFlows
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows?>();
            }
        }
    }
}
