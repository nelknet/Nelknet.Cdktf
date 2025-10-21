using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkforce
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerWorkforce.SagemakerWorkforceCognitoConfig")]
    public class SagemakerWorkforceCognitoConfig : aws.SagemakerWorkforce.ISagemakerWorkforceCognitoConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#client_id SagemakerWorkforce#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#user_pool SagemakerWorkforce#user_pool}.</summary>
        [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}")]
        public string UserPool
        {
            get;
            set;
        }
    }
}
