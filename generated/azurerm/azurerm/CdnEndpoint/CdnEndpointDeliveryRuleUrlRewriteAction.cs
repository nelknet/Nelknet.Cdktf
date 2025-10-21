using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRewriteAction")]
    public class CdnEndpointDeliveryRuleUrlRewriteAction : azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRewriteAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#destination CdnEndpoint#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#source_pattern CdnEndpoint#source_pattern}.</summary>
        [JsiiProperty(name: "sourcePattern", typeJson: "{\"primitive\":\"string\"}")]
        public string SourcePattern
        {
            get;
            set;
        }

        private object? _preserveUnmatchedPath;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#preserve_unmatched_path CdnEndpoint#preserve_unmatched_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preserveUnmatchedPath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PreserveUnmatchedPath
        {
            get => _preserveUnmatchedPath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _preserveUnmatchedPath = value;
            }
        }
    }
}
