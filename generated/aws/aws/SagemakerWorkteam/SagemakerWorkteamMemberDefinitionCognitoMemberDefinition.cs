using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition")]
    public class SagemakerWorkteamMemberDefinitionCognitoMemberDefinition : aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#client_id SagemakerWorkteam#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#user_group SagemakerWorkteam#user_group}.</summary>
        [JsiiProperty(name: "userGroup", typeJson: "{\"primitive\":\"string\"}")]
        public string UserGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#user_pool SagemakerWorkteam#user_pool}.</summary>
        [JsiiProperty(name: "userPool", typeJson: "{\"primitive\":\"string\"}")]
        public string UserPool
        {
            get;
            set;
        }
    }
}
