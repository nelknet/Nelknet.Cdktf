using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudtrail
{
    [JsiiByValue(fqn: "aws.cloudtrail.CloudtrailEventSelector")]
    public class CloudtrailEventSelector : aws.Cloudtrail.ICloudtrailEventSelector
    {
        private object? _dataResource;

        /// <summary>data_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#data_resource Cloudtrail#data_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailEventSelectorDataResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataResource
        {
            get => _dataResource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Cloudtrail.ICloudtrailEventSelectorDataResource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Cloudtrail.ICloudtrailEventSelectorDataResource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataResource = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#exclude_management_event_sources Cloudtrail#exclude_management_event_sources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeManagementEventSources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludeManagementEventSources
        {
            get;
            set;
        }

        private object? _includeManagementEvents;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#include_management_events Cloudtrail#include_management_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeManagementEvents", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeManagementEvents
        {
            get => _includeManagementEvents;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includeManagementEvents = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#read_write_type Cloudtrail#read_write_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readWriteType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReadWriteType
        {
            get;
            set;
        }
    }
}
