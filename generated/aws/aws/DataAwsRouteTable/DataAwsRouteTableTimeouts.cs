using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRouteTable
{
    [JsiiByValue(fqn: "aws.dataAwsRouteTable.DataAwsRouteTableTimeouts")]
    public class DataAwsRouteTableTimeouts : aws.DataAwsRouteTable.IDataAwsRouteTableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#read DataAwsRouteTable#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
