using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolUserPoolAddOns")]
    public class CognitoUserPoolUserPoolAddOns : aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#advanced_security_mode CognitoUserPool#advanced_security_mode}.</summary>
        [JsiiProperty(name: "advancedSecurityMode", typeJson: "{\"primitive\":\"string\"}")]
        public string AdvancedSecurityMode
        {
            get;
            set;
        }

        /// <summary>advanced_security_additional_flows block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#advanced_security_additional_flows CognitoUserPool#advanced_security_additional_flows}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityAdditionalFlows", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows? AdvancedSecurityAdditionalFlows
        {
            get;
            set;
        }
    }
}
