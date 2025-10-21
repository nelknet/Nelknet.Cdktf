namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontRealtimeLogConfigState<'Name> = { assignments: ResizeArray<aws.DataAwsCloudfrontRealtimeLogConfig.DataAwsCloudfrontRealtimeLogConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_realtime_log_config">aws_cloudfront_realtime_log_config</a>.
    /// </summary>
    type DataAwsCloudfrontRealtimeLogConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontRealtimeLogConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontRealtimeLogConfigState<Missing>)

        member _.Zero(()) : DataAwsCloudfrontRealtimeLogConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontRealtimeLogConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_realtime_log_config#name-1">DataAwsCloudfrontRealtimeLogConfig#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudfrontRealtimeLogConfigState<Missing>, value: string) : DataAwsCloudfrontRealtimeLogConfigState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCloudfrontRealtimeLogConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_realtime_log_config#id-1">DataAwsCloudfrontRealtimeLogConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontRealtimeLogConfigState<'Name>, value: string) : DataAwsCloudfrontRealtimeLogConfigState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudfrontRealtimeLogConfigState<'Name>

        member _.Run(state: DataAwsCloudfrontRealtimeLogConfigState<Present>) : aws.DataAwsCloudfrontRealtimeLogConfig.DataAwsCloudfrontRealtimeLogConfig =
            let config = aws.DataAwsCloudfrontRealtimeLogConfig.DataAwsCloudfrontRealtimeLogConfigConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontRealtimeLogConfig.DataAwsCloudfrontRealtimeLogConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudfrontRealtimeLogConfig: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudfrontRealtimeLogConfigState<_>) : aws.DataAwsCloudfrontRealtimeLogConfig.DataAwsCloudfrontRealtimeLogConfig =
            Unchecked.defaultof<aws.DataAwsCloudfrontRealtimeLogConfig.DataAwsCloudfrontRealtimeLogConfig>
