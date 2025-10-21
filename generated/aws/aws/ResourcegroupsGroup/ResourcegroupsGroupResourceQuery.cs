using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResourcegroupsGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resourcegroupsGroup.ResourcegroupsGroupResourceQuery")]
    public class ResourcegroupsGroupResourceQuery : aws.ResourcegroupsGroup.IResourcegroupsGroupResourceQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#query ResourcegroupsGroup#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public string Query
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_group#type ResourcegroupsGroup#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
