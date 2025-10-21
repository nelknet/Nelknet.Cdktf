using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#connection_retry_interval MedialiveChannel#connection_retry_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionRetryInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectionRetryInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#filecache_duration MedialiveChannel#filecache_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filecacheDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FilecacheDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#media_store_storage_class MedialiveChannel#media_store_storage_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mediaStoreStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MediaStoreStorageClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#num_retries MedialiveChannel#num_retries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumRetries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#restart_delay MedialiveChannel#restart_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restartDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RestartDelay
        {
            get;
            set;
        }
    }
}
