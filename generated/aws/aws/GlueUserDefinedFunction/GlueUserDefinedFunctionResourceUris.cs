using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueUserDefinedFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueUserDefinedFunction.GlueUserDefinedFunctionResourceUris")]
    public class GlueUserDefinedFunctionResourceUris : aws.GlueUserDefinedFunction.IGlueUserDefinedFunctionResourceUris
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#resource_type GlueUserDefinedFunction#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_user_defined_function#uri GlueUserDefinedFunction#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }
    }
}
