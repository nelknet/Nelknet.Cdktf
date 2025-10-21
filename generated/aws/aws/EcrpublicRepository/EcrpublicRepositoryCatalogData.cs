using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrpublicRepository
{
    [JsiiByValue(fqn: "aws.ecrpublicRepository.EcrpublicRepositoryCatalogData")]
    public class EcrpublicRepositoryCatalogData : aws.EcrpublicRepository.IEcrpublicRepositoryCatalogData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#about_text EcrpublicRepository#about_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aboutText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AboutText
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#architectures EcrpublicRepository#architectures}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "architectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Architectures
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#description EcrpublicRepository#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#logo_image_blob EcrpublicRepository#logo_image_blob}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logoImageBlob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoImageBlob
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#operating_systems EcrpublicRepository#operating_systems}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatingSystems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OperatingSystems
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#usage_text EcrpublicRepository#usage_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usageText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsageText
        {
            get;
            set;
        }
    }
}
