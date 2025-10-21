using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderContainerRecipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilderContainerRecipe.ImagebuilderContainerRecipeComponentParameter")]
    public class ImagebuilderContainerRecipeComponentParameter : aws.ImagebuilderContainerRecipe.IImagebuilderContainerRecipeComponentParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#name ImagebuilderContainerRecipe#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_container_recipe#value ImagebuilderContainerRecipe#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
