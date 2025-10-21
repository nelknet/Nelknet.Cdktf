using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolSchemaNumberAttributeConstraints")]
    public class CognitoUserPoolSchemaNumberAttributeConstraints : aws.CognitoUserPool.ICognitoUserPoolSchemaNumberAttributeConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#max_value CognitoUserPool#max_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#min_value CognitoUserPool#min_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinValue
        {
            get;
            set;
        }
    }
}
