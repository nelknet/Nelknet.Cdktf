using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageGallery
{
    [JsiiInterface(nativeType: typeof(ISharedImageGallerySharingCommunityGallery), fullyQualifiedName: "azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGallery")]
    public interface ISharedImageGallerySharingCommunityGallery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#eula SharedImageGallery#eula}.</summary>
        [JsiiProperty(name: "eula", typeJson: "{\"primitive\":\"string\"}")]
        string Eula
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#prefix SharedImageGallery#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#publisher_email SharedImageGallery#publisher_email}.</summary>
        [JsiiProperty(name: "publisherEmail", typeJson: "{\"primitive\":\"string\"}")]
        string PublisherEmail
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#publisher_uri SharedImageGallery#publisher_uri}.</summary>
        [JsiiProperty(name: "publisherUri", typeJson: "{\"primitive\":\"string\"}")]
        string PublisherUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISharedImageGallerySharingCommunityGallery), fullyQualifiedName: "azurerm.sharedImageGallery.SharedImageGallerySharingCommunityGallery")]
        internal sealed class _Proxy : DeputyBase, azurerm.SharedImageGallery.ISharedImageGallerySharingCommunityGallery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#eula SharedImageGallery#eula}.</summary>
            [JsiiProperty(name: "eula", typeJson: "{\"primitive\":\"string\"}")]
            public string Eula
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#prefix SharedImageGallery#prefix}.</summary>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#publisher_email SharedImageGallery#publisher_email}.</summary>
            [JsiiProperty(name: "publisherEmail", typeJson: "{\"primitive\":\"string\"}")]
            public string PublisherEmail
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#publisher_uri SharedImageGallery#publisher_uri}.</summary>
            [JsiiProperty(name: "publisherUri", typeJson: "{\"primitive\":\"string\"}")]
            public string PublisherUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
