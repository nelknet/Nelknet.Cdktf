using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageGallery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.sharedImageGallery.SharedImageGallerySharing")]
    public class SharedImageGallerySharing : azurerm.SharedImageGallery.ISharedImageGallerySharing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#permission SharedImageGallery#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public string Permission
        {
            get;
            set;
        }

        /// <summary>community_gallery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#community_gallery SharedImageGallery#community_gallery}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "communityGallery", typeJson: "{\"fqn\":\"azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGallery\"}", isOptional: true)]
        public azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery? CommunityGallery
        {
            get;
            set;
        }
    }
}
