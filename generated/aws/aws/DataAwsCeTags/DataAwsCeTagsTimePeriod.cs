using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsCeTags.DataAwsCeTagsTimePeriod")]
    public class DataAwsCeTagsTimePeriod : aws.DataAwsCeTags.IDataAwsCeTagsTimePeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#end DataAwsCeTags#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
        public string End
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#start DataAwsCeTags#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        public string Start
        {
            get;
            set;
        }
    }
}
