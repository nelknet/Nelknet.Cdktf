using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiByValue(fqn: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFileFormat")]
    public class AppmeshVirtualNodeSpecLoggingAccessLogFileFormat : aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFileFormat
    {
        private object? _json;

        /// <summary>json block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#json AppmeshVirtualNode#json}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecLoggingAccessLogFileFormatJson\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Json
        {
            get => _json;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFileFormatJson[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecLoggingAccessLogFileFormatJson).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _json = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#text AppmeshVirtualNode#text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Text
        {
            get;
            set;
        }
    }
}
