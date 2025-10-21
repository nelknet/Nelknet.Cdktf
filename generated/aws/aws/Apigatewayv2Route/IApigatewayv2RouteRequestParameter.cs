using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2Route
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2RouteRequestParameter), fullyQualifiedName: "aws.apigatewayv2Route.Apigatewayv2RouteRequestParameter")]
    public interface IApigatewayv2RouteRequestParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#request_parameter_key Apigatewayv2Route#request_parameter_key}.</summary>
        [JsiiProperty(name: "requestParameterKey", typeJson: "{\"primitive\":\"string\"}")]
        string RequestParameterKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#required Apigatewayv2Route#required}.</summary>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Required
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2RouteRequestParameter), fullyQualifiedName: "aws.apigatewayv2Route.Apigatewayv2RouteRequestParameter")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2Route.IApigatewayv2RouteRequestParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#request_parameter_key Apigatewayv2Route#request_parameter_key}.</summary>
            [JsiiProperty(name: "requestParameterKey", typeJson: "{\"primitive\":\"string\"}")]
            public string RequestParameterKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_route#required Apigatewayv2Route#required}.</summary>
            [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Required
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
