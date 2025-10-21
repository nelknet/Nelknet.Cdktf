using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageGallery
{
    [JsiiInterface(nativeType: typeof(ISharedImageGallerySharing), fullyQualifiedName: "azurerm.sharedImageGallery.SharedImageGallerySharing")]
    public interface ISharedImageGallerySharing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#permission SharedImageGallery#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        string Permission
        {
            get;
        }

        /// <summary>community_gallery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#community_gallery SharedImageGallery#community_gallery}
        /// </remarks>
        [JsiiProperty(name: "communityGallery", typeJson: "{\"fqn\":\"azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGallery\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery? CommunityGallery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISharedImageGallerySharing), fullyQualifiedName: "azurerm.sharedImageGallery.SharedImageGallerySharing")]
        internal sealed class _Proxy : DeputyBase, azurerm.SharedImageGallery.ISharedImageGallerySharing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#permission SharedImageGallery#permission}.</summary>
            [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
            public string Permission
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>community_gallery block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#community_gallery SharedImageGallery#community_gallery}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "communityGallery", typeJson: "{\"fqn\":\"azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGallery\"}", isOptional: true)]
            public azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery? CommunityGallery
            {
                get => GetInstanceProperty<azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery?>();
            }
        }
    }
}
