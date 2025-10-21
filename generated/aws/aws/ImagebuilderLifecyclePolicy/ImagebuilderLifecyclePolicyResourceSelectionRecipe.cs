using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderLifecyclePolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyResourceSelectionRecipe")]
    public class ImagebuilderLifecyclePolicyResourceSelectionRecipe : aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyResourceSelectionRecipe
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#name ImagebuilderLifecyclePolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#semantic_version ImagebuilderLifecyclePolicy#semantic_version}.</summary>
        [JsiiProperty(name: "semanticVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string SemanticVersion
        {
            get;
            set;
        }
    }
}
