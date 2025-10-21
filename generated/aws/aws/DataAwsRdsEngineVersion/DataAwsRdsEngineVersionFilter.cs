using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRdsEngineVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsRdsEngineVersion.DataAwsRdsEngineVersionFilter")]
    public class DataAwsRdsEngineVersionFilter : aws.DataAwsRdsEngineVersion.IDataAwsRdsEngineVersionFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#name DataAwsRdsEngineVersion#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#values DataAwsRdsEngineVersion#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
