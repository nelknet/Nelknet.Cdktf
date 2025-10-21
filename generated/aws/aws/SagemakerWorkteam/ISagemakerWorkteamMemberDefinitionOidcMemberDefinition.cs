using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkteamMemberDefinitionOidcMemberDefinition), fullyQualifiedName: "aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinition")]
    public interface ISagemakerWorkteamMemberDefinitionOidcMemberDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#groups SagemakerWorkteam#groups}.</summary>
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Groups
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkteamMemberDefinitionOidcMemberDefinition), fullyQualifiedName: "aws.sagemakerWorkteam.SagemakerWorkteamMemberDefinitionOidcMemberDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerWorkteam.ISagemakerWorkteamMemberDefinitionOidcMemberDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#groups SagemakerWorkteam#groups}.</summary>
            [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Groups
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
