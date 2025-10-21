using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.GalleryApplicationVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.galleryApplicationVersion.GalleryApplicationVersionSource")]
    public class GalleryApplicationVersionSource : azurerm.GalleryApplicationVersion.IGalleryApplicationVersionSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#media_link GalleryApplicationVersion#media_link}.</summary>
        [JsiiProperty(name: "mediaLink", typeJson: "{\"primitive\":\"string\"}")]
        public string MediaLink
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#default_configuration_link GalleryApplicationVersion#default_configuration_link}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultConfigurationLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultConfigurationLink
        {
            get;
            set;
        }
    }
}
