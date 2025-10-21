using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkteamMemberDefinition), fullyQualifiedName: "aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinition")]
    public interface ISagemakerWorkteamMemberDefinition
    {
        /// <summary>cognito_member_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#cognito_member_definition SagemakerWorkteam#cognito_member_definition}
        /// </remarks>
        [JsiiProperty(name: "cognitoMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>oidc_member_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#oidc_member_definition SagemakerWorkteam#oidc_member_definition}
        /// </remarks>
        [JsiiProperty(name: "oidcMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition? OidcMemberDefinition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkteamMemberDefinition), fullyQualifiedName: "aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cognito_member_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#cognito_member_definition SagemakerWorkteam#cognito_member_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionCognitoMemberDefinition\"}", isOptional: true)]
            public aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition
            {
                get => GetInstanceProperty<aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionCognitoMemberDefinition?>();
            }

            /// <summary>oidc_member_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#oidc_member_definition SagemakerWorkteam#oidc_member_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcMemberDefinition", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinition\"}", isOptional: true)]
            public aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition? OidcMemberDefinition
            {
                get => GetInstanceProperty<aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition?>();
            }
        }
    }
}
