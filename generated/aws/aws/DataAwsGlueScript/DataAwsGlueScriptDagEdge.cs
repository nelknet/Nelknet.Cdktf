using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsGlueScript
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsGlueScript.DataAwsGlueScriptDagEdge")]
    public class DataAwsGlueScriptDagEdge : aws.DataAwsGlueScript.IDataAwsGlueScriptDagEdge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#source DataAwsGlueScript#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#target DataAwsGlueScript#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        public string Target
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#target_parameter DataAwsGlueScript#target_parameter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetParameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetParameter
        {
            get;
            set;
        }
    }
}
