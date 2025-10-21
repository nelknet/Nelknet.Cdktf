using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2Integration
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2IntegrationResponseParameters), fullyQualifiedName: "aws.apigatewayv2Integration.Apigatewayv2IntegrationResponseParameters")]
    public interface IApigatewayv2IntegrationResponseParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#mappings Apigatewayv2Integration#mappings}.</summary>
        [JsiiProperty(name: "mappings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Mappings
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#status_code Apigatewayv2Integration#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
        string StatusCode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2IntegrationResponseParameters), fullyQualifiedName: "aws.apigatewayv2Integration.Apigatewayv2IntegrationResponseParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2Integration.IApigatewayv2IntegrationResponseParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#mappings Apigatewayv2Integration#mappings}.</summary>
            [JsiiProperty(name: "mappings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Mappings
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#status_code Apigatewayv2Integration#status_code}.</summary>
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
            public string StatusCode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
