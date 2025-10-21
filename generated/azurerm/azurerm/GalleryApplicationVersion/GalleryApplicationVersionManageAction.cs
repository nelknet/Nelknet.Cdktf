using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.GalleryApplicationVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.galleryApplicationVersion.GalleryApplicationVersionManageAction")]
    public class GalleryApplicationVersionManageAction : azurerm.GalleryApplicationVersion.IGalleryApplicationVersionManageAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#install GalleryApplicationVersion#install}.</summary>
        [JsiiProperty(name: "install", typeJson: "{\"primitive\":\"string\"}")]
        public string Install
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#remove GalleryApplicationVersion#remove}.</summary>
        [JsiiProperty(name: "remove", typeJson: "{\"primitive\":\"string\"}")]
        public string Remove
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#update GalleryApplicationVersion#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
