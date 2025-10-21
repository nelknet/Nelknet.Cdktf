using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinition")]
    public class SagemakerWorkteamMemberDefinitionOidcMemberDefinition : aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#groups SagemakerWorkteam#groups}.</summary>
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Groups
        {
            get;
            set;
        }
    }
}
