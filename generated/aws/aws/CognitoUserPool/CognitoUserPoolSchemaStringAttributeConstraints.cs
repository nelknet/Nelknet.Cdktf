using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolSchemaStringAttributeConstraints")]
    public class CognitoUserPoolSchemaStringAttributeConstraints : aws.CognitoUserPool.ICognitoUserPoolSchemaStringAttributeConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#max_length CognitoUserPool#max_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#min_length CognitoUserPool#min_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinLength
        {
            get;
            set;
        }
    }
}
