using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsVolumes
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEbsVolumes.DataAwsEbsVolumesFilter")]
    public class DataAwsEbsVolumesFilter : aws.DataAwsEbsVolumes.IDataAwsEbsVolumesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volumes#name DataAwsEbsVolumes#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volumes#values DataAwsEbsVolumes#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
