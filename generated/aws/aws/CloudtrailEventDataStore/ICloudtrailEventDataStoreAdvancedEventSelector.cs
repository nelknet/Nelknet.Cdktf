using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudtrailEventDataStore
{
    [JsiiInterface(nativeType: typeof(ICloudtrailEventDataStoreAdvancedEventSelector), fullyQualifiedName: "aws.cloudtrailEventDataStore.CloudtrailEventDataStoreAdvancedEventSelector")]
    public interface ICloudtrailEventDataStoreAdvancedEventSelector
    {
        /// <summary>field_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#field_selector CloudtrailEventDataStore#field_selector}
        /// </remarks>
        [JsiiProperty(name: "fieldSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrailEventDataStore.CloudtrailEventDataStoreAdvancedEventSelectorFieldSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FieldSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#name CloudtrailEventDataStore#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudtrailEventDataStoreAdvancedEventSelector), fullyQualifiedName: "aws.cloudtrailEventDataStore.CloudtrailEventDataStoreAdvancedEventSelector")]
        internal sealed class _Proxy : DeputyBase, aws.CloudtrailEventDataStore.ICloudtrailEventDataStoreAdvancedEventSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_selector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#field_selector CloudtrailEventDataStore#field_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrailEventDataStore.CloudtrailEventDataStoreAdvancedEventSelectorFieldSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FieldSelector
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#name CloudtrailEventDataStore#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
