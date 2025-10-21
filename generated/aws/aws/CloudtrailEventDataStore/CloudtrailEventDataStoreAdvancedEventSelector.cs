using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudtrailEventDataStore
{
    [JsiiByValue(fqn: "aws.cloudtrailEventDataStore.CloudtrailEventDataStoreAdvancedEventSelector")]
    public class CloudtrailEventDataStoreAdvancedEventSelector : aws.CloudtrailEventDataStore.ICloudtrailEventDataStoreAdvancedEventSelector
    {
        private object? _fieldSelector;

        /// <summary>field_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#field_selector CloudtrailEventDataStore#field_selector}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrailEventDataStore.CloudtrailEventDataStoreAdvancedEventSelectorFieldSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FieldSelector
        {
            get => _fieldSelector;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CloudtrailEventDataStore.ICloudtrailEventDataStoreAdvancedEventSelectorFieldSelector[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudtrailEventDataStore.ICloudtrailEventDataStoreAdvancedEventSelectorFieldSelector).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fieldSelector = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_event_data_store#name CloudtrailEventDataStore#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
