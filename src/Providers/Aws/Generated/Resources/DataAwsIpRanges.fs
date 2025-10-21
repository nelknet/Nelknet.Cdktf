namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIpRangesState<'Services> = { assignments: ResizeArray<aws.DataAwsIpRanges.DataAwsIpRangesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ip_ranges">aws_ip_ranges</a>.
    /// </summary>
    type DataAwsIpRangesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIpRangesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIpRangesState<Missing>)

        member _.Zero(()) : DataAwsIpRangesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIpRangesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ip_ranges#services-1">DataAwsIpRanges#services</a>.
        /// </summary>
        [<CustomOperation "services">]
        member _.Services(state: DataAwsIpRangesState<Missing>, value: seq<string>) : DataAwsIpRangesState<Present> =
            state.assignments.Add(fun config -> config.Services <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DataAwsIpRangesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ip_ranges#id-1">DataAwsIpRanges#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIpRangesState<'Services>, value: string) : DataAwsIpRangesState<'Services> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIpRangesState<'Services>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ip_ranges#regions-1">DataAwsIpRanges#regions</a>.
        /// </summary>
        [<CustomOperation "regions">]
        member _.Regions(state: DataAwsIpRangesState<'Services>, value: seq<string>) : DataAwsIpRangesState<'Services> =
            state.assignments.Add(fun config -> config.Regions <- (value |> Seq.toArray))
            state : DataAwsIpRangesState<'Services>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ip_ranges#url-1">DataAwsIpRanges#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: DataAwsIpRangesState<'Services>, value: string) : DataAwsIpRangesState<'Services> =
            state.assignments.Add(fun config -> config.Url <- value)
            state : DataAwsIpRangesState<'Services>

        member _.Run(state: DataAwsIpRangesState<Present>) : aws.DataAwsIpRanges.DataAwsIpRanges =
            let config = aws.DataAwsIpRanges.DataAwsIpRangesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIpRanges.DataAwsIpRanges(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIpRanges: missing required arguments. Must call: services.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIpRangesState<_>) : aws.DataAwsIpRanges.DataAwsIpRanges =
            Unchecked.defaultof<aws.DataAwsIpRanges.DataAwsIpRanges>
