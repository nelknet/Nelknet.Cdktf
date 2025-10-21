using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteMatch), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatch")]
    public interface IAppmeshGatewayRouteSpecHttpRouteMatch
    {
        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#header AppmeshGatewayRoute#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatchHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>hostname block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#hostname AppmeshGatewayRoute#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatchHostname\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteMatchHostname? Hostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#path AppmeshGatewayRoute#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatchPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteMatchPath? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#port AppmeshGatewayRoute#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#prefix AppmeshGatewayRoute#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#query_parameter AppmeshGatewayRoute#query_parameter}
        /// </remarks>
        [JsiiProperty(name: "queryParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatchQueryParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryParameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecHttpRouteMatch), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatch")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#header AppmeshGatewayRoute#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatchHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Header
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>hostname block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#hostname AppmeshGatewayRoute#hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatchHostname\"}", isOptional: true)]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteMatchHostname? Hostname
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteMatchHostname?>();
            }

            /// <summary>path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#path AppmeshGatewayRoute#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatchPath\"}", isOptional: true)]
            public aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteMatchPath? Path
            {
                get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteMatchPath?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#port AppmeshGatewayRoute#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#prefix AppmeshGatewayRoute#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>query_parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#query_parameter AppmeshGatewayRoute#query_parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteMatchQueryParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryParameter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
