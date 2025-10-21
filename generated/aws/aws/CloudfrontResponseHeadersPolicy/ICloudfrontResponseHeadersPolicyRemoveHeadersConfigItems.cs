using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontResponseHeadersPolicy
{
    [JsiiInterface(nativeType: typeof(ICloudfrontResponseHeadersPolicyRemoveHeadersConfigItems), fullyQualifiedName: "aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyRemoveHeadersConfigItems")]
    public interface ICloudfrontResponseHeadersPolicyRemoveHeadersConfigItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#header CloudfrontResponseHeadersPolicy#header}.</summary>
        [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
        string Header
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontResponseHeadersPolicyRemoveHeadersConfigItems), fullyQualifiedName: "aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyRemoveHeadersConfigItems")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyRemoveHeadersConfigItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#header CloudfrontResponseHeadersPolicy#header}.</summary>
            [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
            public string Header
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
