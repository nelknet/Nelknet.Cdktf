using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.GalleryApplicationVersion
{
    [JsiiInterface(nativeType: typeof(IGalleryApplicationVersionManageAction), fullyQualifiedName: "azurerm.galleryApplicationVersion.GalleryApplicationVersionManageAction")]
    public interface IGalleryApplicationVersionManageAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#install GalleryApplicationVersion#install}.</summary>
        [JsiiProperty(name: "install", typeJson: "{\"primitive\":\"string\"}")]
        string Install
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#remove GalleryApplicationVersion#remove}.</summary>
        [JsiiProperty(name: "remove", typeJson: "{\"primitive\":\"string\"}")]
        string Remove
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#update GalleryApplicationVersion#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGalleryApplicationVersionManageAction), fullyQualifiedName: "azurerm.galleryApplicationVersion.GalleryApplicationVersionManageAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.GalleryApplicationVersion.IGalleryApplicationVersionManageAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#install GalleryApplicationVersion#install}.</summary>
            [JsiiProperty(name: "install", typeJson: "{\"primitive\":\"string\"}")]
            public string Install
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#remove GalleryApplicationVersion#remove}.</summary>
            [JsiiProperty(name: "remove", typeJson: "{\"primitive\":\"string\"}")]
            public string Remove
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#update GalleryApplicationVersion#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
