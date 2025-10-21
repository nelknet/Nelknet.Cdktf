using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ElasticSanVolume
{
    [JsiiInterface(nativeType: typeof(IElasticSanVolumeCreateSource), fullyQualifiedName: "azurerm.elasticSanVolume.ElasticSanVolumeCreateSource")]
    public interface IElasticSanVolumeCreateSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#source_id ElasticSanVolume#source_id}.</summary>
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#source_type ElasticSanVolume#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        string SourceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticSanVolumeCreateSource), fullyQualifiedName: "azurerm.elasticSanVolume.ElasticSanVolumeCreateSource")]
        internal sealed class _Proxy : DeputyBase, azurerm.ElasticSanVolume.IElasticSanVolumeCreateSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#source_id ElasticSanVolume#source_id}.</summary>
            [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san_volume#source_type ElasticSanVolume#source_type}.</summary>
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
