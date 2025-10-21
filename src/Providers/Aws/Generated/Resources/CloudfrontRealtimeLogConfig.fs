namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, 'Name, 'SamplingRate> = { assignments: ResizeArray<aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config">aws_cloudfront_realtime_log_config</a>.
    /// </summary>
    type CloudfrontRealtimeLogConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontRealtimeLogConfigState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontRealtimeLogConfigState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CloudfrontRealtimeLogConfigState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontRealtimeLogConfigState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#endpoint-1">CloudfrontRealtimeLogConfig#endpoint</a>
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: CloudfrontRealtimeLogConfigState<Missing, 'Fields, 'Name, 'SamplingRate>, value: aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigEndpoint) : CloudfrontRealtimeLogConfigState<Present, 'Fields, 'Name, 'SamplingRate> =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            ({ assignments = state.assignments } : CloudfrontRealtimeLogConfigState<Present, 'Fields, 'Name, 'SamplingRate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#fields-1">CloudfrontRealtimeLogConfig#fields</a>.
        /// </summary>
        [<CustomOperation "fields">]
        member _.Fields(state: CloudfrontRealtimeLogConfigState<'Endpoint, Missing, 'Name, 'SamplingRate>, value: seq<string>) : CloudfrontRealtimeLogConfigState<'Endpoint, Present, 'Name, 'SamplingRate> =
            state.assignments.Add(fun config -> config.Fields <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CloudfrontRealtimeLogConfigState<'Endpoint, Present, 'Name, 'SamplingRate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#name-1">CloudfrontRealtimeLogConfig#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, Missing, 'SamplingRate>, value: string) : CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, Present, 'SamplingRate> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, Present, 'SamplingRate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#sampling_rate-1">CloudfrontRealtimeLogConfig#sampling_rate</a>.
        /// </summary>
        [<CustomOperation "sampling_rate">]
        member _.SamplingRate(state: CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, 'Name, Missing>, value: double) : CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, 'Name, Present> =
            state.assignments.Add(fun config -> config.SamplingRate <- value)
            ({ assignments = state.assignments } : CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_realtime_log_config#id-1">CloudfrontRealtimeLogConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, 'Name, 'SamplingRate>, value: string) : CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, 'Name, 'SamplingRate> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontRealtimeLogConfigState<'Endpoint, 'Fields, 'Name, 'SamplingRate>

        member _.Run(state: CloudfrontRealtimeLogConfigState<Present, Present, Present, Present>) : aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfig =
            let config = aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfigConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontRealtimeLogConfig: missing required arguments. Must call: endpoint, fields, name, sampling_rate.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontRealtimeLogConfigState<_, _, _, _>) : aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfig =
            Unchecked.defaultof<aws.CloudfrontRealtimeLogConfig.CloudfrontRealtimeLogConfig>
