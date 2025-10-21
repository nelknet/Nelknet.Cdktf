using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2Authorizer
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2AuthorizerTimeouts), fullyQualifiedName: "aws.apigatewayv2Authorizer.Apigatewayv2AuthorizerTimeouts")]
    public interface IApigatewayv2AuthorizerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#delete Apigatewayv2Authorizer#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2AuthorizerTimeouts), fullyQualifiedName: "aws.apigatewayv2Authorizer.Apigatewayv2AuthorizerTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2Authorizer.IApigatewayv2AuthorizerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#delete Apigatewayv2Authorizer#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
