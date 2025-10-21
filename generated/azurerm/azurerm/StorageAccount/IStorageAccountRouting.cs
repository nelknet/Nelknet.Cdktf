using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountRouting), fullyQualifiedName: "azurerm.storageAccount.StorageAccountRouting")]
    public interface IStorageAccountRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#choice StorageAccount#choice}.</summary>
        [JsiiProperty(name: "choice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Choice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#publish_internet_endpoints StorageAccount#publish_internet_endpoints}.</summary>
        [JsiiProperty(name: "publishInternetEndpoints", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublishInternetEndpoints
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#publish_microsoft_endpoints StorageAccount#publish_microsoft_endpoints}.</summary>
        [JsiiProperty(name: "publishMicrosoftEndpoints", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublishMicrosoftEndpoints
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountRouting), fullyQualifiedName: "azurerm.storageAccount.StorageAccountRouting")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#choice StorageAccount#choice}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "choice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Choice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#publish_internet_endpoints StorageAccount#publish_internet_endpoints}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publishInternetEndpoints", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PublishInternetEndpoints
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#publish_microsoft_endpoints StorageAccount#publish_microsoft_endpoints}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publishMicrosoftEndpoints", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PublishMicrosoftEndpoints
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
