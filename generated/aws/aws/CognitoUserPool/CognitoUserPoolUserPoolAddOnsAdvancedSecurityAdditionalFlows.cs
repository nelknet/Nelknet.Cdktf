using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows")]
    public class CognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows : aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOnsAdvancedSecurityAdditionalFlows
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#custom_auth_mode CognitoUserPool#custom_auth_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customAuthMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomAuthMode
        {
            get;
            set;
        }
    }
}
