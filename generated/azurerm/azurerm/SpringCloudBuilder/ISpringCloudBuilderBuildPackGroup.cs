using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudBuilder
{
    [JsiiInterface(nativeType: typeof(ISpringCloudBuilderBuildPackGroup), fullyQualifiedName: "azurerm.springCloudBuilder.SpringCloudBuilderBuildPackGroup")]
    public interface ISpringCloudBuilderBuildPackGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#name SpringCloudBuilder#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#build_pack_ids SpringCloudBuilder#build_pack_ids}.</summary>
        [JsiiProperty(name: "buildPackIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BuildPackIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudBuilderBuildPackGroup), fullyQualifiedName: "azurerm.springCloudBuilder.SpringCloudBuilderBuildPackGroup")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudBuilder.ISpringCloudBuilderBuildPackGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#name SpringCloudBuilder#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#build_pack_ids SpringCloudBuilder#build_pack_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "buildPackIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BuildPackIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
