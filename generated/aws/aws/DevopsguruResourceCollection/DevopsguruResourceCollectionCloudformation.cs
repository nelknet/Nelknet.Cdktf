using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruResourceCollection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.devopsguruResourceCollection.DevopsguruResourceCollectionCloudformation")]
    public class DevopsguruResourceCollectionCloudformation : aws.DevopsguruResourceCollection.IDevopsguruResourceCollectionCloudformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#stack_names DevopsguruResourceCollection#stack_names}.</summary>
        [JsiiProperty(name: "stackNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] StackNames
        {
            get;
            set;
        }
    }
}
