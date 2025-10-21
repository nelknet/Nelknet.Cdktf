using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrpublicRepository
{
    [JsiiInterface(nativeType: typeof(IEcrpublicRepositoryCatalogData), fullyQualifiedName: "aws.ecrpublicRepository.EcrpublicRepositoryCatalogData")]
    public interface IEcrpublicRepositoryCatalogData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#about_text EcrpublicRepository#about_text}.</summary>
        [JsiiProperty(name: "aboutText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AboutText
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#architectures EcrpublicRepository#architectures}.</summary>
        [JsiiProperty(name: "architectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Architectures
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#description EcrpublicRepository#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#logo_image_blob EcrpublicRepository#logo_image_blob}.</summary>
        [JsiiProperty(name: "logoImageBlob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogoImageBlob
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#operating_systems EcrpublicRepository#operating_systems}.</summary>
        [JsiiProperty(name: "operatingSystems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OperatingSystems
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#usage_text EcrpublicRepository#usage_text}.</summary>
        [JsiiProperty(name: "usageText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageText
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrpublicRepositoryCatalogData), fullyQualifiedName: "aws.ecrpublicRepository.EcrpublicRepositoryCatalogData")]
        internal sealed class _Proxy : DeputyBase, aws.EcrpublicRepository.IEcrpublicRepositoryCatalogData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#about_text EcrpublicRepository#about_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aboutText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AboutText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#architectures EcrpublicRepository#architectures}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "architectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Architectures
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#description EcrpublicRepository#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#logo_image_blob EcrpublicRepository#logo_image_blob}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logoImageBlob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogoImageBlob
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#operating_systems EcrpublicRepository#operating_systems}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operatingSystems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OperatingSystems
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#usage_text EcrpublicRepository#usage_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usageText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageText
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
