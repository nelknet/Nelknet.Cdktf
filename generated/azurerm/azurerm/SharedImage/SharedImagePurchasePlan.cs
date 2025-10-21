using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.sharedImage.SharedImagePurchasePlan")]
    public class SharedImagePurchasePlan : azurerm.SharedImage.ISharedImagePurchasePlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#name SharedImage#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#product SharedImage#product}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Product
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image#publisher SharedImage#publisher}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Publisher
        {
            get;
            set;
        }
    }
}
