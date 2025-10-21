using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiByValue(fqn: "aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinition")]
    public class SagemakerWorkteamMemberDefinition : aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinition
    {
        /// <summary>cognito_member_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#cognito_member_definition SagemakerWorkteam#cognito_member_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition\"}", isOptional: true)]
        public aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition
        {
            get;
            set;
        }

        /// <summary>oidc_member_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#oidc_member_definition SagemakerWorkteam#oidc_member_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oidcMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinition\"}", isOptional: true)]
        public aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition? OidcMemberDefinition
        {
            get;
            set;
        }
    }
}
