using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsPrefixList
{
    [JsiiByValue(fqn: "aws.dataAwsPrefixList.DataAwsPrefixListTimeouts")]
    public class DataAwsPrefixListTimeouts : aws.DataAwsPrefixList.IDataAwsPrefixListTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prefix_list#read DataAwsPrefixList#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
