using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageGallery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGallery")]
    public class SharedImageGallerySharingCommunityGallery : azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#eula SharedImageGallery#eula}.</summary>
        [JsiiProperty(name: "eula", typeJson: "{\"primitive\":\"string\"}")]
        public string Eula
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#prefix SharedImageGallery#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#publisher_email SharedImageGallery#publisher_email}.</summary>
        [JsiiProperty(name: "publisherEmail", typeJson: "{\"primitive\":\"string\"}")]
        public string PublisherEmail
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#publisher_uri SharedImageGallery#publisher_uri}.</summary>
        [JsiiProperty(name: "publisherUri", typeJson: "{\"primitive\":\"string\"}")]
        public string PublisherUri
        {
            get;
            set;
        }
    }
}
