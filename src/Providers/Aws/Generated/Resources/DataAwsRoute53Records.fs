namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53RecordsState<'ZoneId> = { assignments: ResizeArray<aws.DataAwsRoute53Records.DataAwsRoute53RecordsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_records">aws_route53_records</a>.
    /// </summary>
    type DataAwsRoute53RecordsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53RecordsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53RecordsState<Missing>)

        member _.Zero(()) : DataAwsRoute53RecordsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53RecordsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_records#zone_id-1">DataAwsRoute53Records#zone_id</a>.
        /// </summary>
        [<CustomOperation "zone_id">]
        member _.ZoneId(state: DataAwsRoute53RecordsState<Missing>, value: string) : DataAwsRoute53RecordsState<Present> =
            state.assignments.Add(fun config -> config.ZoneId <- value)
            ({ assignments = state.assignments } : DataAwsRoute53RecordsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_records#name_regex-1">DataAwsRoute53Records#name_regex</a>.
        /// </summary>
        [<CustomOperation "name_regex">]
        member _.NameRegex(state: DataAwsRoute53RecordsState<'ZoneId>, value: string) : DataAwsRoute53RecordsState<'ZoneId> =
            state.assignments.Add(fun config -> config.NameRegex <- value)
            state : DataAwsRoute53RecordsState<'ZoneId>

        member _.Run(state: DataAwsRoute53RecordsState<Present>) : aws.DataAwsRoute53Records.DataAwsRoute53Records =
            let config = aws.DataAwsRoute53Records.DataAwsRoute53RecordsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53Records.DataAwsRoute53Records(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRoute53Records: missing required arguments. Must call: zone_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRoute53RecordsState<_>) : aws.DataAwsRoute53Records.DataAwsRoute53Records =
            Unchecked.defaultof<aws.DataAwsRoute53Records.DataAwsRoute53Records>
