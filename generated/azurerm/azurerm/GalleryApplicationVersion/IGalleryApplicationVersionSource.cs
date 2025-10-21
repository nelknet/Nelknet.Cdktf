using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.GalleryApplicationVersion
{
    [JsiiInterface(nativeType: typeof(IGalleryApplicationVersionSource), fullyQualifiedName: "azurerm.galleryApplicationVersion.GalleryApplicationVersionSource")]
    public interface IGalleryApplicationVersionSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#media_link GalleryApplicationVersion#media_link}.</summary>
        [JsiiProperty(name: "mediaLink", typeJson: "{\"primitive\":\"string\"}")]
        string MediaLink
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#default_configuration_link GalleryApplicationVersion#default_configuration_link}.</summary>
        [JsiiProperty(name: "defaultConfigurationLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultConfigurationLink
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGalleryApplicationVersionSource), fullyQualifiedName: "azurerm.galleryApplicationVersion.GalleryApplicationVersionSource")]
        internal sealed class _Proxy : DeputyBase, azurerm.GalleryApplicationVersion.IGalleryApplicationVersionSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#media_link GalleryApplicationVersion#media_link}.</summary>
            [JsiiProperty(name: "mediaLink", typeJson: "{\"primitive\":\"string\"}")]
            public string MediaLink
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#default_configuration_link GalleryApplicationVersion#default_configuration_link}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultConfigurationLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultConfigurationLink
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
