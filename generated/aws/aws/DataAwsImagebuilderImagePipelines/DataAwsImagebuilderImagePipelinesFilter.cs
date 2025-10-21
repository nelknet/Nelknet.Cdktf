using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsImagebuilderImagePipelines
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsImagebuilderImagePipelines.DataAwsImagebuilderImagePipelinesFilter")]
    public class DataAwsImagebuilderImagePipelinesFilter : aws.DataAwsImagebuilderImagePipelines.IDataAwsImagebuilderImagePipelinesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_pipelines#name DataAwsImagebuilderImagePipelines#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_image_pipelines#values DataAwsImagebuilderImagePipelines#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
