namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RekognitionStreamProcessorState<'Name, 'RoleArn> = { assignments: ResizeArray<aws.RekognitionStreamProcessor.RekognitionStreamProcessorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor">aws_rekognition_stream_processor</a>.
    /// </summary>
    type RekognitionStreamProcessorBuilder(logicalId: string) =
        member _.Yield(_: unit) : RekognitionStreamProcessorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RekognitionStreamProcessorState<Missing, Missing>)

        member _.Zero(()) : RekognitionStreamProcessorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RekognitionStreamProcessorState<Missing, Missing>)

        /// <summary>
        /// An identifier you assign to the stream processor. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#name-1">RekognitionStreamProcessor#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RekognitionStreamProcessorState<Missing, 'RoleArn>, value: string) : RekognitionStreamProcessorState<Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RekognitionStreamProcessorState<Present, 'RoleArn>)

        /// <summary>
        /// The Amazon Resource Number (ARN) of the IAM role that allows access to the stream processor. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#role_arn-1">RekognitionStreamProcessor#role_arn</a>
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: RekognitionStreamProcessorState<'Name, Missing>, value: string) : RekognitionStreamProcessorState<'Name, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : RekognitionStreamProcessorState<'Name, Present>)

        /// <summary>
        /// data_sharing_preference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#data_sharing_preference-1">RekognitionStreamProcessor#data_sharing_preference</a> Accepts: aws.IResolvable | aws.RekognitionStreamProcessor.RekognitionStreamProcessorDataSharingPreference[]
        /// </summary>
        [<CustomOperation "data_sharing_preference">]
        member _.DataSharingPreference(state: RekognitionStreamProcessorState<'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : RekognitionStreamProcessorState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.DataSharingPreference <- value)
            state : RekognitionStreamProcessorState<'Name, 'RoleArn>

        /// <summary>
        /// input block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#input-1">RekognitionStreamProcessor#input</a> Accepts: aws.IResolvable | aws.RekognitionStreamProcessor.RekognitionStreamProcessorInput[]
        /// </summary>
        [<CustomOperation "input">]
        member _.Input(state: RekognitionStreamProcessorState<'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : RekognitionStreamProcessorState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Input <- value)
            state : RekognitionStreamProcessorState<'Name, 'RoleArn>

        /// <summary>
        /// The identifier for your AWS Key Management Service key (AWS KMS key). You can supply the Amazon Resource Name (ARN) of your KMS key, the ID of your KMS key, an alias for your KMS key, or an alias ARN. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#kms_key_id-1">RekognitionStreamProcessor#kms_key_id</a>
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RekognitionStreamProcessorState<'Name, 'RoleArn>, value: string) : RekognitionStreamProcessorState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : RekognitionStreamProcessorState<'Name, 'RoleArn>

        /// <summary>
        /// notification_channel block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#notification_channel-1">RekognitionStreamProcessor#notification_channel</a> Accepts: aws.IResolvable | aws.RekognitionStreamProcessor.RekognitionStreamProcessorNotificationChannel[]
        /// </summary>
        [<CustomOperation "notification_channel">]
        member _.NotificationChannel(state: RekognitionStreamProcessorState<'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : RekognitionStreamProcessorState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.NotificationChannel <- value)
            state : RekognitionStreamProcessorState<'Name, 'RoleArn>

        /// <summary>
        /// output block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#output-1">RekognitionStreamProcessor#output</a> Accepts: aws.IResolvable | aws.RekognitionStreamProcessor.RekognitionStreamProcessorOutput[]
        /// </summary>
        [<CustomOperation "output">]
        member _.Output(state: RekognitionStreamProcessorState<'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : RekognitionStreamProcessorState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Output <- value)
            state : RekognitionStreamProcessorState<'Name, 'RoleArn>

        /// <summary>
        /// regions_of_interest block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#regions_of_interest-1">RekognitionStreamProcessor#regions_of_interest</a> Accepts: aws.IResolvable | aws.RekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterest[]
        /// </summary>
        [<CustomOperation "regions_of_interest">]
        member _.RegionsOfInterest(state: RekognitionStreamProcessorState<'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : RekognitionStreamProcessorState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.RegionsOfInterest <- value)
            state : RekognitionStreamProcessorState<'Name, 'RoleArn>

        /// <summary>
        /// settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#settings-1">RekognitionStreamProcessor#settings</a> Accepts: aws.IResolvable | aws.RekognitionStreamProcessor.RekognitionStreamProcessorSettings[]
        /// </summary>
        [<CustomOperation "settings">]
        member _.Settings(state: RekognitionStreamProcessorState<'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : RekognitionStreamProcessorState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Settings <- value)
            state : RekognitionStreamProcessorState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#tags-1">RekognitionStreamProcessor#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RekognitionStreamProcessorState<'Name, 'RoleArn>, value: seq<string * string>) : RekognitionStreamProcessorState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RekognitionStreamProcessorState<'Name, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#timeouts-1">RekognitionStreamProcessor#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RekognitionStreamProcessorState<'Name, 'RoleArn>, value: aws.RekognitionStreamProcessor.RekognitionStreamProcessorTimeouts) : RekognitionStreamProcessorState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RekognitionStreamProcessorState<'Name, 'RoleArn>

        member _.Run(state: RekognitionStreamProcessorState<Present, Present>) : aws.RekognitionStreamProcessor.RekognitionStreamProcessor =
            let config = aws.RekognitionStreamProcessor.RekognitionStreamProcessorConfig()
            for setter in state.assignments do
                setter config
            aws.RekognitionStreamProcessor.RekognitionStreamProcessor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rekognitionStreamProcessor: missing required arguments. Must call: name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: RekognitionStreamProcessorState<_, _>) : aws.RekognitionStreamProcessor.RekognitionStreamProcessor =
            Unchecked.defaultof<aws.RekognitionStreamProcessor.RekognitionStreamProcessor>
