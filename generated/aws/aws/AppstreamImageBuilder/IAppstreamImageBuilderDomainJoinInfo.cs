using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamImageBuilder
{
    [JsiiInterface(nativeType: typeof(IAppstreamImageBuilderDomainJoinInfo), fullyQualifiedName: "aws.appstreamImageBuilder.AppstreamImageBuilderDomainJoinInfo")]
    public interface IAppstreamImageBuilderDomainJoinInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#directory_name AppstreamImageBuilder#directory_name}.</summary>
        [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#organizational_unit_distinguished_name AppstreamImageBuilder#organizational_unit_distinguished_name}.</summary>
        [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationalUnitDistinguishedName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamImageBuilderDomainJoinInfo), fullyQualifiedName: "aws.appstreamImageBuilder.AppstreamImageBuilderDomainJoinInfo")]
        internal sealed class _Proxy : DeputyBase, aws.AppstreamImageBuilder.IAppstreamImageBuilderDomainJoinInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#directory_name AppstreamImageBuilder#directory_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#organizational_unit_distinguished_name AppstreamImageBuilder#organizational_unit_distinguished_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationalUnitDistinguishedName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
