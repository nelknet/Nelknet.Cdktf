using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRamResourceShare
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsRamResourceShare.DataAwsRamResourceShareFilter")]
    public class DataAwsRamResourceShareFilter : aws.DataAwsRamResourceShare.IDataAwsRamResourceShareFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ram_resource_share#name DataAwsRamResourceShare#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ram_resource_share#values DataAwsRamResourceShare#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
