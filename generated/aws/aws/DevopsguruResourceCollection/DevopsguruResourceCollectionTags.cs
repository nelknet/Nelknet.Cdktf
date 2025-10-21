using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruResourceCollection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.devopsguruResourceCollection.DevopsguruResourceCollectionTags")]
    public class DevopsguruResourceCollectionTags : aws.DevopsguruResourceCollection.IDevopsguruResourceCollectionTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#app_boundary_key DevopsguruResourceCollection#app_boundary_key}.</summary>
        [JsiiProperty(name: "appBoundaryKey", typeJson: "{\"primitive\":\"string\"}")]
        public string AppBoundaryKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#tag_values DevopsguruResourceCollection#tag_values}.</summary>
        [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] TagValues
        {
            get;
            set;
        }
    }
}
