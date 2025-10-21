namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigDeliveryChannelState<'S3BucketName> = { assignments: ResizeArray<aws.ConfigDeliveryChannel.ConfigDeliveryChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel">aws_config_delivery_channel</a>.
    /// </summary>
    type ConfigDeliveryChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigDeliveryChannelState<Missing> =
            ({ assignments = ResizeArray() } : ConfigDeliveryChannelState<Missing>)

        member _.Zero(()) : ConfigDeliveryChannelState<Missing> =
            ({ assignments = ResizeArray() } : ConfigDeliveryChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#s3_bucket_name-1">ConfigDeliveryChannel#s3_bucket_name</a>.
        /// </summary>
        [<CustomOperation "s3_bucket_name">]
        member _.S3BucketName(state: ConfigDeliveryChannelState<Missing>, value: string) : ConfigDeliveryChannelState<Present> =
            state.assignments.Add(fun config -> config.S3BucketName <- value)
            ({ assignments = state.assignments } : ConfigDeliveryChannelState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#id-1">ConfigDeliveryChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigDeliveryChannelState<'S3BucketName>, value: string) : ConfigDeliveryChannelState<'S3BucketName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigDeliveryChannelState<'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#name-1">ConfigDeliveryChannel#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfigDeliveryChannelState<'S3BucketName>, value: string) : ConfigDeliveryChannelState<'S3BucketName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : ConfigDeliveryChannelState<'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#s3_key_prefix-1">ConfigDeliveryChannel#s3_key_prefix</a>.
        /// </summary>
        [<CustomOperation "s3_key_prefix">]
        member _.S3KeyPrefix(state: ConfigDeliveryChannelState<'S3BucketName>, value: string) : ConfigDeliveryChannelState<'S3BucketName> =
            state.assignments.Add(fun config -> config.S3KeyPrefix <- value)
            state : ConfigDeliveryChannelState<'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#s3_kms_key_arn-1">ConfigDeliveryChannel#s3_kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "s3_kms_key_arn">]
        member _.S3KmsKeyArn(state: ConfigDeliveryChannelState<'S3BucketName>, value: string) : ConfigDeliveryChannelState<'S3BucketName> =
            state.assignments.Add(fun config -> config.S3KmsKeyArn <- value)
            state : ConfigDeliveryChannelState<'S3BucketName>

        /// <summary>
        /// snapshot_delivery_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#snapshot_delivery_properties-1">ConfigDeliveryChannel#snapshot_delivery_properties</a>
        /// </summary>
        [<CustomOperation "snapshot_delivery_properties">]
        member _.SnapshotDeliveryProperties(state: ConfigDeliveryChannelState<'S3BucketName>, value: aws.ConfigDeliveryChannel.ConfigDeliveryChannelSnapshotDeliveryProperties) : ConfigDeliveryChannelState<'S3BucketName> =
            state.assignments.Add(fun config -> config.SnapshotDeliveryProperties <- value)
            state : ConfigDeliveryChannelState<'S3BucketName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#sns_topic_arn-1">ConfigDeliveryChannel#sns_topic_arn</a>.
        /// </summary>
        [<CustomOperation "sns_topic_arn">]
        member _.SnsTopicArn(state: ConfigDeliveryChannelState<'S3BucketName>, value: string) : ConfigDeliveryChannelState<'S3BucketName> =
            state.assignments.Add(fun config -> config.SnsTopicArn <- value)
            state : ConfigDeliveryChannelState<'S3BucketName>

        member _.Run(state: ConfigDeliveryChannelState<Present>) : aws.ConfigDeliveryChannel.ConfigDeliveryChannel =
            let config = aws.ConfigDeliveryChannel.ConfigDeliveryChannelConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigDeliveryChannel.ConfigDeliveryChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configDeliveryChannel: missing required arguments. Must call: s3_bucket_name.", 9999, IsError = true)>]
        member _.Run(_: ConfigDeliveryChannelState<_>) : aws.ConfigDeliveryChannel.ConfigDeliveryChannel =
            Unchecked.defaultof<aws.ConfigDeliveryChannel.ConfigDeliveryChannel>
